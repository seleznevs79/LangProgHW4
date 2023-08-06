
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//  Console.Write("Введите первое число: ");
// int A = int.Parse(Console.ReadLine()!);
//  Console.Write("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Результат возведения в степень {B} числа {A} = {GetExp(A)}");


// // // Методы
// int GetExp(int A){
// int exp = 1;

// for(int i = 1; i <= B; i++){
// exp *= A;
// }
// return exp;
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int sum = 0;
// string numstring = num.ToString(); 
// for(int i=0; i< numstring.Length; i++){
//      sum=sum+(numstring[i]-'0');

// }
// Console.WriteLine($"Сумма числа {num} = {sum}");



// С Методом

//  Console.Write("Введите число: ");
//   int num = int.Parse(Console.ReadLine()!);
//   Console.WriteLine($"Сумма числа {num} = {GetSum(num)}");

// // // Методы
//    int GetSum(int num){
//    string numstring = num.ToString(); 
//    int sum=0;
//      for(int i=0; i< numstring.Length; i++){
//        sum=sum+(numstring[i]-'0');
//       }
//     return sum;  
//   }



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(",", array)}]");


//method
int[] GetRange(int size){
int[] massive = new int[size];
for(int i = 0; i < massive.Length; i++){
massive[i] = new Random().Next(0,20);
}
return massive;
}
