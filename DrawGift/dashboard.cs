using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawGift.customers;
using DrawGift.shop;
using DrawGift.raffle;
using DrawGift.campaign;
using DrawGift.admin;
using DrawGift.draw;


namespace DrawGift
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void userDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerdetails c = new customerdetails();
            c.ShowDialog();
        }

    

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addshop sh = new addshop();
            sh.ShowDialog();
        }

        private void shopDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shops s = new shops();
            s.ShowDialog();
        }

        private void editShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editshop es=new editshop();
            es.ShowDialog();
        }

        private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           entry ae = new entry();
            ae.ShowDialog();
        }

        private void raffleEntryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawentries de = new drawentries();
            de.ShowDialog();
        }

        private void addCampaignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addcampaign camp = new addcampaign();
            camp.ShowDialog();
        }

        private void campaignDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            campaigns cp = new campaigns();
            cp.ShowDialog();
        }

        private void drawSettiingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings st = new settings();
            st.ShowDialog();
        }

        private void runDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draws d = new draws();
            d.ShowDialog();
        }

        private void campaignToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
