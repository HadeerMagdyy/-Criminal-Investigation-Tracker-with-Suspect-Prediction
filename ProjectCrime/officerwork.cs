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
    public partial class officerwork : Form
    {
      string offID;
        public officerwork(string val)
        {
            InitializeComponent();
         offID = val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradeviewAsscrime.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
             XmlNodeList list = doc.GetElementsByTagName("Crime");
            string myid = txtViewoffID.Text;

            for (int i = 0; i < list.Count; i++)
            {         
                XmlNodeList childerns = list[i].ChildNodes;
                string offidval = childerns[2].InnerText;

                if (myid == offID) {
                    if (myid == offidval)
                    {
                        string crimeid = childerns[0].Name;
                        string idvalue = childerns[0].InnerText;

                        string typeid = childerns[1].Name;
                        string typevlaue = childerns[1].InnerText;

                        string value = childerns[5].Name;
                        string valuee = childerns[5].InnerText;


                        if (gradeviewAsscrime.ColumnCount == 0)
                        {
                            gradeviewAsscrime.Columns.Add(" Assigend Crime ID", crimeid);
                            gradeviewAsscrime.Columns.Add("Type ID", typeid);
                          
                            gradeviewAsscrime.Columns.Add("crimestat", value);

                        }

                        gradeviewAsscrime.Rows.Add(new string[] { idvalue, typevlaue, valuee });


                    }
                }

                else
                {
                    MessageBox.Show(" This Dont Your ID");
                    break;
                }


            }

        }

        private void officerwork_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            XmlDocument doccc = new XmlDocument();
            XmlNodeList listtt = doccc.GetElementsByTagName("Person");

            doccc.Load("involvedpeople.xml");
         
            for (int i = 0; i < listtt.Count; i++)
            {
                XmlNodeList childernss = listtt[i].ChildNodes;
                string involvedID = childernss[0].InnerText;
                checkedListBox1.Items.Add(involvedID);
            }

            doc.Load("crimes.xml");

            XmlNodeList list = doc.GetElementsByTagName("Crime");
            for (int i = 0; i < list.Count; i++)
            {
               
                XmlNodeList childerns = list[i].ChildNodes;
                string offid = childerns[2].InnerText;
         if (offid == offID)
                {
                    string crimeid = childerns[0].InnerText;
                    comboBox1.Items.Add(crimeid);
                    cmbLoadcrimeid.Items.Add(crimeid);
                }
            }
            }

        private void loadID_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Show s = new Show();
            s.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = cmbLoadcrimeid.SelectedItem.ToString();
                XmlDocument doc = new XmlDocument();
                XmlNodeList list = doc.GetElementsByTagName("Crime");
                doc.Load("crimes.xml");
               
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList child = list[i].ChildNodes;
                        if (child[0].InnerText == id)
                        {
                            child[5].InnerText = "Close";
                      
                        }
                    }

                    doc.Save("crimes.xml");
                    MessageBox.Show(" Done ");

                }
            

            catch
            {
                MessageBox.Show(" You not Assigned In this Crime ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            dataGridView1.Show();
         
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
                    }

        private void button9_Click(object sender, EventArgs e)
        {
            string crimeIDm = comboBox1.SelectedItem.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeIDm);
            XmlNodeList lst = crime.ChildNodes;
          
                lst[4].InnerText = New_description.Text;
                doc.Save("crimes.xml");
                MessageBox.Show("Updated");
            }

        private void button4_Click(object sender, EventArgs e)
        {
                string crimeIDm = comboBox1.SelectedItem.ToString();

                XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeIDm);
            XmlNodeList lst = crime.ChildNodes;
                lst[4].InnerText = lst[4].InnerText + "\n new update:" + Edit_Description.Text;
                doc.Save("crimes.xml");
                MessageBox.Show("edited");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string crimeID = comboBox1.SelectedItem.ToString();
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeID);
            XmlNodeList lst = crime.ChildNodes;

            lst[4].InnerText = null;
            doc.Save("crimes.xml");
            MessageBox.Show("deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
        }
        
            
        }
    }

