using InvolveSA.Data;
using InvolveSA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvolveSA.Views
{
    public partial class ReportIssue : UserControl
    {
        // Holds the uploaded photo bytes
        private byte[] _selectedPhoto;

        // Concrete repository instance
        private readonly ReportIssueRepository _repo = new ReportIssueRepository();


        public ReportIssue()
        {
            InitializeComponent();
            btnUploadPhoto.Click += BtnUploadPhoto_Click;
            btnSubmit.Click += BtnSubmit_Click;
            btnViewReports.Click += BtnViewReports_Click;

        }

        private void ReportIssue_Load(object sender, EventArgs e)
        {

        }
        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
            };
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            _selectedPhoto = File.ReadAllBytes(dlg.FileName);
            btnUploadPhoto.Text = Path.GetFileName(dlg.FileName);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // 1. Validate required fields
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the location.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_selectedPhoto == null)
            {
                MessageBox.Show("Please upload a photo.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Build the model
            var issue = new ReportIssueModel
            {
                Location = txtLocation.Text.Trim(),
                PhotoData = _selectedPhoto,
                PhotoFileName = btnUploadPhoto.Text,
                Description = rtbDescription.Text.Trim(),
                SubmittedAt = DateTime.UtcNow
            };

            // 3. Persist to repository
            _repo.Save(issue);

            // 4. Confirm & reset form
            MessageBox.Show("Your issue has been submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtLocation.Clear();
            rtbDescription.Clear();
            btnUploadPhoto.Text = "Upload Photo…";
            _selectedPhoto = null;
        }

        private void BtnViewReports_Click(object sender, EventArgs e)
        {
            var allReports = _repo.GetAll();
            if (allReports.Count == 0)
            {
                MessageBox.Show("No reports submitted yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var sb = new StringBuilder();
            foreach (var report in allReports)
            {
                sb.AppendLine($"📍 Location: {report.Location}");
                sb.AppendLine($"📝 Description: {report.Description}");
                sb.AppendLine($"🖼️ Photo: {report.PhotoFileName}");
                sb.AppendLine($"🕒 Submitted: {report.SubmittedAt:g}");
                sb.AppendLine(new string('-', 40));
            }

            MessageBox.Show(sb.ToString(), "Submitted Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
