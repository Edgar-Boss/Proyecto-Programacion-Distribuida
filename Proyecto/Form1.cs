using System;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        
        delegate void delegado(int valor);
        Chat chat;//crea el objeto chat
        ChatForm cp2p = new ChatForm();//crea el objeto chat p2p
        
        public Form1()
        {
           


            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            Thread Hilo1 = new Thread(Proceso1);
            Hilo1.Start();
            Thread Hilo2 = new Thread(Proceso2);
            Hilo2.Start();
            Thread Hilo3 = new Thread(Proceso3);
            Hilo3.Start();
            Thread Hilo4 = new Thread(Proceso4);
            Hilo4.Start();
        }

        int inicio = 0;
        int fin = 100;
        bool ban = false;



        public void Proceso1()
        {
            Thread.Sleep(100);

            do
            {
                
                for (int i = inicio; i <= fin; i++)
                {
                    delegado MD = new delegado(Actualizar1);
                    this.Invoke(MD, new object[] { i });
                    Thread.Sleep(100);
                }
                ban = true;
            } while (true);
        }

        public void Proceso2()
        {
            Thread.Sleep(100);

            do
            {

                for (int i = inicio; i <= fin; i++)
                {
                    delegado MD = new delegado(Actualizar2);
                    this.Invoke(MD, new object[] { i });
                    Thread.Sleep(200);
                }
                ban = true;
            } while (true);
        }
        public void Proceso3()
        {
            Thread.Sleep(100);

            do
            {

                for (int i = inicio; i <= fin; i++)
                {
                    delegado MD = new delegado(Actualizar3);
                    this.Invoke(MD, new object[] { i });
                    Thread.Sleep(80);
                }
                ban = true;
            } while (true);
        }

        public void Proceso4()
        {
            Thread.Sleep(100);

            do
            {

                for (int i = inicio; i <= fin; i++)
                {
                    delegado MD = new delegado(Actualizar4);
                    this.Invoke(MD, new object[] { i });
                    Thread.Sleep(80);
                }
                ban = true;
            } while (true);
        }
        public void Actualizar1(int valor)
        {
            if (ban == true)
            {
                p1.Maximum += 100;
                p1.Width += 300;
                ban = false;
            }
            p1.Increment(1);
        }

        public void Actualizar2(int valor)
        {
            if (ban == true)
            {
                p2.Maximum += 100;
                p2.Width += 300;
                ban = false;
            }
            p2.Increment(1);
        }
        public void Actualizar3(int valor)
        {
            if (ban == true)
            {
                p3.Maximum += 100;
                p3.Width += 300;
                ban = false;
            }
            p3.Increment(1);
        }
       
        public void Actualizar4(int valor)
        {
            if (ban == true)
            {
                p4.Maximum += 100;
                p4.Width += 300;
                ban = false;
            }
            p4.Increment(1);
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void peerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            contextMenuStrip1.Items[0].Enabled = false;
            contextMenuStrip1.Items[1].Enabled = true;
            Servidor chat = new Servidor();
        }
        
        private void Cliente_Click(object sender, EventArgs e)
        {

            chat = new Chat();
            chat.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p2pToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cp2p.Show();
        }

        int x = 2000; 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            }
            else
            {
                chart1.ChartAreas[0].Area3DStyle.Enable3D = false;
            }

        }
        double w;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chart1.Series[0].Points.Count > 5)
            {
                chart1.Series[0].Points.RemoveAt(0);
                chart1.Update();
            }
            w = new Random().NextDouble();
            label1.Text = w.ToString();
            chart1.Series[0].Points.AddXY(x++,w);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Legends.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Range;
            checkBox1.Checked=true;
        }
    }
}
