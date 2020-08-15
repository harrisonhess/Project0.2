using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project0._2.Models
{
    public interface IVolunteerRepository
    {
        IEnumerable<Volunteer> Search(string searchTerm);
        IEnumerable<Volunteer> getVolunteers();
        Volunteer SaveVolunteer(Volunteer volunteer);
        Volunteer DeleteVolunteer(int id);

        Volunteer getVolunteer(int id);
        Volunteer createVolunteer(Volunteer volunteer);
    }
}
