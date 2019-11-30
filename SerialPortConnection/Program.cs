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
            //using (PomiaryContext context = new PomiaryContext())
            //{
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

                    double pm1;
                    double pm25;
                    double pm10;
                    double temp;
                    double wilg;

                    Console.WriteLine("pm1: {0}", wartosci[0]);
                    Console.WriteLine("pm25: {0}", wartosci[1]);
                    Console.WriteLine("pm10: {0}", wartosci[2]);
                    Console.WriteLine("temp: {0}", wartosci[3]);
                    Console.WriteLine("wilg: {0}", wartosci[4]);

                    pm1 = double.Parse(wartosci[0]);
                    pm25 = double.Parse(wartosci[1]);
                    pm10 = double.Parse(wartosci[2]);
                    temp = double.Parse(wartosci[3]);
                    wilg = double.Parse(wartosci[4]);
                    //Thread.Sleep(1000);

                    Console.WriteLine("pm1: {0}", pm1);
                    Console.WriteLine("pm25: {0}", pm25);
                    Console.WriteLine("pm10: {0}", pm10);
                    Console.WriteLine("temp: {0}", temp);
                    Console.WriteLine("wilg: {0}", wilg);


                    //INSERT to MeteoDB database
                    //Pomiary pomiar = new Pomiary
                    //{
                    //    DataCzas = DateTime.Now,
                    //    PM1 = pm1,
                    //    PM25 = pm25,
                    //    PM10 = pm10,
                    //    Temperatura = temp,
                    //    Wilgotnosc = wilg
                    //};
                    //context.Pomiaries.Add(pomiar);
                    //context.SaveChanges();

                    //SELECT from MeteoDB database
                    //Pomiary pomiar2 = context.Pomiaries.FirstOrDefault(x => x.Temperatura >= 0);
                    //Console.WriteLine(pomiar2.PomiarID);
                    //Console.Read();

                    //ALTERING data
                    //pomiar2.Wilgotnosc = 72;
                    //context.SaveChanges();
                    //Console.WriteLine(pomiar2);

                    //DELETE from MeteoDB database
                    //Pomiary pomiar3 = context.Pomiaries.FirstOrDefault(x => x.Temperatura == 32);
                    //context.Pomiaries.Remove(pomiar3);
                    //context.SaveChanges();


                }
            //}
        }

    }
}


