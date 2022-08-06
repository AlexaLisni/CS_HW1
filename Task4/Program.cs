// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Ведите первое число: ");
int first_Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");
int second_Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите третье число: ");
int third_Num = Convert.ToInt32(Console.ReadLine());

int max = 0;

if(first_Num >= second_Num){
     max = first_Num;
}else {
     max = second_Num;
}

if(max <= third_Num){
     max = third_Num;
}
Console.WriteLine("Наибольшее веденное число = " + max);
