using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multiBuilding = new MultiBuilding("Ufa", 64, 18, -6.4, -2);
            multiBuilding.Print();

            Console.ReadKey();
        }
    }
    class Building
    {
        string address;
        double length;
        double wigth;
        double height;
        public string Address
        {
            set
            {
                if (value != "")
                {
                    address = value;
                }
                else
                {
                    Console.WriteLine("Не указан адрес");
                }
            }
            get
            {
                return address;
            }
        }
        public double Length
        {
            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина должна быть больше 0");
                }
            }
            get
            {
                return length;
            }
        }
        public double Wigth
        {
            set
            {
                if (value > 0)
                {
                    wigth = value;
                }
                else
                {
                    Console.WriteLine("Ширина должна быть больше 0");
                }
            }
            get
            {
                return wigth;
            }
        }
        public double Height
        {
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Высота должна быть больше 0");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address, double length, double wigth, double height)
        {
            Address = address;
            Length = length;
            Wigth = wigth;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания - {0}", Address);
            Console.WriteLine("Длина здания - {0}", Length);
            Console.WriteLine("Ширина здания - {0}", Wigth);
            Console.WriteLine("Высота здания - {0}", Height);
        }
    }
    internal sealed class MultiBuilding : Building
    {
        int floors;
        public int Floors
        {
            set
            {
                if (value >= 1)
                {
                    floors = value;
                }
                else
                {
                    Console.WriteLine("Этажность должна быть больше 0");
                }
            }
            get
            {
                return floors;
            }
        }
        public MultiBuilding(string address, double length, double wigth, double height, int floors)
        : base(address, length, wigth, height)
        {
            Floors = floors;
        }
        public new void Print()
        {
            Building building = new Building(Address, Length, Wigth, Height);
            building.Print();
            Console.WriteLine("Этажность здания - {0}", Floors);
        }
    }
}
