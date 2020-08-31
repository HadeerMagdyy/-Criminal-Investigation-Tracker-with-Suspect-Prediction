using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace ProjectCrime
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        private void view_Click(object sender, EventArgs e)
        {


            display.Rows.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNodeList list = doc.GetElementsByTagName("Crime");
            string myid = typeIDtxt.Text;
            List<string> search = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;
                string crimeid = childerns[1].InnerText;

                if (myid == crimeid)
                {
                    XmlNodeList childernss = childerns[3].ChildNodes;
                    for (int j = 0; j < childernss.Count; j++)
                    {
                        string iid = childernss[j].InnerText;
                        search.Add(iid);

                    }

                }
            }

            XmlDocument d = new XmlDocument();
            d.Load("involvedpeople.xml");
            XmlNodeList inv = d.GetElementsByTagName("Person");
            for (int k = 0; k < inv.Count; k++)
            {
                XmlNodeList invoo = inv[k].ChildNodes;

                for (int l = 0; l < search.Count; l++)
                {
                    if (invoo[0].InnerText == search[l])
                    {
                        string invid = invoo[0].Name;
                        string idvalue = invoo[0].InnerText;

                        string location = invoo[1].Name;
                        string locationvlaue = invoo[1].InnerText;

                        string image = invoo[2].Name;
                        string imagee = invoo[2].InnerText;

                        string age = invoo[3].Name;
                        string agee = invoo[3].InnerText;

                        if (display.ColumnCount == 0)
                        {
                            display.Columns.Add(" involvedid ", invid);
                            display.Columns.Add("location", location);
                            display.Columns.Add(" image", image);
                            display.Columns.Add("age", age);

                        }

                        display.Rows.Add(new string[] { idvalue, locationvlaue, imagee, agee });

                    }



                }



            }


        }

    }
}

    

