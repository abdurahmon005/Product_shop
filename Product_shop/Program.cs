using System;
class Program
{
   public static void Main(string[] args)
    {
       
        Console.WriteLine("\t\t\t\t\t\t ____________________________________ ");
        Console.WriteLine("\t\t\t\t\t\t|                                    |");
        Console.WriteLine("\t\t\t\t\t\t|                                    |");
        Console.WriteLine("\t\t\t\t\t\t|            PRODUCT SHOP            |");
        Console.WriteLine("\t\t\t\t\t\t|                                    |");
        Console.WriteLine("\t\t\t\t\t\t|____________________________________|\n\n\n");
        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
        Console.WriteLine("|                                    |       |                                    |    |                                    |");
        Console.WriteLine("|                                    |       |                                    |    |                                    |");
        Console.WriteLine("|     1.Mahsulotlar ro'yhati         |       |   2.Sotib olinganm ahsulotlar      |    |        3.Sotib olish               |");
        Console.WriteLine("|                                    |       |                                    |    |                                    |");
        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|");
 

        int[] array_id = { 1, 2, 3, 4, 5 };

        double[] array_narx = { 120000, 250000, 450000, 100000, 125000 };

        string[] array_name = { "GPU", "SSD", "CPU", "HDD", "HARD DICK" };
        string[] array_korzinka = new string[5];
       start:
        Console.Write("\n\nqanday amal bajarmoqchisiz: ");

        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < array_id.Length; i++)
        {
            if (number == 1)
            {
                Console.Write(array_id[i] + "            ");
                Console.Write(array_name[i] + "            ");
                Console.Write(array_narx[i] + "\n");

            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (number == 2)
            {

                Console.Write(array_korzinka[i] + "  ");
            }
        }
        for (int i = 0; i < array_id.Length; i++)
        {
            if (number == 3)
            {
                Console.Write(array_id[i] + "            ");
                Console.Write(array_name[i] + "            ");
                Console.Write(array_narx[i] + "\n");
            }

        }
        Console.Write(" \n\n qaysi mahsulotni sotib olmoqchisiz ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        if (num2 == 1)
        {
            array_korzinka[0] = "GPU";
        }
        if (num2 == 2)
        {
            array_korzinka[1] = "SSD";
        }

        if (num2 == 3)
        {
            array_korzinka[2] = "CPU";
        }

        if (num2 == 4)
        {
            array_korzinka[3] = "HDD";
        }

        if (num2 == 5)
        {
            array_korzinka[4] = "HARD DICK";
        }
        Console.WriteLine("\n\nAmaliyot muvaffaqqiyatli bajarildi!");
        
      ///  Console.Write("1.Mahsulotlar ro'yhati | 2.Sotib olingan mahsulotlar | 3.Sotib olish \n\n\n");

        

        Console.Write("qanday amal bajarmoqchisiz: ");

        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < array_id.Length; i++)
        {
            if (number == 1)
            {
                Console.Write(array_id[i] + "            ");
                Console.Write(array_name[i] + "            ");
                Console.Write(array_narx[i] + "\n");

            }
        }
        for (int i = 0; i < 5; i++)
        {
            if (number == 2)
            {

                Console.Write(array_korzinka[i] + "  ");
            }
        }
        Console.SetCursorPosition(0, 50);  
        for (int i = 50; i < Console.WindowHeight; i++)
        {
            Console.WriteLine(new string(' ', Console.WindowWidth));  
        }
        Console.Clear();
        goto start;
       
    }

}

