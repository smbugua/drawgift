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

namespace DrawGift.customers
{
    public partial class customerdetails : Form
    {
        public customerdetails()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drawgiftDataSet);

        }

        private void customerdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.drawgiftDataSet.customer);

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
       private void customerDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (customerDataGridView.Rows[e.RowIndex].IsNewRow == true)
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root";
                //This is my insert query in which i am taking input from the user through windows forms
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MyConn2.Open();

                //get  account no
                string q2 = "select COUNT(id) as idc from drawgift.customer ;";
                MySqlCommand com4 = new MySqlCommand(q2, MyConn2);
                MySqlDataReader r2;
                r2 = com4.ExecuteReader();
                while (r2.Read())
                {
                    int a = Convert.ToInt32(r2["idc"]) + 1;
                    String raf = "GALLERIA-" + a;
                    int rowIndex = e.RowIndex;
                   // customerDataGridView.Rows[rowIndex].Cells[1].Value = raf.ToString();
                    customerDataGridView.Columns["raffleno"].DefaultCellStyle.NullValue = raf.ToString();
                    
                }



                r2.Close();
            }
        }
    }
}
