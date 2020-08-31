using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCrime
{
    class involvedPeople
    {
        public string InvolvedPeopleID;
        public string location;
        public string Image;
        public string age;
        public List<involvedPeople> Indata = new List<involvedPeople>();
        public void ADDTo(involvedPeople obj)
        {
            Indata.Add(obj);
        }
     
    }
}
