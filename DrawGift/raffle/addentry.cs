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
using DrawGift.Base;

namespace DrawGift.raffle
{
    public partial class addentry : Form
    {
        public addentry()
        {
            InitializeComponent();
        }

        private void addentry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.campaign' table. You can move, or remove it, as needed.
            this.campaignTableAdapter.Fill(this.drawgiftDataSet.campaign);
            InputValidator validator = new InputValidator();
            // TODO: This line of code loads data into the 'drawgiftDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.drawgiftDataSet.customer);
            // TODO: This line of code loads data into the 'drawgiftDataSet.shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter.Fill(this.drawgiftDataSet.shop);
            // TODO: This line of code loads data into the 'drawgiftDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.drawgiftDataSet.users);
            amnt.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms


                string Query = "insert into drawgift.entries(raffleno,shop,amount,points,token,recordedby,dateadded) values('" + this.raffle.Text + "','" + this.shop.Text + "','" + this.amnt.Text + "','" + this.points.Text + "','" + this.token.Text + "','" + this.rec.Text + "','" + this.datea.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn4);
                MySqlDataReader MyReader2;
                MyConn4.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                //MessageBox.Show("Data Saved");
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();

                MyConn4.Close();
                addentry eadd = new addentry();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cust_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(amnt.Text!=null){
         
            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MyConn3.Open();
            //get  account no
            string q2 = "select raffleno as r from drawgift.customer WHERE name='" + this.cust.Text + "' ;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn3);
            MySqlDataReader r3;
            r3 = com4.ExecuteReader();
            while (r3.Read())
            {
                String raf = r3["r"].ToString();
                raffle.Text = raf.ToString();
            }
            r3.Close();

            MyConn3.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms


                string Query = "insert into drawgift.entries(raffleno,shop,amount,points,token,recordedby,dateadded) values('" + this.raffle.Text + "','" + this.shop.Text + "','" + this.amnt.Text + "','" + this.points.Text + "','" + this.token.Text + "','" + this.rec.Text + "','" + this.datea.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn4 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn4);
                MySqlDataReader MyReader2;
                MyConn4.Open();
                MyReader2 = MyCommand2.ExecuteReader();     
                // Here our query will be executed and data saved into the database.
              //  MessageBox.Show("Data Saved");
                while (MyReader2.Read())
                {
                }
                MyReader2.Close();

                MyConn4.Close();
                drawentries eadd = new drawentries();
                this.Hide();

                eadd.ShowDialog();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void amnt_TextChanged(object sender, EventArgs e)
        {
            string MyConnection3 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
            //This is command class which will handle the query and connection object.
            MyConn3.Open();
            //get  account no
            string q2 = "select amount,points from drawgift.drawsettings ;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn3);
            MySqlDataReader r3;
            r3 = com4.ExecuteReader();
            while (r3.Read())
            {
                int a = Convert.ToInt32(r3["amount"]);
                int b = Convert.ToInt32(r3["points"]);
                int c = Convert.ToInt32(amnt.Text);
                Double r =(c / a) * b;
                Double raf = Math.Round(r,2);
                points.Text = raf.ToString();

                if (points.Text == null) {
                    points.Text = "0";
                }


            }
            r3.Close();
            MyConn3.Close();
        }
    }
}
