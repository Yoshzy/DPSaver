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
    public partial class AtualizarItem : Form
    {
        Cadastro cd = new Cadastro();
        private Cadastro _cadastro;
        public AtualizarItem(Cadastro cadastro)
        {
            InitializeComponent();
            _cadastro = cadastro;
        }

        private void GetBoxPic()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Text = open.FileName;
            }
        }
        private void CleanBoxes()
        {
            codBox.Clear();
            nomeBox.Clear();
            qtyBox.Clear();
            picBox.Clear();
            pratBox.Clear();
            numBox.Clear();
            letterBox.Clear();
            linkBox.Clear();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            GetBoxPic();
        }

        private void Update()
        {
            string refquantia = qtyBox.Text.ToLower();
            string reftPrateleira = pratBox.Text.ToLower();
            string reftnum = numBox.Text.ToLower();
            char[] re = {
            '.',
            ',',
            '-',
            '=',
            '/',
            '*',
            '&',
            '^',
            '%',
            '$',
            '#',
            '@',
            '!',
            '{',
            '}',
            '[',
            ']',
            '+',
            '<',
            '>',
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
          };

            Dbc db = new Dbc();
            bool nomeB = false;
            bool qtyB = false;
            bool picB = false;
            bool pratB = false;
            bool numB = false;
            bool letterB = false;
            bool linkB = false;
            try
            {
                if (codBox.Text != "")
                {
                    if (nomeBox.Text != "")
                    {
                        MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `nome` = @nome WHERE `codigo` = @codigo", db.GetConn());
                        cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeBox.Text;
                        cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                        db.conn.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            nomeB = true;
                        }
                        db.conn.Close();
                    }
                    if (qtyBox.Text != "")
                    {
                        if (!refquantia.Trim(re).Equals(""))
                        {
                            MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `quantia` = @quantidade WHERE `codigo` = @codigo", db.GetConn());
                            cmd.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = qtyBox.Text;
                            cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                            db.conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                qtyB = true;
                            }
                        }
                        db.conn.Close();
                    }
                    if (picBox.Text != "")
                    {
                        MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `foto` = @foto WHERE `codigo` = @codigo", db.GetConn());
                        cmd.Parameters.Add("@foto", MySqlDbType.VarChar).Value = $"http://127.0.0.1/Fotos/{Servidor._pNome}";
                        cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                        db.conn.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            picB = true;

                        }

                        db.conn.Close();
                    }
                    if (pratBox.Text != "")
                    {
                        if (!reftPrateleira.Trim(re).Equals(""))
                        {
                            MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `prateleira` = @prateleira WHERE `codigo` = @codigo", db.GetConn());
                            cmd.Parameters.Add("@prateleira", MySqlDbType.Int32).Value = pratBox.Text;
                            cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                            db.conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                pratB = true;
                            }

                        }
                        else
                        {
                            MessageBox.Show("O valor deve ser um número!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        db.conn.Close();
                    }
                    if (numBox.Text != "")
                    {
                        if (!reftnum.Trim(re).Equals(""))
                        {
                            MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `numero` = @numero WHERE `codigo` = @codigo", db.GetConn());
                            cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = numBox.Text;
                            cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                            db.conn.Open();
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                numB = true;
                            }

                            db.conn.Close();
                        }
                    }
                    if (letterBox.Text != "")
                    {

                        MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `letra` = @letra WHERE `codigo` = @codigo", db.GetConn());
                        cmd.Parameters.Add("@letra", MySqlDbType.VarChar).Value = letterBox.Text.ToUpper();
                        cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                        db.conn.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            letterB = true;
                        }
                        db.conn.Close();
                    }
                    if (linkBox.Text != "")
                    {

                        MySqlCommand cmd = new MySqlCommand($"UPDATE produtos SET `link` = @link WHERE `codigo` = @codigo", db.GetConn());
                        cmd.Parameters.Add("@link", MySqlDbType.VarChar).Value = linkBox.Text;
                        cmd.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = codBox.Text;
                        db.conn.Open();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            linkB = true;
                        }
                        db.conn.Close();

                    }
                    if (nomeB || qtyB || picB || pratB || numB || letterB || linkB)
                    {
                        MessageBox.Show("Item atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    CleanBoxes();
               }else
                {
                    MessageBox.Show("Digite o código do produto e altere o campo que deseja alterar!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    codBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            private void attBtn_Click(object sender, EventArgs e)
            {
                Dbc db = new Dbc();

                if (picBox.Text != "")
                {
                    if (Servidor.SendImages(picBox.Text))
                    {

                        Update();
                    }
                    else
                    {
                        string message = "Houve um problema ao enviar a imagem, deseja continuar?";
                        string title = "Ops!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            Update();
                        }
                    }
                }
                else
                {
                    Update();
                }
            }

        private void AtualizarItem_Load(object sender, EventArgs e)
        {

        }
    }
    }