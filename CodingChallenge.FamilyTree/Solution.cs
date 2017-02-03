using System;
using System.Linq;
using System.Collections.Generic;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        public string GetBirthMonth(Person person, string descendantName)
        {
             
            Person chosenOne = null;
            String birthDate = "";
            var family = new List<Person> { person };
            foreach (var d in person.Descendants)
            {
                family.Add(d);
                foreach (var d2 in d.Descendants)
                {
                    family.Add(d2);
                }
            }
            foreach (var f in family)
            {
                if (f.Name == descendantName)
                {
                    chosenOne = f;
                    birthDate = f.Birthday.ToString("MMMM");
                }
            }
            return birthDate;
            }
        }
    }
