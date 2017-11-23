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

namespace DrawGift
{
    public partial class signin : Form
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        InputValidator validator = new InputValidator();
        connector database = new connector();

        public signin()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            Password = validator.CalculateMD5Hash(pass.Text);


            //if (database.logIn(UserName, Password))
            //{
            //    database.UserName = UserName;
            //    dashboard ds = new dashboard();
            //    this.Hide();
            //    ds.ShowDialog();
            //    this.Close();

            //}
            //uname.Text = "";
            //pass.Text = "";

            string a = uname.Text.ToString();

            string MyConnection2 = "datasource=localhost;port=3306;username=root";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.

            MyConn2.Open();
            //get name
            string Query1 = "select password from drawgift.users where status='active' && account_type='0'|| account_type='2' && username='" + a + "';";
            MySqlCommand com3 = new MySqlCommand(Query1, MyConn2);
            MySqlDataReader r1;
            r1 = com3.ExecuteReader();
            while (r1.Read())
            {
                string passwrd = r1["password"].ToString();


                if (Password.ToLower() == passwrd)
                {
                    database.UserName = UserName;
                    dashboard ds = new dashboard();
                    this.Hide();
                    ds.ShowDialog();
                    this.Close();

                }
            }
            MessageBox.Show("Access Denied Please Contact Administrator");
            MessageBox.Show(Password);
            r1.Close();
            uname.Text = "";
            pass.Text = "";






        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(pass.Text))
            {
                Password = validator.CalculateMD5Hash(pass.Text);

            }
            return;
        }



        private void uname_TextChanged(object sender, EventArgs e)
        {
            if (validator.alphaNumericCheck(uname.Text))
            { UserName = uname.Text; }
            return;
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }



    }
}
