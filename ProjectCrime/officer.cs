using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectCrime
{
    class officer
    {

        public string officerName;
        public string officerID;
        public string numOfAssignedCrimes;
        public void getData(string id, string name, string num)
        {
            officerID = id;
            officerName = name;
            numOfAssignedCrimes = num;
        }
    }
}
