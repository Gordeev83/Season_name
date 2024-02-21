namespace Season_name
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод даты с клавиатуры
            Console.Write("Введите дату в формате дд.мм.гггг: ");
            string input = Console.ReadLine();

            // Преобразование строки в объект DateTime
            DateTime date;
            if (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date))
            {
                Console.WriteLine("Ошибка ввода даты!");
                return;
            }

            // Определение сезона
            string season;
            switch (date.Month)
            {
                case 1:
                case 2:
                case 12:
                    season = "winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "autumn";
                    break;
                default:
                    Console.WriteLine("Ошибка определения сезона!");
                    return;
            }

            // Определение дня недели
            string dayOfWeek = date.DayOfWeek.ToString().ToLower();

            // Вывод результата
            Console.WriteLine($"{season} {dayOfWeek}");
        }
    }
}
