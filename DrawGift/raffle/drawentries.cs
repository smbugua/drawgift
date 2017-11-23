using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGift.raffle
{
    public partial class drawentries : Form
    {
        public drawentries()
        {
            InitializeComponent();
        }

        private void entriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.entriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drawgiftDataSet);

        }

        private void drawentries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drawgiftDataSet.entries' table. You can move, or remove it, as needed.
            this.entriesTableAdapter.Fill(this.drawgiftDataSet.entries);

        }
    }
}
