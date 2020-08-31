using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ProjectCrime
{
    public partial class AdminWork : Form
    {
        public AdminWork()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string typeID = txtTypeID.Text;
            string typeName = txtTypeName.Text;

            if (!File.Exists("crimetype.xml"))
            {
                XmlWriter writer = XmlWriter.Create("crimetype.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                writer.WriteAttributeString("name", "crimetypes");

                writer.WriteStartElement("crimetype");
                writer.WriteStartElement("typeID");
                writer.WriteString(typeID);
                //cmbTypeID.Items.Add(typeID.ToString());

                writer.WriteEndElement();

                writer.WriteStartElement("typename");
                writer.WriteString(typeName);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
                MessageBox.Show("Added");
            }

            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("crimetype.xml");

                XmlElement crimetype = doc.CreateElement("crimetype");
                XmlElement node = doc.CreateElement("typeID");
                node.InnerText = typeID;
                crimetype.AppendChild(node);

                node = doc.CreateElement("typename");
                node.InnerText = typeName;
                crimetype.AppendChild(node);

                string value = txtTypeID.Text;
                XmlNodeList list = doc.GetElementsByTagName("crimetype");
                int counter = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string valuee = children[0].InnerText;

                    if (value == valuee)
                    {
                        counter++;
                    }

                }
                if (counter == 0)
                {
                    // hna hay5od l id wl name w y3mlhom append f file l crime type ka children leh ...
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(crimetype);
                    doc.Save("crimetype.xml");
                    MessageBox.Show(" Successfully Set");

                }

                else if (counter != 0)
                {
                    MessageBox.Show("This Type ID already Exist");
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAddcrime_Click(object sender, EventArgs e)
        {
            int OpenCount = 1;
            int numofAssignCrime = 0;
            string crimeId = txtCrimeID.Text;
            string description = txtDescription.Text;
            string crimearea = txtCrimearea.Text;

            string typeid = cmbTypeID.SelectedItem.ToString();
            string officerid = cmbOfficerID.SelectedItem.ToString();

            List<String> InvolvedPeople = new List<string>();
            List<String> photosofcrimes = new List<string>();
            List<String> itemsfound = new List<string>();

            foreach (string item in checkedListBox1.CheckedItems)
            {
                InvolvedPeople.Add(item);
            }


            itemsfound.Add(txtItemFound.Text);
            photosofcrimes.Add(pictureBox1.ImageLocation);



            string crimestat = "";

            if (radioOpen.Checked)
                crimestat = radioOpen.Text;

            else if (radioClose.Checked)

                crimestat = radioClose.Text;


            ///write in file
            if (!File.Exists("crimes.xml"))
            {

                XmlWriter writer = XmlWriter.Create("crimes.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                writer.WriteAttributeString("name", "Crimes");

                writer.WriteStartElement("Crime");

                writer.WriteStartElement("CrimesID");
                writer.WriteString(crimeId);
                writer.WriteEndElement();

                writer.WriteStartElement("TypeID");
                writer.WriteString(typeid);
                writer.WriteEndElement();

                writer.WriteStartElement("OfficerID");
                writer.WriteString(officerid);
                writer.WriteEndElement();

                writer.WriteStartElement("ALLinvolvedpeople");

                for (int i = 0; i < InvolvedPeople.Count; i++)
                {
                    writer.WriteStartElement("involvedpeople");
                    writer.WriteString(InvolvedPeople[i]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();

                writer.WriteStartElement("Description");
                writer.WriteString(description);
                writer.WriteEndElement();

                writer.WriteStartElement("CrimeStatus");
                writer.WriteString(crimestat);
                writer.WriteEndElement();


                writer.WriteStartElement("CrimeArea");
                writer.WriteString(crimearea);
                writer.WriteEndElement();



                writer.WriteStartElement("ALLImage");

                for (int i = 0; i < photosofcrimes.Count; i++)
                {
                    writer.WriteStartElement("Imageofcrime");
                    writer.WriteString(photosofcrimes[i]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();



                writer.WriteStartElement("ALLItems");

                for (int i = 0; i < itemsfound.Count; i++)
                {
                    writer.WriteStartElement("ItemsFound");
                    writer.WriteString(itemsfound[i]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();



                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();

                MessageBox.Show("Added");
            }
            else
            {
                XmlElement nestednode;

                XmlDocument doc = new XmlDocument();
                XmlElement crimes = doc.CreateElement("Crime");
                XmlElement node = doc.CreateElement("CrimesID");
                node.InnerText = crimeId;
                crimes.AppendChild(node);

                node = doc.CreateElement("TypeID");
                node.InnerText = typeid;
                crimes.AppendChild(node);


                node = doc.CreateElement("OfficerID");
                node.InnerText = officerid;
                crimes.AppendChild(node);

                node = doc.CreateElement("ALLinvolvedpeople");
                for (int i = 0; i < InvolvedPeople.Count; i++)
                {
                    nestednode = doc.CreateElement("involvedpeople");
                    nestednode.InnerText = InvolvedPeople[i];
                    node.AppendChild(nestednode);
                }
                crimes.AppendChild(node);



                node = doc.CreateElement("Description");
                node.InnerText = description;
                crimes.AppendChild(node);

                node = doc.CreateElement("CrimeStatus");
                node.InnerText = crimestat;
                crimes.AppendChild(node);


                node = doc.CreateElement("CrimeArea");
                node.InnerText = crimearea;
                crimes.AppendChild(node);


                node = doc.CreateElement("ALLImage");
                for (int i = 0; i < photosofcrimes.Count; i++)
                {
                    nestednode = doc.CreateElement("Imageofcrime");
                    nestednode.InnerText = photosofcrimes[i];
                    node.AppendChild(nestednode);
                }
                crimes.AppendChild(node);


                node = doc.CreateElement("ALLItems");
                for (int i = 0; i < itemsfound.Count; i++)
                {
                    nestednode = doc.CreateElement("ItemsFound");
                    nestednode.InnerText = itemsfound[i];
                    node.AppendChild(nestednode);
                }
                crimes.AppendChild(node);



                doc.Load("crimes.xml");
                XmlNodeList list = doc.GetElementsByTagName("Crime");
                string myid = cmbOfficerID.SelectedItem.ToString();
                doc.Load("crimes.xml");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    string value = childerns[2].InnerText;
                    string valuee = childerns[5].InnerText;

                    if (value == myid)
                    {
                        if (valuee == "Open")
                        {
                            OpenCount++;

                        }
                    }
                }

                MessageBox.Show(OpenCount.ToString());
                if (OpenCount > 4)
                {
                    MessageBox.Show("Can't Added This Officer ID");

                }

                else if (OpenCount <= 4)
                {
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(crimes);
                    doc.Save("crimes.xml");
                    MessageBox.Show(" Successufly added");

                }

            }

            // TO Calculate number of assignd crime
            XmlDocument doc2 = new XmlDocument();
            doc2.Load("crimes.xml");

            XmlNodeList list2 = doc2.GetElementsByTagName("Crime");
            string myidd = cmbOfficerID.SelectedItem.ToString();

            for (int i = 0; i < list2.Count; i++)
            {
                XmlNodeList childerns = list2[i].ChildNodes;
                string value = childerns[2].InnerText;
                string valuee = childerns[5].InnerText;

                if (value == myidd)
                {
                    if (valuee == "Open" || valuee == "Close")
                    {
                        numofAssignCrime++;
                    }
                }
            }

            //3ashan aktb l number of assigned crime f file l officer

            XmlDocument doc3 = new XmlDocument();
            XmlNodeList list3 = doc3.GetElementsByTagName("officers");
            doc3.Load("officer.xml");

            for (int i = 0; i < list3.Count; i++)
            {
                XmlNodeList child = list3[i].ChildNodes;
                if (child[0].InnerText == myidd)
                {
                    child[2].InnerText = numofAssignCrime.ToString();

                }
            }

                doc3.Save("officer.xml");
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTypeID_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  DataSet ds = new DataSet();
            ds.ReadXml("crimetype.xml");
            cmbTypeID.SelectedItem = ("typeID");
            cmbTypeID.DataSource = ds;
            */

            //cmbTypeID.DataSource = txtTypeID;
            //cmbTypeID.Items.Add(txtTypeID);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddOfficer_Click(object sender, EventArgs e)
        {
         
            string officerID = txtOfficerID.Text;

            string officerName = txtOfficerName.Text;
            string numOfAssignedCrimes = txtNumCrime.Text;
            if (!File.Exists("officer.xml"))
            {

                XmlWriter writer = XmlWriter.Create("officer.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                writer.WriteAttributeString("name", "officer");

                writer.WriteStartElement("officers");

                writer.WriteStartElement("officerID");
                writer.WriteString(officerID);
                writer.WriteEndElement();

                writer.WriteStartElement("officerName");
                writer.WriteString(officerName);
                writer.WriteEndElement();

                writer.WriteStartElement("NumOfAssignedCrimes");
                writer.WriteString(numOfAssignedCrimes);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show(" Added ");

            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("officer.xml");

                XmlElement crimes = doc.CreateElement("officers");
                XmlElement node = doc.CreateElement("officersID");
                node.InnerText = officerID;
                crimes.AppendChild(node);
                node = doc.CreateElement("officerName");
                node.InnerText = officerName;
                crimes.AppendChild(node);
                node = doc.CreateElement("NumOfAssignedCrimes");
                node.InnerText = numOfAssignedCrimes;
                crimes.AppendChild(node);


                XmlNodeList list = doc.GetElementsByTagName("officers");
               string theID = txtOfficerID.Text;
               int counter = 0; 
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childerns = list[i].ChildNodes;
                    string idvalue = childerns[0].InnerText;
                    if (theID == idvalue)
                    {
                        counter++;
                    }

                   
                }
                if (counter == 0)
                {
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(crimes);
                    doc.Save("officer.xml");
                    MessageBox.Show(" Added ");
                }
                else if (counter != 0)
                {
                    MessageBox.Show("This ID already Exist !!");
                }
             
            }
            
        }

        private void cmbOfficerID_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cmbOfficerID.DataSource = txtOfficerID;
           // cmbOfficerID.Items.Add(txtOfficerID);
            

        
        }

        private void AdminWork_Load(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            XmlDocument doc3 = new XmlDocument();
            if (File.Exists("crimetype.xml"))
            {
                doc.Load("crimetype.xml");
                XmlNodeList list = doc.GetElementsByTagName("crimetype");

                for (int i = 0; i < list.Count; i++)
                {

                    XmlNodeList childern1 = list[i].ChildNodes;
                    string crimetypeval = childern1[0].InnerText;
                    cmbTypeID.Items.Add(crimetypeval);
                }
            }
            if (File.Exists("officer.xml"))
            {
                doc2.Load("officer.xml");
                XmlNodeList list2 = doc2.GetElementsByTagName("officers");

                for (int i = 0; i < list2.Count; i++)
                {
                    XmlNodeList childern2 = list2[i].ChildNodes;
                    string offval = childern2[0].InnerText;
                    cmbOfficerID.Items.Add(offval);
                    comboBox2.Items.Add(offval);
                }

            }

            if (File.Exists("involvedpeople.xml"))
            {
                doc3.Load("involvedpeople.xml");
                XmlNodeList list3 = doc3.GetElementsByTagName("Person");

                for (int i = 0; i < list3.Count; i++)
                {
                    XmlNodeList childernss = list3[i].ChildNodes;
                    string involvedID = childernss[0].InnerText;
                    checkedListBox1.Items.Add(involvedID);
                }
            }
            // LW L FILE Bta3 crime msh mwgod

           if (File.Exists("crimes.xml"))
           {
               XmlDocument doc4 = new XmlDocument();
               doc4.Load("crimes.xml");
               XmlNodeList list4 = doc4.GetElementsByTagName("Crime");

               for (int i = 0; i < list4.Count; i++)
               {
                   XmlNodeList child = list4[i].ChildNodes;
                   string crimeid = child[0].InnerText;
                   comboBox1.Items.Add(crimeid);
               }
           }
        }
        private void radioOpen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            involvedPeople people = new involvedPeople();
            people.InvolvedPeopleID = involvedpeople_id.Text;
            people.location = location.Text;
            people.Image = pictureBox3.ImageLocation;
            people.age = age.Text;

            if (!File.Exists("involvedpeople.xml"))
            {
                XmlWriter writer = XmlWriter.Create("involvedpeople.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("Table");
                writer.WriteAttributeString("name", "InvolvedPeople");

                writer.WriteStartElement("Person");

                writer.WriteStartElement("InvolvedPeopleID");
                writer.WriteString(people.InvolvedPeopleID);
                writer.WriteEndElement();

                writer.WriteStartElement("Location");
                writer.WriteString(people.location);
                writer.WriteEndElement();

                writer.WriteStartElement("Image");
                writer.WriteString(people.Image);
                writer.WriteEndElement();

                writer.WriteStartElement("Age");
                writer.WriteString(people.age);
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show(" Added ");

            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("involvedpeople.xml");

                XmlElement person = doc.CreateElement("Person");
                XmlElement node = doc.CreateElement("InvolvedPeopleID");
                node.InnerText = people.InvolvedPeopleID;
                person.AppendChild(node);
                node = doc.CreateElement("Location");
                node.InnerText = people.location;
                person.AppendChild(node);
                node = doc.CreateElement("Image");
                node.InnerText = people.Image;
                person.AppendChild(node);
                node = doc.CreateElement("Age");
                node.InnerText = people.age;
                person.AppendChild(node);
                string value = involvedpeople_id.Text;
                XmlNodeList list = doc.GetElementsByTagName("Person");

                int counter = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string valuee = children[0].InnerText;

                    if (value == valuee)
                    {
                        counter++;

                    }
                
                }
                if (counter == 0)
                {
                    XmlElement root = doc.DocumentElement;
                    root.AppendChild(person);
                    doc.Save("involvedpeople.xml");
                    MessageBox.Show("Successfully Added !!!!");

                }
                else if (counter != 0)
                {
                    MessageBox.Show("This Involved ID already Exist");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string crimeIDm = comboBox1.SelectedItem.ToString();
            string OffcierID = comboBox2.SelectedItem.ToString();


            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeIDm);
            XmlNodeList lst = crime.ChildNodes;
            if (lst[2].InnerText == OffcierID)
            {
                lst[4].InnerText = New_description.Text;
                doc.Save("crimes.xml");
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("wrong officer id");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
                string crimeID = comboBox1.SelectedItem.ToString();
                XmlDocument doc = new XmlDocument();
                doc.Load("crimes.xml");

                XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeID);
                crime["CrimeStatus"].InnerText = comboBox3.SelectedItem.ToString();
                doc.Save("crimes.xml");
                MessageBox.Show("Updated !!");
            
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string crimeIDi = comboBox1.SelectedItem.ToString();
            string OffcierID = comboBox2.SelectedItem.ToString();

            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeIDi);
            XmlNodeList lst = crime.ChildNodes;
            if (lst[2].InnerText == OffcierID)
            {
                lst[4].InnerText = lst[5].InnerText + "\n new update:" + Edit_Description.Text;
                doc.Save("crimes.xml");
                MessageBox.Show("edited");
            }
            else
            {
                MessageBox.Show("wrong officer id");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("crimes.xml");
                XmlNodeList imglt = doc.GetElementsByTagName("crimes.xml");
                XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText ==comboBox1.SelectedItem.ToString());
                XmlNodeList itm = crime.ChildNodes;
                XmlElement x = doc.CreateElement("ItemsFound");
                x.InnerText = Items_Found.Text;
                itm[8].AppendChild(x);
                doc.Save("crimes.xml");
                MessageBox.Show("Added !!!!");
            }
        
        }

        private void Items_Found_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNodeList imglt = doc.GetElementsByTagName("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == comboBox1.SelectedItem.ToString());
            XmlNodeList itm = crime.ChildNodes;
            XmlElement x = doc.CreateElement("Imageofcrime");
            x.InnerText = pictureBox2.ImageLocation;
            itm[7].AppendChild(x);
            doc.Save("crimes.xml");
            MessageBox.Show("Added !!!!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNodeList imglt = doc.GetElementsByTagName("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == comboBox1.SelectedItem.ToString());
            XmlNodeList itm = crime.ChildNodes;
            XmlElement x = doc.CreateElement("involvedpeople");
            x.InnerText = Involved_people.Text;
            itm[3].AppendChild(x);
            doc.Save("crimes.xml");
            MessageBox.Show("Added !!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string crimeID = comboBox1.SelectedItem.ToString();
            string OffcierID = comboBox2.SelectedItem.ToString(); ;
            XmlDocument doc = new XmlDocument();
            doc.Load("crimes.xml");
            XmlNode crime = doc.SelectNodes("/Table/Crime").OfType<XmlNode>().FirstOrDefault(n => n["CrimesID"].InnerText == crimeID);
            XmlNodeList lst = crime.ChildNodes;
            if (lst[2].InnerText == OffcierID)
            {
                lst[4].InnerText = null;
                doc.Save("crimes.xml");
                MessageBox.Show("deleted");
            }
            else
            {
                MessageBox.Show("wrong officer id");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void Images_of_Crimes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                pictureBox2.ImageLocation = ofd.FileName;
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);
                pictureBox3.ImageLocation = ofd.FileName;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
