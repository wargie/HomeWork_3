//24. Найти кубы чисел от 1 до N
Console.Write("Число N: ");

int maxNum = Convert.ToInt32(Console.ReadLine());
int count = 1;

    while (count < maxNum)

        {
            Console.WriteLine(count * count * count + " ");
            count++;
        }