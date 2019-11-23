using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
//using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace SerialPortConnection
{
    class Program
    {
        // kolejnosc w lancuchu 
        //PM1 ; PM25 ; PM10 ; temperatura ; wilgotnosc
        static SerialPort _serialPort;
        static void Main(string[] args)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM7";
            _serialPort.BaudRate = 9600;

            string pm1;
            string pm25;
            string pm10;
            string temp;
            string wilg; 
            _serialPort.Open();
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    string answer = "34;56;76;27,8;56,9;";
                    //string  = _serialPort.ReadExisting();
                    string[] wartosci = answer.Split(';');
                    Console.WriteLine(answer);
                    for (int j = 0; j < wartosci.Length; j++)
                    {
                    Console.WriteLine(wartosci[j]);
                    Console.WriteLine(answer);
                    }
                    pm1 = wartosci[0];
                    pm25 = wartosci[1];
                    pm10 = wartosci[2];
                    temp = wartosci[3];
                    wilg = wartosci[4];
                    Thread.Sleep(1000);
                }
                


                //_serialPort.Open();
                //while (true)
                //{
                //    string answer = _serialPort.ReadExisting();
                //    string[] wartosci = answer.Split(';');
                //    Console.WriteLine(answer);
                //    for (int i = 0; i < wartosci.Length; i++)
                //    {
                //        Console.WriteLine(wartosci[i]);
                //    }
                //    //pm1[0] = wartosci[0];
                //    //pm25[0] = wartosci[1];
                //    //pm10[0] = wartosci[2];
                //    //temp[0] = wartosci[3];
                //    //wilg[0] = wartosci[4];



                //    Thread.Sleep(15000);
                //}

            }
            catch (IOException e)
            {
                Console.WriteLine(e.GetType().Name + ": Port nie gotowy!");
            }
            finally
            {
                Console.Read();
            }




            //SQL Connection 
            try
            {
                string connecting = "datasource=DELL/PAULINA;port=3306;username=sa;password=paulina1";
                string Query = "insert into database.MeteoDB(PomiarID, Kategoria,DataCzas,Wartosc) values()";
               
                SqlConnection polaczenie = new SqlConnection(@"Data source=DELL\PAULINA;
                                                             database=MeteoDB;
                                                             User id=sa;
                                                             Password=paulina1;");

                polaczenie.Open();
                SqlCommand komendaSQL = polaczenie.CreateCommand();
                komendaSQL.CommandText = "SELECT * FROM adres";
                SqlDataReader czytnik = komendaSQL.ExecuteReader();

                Console.WriteLine("Wiersze tabeli:");
                while (czytnik.Read())
                {
                    Console.WriteLine(czytnik["nazwisko"].ToString() + "   " + czytnik["imie"].ToString() + "   " + czytnik["adres"].ToString() + "   " + czytnik["kodp"].ToString() + "   " + czytnik["poczta"].ToString());
                }
                czytnik.Close();
                polaczenie.Close();

                Console.ReadKey();
            }

            catch (SqlException e)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd!");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

    }
}


