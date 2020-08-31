using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCrime
{
    class crimetype
    {
        public string crime_ID;
        public string crime_Name;

        public crimetype(string crime_ID, string crime_Name)
        {
            this.crime_ID = crime_ID;
            this.crime_Name = crime_Name;
        }
    }
}
