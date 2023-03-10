try
{
    Console.Write("введите 1 год ");
    double year = Convert.ToDouble(Console.ReadLine());
    if (year <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");
    Console.Write("введите 1 месяц ");
    double month = Convert.ToDouble(Console.ReadLine());
    if (month <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");
    Console.Write("введите 1 день ");
    double day = Convert.ToDouble(Console.ReadLine());
    if (day <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");

    Console.Write("введите 2 год ");
    double year2 = Convert.ToDouble(Console.ReadLine());
    if (year2 <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");
    Console.Write("введите 2 месяц ");
    double month2 = Convert.ToDouble(Console.ReadLine());
    if (month2 <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");
    Console.Write("введите 2 день ");
    double day2 = Convert.ToDouble(Console.ReadLine());
    if (day2 <= 0)
        throw new DivideByZeroException("не может быть меньше или равно нуля");

    double year3 = year - year2;
    double month3 = month - month2;
    double day3 = day - day2;
    if (year3 <= 0)
    {
        throw new Exception("время нельзя повернуть в спять");
    }
    else
    {
        Console.WriteLine("разница в днях: ");
        double daystotal = Convert.ToDouble((year3 - year * 365) + (month3 - month * 30) + (day3 - day * 1));
        Console.WriteLine(daystotal);
    }
}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}
