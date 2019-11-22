using System;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SerialPortConnection
{
    class Program
    {
        static SerialPort _serialPort;
        static void Main(string[] args)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM7";
            _serialPort.BaudRate = 9600;

            try
            {
                _serialPort.Open();
                while (true)
                {
                    string answer = _serialPort.ReadExisting();
                    Console.WriteLine(answer);
                    //string podzial = answer.Split(";");
                    Thread.Sleep(1000);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.GetType().Name + ": Port nie gotowy!");
            }
            finally
            {
                Console.Read();
            }

        }
    }

}
