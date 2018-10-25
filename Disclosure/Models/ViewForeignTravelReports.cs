using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disclosure.Models
{
    public class ViewForeignTravelReports
    {
        public DocumentInfo Source { get; set; }
        public Filter Filters { get; set; }
        public static ViewForeignTravelReports GetMockData()
        {
            return new ViewForeignTravelReports()
            {
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
            public int Year { get; set; }
            public string Quarter { get; set; }
        }

        public class TravelReport
        {
            public string PDFPath { get; set; }
            public string TXTPath { get; set; }
            public DateTime Date { get; set; }
        }
    }
}