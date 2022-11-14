namespace PartData_XML
{
    using System.Drawing;
    using System.Windows.Forms;

    partial class PartInfoForm
    {
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
            this.m_tb_PartNumber = new System.Windows.Forms.TextBox();
            this.m_lbl_PartNumber = new System.Windows.Forms.Label();
            this.m_tb_search = new System.Windows.Forms.TextBox();
            this.TMP_pn = new System.Windows.Forms.Label();
            this.m_InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.m_tb_partName = new System.Windows.Forms.TextBox();
            this.m_tb_itemNumber = new System.Windows.Forms.TextBox();
            this.m_tb_partSize = new System.Windows.Forms.TextBox();
            this.m_tb_docNumber = new System.Windows.Forms.TextBox();
            this.m_tb_designation = new System.Windows.Forms.TextBox();
            this.m_buttClose = new System.Windows.Forms.Button();
            this.m_butt_genLabel = new System.Windows.Forms.Button();
            this.m_processGroupBox = new System.Windows.Forms.GroupBox();
            this.m_tb_partProcess = new System.Windows.Forms.TextBox();
            this.m_tb_partQty = new System.Windows.Forms.TextBox();
            this.m_tb_originDesign = new System.Windows.Forms.TextBox();
            this.m_tb_prductionNotes = new System.Windows.Forms.TextBox();
            this.m_tb_protoNotes = new System.Windows.Forms.TextBox();
            this.TMP_family = new System.Windows.Forms.Label();
            this.m_lb_famliyMembers = new System.Windows.Forms.ListBox();
            this.TMP_prodNote = new System.Windows.Forms.Label();
            this.TMP_protoNote = new System.Windows.Forms.Label();
            this.m_lbl_version = new System.Windows.Forms.Label();
            this.m_cbo_customer = new System.Windows.Forms.ComboBox();
            this.m_tb_errorMessage = new System.Windows.Forms.TextBox();
            this.m_butt_openLocations = new System.Windows.Forms.Button();
            this.m_butt_Search = new System.Windows.Forms.Button();
            this.m_InfoGroupBox.SuspendLayout();
            this.m_processGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_tb_PartNumber
            // 
            this.m_tb_PartNumber.Location = new System.Drawing.Point(0, 0);
            this.m_tb_PartNumber.Name = "m_tb_PartNumber";
            this.m_tb_PartNumber.Size = new System.Drawing.Size(100, 23);
            this.m_tb_PartNumber.TabIndex = 2;
            // 
            // m_lbl_PartNumber
            // 
            this.m_lbl_PartNumber.Location = new System.Drawing.Point(0, 0);
            this.m_lbl_PartNumber.Name = "m_lbl_PartNumber";
            this.m_lbl_PartNumber.Size = new System.Drawing.Size(100, 23);
            this.m_lbl_PartNumber.TabIndex = 1;
            // 
            // m_tb_search
            // 
            this.m_tb_search.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.m_tb_search.Location = new System.Drawing.Point(89, 9);
            this.m_tb_search.MaxLength = 30;
            this.m_tb_search.Name = "m_tb_search";
            this.m_tb_search.Size = new System.Drawing.Size(164, 23);
            this.m_tb_search.TabIndex = 1;
            this.m_tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ev_search_KeyUp);
            // 
            // TMP_pn
            // 
            this.TMP_pn.AutoSize = true;
            this.TMP_pn.Location = new System.Drawing.Point(12, 13);
            this.TMP_pn.Name = "TMP_pn";
            this.TMP_pn.Size = new System.Drawing.Size(75, 15);
            this.TMP_pn.TabIndex = 4;
            this.TMP_pn.Text = "Part Number";
            // 
            // m_InfoGroupBox
            // 
            this.m_InfoGroupBox.Controls.Add(this.m_tb_partName);
            this.m_InfoGroupBox.Controls.Add(this.m_tb_itemNumber);
            this.m_InfoGroupBox.Controls.Add(this.m_tb_partSize);
            this.m_InfoGroupBox.Controls.Add(this.m_tb_docNumber);
            this.m_InfoGroupBox.Controls.Add(this.m_tb_designation);
            this.m_InfoGroupBox.Location = new System.Drawing.Point(12, 57);
            this.m_InfoGroupBox.Name = "m_InfoGroupBox";
            this.m_InfoGroupBox.Size = new System.Drawing.Size(585, 85);
            this.m_InfoGroupBox.TabIndex = 5;
            this.m_InfoGroupBox.TabStop = false;
            this.m_InfoGroupBox.Text = "Information";
            // 
            // m_tb_partName
            // 
            this.m_tb_partName.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_partName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_partName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_tb_partName.Location = new System.Drawing.Point(16, 53);
            this.m_tb_partName.Name = "m_tb_partName";
            this.m_tb_partName.Size = new System.Drawing.Size(451, 16);
            this.m_tb_partName.TabIndex = 7;
            this.m_tb_partName.Text = "Part Name";
            // 
            // m_tb_itemNumber
            // 
            this.m_tb_itemNumber.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_itemNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_itemNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_tb_itemNumber.Location = new System.Drawing.Point(16, 25);
            this.m_tb_itemNumber.Name = "m_tb_itemNumber";
            this.m_tb_itemNumber.Size = new System.Drawing.Size(245, 16);
            this.m_tb_itemNumber.TabIndex = 4;
            this.m_tb_itemNumber.Text = "Item Number";
            // 
            // m_tb_partSize
            // 
            this.m_tb_partSize.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_partSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_partSize.Location = new System.Drawing.Point(272, 25);
            this.m_tb_partSize.Name = "m_tb_partSize";
            this.m_tb_partSize.Size = new System.Drawing.Size(136, 16);
            this.m_tb_partSize.TabIndex = 5;
            this.m_tb_partSize.Text = "Part Size";
            this.m_tb_partSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_tb_docNumber
            // 
            this.m_tb_docNumber.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_docNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_docNumber.Location = new System.Drawing.Point(483, 53);
            this.m_tb_docNumber.Name = "m_tb_docNumber";
            this.m_tb_docNumber.Size = new System.Drawing.Size(86, 16);
            this.m_tb_docNumber.TabIndex = 8;
            this.m_tb_docNumber.Text = "DOC#";
            this.m_tb_docNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_tb_designation
            // 
            this.m_tb_designation.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_designation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_designation.Location = new System.Drawing.Point(433, 25);
            this.m_tb_designation.Name = "m_tb_designation";
            this.m_tb_designation.Size = new System.Drawing.Size(136, 16);
            this.m_tb_designation.TabIndex = 6;
            this.m_tb_designation.Text = "Designation";
            this.m_tb_designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_buttClose
            // 
            this.m_buttClose.Location = new System.Drawing.Point(524, 457);
            this.m_buttClose.Name = "m_buttClose";
            this.m_buttClose.Size = new System.Drawing.Size(75, 23);
            this.m_buttClose.TabIndex = 15;
            this.m_buttClose.Text = "Close";
            this.m_buttClose.UseVisualStyleBackColor = true;
            this.m_buttClose.Click += new System.EventHandler(this.ev_CloseWindow);
            // 
            // m_butt_genLabel
            // 
            this.m_butt_genLabel.Enabled = false;
            this.m_butt_genLabel.Location = new System.Drawing.Point(417, 457);
            this.m_butt_genLabel.Name = "m_butt_genLabel";
            this.m_butt_genLabel.Size = new System.Drawing.Size(101, 23);
            this.m_butt_genLabel.TabIndex = 8;
            this.m_butt_genLabel.TabStop = false;
            this.m_butt_genLabel.Text = "Generate Labels";
            this.m_butt_genLabel.UseVisualStyleBackColor = true;
            this.m_butt_genLabel.Click += new System.EventHandler(this.ev_GenerateLabels);
            // 
            // m_processGroupBox
            // 
            this.m_processGroupBox.Controls.Add(this.m_tb_partProcess);
            this.m_processGroupBox.Controls.Add(this.m_tb_partQty);
            this.m_processGroupBox.Controls.Add(this.m_tb_originDesign);
            this.m_processGroupBox.Controls.Add(this.m_tb_prductionNotes);
            this.m_processGroupBox.Controls.Add(this.m_tb_protoNotes);
            this.m_processGroupBox.Controls.Add(this.TMP_family);
            this.m_processGroupBox.Controls.Add(this.m_lb_famliyMembers);
            this.m_processGroupBox.Controls.Add(this.TMP_prodNote);
            this.m_processGroupBox.Controls.Add(this.TMP_protoNote);
            this.m_processGroupBox.Location = new System.Drawing.Point(12, 141);
            this.m_processGroupBox.Name = "m_processGroupBox";
            this.m_processGroupBox.Size = new System.Drawing.Size(585, 312);
            this.m_processGroupBox.TabIndex = 9;
            this.m_processGroupBox.TabStop = false;
            this.m_processGroupBox.Text = "Processes";
            // 
            // m_tb_partProcess
            // 
            this.m_tb_partProcess.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_partProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_partProcess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tb_partProcess.Location = new System.Drawing.Point(16, 51);
            this.m_tb_partProcess.Name = "m_tb_partProcess";
            this.m_tb_partProcess.Size = new System.Drawing.Size(553, 16);
            this.m_tb_partProcess.TabIndex = 11;
            this.m_tb_partProcess.Text = "Part Processes";
            // 
            // m_tb_partQty
            // 
            this.m_tb_partQty.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_partQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_partQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.m_tb_partQty.Location = new System.Drawing.Point(16, 25);
            this.m_tb_partQty.Name = "m_tb_partQty";
            this.m_tb_partQty.Size = new System.Drawing.Size(225, 16);
            this.m_tb_partQty.TabIndex = 9;
            this.m_tb_partQty.Text = "Qty";
            // 
            // m_tb_originDesign
            // 
            this.m_tb_originDesign.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_originDesign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_originDesign.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_tb_originDesign.Location = new System.Drawing.Point(247, 25);
            this.m_tb_originDesign.Name = "m_tb_originDesign";
            this.m_tb_originDesign.Size = new System.Drawing.Size(322, 16);
            this.m_tb_originDesign.TabIndex = 10;
            this.m_tb_originDesign.Text = "Origin Design";
            this.m_tb_originDesign.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // m_tb_prductionNotes
            // 
            this.m_tb_prductionNotes.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_prductionNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tb_prductionNotes.Location = new System.Drawing.Point(272, 204);
            this.m_tb_prductionNotes.MaxLength = 500;
            this.m_tb_prductionNotes.Multiline = true;
            this.m_tb_prductionNotes.Name = "m_tb_prductionNotes";
            this.m_tb_prductionNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_tb_prductionNotes.Size = new System.Drawing.Size(304, 88);
            this.m_tb_prductionNotes.TabIndex = 14;
            // 
            // m_tb_protoNotes
            // 
            this.m_tb_protoNotes.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_protoNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_tb_protoNotes.Location = new System.Drawing.Point(272, 95);
            this.m_tb_protoNotes.MaxLength = 500;
            this.m_tb_protoNotes.Multiline = true;
            this.m_tb_protoNotes.Name = "m_tb_protoNotes";
            this.m_tb_protoNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.m_tb_protoNotes.Size = new System.Drawing.Size(304, 88);
            this.m_tb_protoNotes.TabIndex = 13;
            // 
            // TMP_family
            // 
            this.TMP_family.AutoSize = true;
            this.TMP_family.Location = new System.Drawing.Point(13, 77);
            this.TMP_family.Name = "TMP_family";
            this.TMP_family.Size = new System.Drawing.Size(72, 15);
            this.TMP_family.TabIndex = 12;
            this.TMP_family.Text = "Family Units";
            // 
            // m_lb_famliyMembers
            // 
            this.m_lb_famliyMembers.BackColor = System.Drawing.SystemColors.Control;
            this.m_lb_famliyMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lb_famliyMembers.FormattingEnabled = true;
            this.m_lb_famliyMembers.ItemHeight = 15;
            this.m_lb_famliyMembers.Items.AddRange(new object[] {
            "Family Name"});
            this.m_lb_famliyMembers.Location = new System.Drawing.Point(16, 95);
            this.m_lb_famliyMembers.Name = "m_lb_famliyMembers";
            this.m_lb_famliyMembers.Size = new System.Drawing.Size(245, 197);
            this.m_lb_famliyMembers.TabIndex = 12;
            // 
            // TMP_prodNote
            // 
            this.TMP_prodNote.AutoSize = true;
            this.TMP_prodNote.Location = new System.Drawing.Point(269, 185);
            this.TMP_prodNote.Name = "TMP_prodNote";
            this.TMP_prodNote.Size = new System.Drawing.Size(100, 15);
            this.TMP_prodNote.TabIndex = 9;
            this.TMP_prodNote.Text = "Production Notes";
            // 
            // TMP_protoNote
            // 
            this.TMP_protoNote.AutoSize = true;
            this.TMP_protoNote.Location = new System.Drawing.Point(269, 76);
            this.TMP_protoNote.Name = "TMP_protoNote";
            this.TMP_protoNote.Size = new System.Drawing.Size(93, 15);
            this.TMP_protoNote.TabIndex = 8;
            this.TMP_protoNote.Text = "Prototype Notes";
            // 
            // m_lbl_version
            // 
            this.m_lbl_version.AutoSize = true;
            this.m_lbl_version.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.m_lbl_version.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.m_lbl_version.Location = new System.Drawing.Point(12, 462);
            this.m_lbl_version.Name = "m_lbl_version";
            this.m_lbl_version.Size = new System.Drawing.Size(194, 13);
            this.m_lbl_version.TabIndex = 10;
            this.m_lbl_version.Text = "v1.0  (Exp: 1/1/2023)  By: Greg Callahan";
            // 
            // m_cbo_customer
            // 
            this.m_cbo_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_cbo_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_cbo_customer.FormattingEnabled = true;
            this.m_cbo_customer.Location = new System.Drawing.Point(258, 9);
            this.m_cbo_customer.Name = "m_cbo_customer";
            this.m_cbo_customer.Size = new System.Drawing.Size(182, 23);
            this.m_cbo_customer.TabIndex = 2;
            // 
            // m_tb_errorMessage
            // 
            this.m_tb_errorMessage.BackColor = System.Drawing.SystemColors.Control;
            this.m_tb_errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tb_errorMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m_tb_errorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.m_tb_errorMessage.Location = new System.Drawing.Point(15, 38);
            this.m_tb_errorMessage.MaxLength = 300;
            this.m_tb_errorMessage.Name = "m_tb_errorMessage";
            this.m_tb_errorMessage.Size = new System.Drawing.Size(579, 16);
            this.m_tb_errorMessage.TabIndex = 5;
            this.m_tb_errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // m_butt_openLocations
            // 
            this.m_butt_openLocations.Enabled = false;
            this.m_butt_openLocations.Location = new System.Drawing.Point(495, 8);
            this.m_butt_openLocations.Name = "m_butt_openLocations";
            this.m_butt_openLocations.Size = new System.Drawing.Size(102, 25);
            this.m_butt_openLocations.TabIndex = 4;
            this.m_butt_openLocations.TabStop = false;
            this.m_butt_openLocations.Text = "Open Location";
            this.m_butt_openLocations.UseVisualStyleBackColor = true;
            this.m_butt_openLocations.Click += new System.EventHandler(this.ev_OpenLocation);
            // 
            // m_butt_Search
            // 
            this.m_butt_Search.Location = new System.Drawing.Point(444, 8);
            this.m_butt_Search.Name = "m_butt_Search";
            this.m_butt_Search.Size = new System.Drawing.Size(38, 25);
            this.m_butt_Search.TabIndex = 3;
            this.m_butt_Search.Text = "Go";
            this.m_butt_Search.UseVisualStyleBackColor = true;
            this.m_butt_Search.Click += new System.EventHandler(this.ev_GoSearchButton);
            // 
            // PartInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_buttClose;
            this.ClientSize = new System.Drawing.Size(609, 491);
            this.Controls.Add(this.m_butt_Search);
            this.Controls.Add(this.m_butt_openLocations);
            this.Controls.Add(this.m_tb_errorMessage);
            this.Controls.Add(this.m_cbo_customer);
            this.Controls.Add(this.m_lbl_version);
            this.Controls.Add(this.m_processGroupBox);
            this.Controls.Add(this.m_butt_genLabel);
            this.Controls.Add(this.m_buttClose);
            this.Controls.Add(this.m_InfoGroupBox);
            this.Controls.Add(this.TMP_pn);
            this.Controls.Add(this.m_tb_search);
            this.Controls.Add(this.m_lbl_PartNumber);
            this.Controls.Add(this.m_tb_PartNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PartInfoForm";
            this.ShowIcon = false;
            this.Text = "Part Info Request";
            this.m_InfoGroupBox.ResumeLayout(false);
            this.m_InfoGroupBox.PerformLayout();
            this.m_processGroupBox.ResumeLayout(false);
            this.m_processGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private TextBox m_tb_PartNumber;
        private Label m_lbl_PartNumber;
        private TextBox m_tb_search;
        private Label TMP_pn;
        private GroupBox m_InfoGroupBox;
        private Button m_buttClose;
        private Button m_butt_genLabel;
        private GroupBox m_processGroupBox;
        private Label TMP_family;
        private ListBox m_lb_famliyMembers;
        private Label TMP_prodNote;
        private Label TMP_protoNote;
        private Label m_lbl_version;
        private TextBox m_tb_prductionNotes;
        private TextBox m_tb_protoNotes;
        private ComboBox m_cbo_customer;
        private TextBox m_tb_partName;
        private TextBox m_tb_itemNumber;
        private TextBox m_tb_partSize;
        private TextBox m_tb_docNumber;
        private TextBox m_tb_designation;
        private TextBox m_tb_originDesign;
        private TextBox m_tb_partProcess;
        private TextBox m_tb_partQty;
        private TextBox m_tb_errorMessage;
        private Button m_butt_openLocations;
        private Button m_butt_Search;
    }
}