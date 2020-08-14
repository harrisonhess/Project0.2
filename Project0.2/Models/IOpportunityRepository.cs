using Project0._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project0._2.Models
{
    public interface IOpportunityRepository
    {
        IEnumerable<Opportunity> GetOpportunities();
        Opportunity SaveOpportunity(Opportunity op);
        Opportunity DeleteOpportunity(int id);

        Opportunity GetOpportunity(int id);
        Opportunity CreateOpportunity(Opportunity op);
    }
}
