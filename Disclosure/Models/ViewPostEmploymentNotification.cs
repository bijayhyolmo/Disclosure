using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disclosure.Models
{
    public class ViewPostEmploymentNotification
    {

        public List<Report> Reports { get; set; }
        public DocumentInfo Source { get; set; }
        public Filter Filters { get; set; }
        public static ViewPostEmploymentNotification GetMockData()
        {
            return new ViewPostEmploymentNotification()
            {
                Reports = new List<Report>
                {
                    new Report
                    {
                        Year = 2008,
                        FilePath = "",
                    },
                },
                Source = new DocumentInfo
                {
                    Name = "Legislative Resource Center",
                    Address = "135 Cannon House Office Building",
                    City = "Washington DC, 20515-6612",
                    Phone = "(202) 226-5200",
                    OfficeHours = "9:00 am - 6:00 pm"
                },
                Filters = new Filter()
            };
        }
        public class Report
        {
            public int Year { get; set; }

            public string FilePath { get; set; }
        }

        public class DocumentInfo
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string OfficeHours { get; set; }
        }

        public class Filter
        {
            public string EmployeeLastName { get; set; }
            public string EmployingOffice { get; set; }
            public DateTime TerminationDateFrom { get; set; }
            public DateTime TerminationDateTo { get; set; }
        }

        public class PostEmploymentData
        {
            public string EmployeeName { get; set; }
            public string EmployingOffice { get; set; }
            public DateTime TerminationDate { get; set; }
            public DateTime LobbyingEligibilityDate { get; set; }
        }
    }
}
