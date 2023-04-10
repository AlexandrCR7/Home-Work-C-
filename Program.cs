//  Напишите программу, которая на вход принимает
//  два числа и выдаёт максимальное.

// System.Console.WriteLine("Введите первое число: ");
// int i = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int x = int.Parse(Console.ReadLine());
// if(i > x){
//     System.Console.WriteLine("Максимальное число = " + i);
// }
// else{
//     System.Console.WriteLine("Максимальное число = " + x);
// }


//------------------------------------------------------------


//  Напишите программу, которая на вход принимает
//  три числа и выдаёт максимальное.

// System.Console.WriteLine("Введите первое число: ");
// int first = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int second = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int third = int.Parse(Console.ReadLine());

// if(first > second && first > third){
//         System.Console.WriteLine("Максимальное число " + first);
//     }

// else if(second > third){
//     System.Console.WriteLine("Максимальное число " + second);
//     }

// else{
// System.Console.WriteLine("Максимальное число " + third);
// }

// ---------------------------------------------------------

//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)

// System.Console.WriteLine("Введите первое число: ");
// int i = int.Parse(Console.ReadLine());
// if(i % 2 == 0){
//     System.Console.WriteLine("Это четное число");
// }
// else{
//     System.Console.WriteLine("Это нечетное число");
// }

//----------------------------------------------------------

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i < N){
     if(i % 2 == 0)
     System.Console.Write(i + ", ");
     i++;
}

