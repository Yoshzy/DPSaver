namespace DP_Saver
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelCd = new System.Windows.Forms.Panel();
            this.btnCadastro = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnDelet = new Guna.UI2.WinForms.Guna2Button();
            this.consultaBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro e Atualização";
            // 
            // panelCd
            // 
            this.panelCd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.panelCd.Location = new System.Drawing.Point(12, 47);
            this.panelCd.Name = "panelCd";
            this.panelCd.Size = new System.Drawing.Size(345, 520);
            this.panelCd.TabIndex = 1;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BorderRadius = 10;
            this.btnCadastro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(363, 47);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(180, 45);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastrar Item";
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(363, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Modificar Item";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelList
            // 
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.panelList.Location = new System.Drawing.Point(558, 47);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(348, 314);
            this.panelList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Consultar e Deletar";
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(558, 367);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(348, 199);
            this.lb1.TabIndex = 11;
            // 
            // btnDelet
            // 
            this.btnDelet.BorderRadius = 10;
            this.btnDelet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(363, 223);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(180, 45);
            this.btnDelet.TabIndex = 12;
            this.btnDelet.Text = "Deletar item";
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // consultaBtn
            // 
            this.consultaBtn.BorderRadius = 10;
            this.consultaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.consultaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.consultaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.consultaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.consultaBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.consultaBtn.ForeColor = System.Drawing.Color.White;
            this.consultaBtn.Location = new System.Drawing.Point(363, 164);
            this.consultaBtn.Name = "consultaBtn";
            this.consultaBtn.Size = new System.Drawing.Size(180, 45);
            this.consultaBtn.TabIndex = 13;
            this.consultaBtn.Text = "Consultar";
            this.consultaBtn.Click += new System.EventHandler(this.consultaBtn_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(938, 579);
            this.ControlBox = false;
            this.Controls.Add(this.consultaBtn);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.panelCd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCd;
        private Guna.UI2.WinForms.Guna2Button btnCadastro;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnDelet;
        private Guna.UI2.WinForms.Guna2Button consultaBtn;
        public System.Windows.Forms.ListBox lb1;
    }
}