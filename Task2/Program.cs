// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Ведите первое число: ");
int first_Num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число: ");
int second_Num = Convert.ToInt32(Console.ReadLine());

if(first_Num > second_Num) {
    Console.WriteLine("Число " + first_Num + " больше числа " + second_Num);
}else if(first_Num < second_Num) {
    Console.WriteLine("Число " + second_Num + " больше числа " + first_Num);
}else if(first_Num == second_Num){
    Console.WriteLine("Число " + second_Num + " равно числу " + first_Num);
}else{
    Console.WriteLine("Error");
}

