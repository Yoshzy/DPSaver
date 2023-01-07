namespace DP_Saver
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textItem = new System.Windows.Forms.Label();
            this.labelItems = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelValuel = new System.Windows.Forms.Label();
            this.labelAlocados = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.noLocItems = new System.Windows.Forms.Label();
            this.labelNLocados = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.descImg = new System.Windows.Forms.PictureBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calendarPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(120)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textItem);
            this.panel1.Controls.Add(this.labelItems);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Saldo:";
            // 
            // textItem
            // 
            this.textItem.AutoSize = true;
            this.textItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textItem.ForeColor = System.Drawing.Color.White;
            this.textItem.Location = new System.Drawing.Point(42, 9);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(150, 20);
            this.textItem.TabIndex = 7;
            this.textItem.Text = "Saldo do estoque";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItems.ForeColor = System.Drawing.Color.White;
            this.labelItems.Location = new System.Drawing.Point(93, 51);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(25, 25);
            this.labelItems.TabIndex = 6;
            this.labelItems.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(100)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelValuel);
            this.panel2.Controls.Add(this.labelAlocados);
            this.panel2.Location = new System.Drawing.Point(338, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 100);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // labelValuel
            // 
            this.labelValuel.AutoSize = true;
            this.labelValuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuel.ForeColor = System.Drawing.Color.White;
            this.labelValuel.Location = new System.Drawing.Point(107, 51);
            this.labelValuel.Name = "labelValuel";
            this.labelValuel.Size = new System.Drawing.Size(25, 25);
            this.labelValuel.TabIndex = 8;
            this.labelValuel.Text = "0";
            // 
            // labelAlocados
            // 
            this.labelAlocados.AutoSize = true;
            this.labelAlocados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlocados.ForeColor = System.Drawing.Color.White;
            this.labelAlocados.Location = new System.Drawing.Point(76, 9);
            this.labelAlocados.Name = "labelAlocados";
            this.labelAlocados.Size = new System.Drawing.Size(83, 20);
            this.labelAlocados.TabIndex = 8;
            this.labelAlocados.Text = "Alocados";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(13)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.noLocItems);
            this.panel3.Controls.Add(this.labelNLocados);
            this.panel3.Location = new System.Drawing.Point(666, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 100);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total:";
            // 
            // noLocItems
            // 
            this.noLocItems.AutoSize = true;
            this.noLocItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noLocItems.ForeColor = System.Drawing.Color.White;
            this.noLocItems.Location = new System.Drawing.Point(111, 51);
            this.noLocItems.Name = "noLocItems";
            this.noLocItems.Size = new System.Drawing.Size(25, 25);
            this.noLocItems.TabIndex = 9;
            this.noLocItems.Text = "0";
            // 
            // labelNLocados
            // 
            this.labelNLocados.AutoSize = true;
            this.labelNLocados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNLocados.ForeColor = System.Drawing.Color.White;
            this.labelNLocados.Location = new System.Drawing.Point(72, 9);
            this.labelNLocados.Name = "labelNLocados";
            this.labelNLocados.Size = new System.Drawing.Size(118, 20);
            this.labelNLocados.TabIndex = 9;
            this.labelNLocados.Text = "Sem Locação";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.panel4.Controls.Add(this.descImg);
            this.panel4.Controls.Add(this.labelDesc);
            this.panel4.Location = new System.Drawing.Point(3, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 42);
            this.panel4.TabIndex = 1;
            // 
            // descImg
            // 
            this.descImg.Image = ((System.Drawing.Image)(resources.GetObject("descImg.Image")));
            this.descImg.Location = new System.Drawing.Point(3, 2);
            this.descImg.Name = "descImg";
            this.descImg.Size = new System.Drawing.Size(45, 40);
            this.descImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.descImg.TabIndex = 5;
            this.descImg.TabStop = false;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.ForeColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(51, 12);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(51, 20);
            this.labelDesc.TabIndex = 5;
            this.labelDesc.Text = "INFO";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(701, 155);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(61, 25);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // calendarPic
            // 
            this.calendarPic.Image = ((System.Drawing.Image)(resources.GetObject("calendarPic.Image")));
            this.calendarPic.Location = new System.Drawing.Point(650, 140);
            this.calendarPic.Name = "calendarPic";
            this.calendarPic.Size = new System.Drawing.Size(45, 40);
            this.calendarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calendarPic.TabIndex = 4;
            this.calendarPic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 286);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(938, 579);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.calendarPic);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox calendarPic;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.PictureBox descImg;
        private System.Windows.Forms.Label textItem;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelValuel;
        private System.Windows.Forms.Label labelAlocados;
        private System.Windows.Forms.Label noLocItems;
        private System.Windows.Forms.Label labelNLocados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}