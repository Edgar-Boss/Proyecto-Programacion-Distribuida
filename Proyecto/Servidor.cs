using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace Proyecto
{
    class Servidor 
    {
        private TcpListener server;
        private TcpClient client = new TcpClient();
        private IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any,8080);
        private List<Connection> list = new List<Connection>();

        Connection con;

        
        private struct Connection
        {
            public NetworkStream stream;
            public StreamWriter streamw;
            public StreamReader streamr;
            public string nick;
        }

        public Servidor()
        {
           
            Inicio();
        }


        
        public void Inicio() 
        {


            MessageBox.Show("Servidor Iniciado");
            server = new TcpListener(ipendpoint);
            try
            {
                server.Start();
            }
            catch(SocketException r)
            {
                Console.WriteLine(r);
            }

            Thread mientras = new Thread(Servidor_espera);
            mientras.Start();

            void  Escuchar_conexion()
            {
                Connection hcon = con;
                do
                {
                    try
                    {
                        string tmp = hcon.streamr.ReadLine();
                        foreach (Connection c in list)
                        {
                            try
                            {
                                c.streamw.WriteLine(hcon.nick + ";" + tmp);
                                c.streamw.Flush();
                            }
                            catch
                            {

                            }

                        }
                    }
                    catch
                    {
                        list.Remove(hcon);
                        Console.WriteLine(con.nick + "se ha desconectado. ");
                        break;

                    }
                    

                }while(true);

            }
            void Servidor_espera()
            {

                while (true)
                {

                    client = server.AcceptTcpClient();
                    

                    con = new Connection();
                    con.stream = client.GetStream();
                    con.streamr = new StreamReader(con.stream);
                    con.streamw = new StreamWriter(con.stream);
                    con.nick = con.streamr.ReadLine();
                    list.Add(con);
                    MessageBox.Show(con.nick + " se ha conectado");
                    Thread t = new Thread(Escuchar_conexion);
                    t.Start();
                }
            }
        }

        

    }
}
