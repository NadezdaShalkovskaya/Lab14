try
{

    Console.Write("Введите номер месяца (от 1 до 12): ");

    
    int month;

    
    bool isValidInput = int.TryParse(Console.ReadLine(), out month);

    if (!isValidInput || month < 1 || month > 12)
    {
        Console.WriteLine("Некорректный номер месяца. Пожалуйста, введите число от 1 до 12.");
        return;
    }

    
    string season;

    if (month >= 3 && month <= 5)
    {
        season = "весна";
    }
    else if (month >= 6 && month <= 8)
    {
        season = "лето";
    }
    else if (month >= 9 && month <= 11)
    {
        season = "осень";
    }
    else // месяц 12, 1, 2
    {
        season = "зима";
    }

    
    Console.WriteLine($"Сезон: {season}");

}
catch 
{
    Console.WriteLine("Error");
}