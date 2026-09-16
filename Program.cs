using System.Text;

const string TxtPath = "..\\..\\..\\data\\titanic.txt";

List<Category> categories = [];
using StreamReader sr = new(TxtPath, encoding: Encoding.UTF8);
while (!sr.EndOfStream) categories.Add(new(sr.ReadLine()));

Console.WriteLine($"állományban található kategóriák száma: {categories.Count} db");

var allPpl = categories.Sum(c => c.Survivors + c.Missing);
Console.WriteLine($"az állományban szereplő személyek száma: {allPpl} fő");

Console.Write("írja be a keresett kategórianév egy részét: ");
string seachStr = Console.ReadLine() ?? throw new Exception("Ne hagyd üresen!");

Console.WriteLine(
    categories.Any(c => c.Name.Contains(seachStr)) 
    ? "\tvan találat!"
    : "\tnincs találat!");