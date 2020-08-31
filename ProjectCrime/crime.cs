using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace ProjectCrime
{
    public class crime
    {
        public string crimeId;
        public string typeid;
        public string description;
        public string crimestatus;
        public string crimearea;
        public string officerid;
        public List<string> itemsfound;
        public List<string> photosofcrimes;
        public List <String> involveddperson;
        public List<crime> alldata=new List<crime>();



        public crime(string crimeId, string typeid, string description, string crimestatus, string officerid, List<String> itemsfound, List<String> photosofcrimes, List<String> involveddperson)
        {
            this.crimeId = crimeId;
            this.typeid = typeid;
            this.description = description;
            this.crimestatus = crimestatus;
            this.officerid = officerid;
            this.itemsfound = itemsfound;
            this.photosofcrimes = photosofcrimes;
            this.involveddperson = involveddperson  ;

        }
             public crime()
        {
            crimeId = "";
            typeid = "";
            description = "";
            crimestatus = "";
            crimearea = "";
            itemsfound = new List<string>();
            photosofcrimes = new List<string>();
        involveddperson=new List<string>();
             }

 

        public void addtolist(crime obj)
        {
            alldata.Add(obj);
        }

       
    }

}

