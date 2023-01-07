using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Saver
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnSair_Click(object sender, EventArgs e)
        {
            
            Login login = new Login();
            this.Hide();
            login.ShowDialog();

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

     
        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Home()
        {
            Home hm = new Home();
            hm.TopLevel = false;
            hm.TopMost = true;
            hm.AutoScroll = true;
            hm.Dock = DockStyle.Fill;
            hm.FormBorderStyle = FormBorderStyle.None;
            mainPannel.Controls.Add(hm);
            hm.BringToFront();
            hm.Show();
        }
        private void CadastroIt()
        {
            Cadastro cd = new Cadastro();
            cd.TopLevel = false;
            cd.TopMost = true;
            cd.AutoScroll = true;
            cd.Dock = DockStyle.Fill;
            cd.FormBorderStyle = FormBorderStyle.None;
            mainPannel.Controls.Add(cd);
            cd.BringToFront();
            cd.Show();
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            Home();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Home();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            CadastroIt();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Busca bc = new Busca();
            bc.TopLevel = false;
            bc.TopMost = true;
            bc.AutoScroll = true;
            bc.Dock = DockStyle.Fill;
            bc.FormBorderStyle = FormBorderStyle.None;
            mainPannel.Controls.Add(bc);
            bc.BringToFront();
            bc.Show();
        }

        private void btnExit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            us.TopLevel = false;
            us.TopMost = true;
            us.AutoScroll = true;
            us.Dock = DockStyle.Fill;
            us.FormBorderStyle = FormBorderStyle.None;
            mainPannel.Controls.Add(us);
            us.BringToFront();
            us.Show();
        }
    }
}
