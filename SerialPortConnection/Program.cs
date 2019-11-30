using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


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
            _serialPort.PortName = "COM6";
            _serialPort.BaudRate = 9600;
 
            _serialPort.Open();
            
            string answer;
            string[] wartosci;

            for (; ; )
            {

                for (; ; )
                {
                    
                    Thread.Sleep(600);
                    answer = _serialPort.ReadExisting();
                    wartosci = answer.Split(';');
                    Console.WriteLine("");
                    if (wartosci.Length > 5)
                        break;
                }

                int pm1;
                int pm25;
                int pm10;
                int temp;
                int wilg;

                pm1 = int.Parse(wartosci[0]);
                pm25 = int.Parse(wartosci[1]);
                pm10 = int.Parse(wartosci[2]);
                temp = int.Parse(wartosci[3]);
                wilg = int.Parse(wartosci[4]);
                //Thread.Sleep(1000);

                Console.WriteLine("pm1: {0}",pm1);
                Console.WriteLine("pm25: {0}", pm25);
                Console.WriteLine("pm10: {0}", pm10);
                Console.WriteLine("temp: {0}", temp);
                Console.WriteLine("wilg: {0}", wilg);

            }

            ////SQL Connection 
            //try
            //{
            //    string connecting = "datasource=DELL/PAULINA;port=3306;username=sa;password=paulina1";
            //    string Query = "insert into database.MeteoDB(PomiarID, Kategoria,DataCzas,Wartosc) values()";

            //    SqlConnection polaczenie = new SqlConnection(@"Data source=DELL\PAULINA;
            //                                                 database=MeteoDB;
            //                                                 User id=sa;
            //                                                 Password=paulina1;");

            //    polaczenie.Open();
            //    SqlCommand komendaSQL = polaczenie.CreateCommand();
            //    komendaSQL.CommandText = "SELECT * FROM adres";
            //    SqlDataReader czytnik = komendaSQL.ExecuteReader();

            //    Console.WriteLine("Wiersze tabeli:");
            //    while (czytnik.Read())
            //    {
            //        Console.WriteLine(czytnik["nazwisko"].ToString() + "   " + czytnik["imie"].ToString() + "   " + czytnik["adres"].ToString() + "   " + czytnik["kodp"].ToString() + "   " + czytnik["poczta"].ToString());
            //    }
            //    czytnik.Close();
            //    polaczenie.Close();

            //    Console.ReadKey();
            //}

            //catch (SqlException e)
            //{
            //    Console.WriteLine("Wystąpił nieoczekiwany błąd!");
            //    Console.WriteLine(e.Message);
            //    Console.ReadKey();
            //}
        }

        void SaveToSQL()
        {
            //DateTime czas = DateTime.Now;
            //string constring = "Data Source=DELL/PAULINA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection conection = new SqlConnection(constring);
            //conection.Open();
            //string Query = "insert into Użytkownik.dbo.Rejestracja(UserName,Password,FirstName,LastName,Weight,Height,Sex) values ('" + pm1 + "','" + pm25 + "','" + pm10 + "','" + temp + "', '" + wilg+ "', '"')";

            //SqlCommand cmd = new SqlCommand(Query, conection);
            //int i = cmd.ExecuteNonQuery();

            //if (i != 0)
            //{
            //    Console.WriteLine("Saved");
            //}
            //else
            //{
            //    Console.WriteLine("Error has occured!");
            //}

            
            
        }

    }
}


