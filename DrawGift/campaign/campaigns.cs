using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGift.campaign
{
    public partial class campaigns : Form
    {
        public campaigns()
        {
            InitializeComponent();
        }

        private void campaignBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.campaignBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drawgiftDataSet);

        }

        private void campaigns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.campaign' table. You can move, or remove it, as needed.
            this.campaignTableAdapter.Fill(this.drawgiftDataSet.campaign);

        }
    }
}
