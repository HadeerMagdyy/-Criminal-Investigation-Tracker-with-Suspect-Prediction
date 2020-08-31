using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace ProjectCrime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {

            AdminWork admin = new AdminWork();
                XmlDocument doc = new XmlDocument();
                doc.Load("ProjectCrime.xml");
                XmlNodeList list = doc.GetElementsByTagName("admin");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string idvalue = children[0].InnerText;
                    string namevalue = children[1].InnerText;
                    if (idvalue == txtadminid.Text && namevalue == txtadminname.Text)
                    {
                       
                        admin.Show();
                    }

                    else
                    {
                        MessageBox.Show("Error ID OR NAME !");
                    }
                }

            }

           
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            
            string val= txtloginoffID.Text;
               XmlDocument doc = new XmlDocument();
            doc.Load("officer.xml");
            XmlNodeList list = doc.GetElementsByTagName("officers");
            int ctr = 0;
            for (int j = 0; j < list.Count; j++)
            {
                XmlNodeList children = list[j].ChildNodes;
                string idvalue = children[0].InnerText;

                string namevalue = children[1].InnerText;
                if (idvalue == txtloginoffID.Text && namevalue == txtloginoffName.Text)
                {
                    (new officerwork(val)).Show();
                    ctr++;

                }
                
            }

            if (ctr == 0)
            {
                    MessageBox.Show("Error ID or Name ");
                
            }
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

         //   offwork = new officerwork();
           // offwork.Show();

        }

        private void txtloginoffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            (new system()).Show();
        }    
      
    }
}
