//Console.Write("Enter the number: ");
//int number = int.Parse(Console.ReadLine());
//int i = 1;
//
//while (i <= number){
//    Console.WriteLine(i * i);
//    i+=1;
//}

//Console.Write("Enter the number: ");
//int number = int.Parse(Console.ReadLine());
//Console.Write("Squares of number: ");
//
//for (int i = 0, i < number, i++) {
//    Console.Write(Math.Pow(i+1, 2));
//}



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] squares = new int[number];  // решение через массивы
Console.Write("Таблица квадратов: ");
for (int i = 0; i < number; i++){
    squares[i] = (i + 1)*(i + 1);
    Console.Write($"{squares[i]} ");
}