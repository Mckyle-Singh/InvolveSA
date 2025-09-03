using InvolveSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvolveSA.Data
{
    public class ReportIssueRepository
    {
        // In-memory storage
        private readonly List<ReportIssueModel> _storage = new();

        // Save a report
        public void Save(ReportIssueModel issue)
        {
            _storage.Add(issue);
        }

        // Retrieve all saved reports (for later use)
        public IReadOnlyList<ReportIssueModel> GetAll()
        {
            return _storage.AsReadOnly();
        }
    }

}