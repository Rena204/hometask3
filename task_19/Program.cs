Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n >= 10000)
    {
        int d = n / 10000;
        int r = n % 10;
 
            if(d == r)
            {
                n = n / 10;
                int d2 = (n / 100) % 10;
                int r2 = n % 10;
                if(d2 == r2)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
    }
