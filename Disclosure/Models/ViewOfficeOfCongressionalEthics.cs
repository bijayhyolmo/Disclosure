using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Disclosure.Models
{
    public class ViewOfficeOfCongressionalEthics
    {
        public DocumentInfo Source { get; set; }
        public List<Candidate> Candidates { get; set; }
        public static ViewOfficeOfCongressionalEthics GetMockData()
        {
            return new ViewOfficeOfCongressionalEthics()
            {
                Candidates = new List<Candidate>
                {
                    new Candidate { Type = "Board", Name = "Mike D. Barnes"},
                    new Candidate { Type = "Board", Name = "Judy Biggert"},
                    new Candidate { Type = "Board", Name = "Jay Eagen"},
                    new Candidate { Type = "Board", Name = "Karan L. English"},
                    new Candidate { Type = "Board", Name = "Porter J. Goss"},
                    new Candidate { Type = "Board", Name = "Allison Hayward"},
                    new Candidate { Type = "Staff", Name = "Omar Ashmawy"},
                    new Candidate { Type = "Staff", Name = "Kelly Brewington"},
                    new Candidate { Type = "Staff", Name = "William H. Cable"},
                    new Candidate { Type = "Staff", Name = "Helen Eisner"},
                },
                Source = new DocumentInfo
                {
                    Name = "Legislative Resource Center",
                    Address = "135 Cannon House Office Building",
                    City = "Washington DC, 20515-6612",
                    Phone = "(202) 226-5200",
                    OfficeHours = "9:00 am - 6:00 pm"
                },
            };
        }

        public class Candidate
        {
            public string Type { get; set; }
            public string Name { get; set; }
        }
        public class DocumentInfo
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Phone { get; set; }
            public string OfficeHours { get; set; }
        }
    }
}