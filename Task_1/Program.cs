int [] coordinate = new int [2]; // new int [2] - это две координаты х и у

Console.Write("Enter coordinate X: ");
coordinate[0] = int.Parse(Console.ReadLine());

Console.Write("Enter coordinate Y: ");
coordinate[1] = int.Parse(Console.ReadLine());

if (coordinate[0] > 0 & coordinate[1] > 0) {
    Console.Write("It's the first quater");
}
if (coordinate[0] < 0 & coordinate[1] > 0) {
    Console.Write("It's the second quater");
}
if (coordinate[0] < 0 & coordinate[1] < 0) {
    Console.Write("It's the third quater");
}
if (coordinate[0] > 0 & coordinate[1] < 0) {
    Console.Write("It's the forth quater");
}
