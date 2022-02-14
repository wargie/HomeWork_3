//18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool X = true;
bool Y = true;
    if (!(X && Y) == (!X || !Y))
        { 
            Console.WriteLine("Утверждение истинно");
        }
    else
        {
            Console.WriteLine("Утверждение не истинно");
        }