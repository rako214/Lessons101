// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

static string isEven(int inputNumber ){
    if(inputNumber % 2 == 0){
        return $"{inputNumber} — чётное.";
    }
    else {
        return $"{inputNumber} — НЕчётное.";
    }
}
Console.WriteLine("Введите целое число, чтобы проверить является ли оно чётным: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(isEven(inputNumber));
