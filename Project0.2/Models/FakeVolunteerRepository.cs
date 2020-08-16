using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project0._2.Models
{
    public class FakeVolunteerRepository : IVolunteerRepository
    {
        private List<Volunteer> Volunteers;

        public FakeVolunteerRepository()
        {
            Volunteers = new List<Volunteer>()
            {
                new Volunteer { ID = 1, FirstName = "John", LastName = "Doe", Username = "johndoe1", Password = "password123", Email = "johndoe1@gmail.com", ApprovalStatus = "Approved" },
                new Volunteer { ID = 2, FirstName = "Jane", LastName = "Doe", Username = "janedoe2", Password = "pswd456", Email = "janedoe1@gmail.com", ApprovalStatus = "Approved" },
                new Volunteer { ID = 3, FirstName = "Jerry", LastName = "Dough", Username = "jerrydough", Password = "p455w0rd", Email = "jerryyo@aol.com", ApprovalStatus = "Denied" },
                new Volunteer { ID = 4, FirstName = "Jack", LastName = "Doh", Username = "jackdoh", Password = "pathword123", Email = "jackhack@yahoo.com", ApprovalStatus = "Approved" },
                new Volunteer { ID = 5, FirstName = "Jill", LastName = "Dont", Username = "jilldont", Password = "wrodssap321", Email = "jillpill@gmail.com", ApprovalStatus = "Approved" },
            };
        }

        public Volunteer createVolunteer(Volunteer volunteer)
        {
            if (Volunteers.Count != 0)
            {
                volunteer.ID = Volunteers.Max(v => v.ID) + 1;
            } else
            {
                volunteer.ID = 1;
            }
                Volunteers.Add(volunteer);
            return volunteer;
        }

        public Volunteer DeleteVolunteer(int id)
        {
            Volunteers.Remove(Volunteers.FirstOrDefault(v => v.ID == id));
            return null;
        }

        public Volunteer getVolunteer(int id)
        {
            return Volunteers.FirstOrDefault(v => v.ID == id);
        }


        public IEnumerable<Volunteer> getVolunteers()
        {
            return Volunteers;
        }
       
        public Volunteer SaveVolunteer(Volunteer volunteer)
        {
            Volunteer vol = Volunteers.FirstOrDefault(v => v.ID == volunteer.ID);
            if (vol != null)
            {
                vol.FirstName = volunteer.FirstName;
                vol.LastName = volunteer.LastName;
                vol.Username = volunteer.Username;
                vol.CenterPreference = volunteer.CenterPreference;
                vol.Skills = volunteer.Skills;
                vol.Availability = volunteer.Availability;
                vol.Address = volunteer.Address;
                vol.PhoneNum = volunteer.PhoneNum;
                vol.Email = volunteer.Email;
                vol.Education = volunteer.Education;
                vol.Licenses = volunteer.Licenses;
                vol.EmergencyName = volunteer.EmergencyName;
                vol.EmergencyPhone = volunteer.EmergencyPhone;
                vol.EmergencyEmail = volunteer.EmergencyEmail;
                vol.EmergencyAddress = volunteer.EmergencyAddress;
                vol.DriversLicenseFiled = volunteer.DriversLicenseFiled;
                vol.SSNFiled = volunteer.SSNFiled;
                vol.ApprovalStatus = volunteer.ApprovalStatus;
            }
            return vol;
        }

        public IEnumerable<Volunteer> Search(string searchTerm)
        {
            if (!String.IsNullOrEmpty(searchTerm) || searchTerm != null)
            {
                return Volunteers.Where(e => e.FirstName.Contains(searchTerm) || e.LastName.Contains(searchTerm) || e.Email.Contains(searchTerm));
            }
            else
            {
                return Volunteers;
            }
        }
    }
}
