
namespace smarthouse1
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.test = new System.Windows.Forms.Button();
            this.demarrerT = new System.Windows.Forms.Button();
            this.deconnecterT = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.holder = new System.Windows.Forms.TextBox();
            this.dem = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idC = new System.Windows.Forms.ColumnHeader();
            this.nomC = new System.Windows.Forms.ColumnHeader();
            this.descriptionC = new System.Windows.Forms.ColumnHeader();
            this.connection = new System.Windows.Forms.ColumnHeader();
            this.demarrage = new System.Windows.Forms.ColumnHeader();
            this.chambreC = new System.Windows.Forms.ColumnHeader();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bedroom1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bedroom2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.livingroom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.diningroom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.kitchen = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bin = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bedroom1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bedroom2.SuspendLayout();
            this.livingroom.SuspendLayout();
            this.diningroom.SuspendLayout();
            this.kitchen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.demarrerT);
            this.panel1.Controls.Add(this.deconnecterT);
            this.panel1.Controls.Add(this.dec);
            this.panel1.Controls.Add(this.holder);
            this.panel1.Controls.Add(this.dem);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(953, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 728);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "quitte mode teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "capteur de son",
            "capteur de pression",
            "capteur de mouvement",
            "capteur de feu"});
            this.comboBox1.Location = new System.Drawing.Point(127, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 23);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(60, 160);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 9;
            this.test.Text = "mode teste";
            this.test.UseVisualStyleBackColor = true;
            this.test.Visible = false;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // demarrerT
            // 
            this.demarrerT.Location = new System.Drawing.Point(153, 270);
            this.demarrerT.Name = "demarrerT";
            this.demarrerT.Size = new System.Drawing.Size(104, 23);
            this.demarrerT.TabIndex = 8;
            this.demarrerT.Text = "demarrerT";
            this.demarrerT.UseVisualStyleBackColor = true;
            this.demarrerT.Visible = false;
            this.demarrerT.Click += new System.EventHandler(this.demarrerT_Click);
            // 
            // deconnecterT
            // 
            this.deconnecterT.Location = new System.Drawing.Point(21, 270);
            this.deconnecterT.Name = "deconnecterT";
            this.deconnecterT.Size = new System.Drawing.Size(104, 23);
            this.deconnecterT.TabIndex = 7;
            this.deconnecterT.Text = "connecterT";
            this.deconnecterT.UseVisualStyleBackColor = true;
            this.deconnecterT.Visible = false;
            this.deconnecterT.Click += new System.EventHandler(this.deconnecterT_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(405, 304);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(75, 23);
            this.dec.TabIndex = 4;
            this.dec.Text = "deconnecter";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Visible = false;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // holder
            // 
            this.holder.Location = new System.Drawing.Point(3, 12);
            this.holder.Name = "holder";
            this.holder.Size = new System.Drawing.Size(100, 23);
            this.holder.TabIndex = 6;
            this.holder.Visible = false;
            // 
            // dem
            // 
            this.dem.Location = new System.Drawing.Point(502, 304);
            this.dem.Name = "dem";
            this.dem.Size = new System.Drawing.Size(75, 23);
            this.dem.TabIndex = 3;
            this.dem.Text = "demarrer";
            this.dem.UseVisualStyleBackColor = true;
            this.dem.Visible = false;
            this.dem.Click += new System.EventHandler(this.dem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(153, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(345, 122);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idC,
            this.nomC,
            this.descriptionC,
            this.connection,
            this.demarrage,
            this.chambreC});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 342);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 377);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idC
            // 
            this.idC.Text = "idC";
            this.idC.Width = 100;
            // 
            // nomC
            // 
            this.nomC.DisplayIndex = 2;
            this.nomC.Text = "nomC";
            this.nomC.Width = 100;
            // 
            // descriptionC
            // 
            this.descriptionC.DisplayIndex = 1;
            this.descriptionC.Text = "descriptionC";
            this.descriptionC.Width = 100;
            // 
            // connection
            // 
            this.connection.Text = "connection";
            this.connection.Width = 100;
            // 
            // demarrage
            // 
            this.demarrage.Text = "demarrage";
            this.demarrage.Width = 100;
            // 
            // chambreC
            // 
            this.chambreC.Text = "chambreC";
            this.chambreC.Width = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(851, 637);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bedroom1
            // 
            this.bedroom1.BackColor = System.Drawing.Color.White;
            this.bedroom1.Controls.Add(this.label2);
            this.bedroom1.Location = new System.Drawing.Point(656, 22);
            this.bedroom1.Name = "bedroom1";
            this.bedroom1.Size = new System.Drawing.Size(277, 206);
            this.bedroom1.TabIndex = 13;
            this.bedroom1.Paint += new System.Windows.Forms.PaintEventHandler(this.bedroom1_Paint);
            this.bedroom1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bedroom1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bedroom 1 \r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::smarthouse1.Properties.Resources.screen_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 728);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bedroom2
            // 
            this.bedroom2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bedroom2.Controls.Add(this.label1);
            this.bedroom2.Location = new System.Drawing.Point(146, 22);
            this.bedroom2.Name = "bedroom2";
            this.bedroom2.Size = new System.Drawing.Size(233, 259);
            this.bedroom2.TabIndex = 13;
            this.bedroom2.Paint += new System.Windows.Forms.PaintEventHandler(this.bedroom2_Paint);
            this.bedroom2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bedroom2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bedroom 2 \r\n";
            // 
            // livingroom
            // 
            this.livingroom.Controls.Add(this.label3);
            this.livingroom.Location = new System.Drawing.Point(57, 304);
            this.livingroom.Name = "livingroom";
            this.livingroom.Size = new System.Drawing.Size(379, 266);
            this.livingroom.TabIndex = 13;
            this.livingroom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.livingroom_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(130, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Living Room";
            // 
            // diningroom
            // 
            this.diningroom.Controls.Add(this.label4);
            this.diningroom.Location = new System.Drawing.Point(474, 335);
            this.diningroom.Name = "diningroom";
            this.diningroom.Size = new System.Drawing.Size(200, 273);
            this.diningroom.TabIndex = 13;
            this.diningroom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.diningroom_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dining Room";
            // 
            // kitchen
            // 
            this.kitchen.Controls.Add(this.label5);
            this.kitchen.Location = new System.Drawing.Point(705, 335);
            this.kitchen.Name = "kitchen";
            this.kitchen.Size = new System.Drawing.Size(228, 235);
            this.kitchen.TabIndex = 13;
            this.kitchen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kitchen_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(72, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kitchen";
            // 
            // bin
            // 
            this.bin.Image = global::smarthouse1.Properties.Resources.trash1;
            this.bin.Location = new System.Drawing.Point(0, 0);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(82, 85);
            this.bin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bin.TabIndex = 14;
            this.bin.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(39, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 82);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::smarthouse1.Properties.Resources.edit1;
            this.pictureBox4.Location = new System.Drawing.Point(2, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 82);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.bin);
            this.panel3.Location = new System.Drawing.Point(169, 637);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 85);
            this.panel3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "liste des actions";
            this.label6.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 728);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kitchen);
            this.Controls.Add(this.diningroom);
            this.Controls.Add(this.livingroom);
            this.Controls.Add(this.bedroom1);
            this.Controls.Add(this.bedroom2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bedroom1.ResumeLayout(false);
            this.bedroom1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bedroom2.ResumeLayout(false);
            this.bedroom2.PerformLayout();
            this.livingroom.ResumeLayout(false);
            this.livingroom.PerformLayout();
            this.diningroom.ResumeLayout(false);
            this.diningroom.PerformLayout();
            this.kitchen.ResumeLayout(false);
            this.kitchen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bin)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel bedroom1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button dem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bedroom2;
        private System.Windows.Forms.Panel livingroom;
        private System.Windows.Forms.Panel diningroom;
        private System.Windows.Forms.Panel kitchen;
        private System.Windows.Forms.TextBox holder;
        private System.Windows.Forms.Button demarrerT;
        private System.Windows.Forms.Button deconnecterT;
        private System.Windows.Forms.PictureBox bin;
        private System.Windows.Forms.ColumnHeader idC;
        private System.Windows.Forms.ColumnHeader descriptionC;
        private System.Windows.Forms.ColumnHeader connection;
        private System.Windows.Forms.ColumnHeader nomC;
        private System.Windows.Forms.ColumnHeader chambreC;
        private System.Windows.Forms.ColumnHeader demarrage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

