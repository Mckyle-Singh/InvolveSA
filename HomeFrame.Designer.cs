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
            NavPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NavPanel
            // 
            NavPanel.BackColor = Color.CornflowerBlue;
            NavPanel.Controls.Add(btnLocalEvents);
            NavPanel.Controls.Add(btnServiceRequests);
            NavPanel.Controls.Add(btnResponseIssue);
            NavPanel.Dock = DockStyle.Left;
            NavPanel.Location = new Point(0, 0);
            NavPanel.Name = "NavPanel";
            NavPanel.Size = new Size(211, 450);
            NavPanel.TabIndex = 0;
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.Dock = DockStyle.Top;
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 10F);
            btnLocalEvents.Location = new Point(0, 58);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(211, 29);
            btnLocalEvents.TabIndex = 2;
            btnLocalEvents.Text = "Local Events ";
            btnLocalEvents.UseVisualStyleBackColor = true;
            btnLocalEvents.Click += this.btnLocalEvents_Click_1;
            // 
            // btnServiceRequests
            // 
            btnServiceRequests.Dock = DockStyle.Top;
            btnServiceRequests.FlatAppearance.BorderSize = 0;
            btnServiceRequests.FlatStyle = FlatStyle.Flat;
            btnServiceRequests.Font = new Font("Segoe UI", 10F);
            btnServiceRequests.Location = new Point(0, 29);
            btnServiceRequests.Name = "btnServiceRequests";
            btnServiceRequests.Size = new Size(211, 29);
            btnServiceRequests.TabIndex = 1;
            btnServiceRequests.Text = "Service Requests";
            btnServiceRequests.UseVisualStyleBackColor = true;
            btnServiceRequests.Click += this.btnServiceRequests_Click_1;
            // 
            // btnResponseIssue
            // 
            btnResponseIssue.Dock = DockStyle.Top;
            btnResponseIssue.FlatAppearance.BorderColor = Color.CornflowerBlue;
            btnResponseIssue.FlatAppearance.BorderSize = 0;
            btnResponseIssue.FlatStyle = FlatStyle.Flat;
            btnResponseIssue.Font = new Font("Segoe UI", 10F);
            btnResponseIssue.Location = new Point(0, 0);
            btnResponseIssue.Name = "btnResponseIssue";
            btnResponseIssue.Size = new Size(211, 29);
            btnResponseIssue.TabIndex = 0;
            btnResponseIssue.Text = "Report Issues";
            btnResponseIssue.UseVisualStyleBackColor = true;
            btnResponseIssue.Click += this.btnResponseIssue_Click;
            // 
            // HomeFrame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NavPanel);
            ForeColor = SystemColors.Window;
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
    }
}
