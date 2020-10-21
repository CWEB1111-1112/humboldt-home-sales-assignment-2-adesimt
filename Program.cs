using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int noahTotal, silasTotal, chrisTotal, totalSale, amountOfSale;
            String name, initial, finish, end;

            int noahSales = 0;
            int silasSales = 0;
            int chrisSales = 0;
            end = "z";

            Console.WriteLine("Enter the initial of the salesperson: ");
            name = Console.ReadLine();

            initial = name.ToUpper();
            finish = end.ToUpper();

            string[] salespeople = {"Noah", "Silas", "Chris"};

            while(initial != finish){

                while(initial != "N" && initial != "S" && initial != "C" &&initial != "Z"){
                    
                    Console.WriteLine("You have entered an invalid initial.");
                    Console.WriteLine("Enter the initial of the salesperson: ");
                    name = Console.ReadLine();
                    initial = name.ToUpper();
                }

                if(initial == "Z"){
                    break;
                }
                else{

                    Console.WriteLine("Enter the amount of sale");
                    amountOfSale = Convert.ToInt32(Console.ReadLine());

                    if(initial == "N"){
                        noahSales += amountOfSale;
                    }
                    if(initial == "S"){
                        silasSales += amountOfSale;
                    }
                    if(initial == "C"){
                        chrisSales += amountOfSale;
                    }

                    Console.WriteLine("Enter the initial of the salesperson: ");
                    name = Console.ReadLine();
                    initial = name.ToUpper();
                    
                }


            }

            noahTotal = noahSales;
            silasTotal = silasSales;
            chrisTotal = chrisSales;
            totalSale = noahSales + silasSales + chrisSales;

            Console.WriteLine($"Noah's total sale is ${noahTotal} \n");
            Console.WriteLine($"Silas's total sale is ${silasTotal} \n");
            Console.WriteLine($"Chris's total sale is ${chrisTotal} \n");
            Console.WriteLine($"Total sales = ${totalSale} ");



        }
    }
}
