using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disclosure.Models
{
    public class ViewGiftTravelFilings
    {
        public List<Report> Reports { get; set; }
        public DocumentInfo Source { get; set; }
        public Filter Filters { get; set; }
        public static ViewGiftTravelFilings GetMockData()
        {
            return new ViewGiftTravelFilings()
            {
                Reports = new List<Report>
                {
                    new Report
                    {
                        Year = 2008,
                        FilePath = "",
                    },
                    new Report
                    {
                        Year = 2009,
                        FilePath = "",
                    },
                    new Report
                    {
                        Year = 2010,
                        FilePath = "",
                    },
                    new Report
                    {
                        Year = 2011,
                        FilePath = "",
                    },
                    new Report
                    {
                        Year = 2012,
                        FilePath = "",
                    },
                    new Report
                    {
                        Year = 2013,
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
            public string MemberLastName { get; set; }
            public string Sponsor { get; set; }
            public string Destination { get; set; }
            public DateTime TravelDateFrom { get; set; }
            public DateTime TravelDateTo { get; set; }
        }

        public class TravelData
        {
            public string MemberName { get; set; }
            public int FilerName { get; set; }
            public string Destination { get; set; }
            public DateTime TravelDateFrom { get; set; }
            public DateTime TravelDateTo { get; set; }
            public string Sponsor { get; set; }
        }
    }
}