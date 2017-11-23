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

namespace DrawGift.admin
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void drawsettingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drawsettingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drawgiftDataSet);

        }

        private void settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.drawsettings' table. You can move, or remove it, as needed.
            this.drawsettingsTableAdapter.Fill(this.drawgiftDataSet.drawsettings);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "insert into drawgift.drawsettings(amount,points) values('" + this.amnt.Text + "','" + this.points.Text + "');";
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
               
                this.Hide();
                //this.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
