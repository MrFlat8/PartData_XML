using System;
using System.Collections.Generic;
using System.Xml;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace PartData_XML
{
    /// <summary>
    /// Pre-Qualified path location for part info XML
    /// </summary>
    public struct PartXmlPath
    {
        public string XmlName;
        public string XmlPath;
        public bool Exists;
    }

    /// <summary>
    /// Provide the resulting XML data in plain text
    /// </summary>
    public struct PartData
    {
        public string PartNumber    = "";
        public string Size          = "";
        public string Designation   = "";
        public string PartName      = "";
        public string Usage         = "";
        public string OriginDesign  = "";
        public string Processes     = "";
        public string ProtoNotes    = "";
        public string ProdNotes     = "";
        public string Qty           = "";
        public string DocNumber     = "";
        public string Customer      = "";

        public List<object> FamilyUnits = new();

        public bool IsSet = false;

        public void ClearValues()
        {
            PartNumber = Size = Designation =
                PartName = Usage = OriginDesign =
                Processes = ProtoNotes = ProdNotes =
                Qty = DocNumber = Customer = "";
            
            FamilyUnits.Clear();
            IsSet = false;
        }
    }











    

    


    public partial class PartInfoForm : Form
    {
        // base path pointing to the starting part structure
        private const string m_basePath = "\\\\spi\\art\\PROTOTYPE\\";
        // path that existing label program looks at
        private const string m_labelPath = "D:\\TEMP\\";
        //private const string m_labelPath = "\\\\spi\\art\\PROTOTYPE\\AutoCAD_XML\\";
        // If no customers are loaded, this program cant be used
        // also might mean that the server is not reachable
        private bool HasCustomers = false;
        PartData m_data = new();

        // this is designed for room to grow the part number length
        private readonly Regex m_RegEx_PartNumberTest = new(@"^[A-Z]{2,4}-\d{2}-\d{5,8}[A-Z]$");

        public PartInfoForm()
        {
            InitializeComponent();

            m_cbo_customer.Items.AddRange(LoadCustomers());
            m_cbo_customer.SelectedIndex = 0;
            m_tb_PartNumber.Focus();
            
            if (!HasCustomers)
                m_buttClose.Focus();
            
            DateTime expireDate = new(2023, 1, 1);
            DateTime currentDate = DateTime.Now;
            if (currentDate > expireDate)
            {
                // Force User to Update and trigger review for
                // Possible Dev Updates that can/should be made
                m_tb_search.Enabled = false;
                m_butt_Search.Enabled = false;
                m_butt_genLabel.Enabled = false;
                m_tb_errorMessage.Text = "Please Update this Application";
            }
        }




        private object[] LoadCustomers()
        {
            DirectoryInfo dir = new(m_basePath);
            if (!dir.Exists)
            {
                // Stop all actions, no connection was found
                m_tb_errorMessage.Text = "No Customers Were Found";
                m_tb_PartNumber.Enabled = false;
                return Array.Empty<object>();
            }

            DirectoryInfo[] subDir = dir.GetDirectories();
            object[] customers = new object[subDir.Length];

            for (int i = 0; i < subDir.Length; i++)
                customers[i] = subDir[i].Name;

            HasCustomers = true;
            return customers;
        }

        private PartXmlPath FindPart(string PartName, string Customer)
        {
            PartXmlPath part = new PartXmlPath
            {
                XmlName = PartName,
                XmlPath = $"{m_basePath}{Customer}\\_Parts\\{PartName}",
                Exists = false
            };

            DirectoryInfo dir = new(part.XmlPath);
            FileInfo xmlFile = new($"{part.XmlPath}\\{PartName}.xml");
            part.Exists = dir.Exists && xmlFile.Exists;

            return part;
        }

        private void LoadPartDataToForm(PartXmlPath part)
        {
            GetPartXML(part);

            m_tb_designation.Text = m_data.Designation;
            m_tb_docNumber.Text = $"DOC# {m_data.DocNumber}";
            m_tb_originDesign.Text = m_data.OriginDesign;
            m_tb_itemNumber.Text = m_data.PartNumber;
            m_tb_partName.Text = m_data.PartName;
            m_tb_partProcess.Text = m_data.Processes;
            m_tb_partQty.Text = $"Qty: {m_data.Qty}x   {m_data.Usage}";
            m_tb_partSize.Text = m_data.Size;
            m_tb_prductionNotes.Text = m_data.ProdNotes;
            m_tb_protoNotes.Text = m_data.ProtoNotes;
            m_lb_famliyMembers.DataSource = m_data.FamilyUnits;
        }

        private void GetPartXML(PartXmlPath Part)
        {
            XmlReader r = XmlReader.Create($"{Part.XmlPath}\\{Part.XmlName}.xml");
            m_data.ClearValues();
            m_data.IsSet = true;

            string id, idVal;
            while (r.ReadToFollowing("att"))
            {
                r.ReadToFollowing("id");
                id = r.ReadElementContentAsString();

                // value of the node
                // may not have attribute value node
                if (!r.ReadToFollowing("av"))
                    continue;
                idVal = r.ReadElementContentAsString();

                switch (id)
                {
                    case "00002_0000002489":
                        // Usage
                        m_data.Usage = idVal;
                        break;
                    case "00002_0000002491":
                        m_data.ProdNotes = idVal;
                        break;
                    case "00002_0000002490":
                        m_data.ProtoNotes = idVal;
                        break;
                    case "00002_0000003074":
                        // part width 
                        m_data.Size = $"{idVal}\"{m_data.Size}";
                        break;
                    case "00002_0000003075":
                        m_data.Size += $" x {idVal}\"";
                        break;
                    case "00002_0000002488":
                        m_data.Qty = idVal;
                        break;
                    case "00002_0000002487":
                        m_data.DocNumber = idVal;
                        break;
                    case "00002_0000002486":
                        m_data.Processes = idVal;
                        break;
                    case "00002_0000002485":
                        m_data.PartName = idVal;
                        break;
                    case "00002_0000002496":
                        m_data.OriginDesign = idVal;
                        break;
                    case "00002_0000002484":
                        m_data.PartNumber = idVal;
                        break;
                    case "00002_0000003078":
                        m_data.Designation = idVal;
                        break;
                    case "00002_0000002492":
                        // Family Names separated by pipe
                        string[] familyNames = idVal.Split('|');

                        if (familyNames.Length == 0)
                            break;

                        for (int i = 0; i < familyNames.Length; i++)
                            m_data.FamilyUnits.Add(familyNames[i].Replace(".pdf", ""));
                        break;
                    default:
                        // dont care about other data
                        break;
                }
            }
            m_data.Customer = (string)m_cbo_customer.SelectedItem;

            r.Close();
            r.Dispose();
        }

        private void LaunchSearch()
        {
            // personal preference to upper case
            string pn = m_tb_search.Text.ToUpper();
            m_tb_search.Text = pn;

            // test the part number to match company defaults
            if (!m_RegEx_PartNumberTest.IsMatch(pn))
            {
                m_tb_errorMessage.Text = "Part Number Does Not Meet Expected Format";
                return;
            }

            // is a customer selected
            if (m_cbo_customer.SelectedIndex == -1)
            {
                m_tb_errorMessage.Text = "No Customer Selected";
                return;
            }

            PartXmlPath part = FindPart(m_tb_search.Text, (string)m_cbo_customer.SelectedItem);
            if (!part.Exists)
            {
                m_tb_errorMessage.Text = "Part Not Found or Info File is Missing";
                return;
            }

            // Fill the form
            LoadPartDataToForm(part);
            m_butt_genLabel.Enabled = true;
            m_butt_openLocations.Enabled = true;
        }

        private void GenerateLabels()
        {
            m_butt_genLabel.Enabled = false;

            // dont think there is a way for the program to get here
            // without actual data filled in
            if (!m_data.IsSet)
                return;

            string filePath = $"{m_labelPath}{m_data.PartNumber}";

            // get the designation
            MatchCollection designations = Regex.Matches(m_data.Designation, @"[A-Z]{2,3}(?=\()");
            
            // writes the RH part
            string fileContents = $"<AUOTCAD>\n" +
                $"{m_data.PartNumber}-{designations[0].Value}\n" +
                $"{m_data.PartName}\n" +
                $"{DateTime.Now.Year}\n" +
                $"{m_data.Customer}\n" +
                $"{m_data.Processes}\n" +
                $"{m_data.Qty} {m_data.Usage}\n" +
                $"{m_data.DocNumber}\n" +
                $"{m_basePath}{m_data.Customer}\\_Parts\\{m_data.PartNumber}\n" +
                $"{m_data.PartNumber}-{designations[0].Value}\n\n</AUTOCAD>";
            File.WriteAllText($"{filePath}-{designations[0].Value}.xml", fileContents);

            // writes the LH part
            fileContents = Regex.Replace(fileContents, $"-{designations[0].Value}", $"-{designations[1].Value}");
            File.WriteAllText($"{filePath}-{designations[1].Value}.xml", fileContents);

        }





        // ------- Events can go here
        private void ev_search_KeyUp(object sender, KeyEventArgs e)
        {
            // clear any previous errors
            m_tb_errorMessage.Text = "";
            m_butt_genLabel.Enabled = false;
            m_butt_openLocations.Enabled = false;

            // this will only be attached to the search box
            if (e.KeyCode != Keys.Enter && HasCustomers)
                return;

            LaunchSearch();
        }


        private void ev_OpenLocation(object sender, EventArgs e)
        {
            string pathToPartFiles = $"{m_basePath}{m_cbo_customer.SelectedItem}\\_Parts\\{m_data.PartNumber}\\";
            System.Diagnostics.Process.Start("explorer.exe", pathToPartFiles);
        }

        private void ev_GenerateLabels(object sender, EventArgs e)
        {
            GenerateLabels();
        }

        private void ev_GoSearchButton(object sender, EventArgs e)
        {
            // clear any previous errors
            m_tb_errorMessage.Text = "";
            m_butt_genLabel.Enabled = false;
            m_butt_openLocations.Enabled = false;

            if (!HasCustomers)
                return;

            LaunchSearch();
        }

        private void ev_CloseWindow(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
        }
    }
}
