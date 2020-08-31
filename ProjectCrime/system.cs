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
    public partial class system : Form
    {
        public system()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void system_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument docc = new XmlDocument();


            if (File.Exists("crimetype.xml"))
            {
                doc.Load("crimetype.xml");
                XmlNodeList list = doc.GetElementsByTagName("crimetype");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    string Typee = childerns[0].InnerText;

                    cmbsystem.Items.Add(Typee);

                }
            }

            if (File.Exists("crimes.xml"))
            {
                docc.Load("crimes.xml");
                XmlNodeList listt = docc.GetElementsByTagName("Crime");


                for (int i = 0; i < listt.Count; i++)
                {
                    XmlNodeList children = listt[i].ChildNodes;
                    string crimeareaaa = children[6].InnerText;
                    cmbsystem2.Items.Add(crimeareaaa);

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNodeList list = doc.GetElementsByTagName("Crime");
            string value2 = cmbsystem.SelectedItem.ToString();
            List<string> search = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;
                string typeid = childerns[1].InnerText;

                if (typeid == value2)
                {
                    XmlNodeList childernss = childerns[3].ChildNodes;

                    for (int j = 0; j < childernss.Count; j++)
                    {
                        string iid = childernss[j].InnerText;
                        search.Add(iid);

                    }



                }

            }//end for loop

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
                        string age = invoo[3].Name;
                        string agee = invoo[3].InnerText;



                        if (dataGridView1.ColumnCount == 0)
                        {
                            dataGridView1.Columns.Add(" involvedid ", invid);
                            dataGridView1.Columns.Add("location", location);
                            dataGridView1.Columns.Add("age", age);

                        }

                        dataGridView1.Rows.Add(new string[] { idvalue, locationvlaue, agee });


                    }


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");

            XmlNodeList list = doc.GetElementsByTagName("Crime");
            XmlNodeList list2 = doc.GetElementsByTagName("involvedpeople");
            string value2 = cmbsystem2.SelectedItem.ToString();
            List<string> search = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList childerns = list[i].ChildNodes;
                string crimeareea = childerns[6].InnerText;

                if (crimeareea == value2)
                {
                    XmlNodeList childernss = childerns[3].ChildNodes;

                    for (int j = 0; j < childernss.Count; j++)
                    {
                        string iid = childernss[j].InnerText;
                        search.Add(iid);

                    }



                }

            }//end for loop

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
                        string age = invoo[3].Name;
                        string agee = invoo[3].InnerText;



                        if (dataGridView2.ColumnCount == 0)
                        {
                            dataGridView2.Columns.Add(" involvedid ", invid);
                            dataGridView2.Columns.Add("location", location);
                            dataGridView2.Columns.Add("age", age);

                        }

                        dataGridView2.Rows.Add(new string[] { idvalue, locationvlaue, agee });


                    }
                }


            }
        }
    }
}