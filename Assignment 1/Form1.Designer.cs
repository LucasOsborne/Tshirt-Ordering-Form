namespace Assignment_1
{
    partial class TshirtOrderFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TshirtOrderFrm));
            this.TshirtOrderNumLbl = new System.Windows.Forms.Label();
            this.TshirtOrderLbl = new System.Windows.Forms.Label();
            this.TshirtSizeLbl = new System.Windows.Forms.Label();
            this.TshirtSizeCmbBox = new System.Windows.Forms.ComboBox();
            this.TshirtColorLbl = new System.Windows.Forms.Label();
            this.TshirtColorCmbBox = new System.Windows.Forms.ComboBox();
            this.TshirtMaterialLbl = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.TshirtMaterialLycraRadioBtn = new System.Windows.Forms.RadioButton();
            this.TshirtMaterialCottonRadioBtn = new System.Windows.Forms.RadioButton();
            this.TshirtQuantityLbl = new System.Windows.Forms.Label();
            this.TshirtQauntityNumUD = new System.Windows.Forms.NumericUpDown();
            this.TshirtPrintTextChkBox = new System.Windows.Forms.CheckBox();
            this.TshirtPrintingTxtBox = new System.Windows.Forms.TextBox();
            this.TshirtCollectionDateLbl = new System.Windows.Forms.Label();
            this.TshirtSurnameBoxLbl = new System.Windows.Forms.TextBox();
            this.TshirtSurnameLbl = new System.Windows.Forms.Label();
            this.TshirtDetailsGrpBox = new System.Windows.Forms.GroupBox();
            this.TshirtCollectionDateDTPicker = new System.Windows.Forms.DateTimePicker();
            this.TshirtTotalCostBoxLbl = new System.Windows.Forms.Label();
            this.TshirtTotalCostLbl = new System.Windows.Forms.Label();
            this.TshirtCalculateBtn = new System.Windows.Forms.Button();
            this.TshirtCompanyLogoPB = new System.Windows.Forms.PictureBox();
            this.TshirtMaterialRadioBtnPanel = new System.Windows.Forms.Panel();
            this.TshirtExitBtn = new System.Windows.Forms.Button();
            this.TshirtClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TshirtQauntityNumUD)).BeginInit();
            this.TshirtDetailsGrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TshirtCompanyLogoPB)).BeginInit();
            this.TshirtMaterialRadioBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TshirtOrderNumLbl
            // 
            this.TshirtOrderNumLbl.AutoSize = true;
            this.TshirtOrderNumLbl.Location = new System.Drawing.Point(34, 60);
            this.TshirtOrderNumLbl.Name = "TshirtOrderNumLbl";
            this.TshirtOrderNumLbl.Size = new System.Drawing.Size(33, 20);
            this.TshirtOrderNumLbl.TabIndex = 0;
            this.TshirtOrderNumLbl.Text = "No:";
            // 
            // TshirtOrderLbl
            // 
            this.TshirtOrderLbl.AutoSize = true;
            this.TshirtOrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TshirtOrderLbl.Location = new System.Drawing.Point(34, 22);
            this.TshirtOrderLbl.Name = "TshirtOrderLbl";
            this.TshirtOrderLbl.Size = new System.Drawing.Size(164, 29);
            this.TshirtOrderLbl.TabIndex = 1;
            this.TshirtOrderLbl.Text = "T-shirt Order";
            // 
            // TshirtSizeLbl
            // 
            this.TshirtSizeLbl.AutoSize = true;
            this.TshirtSizeLbl.Location = new System.Drawing.Point(33, 108);
            this.TshirtSizeLbl.Name = "TshirtSizeLbl";
            this.TshirtSizeLbl.Size = new System.Drawing.Size(44, 20);
            this.TshirtSizeLbl.TabIndex = 2;
            this.TshirtSizeLbl.Text = "Size:";
            // 
            // TshirtSizeCmbBox
            // 
            this.TshirtSizeCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TshirtSizeCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TshirtSizeCmbBox.BackColor = System.Drawing.Color.White;
            this.TshirtSizeCmbBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.TshirtSizeCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TshirtSizeCmbBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TshirtSizeCmbBox.FormattingEnabled = true;
            this.TshirtSizeCmbBox.Items.AddRange(new object[] {
            "XS - £4.50",
            "S - £5.00",
            "M - £5.50",
            "L - £6.00",
            "XL - £7.00"});
            this.TshirtSizeCmbBox.Location = new System.Drawing.Point(38, 131);
            this.TshirtSizeCmbBox.Name = "TshirtSizeCmbBox";
            this.TshirtSizeCmbBox.Size = new System.Drawing.Size(121, 28);
            this.TshirtSizeCmbBox.TabIndex = 3;
            this.TshirtSizeCmbBox.SelectedIndexChanged += new System.EventHandler(this.TshirtSizeCmbBox_SelectedIndexChanged);
            // 
            // TshirtColorLbl
            // 
            this.TshirtColorLbl.AutoSize = true;
            this.TshirtColorLbl.Location = new System.Drawing.Point(34, 189);
            this.TshirtColorLbl.Name = "TshirtColorLbl";
            this.TshirtColorLbl.Size = new System.Drawing.Size(59, 20);
            this.TshirtColorLbl.TabIndex = 4;
            this.TshirtColorLbl.Text = "Colour:";
            // 
            // TshirtColorCmbBox
            // 
            this.TshirtColorCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TshirtColorCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TshirtColorCmbBox.BackColor = System.Drawing.Color.White;
            this.TshirtColorCmbBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TshirtColorCmbBox.FormattingEnabled = true;
            this.TshirtColorCmbBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "White",
            "Green",
            "Purple",
            "Yellow"});
            this.TshirtColorCmbBox.Location = new System.Drawing.Point(38, 212);
            this.TshirtColorCmbBox.Name = "TshirtColorCmbBox";
            this.TshirtColorCmbBox.Size = new System.Drawing.Size(121, 28);
            this.TshirtColorCmbBox.TabIndex = 5;
            // 
            // TshirtMaterialLbl
            // 
            this.TshirtMaterialLbl.AutoSize = true;
            this.TshirtMaterialLbl.Location = new System.Drawing.Point(34, 260);
            this.TshirtMaterialLbl.Name = "TshirtMaterialLbl";
            this.TshirtMaterialLbl.Size = new System.Drawing.Size(69, 20);
            this.TshirtMaterialLbl.TabIndex = 6;
            this.TshirtMaterialLbl.Text = "Material:";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // TshirtMaterialLycraRadioBtn
            // 
            this.TshirtMaterialLycraRadioBtn.AutoSize = true;
            this.TshirtMaterialLycraRadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.TshirtMaterialLycraRadioBtn.Location = new System.Drawing.Point(144, 3);
            this.TshirtMaterialLycraRadioBtn.Name = "TshirtMaterialLycraRadioBtn";
            this.TshirtMaterialLycraRadioBtn.Size = new System.Drawing.Size(125, 24);
            this.TshirtMaterialLycraRadioBtn.TabIndex = 1;
            this.TshirtMaterialLycraRadioBtn.Text = "Lycra - £2.50";
            this.TshirtMaterialLycraRadioBtn.UseVisualStyleBackColor = false;
            // 
            // TshirtMaterialCottonRadioBtn
            // 
            this.TshirtMaterialCottonRadioBtn.AutoSize = true;
            this.TshirtMaterialCottonRadioBtn.Checked = true;
            this.TshirtMaterialCottonRadioBtn.Location = new System.Drawing.Point(3, 3);
            this.TshirtMaterialCottonRadioBtn.Name = "TshirtMaterialCottonRadioBtn";
            this.TshirtMaterialCottonRadioBtn.Size = new System.Drawing.Size(135, 24);
            this.TshirtMaterialCottonRadioBtn.TabIndex = 0;
            this.TshirtMaterialCottonRadioBtn.TabStop = true;
            this.TshirtMaterialCottonRadioBtn.Text = "Cotton - £1.00";
            this.TshirtMaterialCottonRadioBtn.UseVisualStyleBackColor = false;
            // 
            // TshirtQuantityLbl
            // 
            this.TshirtQuantityLbl.AutoSize = true;
            this.TshirtQuantityLbl.Location = new System.Drawing.Point(34, 342);
            this.TshirtQuantityLbl.Name = "TshirtQuantityLbl";
            this.TshirtQuantityLbl.Size = new System.Drawing.Size(118, 20);
            this.TshirtQuantityLbl.TabIndex = 8;
            this.TshirtQuantityLbl.Text = "Quantity (1-50):";
            // 
            // TshirtQauntityNumUD
            // 
            this.TshirtQauntityNumUD.BackColor = System.Drawing.Color.White;
            this.TshirtQauntityNumUD.Location = new System.Drawing.Point(39, 365);
            this.TshirtQauntityNumUD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TshirtQauntityNumUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TshirtQauntityNumUD.Name = "TshirtQauntityNumUD";
            this.TshirtQauntityNumUD.Size = new System.Drawing.Size(120, 26);
            this.TshirtQauntityNumUD.TabIndex = 9;
            this.TshirtQauntityNumUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TshirtPrintTextChkBox
            // 
            this.TshirtPrintTextChkBox.Location = new System.Drawing.Point(32, 397);
            this.TshirtPrintTextChkBox.Name = "TshirtPrintTextChkBox";
            this.TshirtPrintTextChkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TshirtPrintTextChkBox.Size = new System.Drawing.Size(182, 25);
            this.TshirtPrintTextChkBox.TabIndex = 10;
            this.TshirtPrintTextChkBox.Text = "?Printing on T-shirts";
            this.TshirtPrintTextChkBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TshirtPrintTextChkBox.UseVisualStyleBackColor = true;
            this.TshirtPrintTextChkBox.CheckedChanged += new System.EventHandler(this.TshirtPrintTextChkBox_CheckedChanged);
            // 
            // TshirtPrintingTxtBox
            // 
            this.TshirtPrintingTxtBox.BackColor = System.Drawing.Color.White;
            this.TshirtPrintingTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TshirtPrintingTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TshirtPrintingTxtBox.Location = new System.Drawing.Point(40, 428);
            this.TshirtPrintingTxtBox.Multiline = true;
            this.TshirtPrintingTxtBox.Name = "TshirtPrintingTxtBox";
            this.TshirtPrintingTxtBox.Size = new System.Drawing.Size(290, 124);
            this.TshirtPrintingTxtBox.TabIndex = 11;
            this.TshirtPrintingTxtBox.Visible = false;
            // 
            // TshirtCollectionDateLbl
            // 
            this.TshirtCollectionDateLbl.AutoSize = true;
            this.TshirtCollectionDateLbl.Location = new System.Drawing.Point(46, 25);
            this.TshirtCollectionDateLbl.Name = "TshirtCollectionDateLbl";
            this.TshirtCollectionDateLbl.Size = new System.Drawing.Size(118, 20);
            this.TshirtCollectionDateLbl.TabIndex = 12;
            this.TshirtCollectionDateLbl.Text = "Collection date:";
            // 
            // TshirtSurnameBoxLbl
            // 
            this.TshirtSurnameBoxLbl.BackColor = System.Drawing.Color.White;
            this.TshirtSurnameBoxLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TshirtSurnameBoxLbl.Location = new System.Drawing.Point(50, 115);
            this.TshirtSurnameBoxLbl.Name = "TshirtSurnameBoxLbl";
            this.TshirtSurnameBoxLbl.Size = new System.Drawing.Size(174, 26);
            this.TshirtSurnameBoxLbl.TabIndex = 16;
            // 
            // TshirtSurnameLbl
            // 
            this.TshirtSurnameLbl.AutoSize = true;
            this.TshirtSurnameLbl.Location = new System.Drawing.Point(48, 92);
            this.TshirtSurnameLbl.Name = "TshirtSurnameLbl";
            this.TshirtSurnameLbl.Size = new System.Drawing.Size(78, 20);
            this.TshirtSurnameLbl.TabIndex = 15;
            this.TshirtSurnameLbl.Text = "Surname:";
            // 
            // TshirtDetailsGrpBox
            // 
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtCollectionDateDTPicker);
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtTotalCostBoxLbl);
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtTotalCostLbl);
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtCollectionDateLbl);
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtSurnameBoxLbl);
            this.TshirtDetailsGrpBox.Controls.Add(this.TshirtSurnameLbl);
            this.TshirtDetailsGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TshirtDetailsGrpBox.Location = new System.Drawing.Point(38, 557);
            this.TshirtDetailsGrpBox.Name = "TshirtDetailsGrpBox";
            this.TshirtDetailsGrpBox.Size = new System.Drawing.Size(292, 182);
            this.TshirtDetailsGrpBox.TabIndex = 18;
            this.TshirtDetailsGrpBox.TabStop = false;
            this.TshirtDetailsGrpBox.Text = "Details:";
            // 
            // TshirtCollectionDateDTPicker
            // 
            this.TshirtCollectionDateDTPicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.TshirtCollectionDateDTPicker.CalendarTitleBackColor = System.Drawing.Color.LightGreen;
            this.TshirtCollectionDateDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TshirtCollectionDateDTPicker.Location = new System.Drawing.Point(50, 48);
            this.TshirtCollectionDateDTPicker.Name = "TshirtCollectionDateDTPicker";
            this.TshirtCollectionDateDTPicker.Size = new System.Drawing.Size(174, 26);
            this.TshirtCollectionDateDTPicker.TabIndex = 20;
            // 
            // TshirtTotalCostBoxLbl
            // 
            this.TshirtTotalCostBoxLbl.BackColor = System.Drawing.Color.White;
            this.TshirtTotalCostBoxLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TshirtTotalCostBoxLbl.Location = new System.Drawing.Point(98, 155);
            this.TshirtTotalCostBoxLbl.Name = "TshirtTotalCostBoxLbl";
            this.TshirtTotalCostBoxLbl.Size = new System.Drawing.Size(112, 24);
            this.TshirtTotalCostBoxLbl.TabIndex = 19;
            this.TshirtTotalCostBoxLbl.Text = "£0.00";
            // 
            // TshirtTotalCostLbl
            // 
            this.TshirtTotalCostLbl.AutoSize = true;
            this.TshirtTotalCostLbl.Location = new System.Drawing.Point(46, 155);
            this.TshirtTotalCostLbl.Name = "TshirtTotalCostLbl";
            this.TshirtTotalCostLbl.Size = new System.Drawing.Size(48, 20);
            this.TshirtTotalCostLbl.TabIndex = 18;
            this.TshirtTotalCostLbl.Text = "Total:";
            // 
            // TshirtCalculateBtn
            // 
            this.TshirtCalculateBtn.BackColor = System.Drawing.Color.White;
            this.TshirtCalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TshirtCalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TshirtCalculateBtn.Location = new System.Drawing.Point(140, 745);
            this.TshirtCalculateBtn.Name = "TshirtCalculateBtn";
            this.TshirtCalculateBtn.Size = new System.Drawing.Size(88, 34);
            this.TshirtCalculateBtn.TabIndex = 20;
            this.TshirtCalculateBtn.Text = "Calculate";
            this.TshirtCalculateBtn.UseVisualStyleBackColor = false;
            this.TshirtCalculateBtn.Click += new System.EventHandler(this.TshirtCalculateBtn_Click);
            // 
            // TshirtCompanyLogoPB
            // 
            this.TshirtCompanyLogoPB.Image = global::Assignment_1.Properties.Resources.Logo;
            this.TshirtCompanyLogoPB.Location = new System.Drawing.Point(243, 12);
            this.TshirtCompanyLogoPB.Name = "TshirtCompanyLogoPB";
            this.TshirtCompanyLogoPB.Size = new System.Drawing.Size(116, 83);
            this.TshirtCompanyLogoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TshirtCompanyLogoPB.TabIndex = 21;
            this.TshirtCompanyLogoPB.TabStop = false;
            // 
            // TshirtMaterialRadioBtnPanel
            // 
            this.TshirtMaterialRadioBtnPanel.Controls.Add(this.TshirtMaterialCottonRadioBtn);
            this.TshirtMaterialRadioBtnPanel.Controls.Add(this.TshirtMaterialLycraRadioBtn);
            this.TshirtMaterialRadioBtnPanel.Location = new System.Drawing.Point(38, 294);
            this.TshirtMaterialRadioBtnPanel.Name = "TshirtMaterialRadioBtnPanel";
            this.TshirtMaterialRadioBtnPanel.Size = new System.Drawing.Size(282, 31);
            this.TshirtMaterialRadioBtnPanel.TabIndex = 22;
            // 
            // TshirtExitBtn
            // 
            this.TshirtExitBtn.BackColor = System.Drawing.Color.White;
            this.TshirtExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TshirtExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TshirtExitBtn.Location = new System.Drawing.Point(60, 745);
            this.TshirtExitBtn.Name = "TshirtExitBtn";
            this.TshirtExitBtn.Size = new System.Drawing.Size(75, 34);
            this.TshirtExitBtn.TabIndex = 23;
            this.TshirtExitBtn.Text = "Exit";
            this.TshirtExitBtn.UseVisualStyleBackColor = false;
            this.TshirtExitBtn.Click += new System.EventHandler(this.TshirtExitBtn_Click);
            // 
            // TshirtClearBtn
            // 
            this.TshirtClearBtn.BackColor = System.Drawing.Color.White;
            this.TshirtClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TshirtClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TshirtClearBtn.Location = new System.Drawing.Point(232, 745);
            this.TshirtClearBtn.Name = "TshirtClearBtn";
            this.TshirtClearBtn.Size = new System.Drawing.Size(80, 34);
            this.TshirtClearBtn.TabIndex = 24;
            this.TshirtClearBtn.Text = "Clear";
            this.TshirtClearBtn.UseVisualStyleBackColor = false;
            this.TshirtClearBtn.Click += new System.EventHandler(this.TshirtClearBtn_Click);
            // 
            // TshirtOrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 837);
            this.Controls.Add(this.TshirtClearBtn);
            this.Controls.Add(this.TshirtExitBtn);
            this.Controls.Add(this.TshirtMaterialRadioBtnPanel);
            this.Controls.Add(this.TshirtCompanyLogoPB);
            this.Controls.Add(this.TshirtCalculateBtn);
            this.Controls.Add(this.TshirtDetailsGrpBox);
            this.Controls.Add(this.TshirtPrintingTxtBox);
            this.Controls.Add(this.TshirtPrintTextChkBox);
            this.Controls.Add(this.TshirtQauntityNumUD);
            this.Controls.Add(this.TshirtQuantityLbl);
            this.Controls.Add(this.TshirtMaterialLbl);
            this.Controls.Add(this.TshirtColorCmbBox);
            this.Controls.Add(this.TshirtColorLbl);
            this.Controls.Add(this.TshirtSizeCmbBox);
            this.Controls.Add(this.TshirtSizeLbl);
            this.Controls.Add(this.TshirtOrderLbl);
            this.Controls.Add(this.TshirtOrderNumLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TshirtOrderFrm";
            this.Text = "T-shirt Order";
            ((System.ComponentModel.ISupportInitialize)(this.TshirtQauntityNumUD)).EndInit();
            this.TshirtDetailsGrpBox.ResumeLayout(false);
            this.TshirtDetailsGrpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TshirtCompanyLogoPB)).EndInit();
            this.TshirtMaterialRadioBtnPanel.ResumeLayout(false);
            this.TshirtMaterialRadioBtnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TshirtOrderNumLbl;
        private System.Windows.Forms.Label TshirtOrderLbl;
        private System.Windows.Forms.Label TshirtSizeLbl;
        private System.Windows.Forms.Label TshirtColorLbl;
        private System.Windows.Forms.ComboBox TshirtColorCmbBox;
        private System.Windows.Forms.Label TshirtMaterialLbl;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.RadioButton TshirtMaterialLycraRadioBtn;
        private System.Windows.Forms.RadioButton TshirtMaterialCottonRadioBtn;
        private System.Windows.Forms.Label TshirtQuantityLbl;
        private System.Windows.Forms.NumericUpDown TshirtQauntityNumUD;
        private System.Windows.Forms.CheckBox TshirtPrintTextChkBox;
        private System.Windows.Forms.TextBox TshirtPrintingTxtBox;
        private System.Windows.Forms.Label TshirtCollectionDateLbl;
        private System.Windows.Forms.TextBox TshirtSurnameBoxLbl;
        private System.Windows.Forms.Label TshirtSurnameLbl;
        private System.Windows.Forms.GroupBox TshirtDetailsGrpBox;
        private System.Windows.Forms.Label TshirtTotalCostLbl;
        private System.Windows.Forms.Button TshirtCalculateBtn;
        private System.Windows.Forms.PictureBox TshirtCompanyLogoPB;
        private System.Windows.Forms.ComboBox TshirtSizeCmbBox;
        private System.Windows.Forms.Panel TshirtMaterialRadioBtnPanel;
        private System.Windows.Forms.Label TshirtTotalCostBoxLbl;
        private System.Windows.Forms.DateTimePicker TshirtCollectionDateDTPicker;
        private System.Windows.Forms.Button TshirtExitBtn;
        private System.Windows.Forms.Button TshirtClearBtn;
    }
}

