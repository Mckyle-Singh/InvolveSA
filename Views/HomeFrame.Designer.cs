namespace InvolveSA
{
    partial class HomeFrame
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NavPanel = new Panel();
            btnLocalEvents = new Button();
            btnServiceRequests = new Button();
            btnResponseIssue = new Button();
            pnlContent = new Panel();
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.FromArgb(51, 51, 76);
            NavPanel.Controls.Add(btnLocalEvents);
            NavPanel.Controls.Add(btnServiceRequests);
            NavPanel.Controls.Add(btnResponseIssue);
            NavPanel.Dock = DockStyle.Left;
            NavPanel.Location = new Point(0, 0);
            NavPanel.Margin = new Padding(3, 2, 3, 2);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(185, 338);
            NavPanel.TabIndex = 0;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.Dock = DockStyle.Top;
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 10F);
            btnLocalEvents.Location = new Point(0, 75);
            btnLocalEvents.Margin = new Padding(3, 2, 3, 2);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(185, 32);
            btnLocalEvents.TabIndex = 2;
            btnLocalEvents.Text = "Local Events ";
            btnLocalEvents.UseVisualStyleBackColor = true;
            btnLocalEvents.Click += btnLocalEvents_Click_1;
            // 
            // btnServiceRequests
            // 
            btnServiceRequests.Dock = DockStyle.Top;
            btnServiceRequests.FlatAppearance.BorderSize = 0;
            btnServiceRequests.FlatStyle = FlatStyle.Flat;
            btnServiceRequests.Font = new Font("Segoe UI", 10F);
            btnServiceRequests.Location = new Point(0, 39);
            btnServiceRequests.Margin = new Padding(3, 2, 3, 2);
            btnServiceRequests.Name = "btnServiceRequests";
            btnServiceRequests.Size = new Size(185, 36);
            btnServiceRequests.TabIndex = 1;
            btnServiceRequests.Text = "Service Requests";
            btnServiceRequests.UseVisualStyleBackColor = true;
            btnServiceRequests.Click += btnServiceRequests_Click_1;
            // 
            // btnResponseIssue
            // 
            btnResponseIssue.Dock = DockStyle.Top;
            btnResponseIssue.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnResponseIssue.FlatAppearance.BorderSize = 0;
            btnResponseIssue.FlatStyle = FlatStyle.Flat;
            btnResponseIssue.Font = new Font("Segoe UI", 10F);
            btnResponseIssue.Location = new Point(0, 0);
            btnResponseIssue.Margin = new Padding(3, 2, 3, 2);
            btnResponseIssue.Name = "btnResponseIssue";
            btnResponseIssue.Size = new Size(185, 39);
            btnResponseIssue.TabIndex = 0;
            btnResponseIssue.Text = "Report Issues";
            btnResponseIssue.UseVisualStyleBackColor = true;
            btnResponseIssue.Click += btnResponseIssue_Click;
            // 
            // pnlContent
            // 
            pnlContent.Location = new Point(183, 0);
            pnlContent.Margin = new Padding(3, 2, 3, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(516, 370);
            pnlContent.TabIndex = 1;
            // 
            // HomeFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(pnlContent);
            Controls.Add(NavPanel);
            ForeColor = SystemColors.Window;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeFrame";
            Text = "Form1";
            Load += Form1_Load;
            NavPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavPanel;
        private Button btnResponseIssue;
        private Button btnLocalEvents;
        private Button btnServiceRequests;
        private Panel pnlContent;
    }
}
