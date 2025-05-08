// See https://aka.ms/new-console-template for more information

Console.WriteLine("My Set Class");

var s = new MySet.MySetArray();
// var s = new MySet.MySetList();

s.Add(19);
s.Add(29);
s.Add(39);

Console.WriteLine($"Size of set = {s.Size()}");
Console.WriteLine($"is 5 in the set = {s.Contains(5)}");
Console.WriteLine($"is 29 in the set = {s.Contains(29)}");

s.Remove(99);
s.Remove(29);

s.Add(191);
s.Add(291);
s.Add(391);

s.Add(2);
s.Add(21);
s.Add(22);
s.Add(23);
s.Add(24);
s.Add(25);
s.Add(26);
s.Add(27);


// Console.WriteLine($"Removed value 29");
// Console.WriteLine($"Size of zet = {s.Size()}");
// Console.WriteLine($"is 29 in the set = {s.Contains(29)}");
