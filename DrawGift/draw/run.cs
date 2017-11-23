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
    public partial class run : Form
    {
        public run()
        {
            InitializeComponent();
        }

        private void run_Load(object sender, EventArgs e)
        {
           
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MyConn2.Open();

                //get  account no
                string q2 = "SELECT * FROM drawgift.entries ORDER BY RAND() LIMIT 1 ;";
                MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
                MySqlDataReader r2;
                r2 = com4.ExecuteReader();
                while (r2.Read())
                {
                    int a = Convert.ToInt32(r2["raflleno"]) + 1;
                    String raf = a.ToString();
                    draws d = new draws();
                    
                    label1.Text = "";
                    
                }
                    
           


                r2.Close();
        }
    }
}
