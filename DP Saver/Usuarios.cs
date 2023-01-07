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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            comboSetor.Items.Add("Administração");
            comboSetor.Items.Add("Expedição");
            comboSetor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Dbc db = new Dbc();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `usuarios`(`usuario`, `senha`, `acesslevel`, `foto`, `setor`) VALUES (@usuario, @senha, @acesslevel, @foto, @setor)", db.GetConn());
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = nomBox.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = passBox.Text;
                cmd.Parameters.Add("@acesslevel", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.Add("@foto", MySqlDbType.VarChar).Value = "https://recursos.dispropil.com.br/i/SVG-diversos/logo.png";
                cmd.Parameters.Add("@setor", MySqlDbType.VarChar).Value = comboSetor.Text;
                db.conn.Open();
                if (!checkNome())
                {
                    if (!CheckBoxes())
                    {

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanBx();
                            db.conn.Close();

                        }
                        else
                        {
                            MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Já existe um usuário com esse nome, por favor escolha outro ID!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }
        private bool CheckBoxes()
        {
            string nome = nomBox.Text;
            string password = passBox.Text;
            if (nome.Equals("") || password.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private bool checkNome()
        {
            Dbc db = new Dbc();
            try
            {

                string nome = nomBox.Text;

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `usuarios` WHERE `usuario` = @usuario", db.GetConn());
                db.conn.Open();
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = nome;

                adapter.SelectCommand = cmd;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                db.conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
            db.conn.Close();
        }

                private void CleanBx()
        {
            nomBox.Clear();
            passBox.Clear();
        }
    }
}
