using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Information_carrier
    {
        private string Name_carrier { get; set; } = "";

        private string Name { get; set; } = "";

        private string Model { get; set; } = "";

        private double Price { get; set; } = 0;

        protected Information_carrier()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abstract Default Constructor!");
            Console.ResetColor();
            Name_carrier = "Some Name Carrier";
            Name = "Some Name";
            Model = "Some Model";
            Price = 99.99;
        }

        protected Information_carrier(string Name_carrier, string Name, string Model, double Price)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abstract Param Constructor!");
            Console.ResetColor();
            this.Name_carrier = Name_carrier;
            this.Name = Name;
            this.Model = Model;
            this.Price = Price;
        }


        public virtual void Print()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abstract Print");
            Console.ResetColor();
            Console.WriteLine(Name_carrier);
            Console.WriteLine(Name);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
        }
        public virtual void Download()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abstract Download");
            Console.ResetColor();
        }
        public virtual void Preservation()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abstract Preservation");
            Console.ResetColor();
        }
    }
    class Flash : Information_carrier
    {
        private int memoryUSB;
        private int speedUSB;
        public int MemoryUSB { get; set; } = 0;
        public int SpeedUSB { get; set; } = 0;

        public Flash() : base()
        {
            memoryUSB = 100000;
            speedUSB = 3000;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Default Constructor!");
            Console.ResetColor();
        }
        public Flash(string Name_carrier, string Name, string Model, double Price, int memoryUSB, int speedUSB) 
            : base(Name_carrier, Name, Model, Price)
        {
            this.memoryUSB = memoryUSB;
            this.speedUSB = speedUSB;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Default Param Constructor!");
            Console.ResetColor();
        }
        public override void Print()
        {
           // Print();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Print Flash");
            Console.ResetColor();
            Console.WriteLine(memoryUSB);
            Console.WriteLine(speedUSB);
            Console.WriteLine(" ");
        }
        public override void Download()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Download Flash");
            Console.ResetColor();
        }
        public override void Preservation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Preservation Flash");
            Console.ResetColor();
        }
    }
    class HDD : Information_carrier
    {
        private int memoryUSB;
        private int speedUSB;
        public int MemoryUSB { get; set; } = 0;
        public int SpeedUSB { get; set; } = 0;

        public HDD() : base()
        {
            memoryUSB = 100000;
            speedUSB = 3000;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Default Constructor!");
            Console.ResetColor();
        }
        public HDD(string Name_carrier, string Name, string Model, double Price, int memoryUSB, int speedUSB)
            : base(Name_carrier, Name, Model, Price)
        {
            this.memoryUSB = memoryUSB;
            this.speedUSB = speedUSB;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Default Param Constructor!");
            Console.ResetColor();
        }
        public override void Print()
        {
            base.Print();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Print HDD");
            Console.ResetColor();
            Console.WriteLine(memoryUSB);
            Console.WriteLine(speedUSB);
            Console.WriteLine(" ");
        }
        public override void Download()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Download HDD");
            Console.ResetColor();
        }
        public override void Preservation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Preservation HDD");
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        
            List<Information_carrier> Information = new List<Information_carrier>();
            //for (int i = 0; i < Information.Count; i++)
            Information.Add(new Flash("NamqCarrier1", "Name1", "Model1", 100, 9999, 99999999));
            Information.Add(new HDD("NamqCarrier2", "Name2", "Model2", 100, 8888, 2222222));

            Information[0].Print();
            Information[1].Print();



        }
    }
}
