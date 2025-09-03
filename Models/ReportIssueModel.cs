using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvolveSA.Models
{
    public class ReportIssueModel
    {
        public string Location { get; set; }
        public byte[] PhotoData { get; set; }
        public string PhotoFileName { get; set; }
        public string Description { get; set; }
        public DateTime SubmittedAt { get; set; }


    }
}
