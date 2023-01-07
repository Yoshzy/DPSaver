using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_Saver.Src;
using DP_Saver.Data;
using MySql.Data.MySqlClient;

namespace DP_Saver
{
    public partial class Login : Form
    {
        Main mn = new Main();
        EditFile eF = new EditFile();
        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            enterButton.FillColor = Color.OrangeRed;
            if(loginBox.Text == "")
            {
                enterButton.FillColor = Color.Gray;
            }
        }
        private void CheckInfo()
        {
            bool verificador = bool.Parse(eF.Check);
            if (verificador)
            {
                loginBox.Text = eF.User;
                checkBoxUS.Checked = true;
            }
            else
            {
                loginBox.Text = "";
                checkBoxUS.Checked = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            eF.LoadIni();
            CheckInfo();
        }

        private bool CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/"))
                    return true;
            }
            catch
            {
                return false;

            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Dbc db = new Dbc();
            try
            {

                if (CheckConnection())
                {
                    string user = loginBox.Text;
                    string senha = passBox.Text;
                    string check = checkBoxUS.Checked.ToString();
                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM `usuarios` WHERE `usuario` = @usn and `senha` = @sn", db.GetConn());
                    cmd.Parameters.Add("@usn", MySqlDbType.VarChar).Value = user;
                    cmd.Parameters.Add("@sn", MySqlDbType.VarChar).Value = senha;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        eF.GetUser(user, check);
                        this.Hide();
                        mn.ShowDialog();
                        db.conn.Close();
                    }
                    else
                    {

                        if (user.Trim().Equals(""))
                        {
                            MessageBox.Show("Insira o nome do usuário!", "Usuario em Branco!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        else if (senha.Trim().Equals(""))
                        {
                            MessageBox.Show("Insira sua senha!", "Senha em Branco!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!", "Erro de Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Problemas de Conexão", "OOPS ALGO DEU ERRADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                db.conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
