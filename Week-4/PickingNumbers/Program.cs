using PickingNumbers;

var n = Console.ReadLine();
var stringArr = Console.ReadLine()?.Split(' ');
if (stringArr != null)
{
    var list = Array.ConvertAll(stringArr, int.Parse).ToList();
    var res = Result.pickingNumbers(list);
    Console.WriteLine(res);
}