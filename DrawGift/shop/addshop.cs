using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DrawGift.shop
{
    public partial class addshop : Form
    {
        public addshop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into drawgift.shop(name,shopno,shopcode) values('" + this.shop.Text + "','" + this.shopno.Text +  "','" + this.code.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                MessageBox.Show("Data Saved");
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();

                MyConn2.Close();
                shops eadd = new shops();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addshop_Load(object sender, EventArgs e)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MyConn2.Open();

            //get  account no
            string q2 = "select COUNT(id) as idc from drawgift.shop ;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
            MySqlDataReader r2;
            r2 = com4.ExecuteReader();
            while (r2.Read())
            {
                int a = Convert.ToInt32(r2["idc"]) + 1;
                String raf = "SHOP-" + a;
                code.Text = raf.ToString();
            }
            r2.Close();
        }
        }
    }

