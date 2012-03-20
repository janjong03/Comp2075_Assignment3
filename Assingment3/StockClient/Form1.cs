using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Xml.Linq;
using StockClient.SvcStock;

namespace StockClient
{
    public partial class Form1 : Form
    {
        StockServiceClient ServiceClient;
        public Form1()
        {
            InitializeComponent();
            ServiceClient = new StockServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceClient.PopulateData();

           
            comboBox1.Items.AddRange(ServiceClient.StockType());
            CompanyInfo[] lstcompany = null;
            
          lstcompany = ServiceClient.CompanyDetails();
   //         dataGridView1.DataSource = lstcompany;

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Company Name";
            dataGridView1.Columns[1].Name = "Location";
            dataGridView1.Columns[2].Name = "Stock Price";

            foreach (CompanyInfo a in lstcompany)
            {
                dataGridView1.Rows.Add(a.CompanyName, a.Location, a.StockPrice);
             


            }
               
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

          
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            CompanyInfo[] lstcompany = null;
            string x = comboBox1.SelectedItem.ToString();
            lstcompany = ServiceClient.CompanyStockType(x);
            foreach (CompanyInfo a in lstcompany)
            {
                dataGridView1.Rows.Add(a.CompanyName, a.Location, a.StockPrice);



            }
        
        }

       
    }
}
