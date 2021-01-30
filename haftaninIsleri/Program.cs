using System;

namespace haftaninIsleri
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDo father = new ToDo();
            Console.WriteLine("Enter hours to spend Cleaning");
            father.Cleaning = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours to spend Cooking");
            father.Cooking = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours to spend SelfTime");
            father.SelfTime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours to spend Working");
            father.Working = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total Time for all thing in ToDo list ==>{0}", Convert.ToDouble(father.Cleaning + father.Cooking + father.SelfTime + father.Working));


            ToDo sister = new ToDo();
            sister.Cleaning = 1;
            sister.Cooking = 1;
            sister.SelfTime = 1;
            sister.Working = 5;

            ToDo brother = new ToDo();
            brother.Cleaning = 1;
            brother.Cooking = 2;
            brother.SelfTime = 5.5;
            brother.Working = 0.5;

        }
    }



    class ToDo
    {
        public double Cleaning { get; set; }
        public double Cooking { get; set; }
        public double SelfTime { get; set; }
        public double Working { get; set; }


    }
}