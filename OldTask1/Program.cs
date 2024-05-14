using System;

namespace OldTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DollarVSManat
            //while (true)
            //{
            //    double azn;
            //    Console.WriteLine("Nece Manat");
            //    azn = Convert.ToDouble(Console.ReadLine());

            //    double change = 0.59;

            //    double usd = azn * change;

            //    Console.WriteLine($"{azn}<=>AZN, {usd}<=>USD ya beraberdi");
            //}

            //while (true)
            //{
            //    double usd;
            //    Console.WriteLine("Nece Dollar");
            //    usd = Convert.ToDouble(Console.ReadLine());

            //    double change = 1.70;

            //    double azn = usd * change;

            //    Console.WriteLine($"{usd}<=>USD {azn}<=>AZN ne berabedrdi");

            //}
            #endregion

            #region YasVeGenderSecimi
            //while (true)
            //{
            //    Console.WriteLine("Yaşınızı yazin:");
            //    if (int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        if (age % 2 == 0)
            //        {
            //            Console.WriteLine("Cut yaş.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tek yaş.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Normal sayi gir blet");
            //    }
            //}
            #endregion

            #region GenderYas
            //while (true)
            //{
            //    Console.WriteLine("Yaşınızı yazın:");
            //    if (int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        Console.WriteLine(" (Qadin = 'Q', Kisi = 'K'):");
            //        string gender = Console.ReadLine().ToUpper(); 

            //        if (age > 18)
            //        {
            //            if (gender == "Q")
            //            {
            //                Console.WriteLine("Oooo chox qesexsizzz");
            //            }
            //            else if (gender == "K")
            //            {
            //                Console.WriteLine("Get REddol iciri");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Peteneysen bala sen");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Get sudunu iç.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Yaivi de ala beynimi xarab eleme ");
            //    }
            //}
            #endregion

            #region
            //while (true)
            //{
            //    Console.WriteLine("Yasini gir Xanim");
            //    if (int.TryParse(Console.ReadLine(), out int age))
            //    {
            //        if (age>18)
            //        {
            //            Console.WriteLine("Uni telebesi");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Mektebli usag");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine( "Yasini duzgun qeyd et");
            //    }
            //}
            #endregion

            #region reqemlerinYeriniDeyise
            //int a = 5;
            //int b = 6;

            //Console.WriteLine("Evvel");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            ////5 + 6 = 11;
            ////a oldu 11
            ////11-5=6
            //// b oldu 6
            //// 11-6=5
            //// a oldu 5
            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine("Sonra:");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            #endregion

            #region reqeminKvadratiIkiReqemArasindaTap
            //int a = 6;
            //if (20<(a*a) && (a*a)<50)
            //{
            //    Console.WriteLine("Ededler arasindadi");
            //}
            //else
            //{
            //    Console.WriteLine("Deyil");
            //}
            #endregion

            #region VerilmishReqeminCemini
            //int a = 123;
            //int num1 = a % 10;  //3
            //int num2 = (a / 10)%10;  //2
            //int num3 = a /100; //1
            //Console.WriteLine(num1+num2+num3);
            #endregion

            #region Int32TryParse
            //string input =Console.ReadLine();
            //int num=Int32.Parse(input);
            //Console.WriteLine(input+20); 
            //Console.WriteLine(num+20);


            //Console.WriteLine( "Tevelludu yaz");
            //string input=Console.ReadLine();
            //int tv=Int32.Parse(input);
            //Console.WriteLine($" Yas {2024-tv}");

            //while (true)
            //{
            //    Console.WriteLine("Tevelludu yazin:");

            //    if (int.TryParse(Console.ReadLine(), out int num))
            //    {
            //        Console.WriteLine($"Yas {2024-num}");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Duzgun eded daxil et");
            //    }
            //}

            //int num;
            //int num2;
            //Console.WriteLine("1ci reqem");
            //bool result = Int32.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine("2ci reqem");
           
            //bool result2 = Int32.TryParse(Console.ReadLine(), out num2);
            // if (result==false  || result2==false)
            //{
            //    Console.WriteLine("Duzgun reqem daxil et");
            //}
            // else
            //{
            //    Console.WriteLine($"Cem {num + num2}");
            //}


            #endregion

            int a=5; int b=5;



        }
    }
}
