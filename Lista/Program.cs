using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Pedro");
list.Add("Davi");
list.Insert(2, "Anna");

foreach(string obj in list){
    Console.WriteLine(obj);
}
Console.WriteLine("List Count: " + list.Count);

static  bool Test(string s){
    return s[0] == 'A';
}

string s1 = list.Find(Test);
Console.WriteLine("First 'A': " + s1);

string s2 = list.FindLast(x => x[0] == 'A'); // Mesma função da de cima;
Console.WriteLine("Last 'A': " + s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("First position 'A': " + pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position 'A': " + pos2);

List<string> list2 = list.FindAll(x => x.Length == 5);
Console.WriteLine("----------------------------------")
foreach(string obj in list2){
Console.WriteLine("Names with five latters: " + obj);
}

list.Remove("Alex");
Console.WriteLine("----------------------------------")
foreach(string obj in list){
Console.WriteLine("Remove name Alex: " + obj);
}

list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("----------------------------------")
foreach(string obj in list){
Console.WriteLine("Remove all names with the latter 'M': " + obj);
}

list.RemoveAt(3);
Console.WriteLine("----------------------------------")
foreach(string obj in list){
Console.WriteLine("Remove name Alex: " + obj);
}

list.RemoveRange(2, 2);
Console.WriteLine("----------------------------------")
foreach(string obj in list){
Console.WriteLine("Remove two position, two names: " + obj);
}