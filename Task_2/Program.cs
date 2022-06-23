Console.WriteLine("Enter the number from 1 to 4: ");
int quarter = int.Parse(Console.ReadLine());


if (quarter == 1) {
    Console.WriteLine("x > 0, y > 0");
} 
else if (quarter == 2) {
    Console.WriteLine("x < 0, y > 0");
}
else if (quarter == 3) {
    Console.WriteLine("x < 0, y < 0");
}
else if (quarter == 4) {
    Console.WriteLine("x > 0, y < 0");
}
