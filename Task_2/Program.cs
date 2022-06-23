// Console.WriteLine("Enter the number from 1 to 4: ");
// int quarter = int.Parse(Console.ReadLine());
// 
// if (quarter == 1) {
//     Console.WriteLine("x > 0, y > 0");
// } 
// else if (quarter == 2) {
//     Console.WriteLine("x < 0, y > 0");
// }
// else if (quarter == 3) {
//     Console.WriteLine("x < 0, y < 0");                     // условие else if необходимо для последнего else
// }
// else if (quarter == 4) {
//     Console.WriteLine("x > 0, y < 0");
// }
// else {
//     Console.WriteLine("This quater doesn't exist");
// }


string[] ranges = {    // строчный массив в виде диапазонов, по номеру ячейки будет выдаваться нужный диапозон
    "x > 0, y > 0",    // ячейка = номеру диапазона
    "x < 0, y > 0",
    "x < 0, y < 0",
    "x > 0, y < 0"
};

Console.WriteLine("Enter the number from 1 to 4: "); // диапазон ввода от 1 до 4
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ranges[quater-1]); //для совпадения по диапазонам нужно отнять единицу