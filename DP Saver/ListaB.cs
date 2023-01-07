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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        
        public static void LoadList(string prateleira, int numero, string letra)
        {
            Dbc db = new Dbc();

           listB1 lb = new ListBox();
            
            try
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `produtos` WHERE `prateleira` = '{prateleira}' AND `numero` = '{numero}' AND `letra` = '{letra}'", db.GetConn());
                db.conn.Open();
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                  lb.Items.Add($"{read["codigo"].ToString()} {read["nome"].ToString()} {read["quantia"].ToString()}");

                }
                db.conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
