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
using DP_Saver.Data;
using DP_Saver.Src;

namespace DP_Saver
{
    public partial class Cadastro : Form
    {
       
        public Cadastro()
        {
            InitializeComponent();
        }

        private void CallCdt1()
        {
            CdT1 cd1 = new CdT1(this);
            cd1.TopLevel = false;
            cd1.TopMost = true;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            cd1.FormBorderStyle = FormBorderStyle.None;
            panelCd.Controls.Add(cd1);
            cd1.BringToFront();
            cd1.Show();
        }

        

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            CdT1 cd1 = new CdT1(this);
            cd1.TopLevel = false;
            cd1.TopMost = true;
            cd1.AutoScroll = true;
            cd1.Dock = DockStyle.Fill;
            cd1.FormBorderStyle = FormBorderStyle.None;
            panelCd.Controls.Add(cd1);
            cd1.BringToFront();
            cd1.Show();
        }

       
        private void Cadastro_Load(object sender, EventArgs e)
        {
            CallCdt1();
            LoadCs();
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AtualizarItem att = new AtualizarItem(this);
            att.TopLevel = false;
            att.TopMost = true;
            att.AutoScroll = true;
            att.Dock = DockStyle.Fill;
            att.FormBorderStyle = FormBorderStyle.None;
            panelCd.Controls.Add(att);
            att.BringToFront();
            att.Show();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            Deletar del = new Deletar();
            del.TopLevel = false;
            del.TopMost = true;
            del.AutoScroll = true;
            del.Dock = DockStyle.Fill;
            del.FormBorderStyle = FormBorderStyle.None;
            panelList.Controls.Add(del);
            del.BringToFront();
            del.Show();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            Consulta cs = new Consulta(this);
            cs.TopLevel = false;
            cs.TopMost = true;
            cs.AutoScroll = true;
            cs.Dock = DockStyle.Fill;
            cs.FormBorderStyle = FormBorderStyle.None;
            panelList.Controls.Add(cs);
            cs.BringToFront();
            cs.Show();
        }
        private void LoadCs()
        {
            Consulta cs = new Consulta(this);
            cs.TopLevel = false;
            cs.TopMost = true;
            cs.AutoScroll = true;
            cs.Dock = DockStyle.Fill;
            cs.FormBorderStyle = FormBorderStyle.None;
            panelList.Controls.Add(cs);
            cs.BringToFront();
            cs.Show();
        }
    }
}
