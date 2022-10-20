namespace TypyDanych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1) Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane
               które chcesz przetrzymywać to:
                a. Imię,
                b. Nazwisko
                c. Wiek
                d. Płeć (‘m’ albo ‘k’)
                e. PESEL
                f. Numer pracownika (np. 2509324094)
               Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje */

            Console.WriteLine("Ex. 1:\r\n");

            string name;
            string lastName;
            int age;
            bool isMale;
            string pesel;
            string employeeId;

            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Male? (true or false)");
            isMale = bool.Parse(Console.ReadLine());
            Console.WriteLine("PESEL number:");
            pesel = Console.ReadLine();
            Console.WriteLine("Employee ID:");
            employeeId = Console.ReadLine();

            /* 2) Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
               odwrotnej kolejności niż zostały zadeklarowane */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 2:\r\n");

            char firstLetter = 't';
            char secondLetter = 'o';
            char thirdLetter = 'd';

            Console.WriteLine($"{firstLetter} {secondLetter} {thirdLetter}\r\n");

            /* 3) Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
               przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow()) */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 3:\r\n");

            double width, height, result;

            Console.WriteLine("Insert width of a rectangle:");
            width = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert height of a rectangle:");
            height = double.Parse(Console.ReadLine());
            
            result = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            
            Console.WriteLine($"Rectange diagonal equals: {result}");

            /* 4) Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
               przypiszesz im następujące wartości:
               a. 10
               b. Szkoła Dotneta
               c. 12,5
               Pamiętaj o użyciu poprawnych typów danych. */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 4:\r\n");

            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            Console.WriteLine($"{a} \r\n{b} \r\n{c}");

            /* 5) Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
               numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej)
               i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
               typDanych.Parse(odpowiedźOdUżytkownika). */

            Console.WriteLine("\r\n*****************************");
            Console.WriteLine("\r\nEx. 5:\r\n");

            Console.WriteLine("Enter your name:");
            string yourName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int yourAge = int.Parse(Console.ReadLine());
            if (yourAge <= 0)
            {
                Console.WriteLine("You have entered wrong value of age :(");
            }
            Console.WriteLine("Enter your weight:");
            double yourWeight = double.Parse(Console.ReadLine());
            if (yourWeight <= 0)
            {
                Console.WriteLine("You have entered wrong value of weight :(");
            }
            Console.WriteLine("Enter your PESEL:");
            string yourPesel = Console.ReadLine();

            if (yourPesel.Length > 11)
            {
                Console.WriteLine("You have entered too much digits :(");
            }
            else if (yourPesel.Length < 11)
            {
                Console.WriteLine("You have entered too little digits :(");
            }
            else
            {
                Console.WriteLine(pesel);
            }

            Console.ReadKey();
        }
    }
}