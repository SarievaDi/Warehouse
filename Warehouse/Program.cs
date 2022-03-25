using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouses Warehouse1 = new Warehouses(
                "London",
                "Pears",
                "kilogram",
                980
                );
            Warehouses Warehouse2 = new Warehouses(
                "New-York",
                "Oranges",
                "ton",
                2.321
                );
            Warehouses Warehouse3 = new Warehouses(
                "New-York",
                "Pears",
                "kilogram",
                1100
                );
            Warehouses Warehouse4 = new Warehouses(
                "London",
                "Tomato",
                "ton",
                2.5
                );
            Warehouses Warehouse5 = new Warehouses(
                "London",
                "Apple",
                "ton",
                3.180
                );
            Warehouses Warehouse6 = new Warehouses(
                "Birmingham",
                "Avocado",
                "kilogram",
                492
                );
            Warehouses Warehouse7 = new Warehouses(
                "Birmingham",
                "Kiwi",
                "kilogram",
                1200
                );
            Warehouses Warehouse8 = new Warehouses(
                "Los-Angeles",
                "Apricot",
                "ton",
                0.461
                );
            Warehouses Warehouse9 = new Warehouses(
                "Los-Angeles",
                "Lemon",
                "ton",
                1.594
                );
            Warehouses Warehouse10 = new Warehouses(
                "Los-Angeles",
                "Banana",
                "ton",
                2.784
                );
            Warehouses Warehouse11 = new Warehouses(
                "London",
                "Apricot",
                "ton",
                0.682
                );
            Warehouses Warehouse12 = new Warehouses(
                "London",
                "Kiwi",
                "kilogram",
                347
                );
            Warehouses Warehouse13 = new Warehouses(
                "New-York",
                "Avocado",
                "kilogram",
                299
                );
            Warehouses Warehouse14 = new Warehouses(
                "New-York",
                "Banana",
                "ton",
                5.04
                );
            Warehouses Warehouse15 = new Warehouses(
                "Birmingham",
                "Pears",
                "kilogram",
                1370
                );
            Warehouses Warehouse16 = new Warehouses(
                "Los-Angeles",
                "Apple",
                "ton",
                0.254
                );
            Warehouses Warehouse17 = new Warehouses(
                "Birmingham",
                "Lemon",
                "ton",
                1.9
                );

            Warehouses[] warehouses = new Warehouses[]
            {
                Warehouse1,
                Warehouse2,
                Warehouse3,
                Warehouse4,
                Warehouse5,
                Warehouse6,
                Warehouse7,
                Warehouse8,
                Warehouse9,
                Warehouse10,
                Warehouse11,
                Warehouse12,
                Warehouse13,
                Warehouse14,
                Warehouse15,
                Warehouse16,
                Warehouse17
            };

            Console.WriteLine("Выводим для каждого склада товары, название которых начинается на А и остаток на этом складе меньше 500 кг: ");
            for (int i = 0; i < warehouses.Length; i++)
            {
                if (warehouses[i].Product[0] == 'A' & ((warehouses[i].Measurement== "kilogram" & warehouses[i].Residue<500) || (warehouses[i].Measurement == "ton" & warehouses[i].Residue < 0.5)))
                {
                    Console.WriteLine("Склад: " + warehouses[i].WarehouseName +", Товар: " + warehouses[i].Product + ", Остаток: " + warehouses[i].Residue + " " + warehouses[i].Measurement);
                }
            }
            Console.ReadKey();

        }
    }
}
