// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();

int quarterNumber = new Random().Next(1, 5);
string diapason = "";

switch (quarterNumber)
{
    case 1:
        diapason = "x > 0, y > 0";
        break;
    case 2:
        diapason = "x < 0, y > 0";
        break;
    case 3:
        diapason = "x < 0, y < 0";
        break;
    default:
        diapason = "x > 0, y < 0";
        break;
}

Console.WriteLine($"Для {quarterNumber}-й четверти координаты точки должны находиться в диапазоне: ( {diapason} )");
Console.WriteLine(); //исключительно для удобства чтения :)