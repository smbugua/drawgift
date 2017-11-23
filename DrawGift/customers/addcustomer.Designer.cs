namespace DrawGift.customers
{
    partial class addcustomer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.addr = new System.Windows.Forms.RichTextBox();
            this.raffle = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.addr);
            this.groupBox1.Controls.Add(this.raffle);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(371, 290);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(97, 30);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(371, 83);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(161, 26);
            this.id.TabIndex = 9;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(13, 248);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(191, 26);
            this.tel.TabIndex = 8;
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(371, 168);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(260, 106);
            this.addr.TabIndex = 7;
            this.addr.Text = "";
            // 
            // raffle
            // 
            this.raffle.Enabled = false;
            this.raffle.Location = new System.Drawing.Point(13, 83);
            this.raffle.Name = "raffle";
            this.raffle.Size = new System.Drawing.Size(191, 26);
            this.raffle.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(13, 168);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(320, 26);
            this.name.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID/Passport No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raffle no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(698, 356);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "addcustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.addcustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox raffle;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.RichTextBox addr;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button save;

    }
}