using System;

namespace GoatInKitchenGarden
{
    class Program
    {
        //Козла пустили в квадратный огород и привязали к колышку. Колышек воткнули точно в центре огорода. Козёл ест всё, до чего дотянется, 
        //не перелезая через забор огорода и не разрывая веревку. Какая площадь огорода будет объедена? Даны длина веревки и размеры огорода.
        static void Main(string[] args)
        {
            Console.WriteLine("The lenght of rope:");
            string str = Console.ReadLine();
            double r = double.Parse(str);
            Console.WriteLine("The lenght of kitchen-garden's one side:");
            str = Console.ReadLine();
            double l = double.Parse(str);
            double s = Math.PI * r * r;
            if (l < 2 * r)
            {
                double a = Math.Acos(l / 2 / r);
                s -= 4 * (a * r * r - l / 2 * r * Math.Sin(a));
            }
            Console.WriteLine("The square is {0}", s);
        }
    }
}
