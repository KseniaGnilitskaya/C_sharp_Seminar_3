//Console.Write("Enter the number: ");
//int number = int.Parse(Console.ReadLine());
//int i = 1;
//
//while (i <= number){
//    Console.WriteLine(i * i);
//    i+=1;
//}

Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Squares of number: ");

for (int i = 0, i < number, i++) {
    Console.Write(Math.Pow(i+1, 2));
}