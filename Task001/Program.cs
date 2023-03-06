// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго

static string isSquare(int firstNumber, int secondNumber){
    if(firstNumber == secondNumber * secondNumber){
        return $"{firstNumber} является квадратом {secondNumber}";
    }
    else return $"{firstNumber} не является квадратом {secondNumber}";
}

Console.WriteLine("Введите два целых числа чтобы проверить, является ли первое число квадратом второго: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isSquare(firstNumber, secondNumber));
