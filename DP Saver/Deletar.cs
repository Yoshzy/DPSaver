using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DP_Saver.Data;
using DP_Saver.Src;
using MySql.Data.MySqlClient;

namespace DP_Saver
{
    public partial class Deletar : Form
    {
        public Deletar()
        {
            InitializeComponent();
        }

        private void CleanBoxes()
        {
            codeBox.Clear();
            pratBox.Clear();
            numBox.Clear();
            letterBox.Clear();
        }
        private void DelItem(string codigo, string prateleira, string numero, string letra)
        {
            Dbc db = new Dbc();
            try
            {

                if (MessageBox.Show($"Você deseja mesmo excluir?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"DELETE FROM `produtos` WHERE codigo = {codigo} AND prateleira = '{prateleira}' AND numero = '{numero}' AND letra = '{letra}'", db.GetConn());
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Produto apagado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanBoxes();

                    }
                    else
                    {
                        MessageBox.Show("Algo deu errado revise os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            db.conn.Close();
        }
        private bool FatoradorNum()
        {
            string reftPrateleira = pratBox.Text.ToLower();
            string reftnum = numBox.Text.ToLower();
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            if (reftPrateleira.Trim(re).Equals("") || reftnum.Trim(re).Equals(""))
            {
                MessageBox.Show("São aceitos apenas números em prateleira e numero.", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool FatoradorLetter()
        {
            string letra = letterBox.Text;
            char[] re = { '.', ',', '-', '=', '/', '*', '&', '^', '%', '$', '#', '@', '!', '{', '}', '[', ']', '+', '<', '>', '1','2','3','4','5','6','7','8','9','0'};

            if (letra.Trim(re).Equals(""))
            {
                MessageBox.Show("Pode usar apenas letras em letra.", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckBoxes()
        {
            string codigo = codeBox.Text;
            string prateleira = pratBox.Text;
            string numero = numBox.Text;
            string letra = letterBox.Text;

            if (codigo.Equals("") || prateleira.Equals("") || numero.Equals("") || letra.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            if (!CheckBoxes() && !FatoradorNum() && !FatoradorLetter())
            {
                DelItem(codeBox.Text, pratBox.Text, numBox.Text, letterBox.Text);
            }
            else
            {
                MessageBox.Show("Revise todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeBox.Focus();
            }
        }
    }
}
