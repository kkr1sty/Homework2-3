
        Console.Write("Введите ваш вес в килограммах (например, 75,5): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите ваш рост в метрах (например, 1,82): ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Расчёт ИМТ
        double bmi = weight / (height * height);

        // Вывод результата с округлением до двух знаков
        Console.WriteLine($"Ваш индекс массы тела равен: {bmi:F2}");
