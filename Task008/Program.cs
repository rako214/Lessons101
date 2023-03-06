// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Здесь я понял что в цикле можно добавить доп инкремент/декремент, если мы уже на чётном числе. Проверял на вводе 1 000 000
// с помощью класса StopWatch:
// 00:00:27.0770471 00:00:28.0858527 с доп инкр/декр 1 000 000
// 00:00:28.6691101 00:00:29.5755236 без             1 000 000

static void printEvenNumbersToN(int inputNumber){
    if(inputNumber > 0){
	for (int i = 1; i <= inputNumber; i++){
		if(i % 2 == 0){
			Console.Write($"{i} ");
            i++; // доп инкремент
		}
	}
}
else if (inputNumber <= 0){
	for (int i = 1; i >= inputNumber; i--){
		if(i % 2 == 0 & i != 0){
			Console.Write($"{i} ");
            i--; // доп декремент
		}
	}
}
}
Console.WriteLine("Введите число, чтобы программа вывела все чётные числа до него: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
printEvenNumbersToN(inputNumber);

