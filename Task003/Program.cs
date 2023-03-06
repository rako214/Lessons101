// 3. Напишите программу, которая выдаёт название дня недели по заданному номеру.

var daysOfWeek = new Dictionary<int, string>(){
    {1, "Понедельник"},
    {2, "Вторник"},
    {3, "Среда"},
    {4, "Четверг"},
    {5, "Пятница"},
    {6, "Суббота"},
    {7, "Воскресенье"}
};

string returnDayByNumber(int numberOfDay){
    return $"Сегодня {daysOfWeek[numberOfDay]}";
}

Console.WriteLine("Введите номер дня недели (1 - 7): ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(returnDayByNumber(numberOfDay));