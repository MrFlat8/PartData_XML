namespace PartData_XML
{
    using System.Drawing;
    using System.Windows.Forms;

    partial class PartInfoForm
    {
        // all Components in order of appearance
        private Label m_lbl_partNumber;
        private TextBox m_tb_search;
        private ComboBox m_cbo_customer;
        private Button m_butt_search;
        private Button m_butt_openLocations;
        private TextBox m_tb_errorMessage;

        private GroupBox m_InfoGroupBox;
        private TextBox m_tb_itemNumber;
        private TextBox m_tb_partSize;
        private TextBox m_tb_designation;
        private TextBox m_tb_partName;
        private TextBox m_tb_docNumber;
        
        private GroupBox m_processGroupBox;
        private TextBox m_tb_partQty;
        private TextBox m_tb_partProcess;
        private TextBox m_tb_originDesign;
        private Label m_lbl_familyUnits;
        private ListBox m_lb_famliyMembers;
        private Label m_lbl_protoNotes;
        private TextBox m_tb_protoNotes;
        private Label m_lbl_productionNotes;
        private TextBox m_tb_prductionNotes;
        
        private Label m_lbl_version;
        private Button m_butt_genLabel;
        private Button m_butt_Close;


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Elements that can be reused multiple times
            Font BoldFont = new("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);


            // -----------------------------------------  Controls for User Iput Area
            m_lbl_partNumber = new Label()
            {
                Name = "m_lbl_partNumber",
                Text = "Part Number",
                Location = new Point(12, 13),
                Size = new Size(75, 15),
                AutoSize = true
            };

            m_tb_search = new TextBox()
            {
                Name = "m_tb_search",
                Location = new Point(89, 9),
                Size = new Size(164, 23),
                BorderStyle = BorderStyle.FixedSingle,
                CharacterCasing = CharacterCasing.Upper,
                MaxLength = 30,
                TabIndex = 1
            };
            m_tb_search.KeyUp += ev_search_KeyUp;

            m_cbo_customer = new ComboBox()
            {
                Name = "m_cbo_customer",
                Location = new Point(258, 9),
                Size = new Size(182, 23),
                AutoCompleteMode = AutoCompleteMode.Suggest,
                AutoCompleteSource = AutoCompleteSource.ListItems,
                FormattingEnabled = true,
                TabIndex = 2
            };

            m_butt_search = new Button()
            {
                Name = "m_butt_search",
                Text = "Go",
                Location = new Point(444, 8),
                Size = new Size(38, 25),
                UseVisualStyleBackColor = true,
                TabIndex = 3
            };
            m_butt_search.Click += ev_GoSearchButton;

            m_butt_openLocations = new Button()
            {
                Name = "m_butt_openLocations",
                Text = "Open Location",
                Location = new Point(495, 8),
                Size = new Size(102, 25),
                Enabled = false,
                TabStop = false,
                UseVisualStyleBackColor = true,
                TabIndex = 4
            };
            m_butt_openLocations.Click += ev_OpenLocation;

            m_tb_errorMessage = new TextBox()
            {
                Name = "m_tb_errorMessage",
                Location = new Point(15, 38),
                Size = new Size(579, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                Font = BoldFont,
                ForeColor = Color.Maroon,
                MaxLength = 300,
                TextAlign = HorizontalAlignment.Center,
                TabIndex = 5
            };




            // -----------------------------------------  Controls for Info Group Box
            m_tb_partName = new TextBox()
            {
                Name = "m_tb_partName",
                Text = "Part Name",
                Location = new Point(16, 53),
                Size = new Size(451, 16),
                Font = BoldFont,
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TabIndex = 6
            };

            m_tb_partSize = new TextBox()
            {
                Name = "m_tb_partSize",
                Text = "Part Size",
                Location = new Point(272, 25),
                Size = new Size(136, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Center,
                TabIndex = 7
            };

            m_tb_designation = new TextBox()
            {
                Name = "m_tb_designation",
                Text = "Designation",
                Location = new Point(433, 25),
                Size = new Size(136, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Right,
                TabIndex = 8
            };

            m_tb_itemNumber = new TextBox()
            {
                Name = "m_tb_itemNumber",
                Text = "Item Number",
                Location = new Point(16, 25),
                Size = new Size(245, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                Font = BoldFont,
                TabIndex = 9
            };

            m_tb_docNumber = new TextBox()
            {
                Name = "m_tb_docNumber",
                Text = "DOC#",
                Location = new Point(483, 53),
                Size = new Size(86, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Right,
                TabIndex = 8
            };

            m_InfoGroupBox = new GroupBox()
            {
                
                Name = "m_InfoGroupBox",
                Text = "Information",
                Location = new Point(12, 57),
                Size = new Size(585, 85),
                TabStop = false
            };
            m_InfoGroupBox.Controls.AddRange(new Control[] {
                m_tb_itemNumber, m_tb_partSize, m_tb_designation, m_tb_partName, m_tb_docNumber
            });




            // -----------------------------------------  Controls for Process Group Box
            m_tb_partQty = new TextBox()
            {
                Name = "m_tb_partQty",
                Text = "Qty",
                Location = new Point(16, 25),
                Size = new Size(225, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TabIndex = 9
            };

            m_tb_originDesign = new TextBox()
            {
                Name = "m_tb_originDesign",
                Text = "Origin Design",
                Location = new Point(247, 25),
                Size = new Size(322, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                Font = BoldFont,
                TextAlign = HorizontalAlignment.Right,
                TabIndex = 10
            };

            m_tb_partProcess = new TextBox()
            {
                Name = "m_tb_partProcess",
                Text = "Part Processes",
                Location = new Point(16, 51),
                Size = new Size(553, 16),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.None,
                TabIndex = 11
            };

            m_lbl_familyUnits = new Label()
            {
                Name = "m_lbl_familyUnits",
                Text = "Family Units",
                Location = new Point(13, 77),
                Size = new Size(72, 15),
                AutoSize = true,
            };

            m_lb_famliyMembers = new ListBox()
            {
                Name = "m_lb_famliyMembers",
                Location = new Point(16, 95),
                Size = new Size(245, 197),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.FixedSingle,
                FormattingEnabled = true,
                ItemHeight = 15,
                TabIndex = 12,
            };
            m_lb_famliyMembers.Items.AddRange(new string[] { "Family Name" });

            m_lbl_protoNotes = new Label()
            {
                Name = "m_lbl_protoNotes",
                Text = "Prototype Notes",
                Location = new Point(269, 76),
                Size = new Size(93, 15),
                AutoSize = true
            };

            m_tb_protoNotes = new TextBox()
            {
                Name = "m_tb_protoNotes",
                Location = new Point(272, 95),
                Size = new Size(304, 88),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = SystemColors.Control,
                MaxLength = 1000,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                TabIndex = 13
            };

            m_lbl_productionNotes = new Label()
            {
                Name = "m_lbl_productionNotes",
                Text = "Production Notes",
                Location = new Point(269, 185),
                Size = new Size(100, 15),
                AutoSize = true
            };

            m_tb_prductionNotes = new TextBox()
            {
                Name = "m_tb_prductionNotes",
                Location = new Point(272, 204),
                Size = new Size(304, 88),
                BackColor = SystemColors.Control,
                BorderStyle = BorderStyle.FixedSingle,
                MaxLength = 1000,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                TabIndex = 14
            };

            m_processGroupBox = new GroupBox()
            {
                Name = "m_processGroupBox",
                Text = "Processes",
                Location = new Point(12, 141),
                Size = new Size(585, 312),
                TabStop = false

            };
            m_processGroupBox.Controls.AddRange(new Control[]
            {
                m_tb_partQty, m_tb_originDesign, m_tb_partProcess, m_lbl_familyUnits, m_lb_famliyMembers,
                m_lbl_protoNotes, m_tb_protoNotes, m_lbl_productionNotes, m_tb_prductionNotes
            });




            // -----------------------------------------  Bottom Button Row
            m_lbl_version = new Label()
            {
                Name = "m_lbl_version",
                Text = "v1.0  (Exp: 1/1/2023)  By: Greg Callahan",
                Location = new Point(12, 462),
                Size = new Size(194, 13),
                AutoSize = true,
                Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point),
                ForeColor = SystemColors.ControlDarkDark
            };

            m_butt_genLabel = new Button()
            {
                Name = "m_butt_genLabel",
                Text = "Generate Labels",
                Location = new Point(417, 457),
                Size = new Size(101, 23),
                Enabled = false,
                TabStop = false,
                UseVisualStyleBackColor = true,
                TabIndex = 15
            };
            m_butt_genLabel.Click += ev_GenerateLabels;

            m_butt_Close = new Button()
            {
                Name = "m_buttClose",
                Text = "Close",
                Location = new Point(524, 457),
                Size = new Size(75, 23),
                UseVisualStyleBackColor = true,
                TabIndex = 16
            };
            m_butt_Close.Click += ev_CloseWindow;




            // -----------------------------------------  Form Specific Config
            Name = "PartInfoForm";
            Text = "Part Info Request";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 491);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ShowIcon = false;
            Controls.AddRange(new Control[]
            {
                m_lbl_partNumber, m_tb_search, m_cbo_customer, m_butt_search, m_butt_openLocations,
                m_tb_errorMessage, m_InfoGroupBox, m_processGroupBox,
                m_lbl_version, m_butt_genLabel, m_butt_Close
            });

            PerformLayout();
        }
    }
}