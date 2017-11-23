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

namespace DrawGift.draw
{
    public partial class draws : Form
    {
        public draws()
        {
            InitializeComponent();
        }

        private void draw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.campaign' table. You can move, or remove it, as needed.
            this.campaignTableAdapter.Fill(this.drawgiftDataSet.campaign);
           // label4.Visible = false;
           // label5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MyConn2.Open();

                //get  account no

                String a1 = comboBox1.Text;
                string q2 = "SELECT * FROM drawgift.entries where token ='"+a1+"' ORDER BY RAND() LIMIT 1 ;";
                MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
                MySqlDataReader r2;
                r2 = com4.ExecuteReader();
                r2.Read();
                String b=r2["raffleno"].ToString();


                string MyConnection3 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                //This is command class which will handle the query and connection object.
                MyConn3.Open();
                string q3 = "SELECT * FROM drawgift.customer WHERE raffleno='" +b +"';";
                MySqlCommand com5 = new MySqlCommand(q3, MyConn3);
                MySqlDataReader r3;
                r3 = com5.ExecuteReader();

                while (r3.Read())
                {
                   

                   String a = r3["idno"].ToString();
                    String c= r3["name"].ToString();
            String val1 = comboBox1.Text;
            String val2 = comboBox2.Text;
            label5.Text="THE WINNER FOR THE "+val1+" Campaign "+val2+" DRAW IS "+c+" ID No "+a;
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
                }
            r3.Close();
            MyConn3.Close();
            r2.Close();
            MyConn2.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
