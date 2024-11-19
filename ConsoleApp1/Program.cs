namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rozpoczynam sprawdzian)");
            Zadanie_5_6();
            Console.WriteLine("Kończę sprawdzian.");
        }

        static void Zadanie_1()
        {
            Console.WriteLine("Rozpoczynam zadanie 1");
            int a = 11;
            int b = 123;
            // tutaj rozwiązanie zadania 1
            while (b <= a) {
                if (b % 3 == 0){
                    Console.WriteLine(b);
                }
            }

            Console.WriteLine("Kończę zadanie 1");
        }
        static void Zadanie_2()
        {
            Console.WriteLine("Rozpoczynam zadanie 2");
            // zadanie numer 2
            // zaimplementuj poniższą procedurę
            static void PrintTriangle(int i)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(new string('$', i);
                }
            static void Main(string args)
                {
                    Console.Write("Podaj wysokość trójkąta:");
                    if (int.TryParse(Console.ReadLine(), out i))
                    {
                        PrintTriangle(i);
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowa wartość");
                    }
                }


            Console.WriteLine("Kończę zadanie 2");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Rozpoczynam zadanie 3");
            DateTime today = DateTime.Now;
            int hour = today.Hour;
                DayOfWeek dayOfWeek = today.DayOfWeek;
                int dayNumber = (int)dayOfWeek + 1;

           string txt;
           if(hour > 12  )
                {
                    txt = "Dzień dobry";
                }else if(hour < 12 )
                {
                    txt = "Dobry wieczór";
                }
                Console.WriteLine($"{txt}, dzisiaj jest {dayOfWeek}, czyli {dayNumber} dzień tygodnia");
          
            // tutaj rozwiązanie zadania 3
            string finalText = "";
            Console.WriteLine(finalText);


            Console.WriteLine("Kończę zadanie 3");
        }
        static void Zadanie_4()
        {
            Console.WriteLine("Rozpoczynam zadanie 4");
            double[] numbers = { 1.5, -2.22, 4.56, -7, 8.01, 0.0 };

            // zadanie numer 4
            // zaimplementuj poniższą funkcję
            static double FindMaxAbsoluteValue(double[] args)
                {
                    double maxAbsoluteValue = 0.0;
                    double result = 0.0;
                    double maxAbsolute = FindMaxAbsoluteValue(numbers);
                    foreach (double number in numbers) {
                        double absValue = Math.Abs(number){


                            if (absValue > maxAbsoluteValue)
                            {
                                maxAbsoluteValue = absValue;
                                result = number;
                            }
                        }
                        return result;
                    }
                }



            Console.WriteLine("The MIN value = " + FindMaxAbsoluteValue(numbers));
            Console.WriteLine("Kończę zadanie 4");
        }
        static void Zadanie_5_6()
        {
            // tutaj rozwiązanie zadań 5 oraz 6
            // można modyfikować, zmieniać kolejność itp.
            Console.WriteLine("Rozpoczynam pętlę.");

            Console.WriteLine("Podaj numer zadania od 1 do 4, które mam wyświetlić.");
                try
                {
                    string txt = Console.ReadLine();
                    int number = int.Parse(txt);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie można przekonwertować na liczbę całkowitą.");
                }
            Zadanie_1();
            Zadanie_2();
            Zadanie_3();
            Zadanie_4();


                // else(txt = 0)
                //break;
            Console.WriteLine("Kończę pętlę.");
        }

    }
}