using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disclosure.Models
{
    public class ViewFinancialDisclosureReports
    {
        public List<FinancialDisclosureReports> Reports { get; set; }
        public List<ResourceForMembersAndStaffs> ResourcesForStaff { get; set; }
        public List<ResourceForCongressionalCandidates> ResourcesForCandidates { get; set; }
        public DisclosureDocumentSource Source { get; set; }
        public Filter MemberFilter { get; set; }
        public Filter CandidateFilter { get; set; }
        public static ViewFinancialDisclosureReports GetMockData()
        {
            return new ViewFinancialDisclosureReports()
            {
                Reports = new List<FinancialDisclosureReports>
                {
                    new FinancialDisclosureReports
                    {
                        Year = 2008,
                        FilePath = "",
                    },
                    new FinancialDisclosureReports
                    {
                        Year = 2009,
                        FilePath = "",
                    },
                    new FinancialDisclosureReports
                    {
                        Year = 2010,
                        FilePath = "",
                    },
                    new FinancialDisclosureReports
                    {
                        Year = 2011,
                        FilePath = "",
                    },
                    new FinancialDisclosureReports
                    {
                        Year = 2012,
                        FilePath = "",
                    },
                    new FinancialDisclosureReports
                    {
                        Year = 2013,
                        FilePath = "",
                    },
                },
                ResourcesForCandidates = new List<ResourceForCongressionalCandidates>
                {
                   new ResourceForCongressionalCandidates { Link = "https://ethics.house.gov/sites/ethics.house.gov/files/CY%202017%20Instruction%20Guide%20for%20Financial%20Disclosure%20Statements%20and%20PTRs_0.pdf",
                   Text = "CY 2017 Instruction Guide for Financial Disclosure Statements and Periodic Transaction Reports",
                   }
                },
                ResourcesForStaff = new List<ResourceForMembersAndStaffs>
                {
                    new ResourceForMembersAndStaffs { Link = "https://fd.house.gov/",Text = "Financial Disclosure Online Reporting Application" }
                },
                Source = new DisclosureDocumentSource
                {
                    Name = "Legislative Resource Center",
                    Address = "135 Cannon House Office Building",
                    City = "Washington DC, 20515-6612",
                    Phone = "(202) 226-5200",
                    OfficeHours = "9:00 am - 6:00 pm"
                },
                MemberFilter = new Filter(),
                CandidateFilter = new Filter(),
            };
        }
        public class FinancialDisclosureReports
        {
            public int Year { get; set; }

            public string FilePath { get; set; }
        }

        public class ResourceForMembersAndStaffs
        {
            public string Link { get; set; }
            public string Text { get; set; }
        }

        public class ResourceForCongressionalCandidates
        {
            public string Link { get; set; }
            public string Text { get; set; }
        }

        public class DisclosureDocumentSource
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string OfficeHours { get; set; }
        }

        public class Filter
        {
            public string LastName { get; set; }
            public int ElectionYear { get; set; }
            public string State { get; set; }
            public string District { get; set; }
            public string PostUrl { get; set; }
        }

        public class FinancialDisclosureData
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public string Office { get; set; }
            public string Filing { get; set; }
        }
    }
}