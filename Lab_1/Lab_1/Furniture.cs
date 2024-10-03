using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Furniture
    {
       public string material;
        public int price;

        public Furniture(string material, int price)
        {
            this.material = material;
            this.price = price;
        }

       
    }

    internal class Table : Furniture
    {
        public double height, surface;
        public Table(string material, int price , double height , double surface) : base(material, price)
        {
            this.height = height;
            this.surface = surface;
        }

        public void displayFurniture()
        {
            Console.WriteLine("Material is  " + material);
            Console.WriteLine("price is  " + price);
            Console.WriteLine("height  " + height + " feet");
            Console.WriteLine("surface  " + surface + " sq. feet");
        }
    }
}
