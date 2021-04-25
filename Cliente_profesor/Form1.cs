using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_profesor
{
    public partial class Form1 : Form
    {
        TcpClient clienteSocket = new TcpClient();

        public Form1()
        {
            InitializeComponent();
            clienteSocket.Connect("127.0.0.1", 8080);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string men = "";
                if(btnverdadero.Checked)
                {
                    men = "profesor," + txtpregunta.Text + ",1";
                }
                else if (btnfalso.Checked)
                {
                    men = "profesor," + txtpregunta.Text + ",0";
                }

                NetworkStream serverStream = clienteSocket.GetStream();
                byte[] mensajeCliente = System.Text.Encoding.ASCII.GetBytes(men + "$");
                serverStream.Write(mensajeCliente, 0, mensajeCliente.Length);
                serverStream.Flush();

                byte[] mensajeServidor = new byte[10025];
                serverStream.Read(mensajeServidor, 0, 10024);
                string me = System.Text.Encoding.ASCII.GetString(mensajeServidor);
                me = me.Substring(0, me.IndexOf("$"));

                MessageBox.Show(me, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
