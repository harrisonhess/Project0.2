using Project0._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project0._2.Models
{
    public class FakeOpportunityRepository : IOpportunityRepository
    {
        private List<Opportunity> Opportunities;

        public FakeOpportunityRepository()
        {
            Opportunities = new List<Opportunity>()
            {
                new Opportunity { id = 1, Name = "Park Cleanup", Center = "Central Park", Date = "August 31, 2020" },
                new Opportunity { id = 2, Name = "Beach Cleanup", Center = "Central Beach", Date = "August 15, 2020" },
                new Opportunity { id = 3, Name = "Sea Turtle Watch", Center = "Central Beach", Date = "September 27, 2020" },
                new Opportunity { id = 4, Name = "Highway Cleanup", Center = "Central Highway", Date = "November 16, 2020" },
                new Opportunity { id = 5, Name = "Elderly Watch", Center = "TLC Elder Home", Date = "July 24, 2021" },
                new Opportunity { id = 6, Name = "Kids Camp Help", Center = "Lakeside Park", Date = "May 11, 2021" },
                new Opportunity { id = 7, Name = "Homeless Shelter Help", Center = "Central Park", Date = "February 14, 2021" }
            };
        }

        public Opportunity CreateOpportunity(Opportunity Opportunity)
        {
            if (Opportunities.Count != 0)
            {
                Opportunity.id = Opportunities.Max(v => v.id) + 1;
            } else
            {
                Opportunity.id = 1;
            }
                Opportunities.Add(Opportunity);
            return Opportunity;
        }

        public Opportunity DeleteOpportunity(int id)
        {
            Opportunities.Remove(Opportunities.FirstOrDefault(v => v.id == id));
            return null;
        }

        public Opportunity GetOpportunity(int id)
        {
            return Opportunities.FirstOrDefault(v => v.id == id);
        }


        public IEnumerable<Opportunity> GetOpportunities()
        {
            return Opportunities;
        }

        public Opportunity SaveOpportunity(Opportunity Opportunity)
        {
            Opportunity op = Opportunities.FirstOrDefault(v => v.id == Opportunity.id);
            if (op != null)
            {
                op.Name = Opportunity.Name;
                op.Center = Opportunity.Center;
                op.Date = Opportunity.Date;
            }
            return op;
        }
    }
}
