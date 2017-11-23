namespace DrawGift.raffle
{
    partial class addentry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.token = new System.Windows.Forms.ComboBox();
            this.campaignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drawgiftDataSet = new DrawGift.drawgiftDataSet();
            this.amnt = new System.Windows.Forms.TextBox();
            this.shop = new System.Windows.Forms.ComboBox();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raffle = new System.Windows.Forms.TextBox();
            this.cust = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rec = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datea = new System.Windows.Forms.DateTimePicker();
            this.points = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.usersTableAdapter();
            this.shopTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.shopTableAdapter();
            this.customerTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.customerTableAdapter();
            this.campaignTableAdapter = new DrawGift.drawgiftDataSetTableAdapters.campaignTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawgiftDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(755, 445);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.token);
            this.groupBox1.Controls.Add(this.amnt);
            this.groupBox1.Controls.Add(this.shop);
            this.groupBox1.Controls.Add(this.raffle);
            this.groupBox1.Controls.Add(this.cust);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raffle Entry";
            // 
            // token
            // 
            this.token.DataSource = this.campaignBindingSource;
            this.token.DisplayMember = "name";
            this.token.FormattingEnabled = true;
            this.token.Location = new System.Drawing.Point(119, 37);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(227, 26);
            this.token.TabIndex = 10;
            // 
            // campaignBindingSource
            // 
            this.campaignBindingSource.DataMember = "campaign";
            this.campaignBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // drawgiftDataSet
            // 
            this.drawgiftDataSet.DataSetName = "drawgiftDataSet";
            this.drawgiftDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amnt
            // 
            this.amnt.Location = new System.Drawing.Point(115, 326);
            this.amnt.Name = "amnt";
            this.amnt.Size = new System.Drawing.Size(149, 26);
            this.amnt.TabIndex = 9;
            this.amnt.TextChanged += new System.EventHandler(this.amnt_TextChanged);
            // 
            // shop
            // 
            this.shop.DataSource = this.shopBindingSource;
            this.shop.DisplayMember = "name";
            this.shop.FormattingEnabled = true;
            this.shop.Location = new System.Drawing.Point(115, 257);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(231, 26);
            this.shop.TabIndex = 8;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "shop";
            this.shopBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // raffle
            // 
            this.raffle.Enabled = false;
            this.raffle.Location = new System.Drawing.Point(115, 184);
            this.raffle.Name = "raffle";
            this.raffle.Size = new System.Drawing.Size(231, 26);
            this.raffle.TabIndex = 7;
            // 
            // cust
            // 
            this.cust.DataSource = this.customerBindingSource;
            this.cust.DisplayMember = "name";
            this.cust.FormattingEnabled = true;
            this.cust.Location = new System.Drawing.Point(115, 111);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(231, 26);
            this.cust.TabIndex = 6;
            this.cust.SelectedIndexChanged += new System.EventHandler(this.cust_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount Paid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Shop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Raffle No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Draw Campaign";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rec);
            this.groupBox2.Controls.Add(this.datea);
            this.groupBox2.Controls.Add(this.points);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 421);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raffle Entry";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(39, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 80);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "save and exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "save and new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rec
            // 
            this.rec.DataSource = this.usersBindingSource;
            this.rec.DisplayMember = "fullname";
            this.rec.FormattingEnabled = true;
            this.rec.Location = new System.Drawing.Point(155, 184);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(193, 26);
            this.rec.TabIndex = 6;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.drawgiftDataSet;
            // 
            // datea
            // 
            this.datea.CustomFormat = "yyyy-MM-dd";
            this.datea.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datea.Location = new System.Drawing.Point(155, 111);
            this.datea.Name = "datea";
            this.datea.Size = new System.Drawing.Size(153, 26);
            this.datea.TabIndex = 5;
            // 
            // points
            // 
            this.points.Enabled = false;
            this.points.Location = new System.Drawing.Point(155, 34);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(153, 26);
            this.points.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "Recorded By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Points";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // campaignTableAdapter
            // 
            this.campaignTableAdapter.ClearBeforeFill = true;
            // 
            // addentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 445);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addentry";
            this.Text = "Add Raffle Entry";
            this.Load += new System.EventHandler(this.addentry_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawgiftDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cust;
        private System.Windows.Forms.TextBox raffle;
        private System.Windows.Forms.ComboBox shop;
        private System.Windows.Forms.TextBox amnt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.DateTimePicker datea;
        private System.Windows.Forms.ComboBox rec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private drawgiftDataSet drawgiftDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private drawgiftDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private drawgiftDataSetTableAdapters.shopTableAdapter shopTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private drawgiftDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ComboBox token;
        private System.Windows.Forms.BindingSource campaignBindingSource;
        private drawgiftDataSetTableAdapters.campaignTableAdapter campaignTableAdapter;
    }
}