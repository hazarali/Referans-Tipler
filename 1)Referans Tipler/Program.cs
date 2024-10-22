using System;

namespace _1_Referans_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product {Id=1,Name="Table",Stock=55};

            ValueorReference valueorReference= new ValueorReference();
            valueorReference.Show(product1);

            Console.WriteLine(product1.Name);
            Console.ReadLine();
            
            


        }

    }
}
