namespace InvolveSA
{
    public partial class HomeFrame : Form
    {
        public HomeFrame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnResponseIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report Issues clicked");
        }

        private void btnServiceRequests_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Service Requests clicked");
        }

        private void btnLocalEvents_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Local Events clicked");
        }

    }
}
