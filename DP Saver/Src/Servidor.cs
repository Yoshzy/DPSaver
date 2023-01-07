using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Saver.Src
{
    internal class Servidor
    {
        static IPEndPoint ipEnd_Client;
        static Socket clientSocket_Client;
        public static string IpEndere = "127.0.0.1";
        static int HostPort = 1202;
        private static bool enviado = false;
        private static string pNome;

        public static string _pNome { get { return pNome; } }
        public static bool _Enviado { get { return enviado; } }

        public static bool SendImages(string arquivo)
        {
            try
            {
                ipEnd_Client = new IPEndPoint(IPAddress.Parse(IpEndere), HostPort);
                clientSocket_Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                string pasta = "";
                pasta = arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] FileNameBytes = Encoding.UTF8.GetBytes(arquivo);
                if(FileNameBytes.Length > 50000 * 1024)
                {
                    MessageBox.Show("Arquivo excede o limite de 50mb!", "Aviso!", MessageBoxButtons.OK);
                    
                }
                string caminho = pasta + arquivo;

                byte[] fileData = File.ReadAllBytes(caminho);

                byte[] clientData = new byte[4 + FileNameBytes.Length + fileData.Length];
                byte[] fileNameLen = BitConverter.GetBytes(FileNameBytes.Length);
             
                fileNameLen.CopyTo(clientData, 0);
                FileNameBytes.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + FileNameBytes.Length);
                clientSocket_Client.Connect(ipEnd_Client);
                clientSocket_Client.Send(clientData, 0, clientData.Length, 0);
                clientSocket_Client.Close();
                pNome = arquivo;
                return true;

            }
            catch(Exception ex)
            {
               return false;
            }
        }
    }
}
