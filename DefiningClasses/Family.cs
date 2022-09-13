using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get; set; }
        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(x =>x.Age).FirstOrDefault();
        }
        public void GetMoreThenThirti()
        {
            foreach (var member in FamilyMembers.OrderBy(x => x.Name))
            {
                if (member.Age > 30)
                {
                    Console.WriteLine($"{member.Name} - {member.Age}");
                }
            }
        }
        public void CalculateDates(DateTime startDate, DateTime endDate)
        {
            TimeSpan days = endDate - startDate;
            Console.WriteLine(Math.Abs(days.Days));
        }

    }
}
