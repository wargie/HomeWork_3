﻿//22.Найти расстояние между точками в пространстве 2D/3D
char selection;
Double x1, x2, y1, y2, z1, z2, distance;
    Console.WriteLine("1. Расстояние между двумя точками на плоскости");
    Console.WriteLine("2. Расстояние между двумя точками в пространстве");
    Console.WriteLine("Выберите нужный пункт (1 или 2):");
        
        selection = Convert.ToChar(Console.ReadLine());
        
        switch (selection)
        {
            case '1':
                
                Console.Write("Введите координаты точки x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты  точки y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
                
                break;
            
            case '2':
                
                Console.Write("Введите координаты точки x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки z1: ");
                z1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты точки z2: ");
                z2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                
                
                break;
            default:
                
                Console.WriteLine("Введён неверный символ!");
                
                break;
        }