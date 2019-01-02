using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Proyecto
{
    public partial class Chat : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        private static string nick="desconocido";

        private delegate void DAddItem(String s);


        private void AddItem(String s)
        {
            listBox1.Items.Add(s);
        }



        public Chat()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            streamw.WriteLine(textBox1.Text);
            streamw.Flush();
            textBox1.Clear();
        }

        void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DAddItem(AddItem),streamr.ReadLine());

                }
                catch
                {
                    MessageBox.Show("Nose ha podido conectar al servidor");
                    Application.Exit();
                }

            }

        }

        void Conectar_()
        {

            try
            {
                client.Connect("127.0.0.1", 8080);
                if (client.Connected)
                {
                    Thread t = new Thread(Listen);
                    stream = client.GetStream();
                    streamw = new StreamWriter(stream);
                    streamr = new StreamReader(stream);
                    streamw.WriteLine(nick);
                    stream.Flush();
                    t.Start();

                }
                else
                {
                    MessageBox.Show("Servidor no dispoible");
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Servidor no disponible");
                Application.Exit();
            }
        }

        private void connect_Click_1(object sender, EventArgs e)
        {
            label_user.Visible = false;
            textBox2.Visible = false;
            connect.Visible = false;
            listBox1.Visible = true;
            textBox1.Visible = true;
            cone.Visible = true;

            nick = textBox2.Text;
            Conectar_();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
