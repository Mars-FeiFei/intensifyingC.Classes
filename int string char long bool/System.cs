using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace IntensifyingC
{
    /// <summary>
    ///  { } namespace  System.IntensifyongC
    /// </summary>
    
    
        /// <summary>
        /// { } namespace System.Conversion
        /// </summary>
        public class Conversion
        {
            public static int ConvertToInt(object value)
            {
                return Convert.ToInt32(value);
            }

            public static double ConvertToDouble(object value)
            {
                return Convert.ToDouble(value);
            }

            public static string ConvertToString(object value)
            {
                return Convert.ToString(value);
            }

            public static bool ConvertToBool(object value)
            {
                return Convert.ToBoolean(value);
            }

            public static char ConvertToChar(object value)
            {
                return Convert.ToChar(value);
            }

            public static byte ConvertToByte(object value)
            {
                return Convert.ToByte(value);
            }

            public static short ConvertToShort(object value)
            {
                return Convert.ToInt16(value);
            }

            public static long ConvertToLong(object value)
            {
                return Convert.ToInt64(value);
            }

            public static float ConvertToFloat(object value)
            {
                return Convert.ToSingle(value);
            }
        }
        public class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                   return a / b;
            }
            public class Computer
            {
                public string Brand { get; set; }
                public string Model { get; set; }
                public int Year { get; set; }
                public double Price { get; set; }

                public Computer(string brand, string model, int year, double price)
                {
                    Brand = brand;
                    Model = model;
                    Year = year;
                    Price = price;
                }

                public void DisplayInfo()
                {
                    Console.WriteLine($"品牌： {Brand}");
                    Console.WriteLine($"型号： {Model}");
                    Console.WriteLine($"年份： {Year}");
                    Console.WriteLine($"价格： {Price}");
                }
            }
        }
        /// <summary>
        ///  { } namespace System.CMD
        /// </summary>
        public class CMD
        {
            public static void ExecuteCommand(string command)
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine(output);
            }
        }
        /// <summary>
        ///  { } namespace Sytem.Car
        /// </summary>
        public class Car
        {
            string car;
            string CarType;
            public static string Name { get; set; }
            public static double Performance { get; set; }
            public Car(string carType)
            {
                CarType = carType.ToUpper();
                if (CarType == "SUV")
                {
                car =   "`afffa- \r\n O    O\r\nThis is a SUV.";
                }
                else if (CarType == "SPORTS-CAR")
                {
                car = @"/\__/\"+"\r\nO____O\r\nThis is a SPORTS-CAR.";
                }
                else
                {
                    car = "Because the characters you\r\n entered were incorrect or did not meet\r\n the program conditions, a normal car will be\r\n shown below:a00a- \r\n             o--o\r\nThis is a normal car.";
                }
            }
            public  void DisplayTheCar()
            {
                Console.WriteLine(car);
            }
            public  void DisplayCarInfo(string name, double performance)
            {
                Name = name;
                Performance = performance;
                Console.WriteLine($"name:{Name}");
                Console.WriteLine($"performance:{Performance}");
            }
        }
       

    }
    /// <summary>
    ///  { } namespace Sytem.Car
    /// </summary>
    public class ControlPanel
    {
        

        /// <summary>
        /// ProcessStart.Start(string path);
        /// </summary>

        public class ProcessStart
        {
            public void Start(string path)
            {
                try { Process.Start(path); }catch(Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        public class CraneTransmitMessage
        {
            private string _ipAddress;
            private int _port;

            public CraneTransmitMessage(string ipAddress, int port)
            {
                _ipAddress = ipAddress;
                _port = port;
            }

            public void SendMessage(string message)
            {
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(_ipAddress, _port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        stream.Write(data, 0, data.Length);
                    }
                }
            }

            public string ReceiveMessage()
            {
                string message = "";
                using (TcpClient client = new TcpClient())
                {
                    client.Connect(_ipAddress, _port);
                    using (NetworkStream stream = client.GetStream())
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    }
                }
                return message;
            }
        }
        public class IntensifyingConsole
        {
            public static void ReadLine()
            {
                Console.ReadLine();
            }

            public static void WriteLine(string message)
            {
                Console.WriteLine(message);
            }

            public static int GetIntegerInput(string prompt)
            {
                Console.Write(prompt);
                return int.Parse(Console.ReadLine());
            }

            public static double GetDoubleInput(string prompt)
            {
                Console.Write(prompt);
                return double.Parse(Console.ReadLine());
            }

            public static bool GetBooleanInput(string prompt)
            {
                Console.Write(prompt);
                return bool.Parse(Console.ReadLine().ToLower());
            }

            public static char GetCharInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadKey().KeyChar;
            }

            public static string GetStringInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine();
            }

            public static void ClearScreen()
            {
                Console.Clear();
            }

            public static void PauseProgram()
            {
                Console.WriteLine("按任意键继续...");
                Console.ReadKey();
            }

            public static void ShowMenu()
            {
                WriteLine("1. 选项一");
                WriteLine("2. 选项二");
                WriteLine("3. 退出");
            }

            public static void ShowErrorMessage(string message)
            {
                WriteLine("错误： " + message);
                PauseProgram();
            }

            public static void ShowInfoMessage(string message)
            {
                WriteLine("信息： " + message);
                PauseProgram();
            }

            public static void ShowWarningMessage(string message)
            {
                WriteLine("警告： " + message);
                PauseProgram();
            }
            public static void ThrowNewException()
            {
                throw new Exception();
            }
            public static void Clear()
            {
                Console.Clear();
            }
        }

    }
    public class Car2
    {
        string Info;
        public string Type { get; private set; }
        public Car2(string type)
        {
            Type = type.ToUpper();
            if (Type == "SPORTS-CAR")
            {
                Info = "      ________\r\n  ___|        |___\r\n   /   |        | \r\n     |        | "+@"  \  " + "\r\n( )---------------( )";
                Console.WriteLine(Info);
            }
            else if (Type == "TRACTOR")
            {
                Info = "       _______\r\n  ___|        |___\r\n /   |        |   \\\r\n|    |        |    |\r\n \\   |        |   /\r\n  |___|        |___\r\n";
                Console.WriteLine(Info);
            }

        }
    }



