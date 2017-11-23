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
using Microsoft.CSharp;
using Twilio;

namespace DrawGift.raffle
{
    public partial class entry : Form
    {
        public entry()
        {
            InitializeComponent();
        }

        private void entry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.drawgiftDataSet.customer);
            // TODO: This line of code loads data into the 'drawgiftDataSet.shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter.Fill(this.drawgiftDataSet.shop);

            name.Enabled = false;
            pass.Enabled = false;
            area.Enabled = false;
            tel2.Visible = false;
            tel.Text = "0";

        }

        //PERFORM CALCULATION OF VOCUHERS EARNED

        private void Calculate(object sender, DataGridViewCellEventArgs e)
        {
            object a = dataGridView1.CurrentRow.Cells["Total"].Value;
            int aNumber = 0;
            int setlimit = 1000;
            if (a != null)
                aNumber = Convert.ToInt32(a.ToString());
            int vouch = (aNumber / setlimit);
            dataGridView1.CurrentRow.Cells["vouchers"].Value = vouch;


        }
       



        //PERFORM ACTION SEARCH
        private void search_Click(object sender, EventArgs e)
        {
            String id = idno.Text;
            String phone = tel.Text;
            

                Double t = Convert.ToDouble(this.tel.Text);
                Double t2 = Convert.ToDouble(254000000000 + t);
                String newtel = "+" + t2.ToString();

                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MyConn2.Open();

                //get  account no
                string q2 = "select *  from drawgift.customer where tel='" + phone + "'|| tel ='" + newtel + "'|| idno ='" + id + "' ;";
                MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
                MySqlDataReader r2;
                r2 = com4.ExecuteReader();
                r2.Read();
                if (r2.HasRows)
                {
                    String b = r2["name"].ToString();
                    String c = r2["passport"].ToString();
                    String d = r2["address"].ToString();
                    String f = r2["tel"].ToString();
                    String g = r2["idno"].ToString();
                    tel.Text = f;
                    idno.Text = g;
                    name.Text = b;
                    pass.Text = c;
                    area.Text = d;

                    tel.Enabled = false;
                    idno.Enabled = false;
                    name.Enabled = false;
                    pass.Enabled = true;
                    area.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Capture Customer Information");
                    tel.Enabled = true;
                    idno.Enabled = true;
                    name.Enabled = true;
                    name.Text = "";
                    pass.Enabled = true;
                    pass.Text = "";
                    area.Enabled = true;
                    area.Text = "";
                    checkBox1.Checked = true;
                }

                r2.Close();

           
        }
        //PERFORM ACTION RESET
        private void button1_Click(object sender, EventArgs e)
        {

            tel.Enabled = true;
            tel.Text = "0";
            idno.Enabled = true;
            idno.Text = "";
            name.Enabled = false;
            name.Text = "";
            pass.Enabled = false;
            pass.Text = "";
            area.Enabled = false;
            area.Text = "";
            checkBox1.Checked = false;
            dataGridView1.Rows.Clear();


        }

        private void save_Click(object sender, EventArgs e)
        {
            Double t = Convert.ToDouble(this.tel.Text);
            Double t2 = Convert.ToDouble(254000000000 + t);
            String newtel = "+" + t2.ToString();
           
            if (checkBox1.Checked == true)
            {
                //ADD NEW CUSTOMER
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into drawgift.customer(name,passport,address,idno,tel) values('" + this.name.Text + "','" + this.pass.Text + "','" + this.area.Text + "','" + this.idno.Text + "','" + newtel + "');";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                
                while (MyReader2.Read())
                {
                  }
                MyReader2.Close();

                MyConn2.Close();
            }

            if ( pass.Text!="N/A")  
            {
                //UPDATE CUSTOMER DETAILS
                string MyConnection7 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "UPDATE drawgift.customer set passport='"+pass.Text+"'WHERE idno='"+idno.Text+"'|| tel='"+tel.Text+"' ";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn7 = new MySqlConnection(MyConnection7);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand7 = new MySqlCommand(Query, MyConn7);
                MySqlDataReader MyReader7;
                MyConn7.Open();
                MyReader7 = MyCommand7.ExecuteReader();     // Here our query will be executed and data saved into the database.

                while (MyReader7.Read())
                {
                }
                MyReader7.Close();

                MyConn7.Close();
            }

             //GENERATE TOKEN
            string MyConnection4 = "datasource=localhost;port=3306;username=root";
            //This is my insert query in which i am taking input from the user through windows forms
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn4 = new MySqlConnection(MyConnection4);
            //This is command class which will handle the query and connection object.
            MyConn4.Open();

            //get  account no
            string q2 = "select COUNT(id) as idc from drawgift.entries ;";
            MySqlCommand com4 = new MySqlCommand(q2, MyConn4);
            MySqlDataReader r2;
            r2 = com4.ExecuteReader();
            r2.Read();
                int ab = Convert.ToInt32(r2["idc"]) + 1;
                String raf = ("GALLERIA-" + ab).ToString();
            r2.Close();



            
            //ITERATE TRHOUGH ARRAY
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                object a = dataGridView1.Rows[i].Cells["Total"].Value;
                int aNumber = 0;
                int setlimit = 1000;
                if (a != null)
                    aNumber = Convert.ToInt32(a.ToString());
                int vouch = (aNumber / setlimit);
                dataGridView1.Rows[i].Cells["vouchers"].Value = vouch;
           

                //ASSIGN VALUABLES
                object va = dataGridView1.Rows[i].Cells["vouchers"].Value;
                String v = va.ToString();
                object sh = dataGridView1.Rows[i].Cells["Shop"].Value;
               // String s = sh.ToString();
                //String tot = a.ToString();



                //SEARCH FOR SHOPNAME
                string shopconnection = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string shopquery = "SELECT cname FROM drawgift.shop WHERE name='" + sh+ "'";

                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection shopconn = new MySqlConnection(shopconnection);
                //This is command class which will handle the query and connection object.
                MySqlCommand shopcommand = new MySqlCommand(shopquery, shopconn);
                MySqlDataReader shopreader;
                shopconn.Open();
                shopreader = shopcommand.ExecuteReader();     // Here our query will be executed and data saved into the database.
                shopreader.Read();
                String shopname = shopreader["cname"].ToString();
                shopreader.Close();

                shopconn.Close();

                 //RUN INSERT SCRIPT
                    try
                    {
                        //ADD NEW RAFFLE ENTRY
                        string MyConnection3 = "datasource=localhost;port=3306;username=root";
                        //This is my insert query in which i am taking input from the user through windows forms
                        string Query = "insert into drawgift.entries(customername,passport,tel,address,raffleno,idno,shop,amount,points,dateadded)values('" + this.name.Text + "','" + this.pass.Text + "','" + newtel + "','" + this.area.Text + "','" + raf + "','" + this.idno.Text + "','" + shopname + "','" + a + "','" + vouch + "','" + this.datea.Text + "');";
                        //This is  MySqlConnection here i have created the object and pass my connection string.
                        MySqlConnection MyConn3 = new MySqlConnection(MyConnection3);
                        //This is command class which will handle the query and connection object.
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn3);
                        MySqlDataReader MyReader3;
                        MyConn3.Open();
                        MyReader3 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.

                        while (MyReader3.Read())
                        {
                            // Find your Account Sid and Auth Token at twilio.com/user/account
                          /*  string AccountSid = "AC76b83713f0c7385af9352e3dfb902288";
                            string AuthToken = "6e48fb10b5b82dd13f2eb663d6a3c210";
                            var twilio = new TwilioRestClient(AccountSid, AuthToken);

                            twilio.SendMessage("+17083283330","+254728944815","This is the ship that made the Kessel Run in fourteen parsecs?"
                            );*/


                            // Specify your login credentials
                            string username = "smbugua";
                            string apiKey = "93f87c6f181904289e830c9fabda74e70cfcaef5d804e9811d9f097dee44989e";

                            // Specify the numbers that you want to send to in a comma-separated list
                            // Please ensure you include the country code (+254 for Kenya in this case)
                            string recipients = this.tel.Text;
                            // And of course we want our recipients to know what we really do
                            string message = "I'm a lumberjack and its ok, I sleep all night and I work all day";

                            // Create a new instance of our awesome gateway class
                            AfricasTalkingGateway gateway = new AfricasTalkingGateway(username, apiKey);
                            // Any gateway errors will be captured by our custom Exception class below,
                            // so wrap the call in a try-catch block   
                            try
                            {
                                // Thats it, hit send and we'll take care of the rest
                                gateway.sendMessage(recipients, message);
                                dynamic results = gateway.sendMessage(recipients, message);

                                foreach (dynamic result in results)
                                {
                                    Console.Write((string)result["number"] + ",");
                                    Console.Write((string)result["status"] + ","); // status is either "Success" or "error message"
                                    Console.Write((string)result["messageId"] + ",");
                                    Console.WriteLine((string)result["cost"]);
                                }
                            }
                            catch (AfricasTalkingGatewayException e1)
                            {
                                Console.WriteLine("Encountered an error: " + e1.Message);
                            }
                        }
                        MyReader3.Close();

                        MyConn3.Close();
                        //RESET EVERYTHING
                       


                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }

            MessageBox.Show("ENTRIES SAVED");
            tel.Enabled = true;
            tel.Text = "0";
            idno.Enabled = true;
            idno.Text = "";
            name.Enabled = false;
            name.Text = "";
            pass.Enabled = false;
            pass.Text = "";
            area.Enabled = false;
            area.Text = "";

            checkBox1.Checked = false;
            dataGridView1.Rows.Clear();

                      
               
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

     
    
           
    
        }
    }



