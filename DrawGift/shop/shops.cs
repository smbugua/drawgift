using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGift.shop
{
    public partial class shops : Form
    {
        public shops()
        {
            InitializeComponent();
        }

        private void shopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shopBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drawgiftDataSet);

        }

        private void shops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.shop' table. You can move, or remove it, as needed.
            this.shopTableAdapter.Fill(this.drawgiftDataSet.shop);

        }
    }
}
