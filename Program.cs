using System;

namespace Lab_1
{
    public class Display
    {
        public int width;
        public int height;
        public float ppi;
        public string model;

        public Display(int width, int height, float ppi, string model)
        {
            this.width = width;
            this.height = height;
            this.ppi = ppi;
            this.model = model;
        }

        public void compareSize(Display m)
        {
            double size = Math.Sqrt(Math.Pow(this.height, 2) + Math.Pow(this.width, 2));
            double size2 = Math.Sqrt(Math.Pow(m.height, 2) + Math.Pow(m.width, 2));
            if (size == size2)
                Console.WriteLine("Their size is equal");
            else if (size > size2)
                Console.WriteLine($"{this.model} is bigger than {m.model}");
            else
                Console.WriteLine($"{this.model} is smaller than {m.model}");
        }

        public void compareSharpness(Display m)
        {
            if (this.ppi == m.ppi)
                Console.WriteLine("Their sharpness is equal");
            else if (this.ppi > m.ppi)
                Console.WriteLine($"{this.model} is sharper than {m.model}");
            else
                Console.WriteLine($"{this.model} is less sharp than {m.model}");
        }

        public void compareWithMonitor(Display m)
        {
            Console.WriteLine($"Comparing {this.model} with {m.model}: ");
            compareSize(m);
            compareSharpness(m);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Display Dell_Ultra = new Display(1920, 1080, 120.5f, "U272K4p");
            Display Asus_ProArt = new Display(2400, 1650, 100.1f, "PAQ78ARNG");
            Display Samsung_Odyssey = new Display(2400, 1650, 120.5f, "LCCPTR4003");
            Dell_Ultra.compareWithMonitor(Asus_ProArt);
            Dell_Ultra.compareWithMonitor(Samsung_Odyssey);
            Samsung_Odyssey.compareWithMonitor(Asus_ProArt);
        }
    }
}
