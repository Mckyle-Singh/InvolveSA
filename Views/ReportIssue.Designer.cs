namespace InvolveSA.Views
{
    partial class ReportIssue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLocation = new Label();
            colorDialog1 = new ColorDialog();
            pnlMapPlaceholder = new Panel();
            lblTitle = new Label();
            txtLocation = new TextBox();
            btnUploadPhoto = new Button();
            rtbDescription = new RichTextBox();
            lblDescription = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.ForeColor = SystemColors.MenuText;
            lblLocation.Location = new Point(360, 40);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(96, 15);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Location of Issue";
            // 
            // pnlMapPlaceholder
            // 
            pnlMapPlaceholder.BackColor = SystemColors.ActiveCaption;
            pnlMapPlaceholder.Location = new Point(10, 40);
            pnlMapPlaceholder.Name = "pnlMapPlaceholder";
            pnlMapPlaceholder.Size = new Size(340, 180);
            pnlMapPlaceholder.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.MenuText;
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Report an Issue";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(360, 60);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(140, 23);
            txtLocation.TabIndex = 7;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.BackColor = SystemColors.ActiveCaption;
            btnUploadPhoto.Location = new Point(360, 100);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(140, 30);
            btnUploadPhoto.TabIndex = 8;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = false;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(10, 255);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(490, 60);
            rtbDescription.TabIndex = 9;
            rtbDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = SystemColors.ControlText;
            lblDescription.Location = new Point(10, 235);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // btnSubmit
            // 
            btnSubmit.ForeColor = SystemColors.MenuText;
            btnSubmit.Location = new Point(218, 325);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(80, 30);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnViewReports
            // 
            btnViewReports = new Button();
            btnViewReports.Location = new Point(10, 325);  // left of Submit
            btnViewReports.Size = new Size(120, 30);
            btnViewReports.Text = "View Reports";
            btnViewReports.UseVisualStyleBackColor = true;
            Controls.Add(btnViewReports);
            btnViewReports.ForeColor = SystemColors.MenuText;
            // 
            // ReportIssue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDescription);
            Controls.Add(rtbDescription);
            Controls.Add(btnUploadPhoto);
            Controls.Add(txtLocation);
            Controls.Add(lblTitle);
            Controls.Add(pnlMapPlaceholder);
            Controls.Add(lblLocation);
            Controls.Add(btnSubmit);
            Location = new Point(360, 100);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReportIssue";
            Size = new Size(516, 370);
            Load += ReportIssue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLocation;
        private ColorDialog colorDialog1;
        private Panel pnlMapPlaceholder;
        private Label lblTitle;
        private TextBox txtLocation;
        private Button btnUploadPhoto;
        private RichTextBox rtbDescription;
        private Label lblDescription;
        private Button btnSubmit;
        private Button btnViewReports;



    }
}
