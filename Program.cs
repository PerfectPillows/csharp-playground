using leetcode.arrays_and_hashing;
using leetcode.practice;

EncodeDecodeStrings obj = new EncodeDecodeStrings();

List<string> strings = new List<string>{ "leet", "code", "loves", "you" };

Console.WriteLine(obj.encode(strings)); 
foreach(string s in obj.decode(obj.encode(strings))) {
    Console.WriteLine(s);
}


var str = "Hello World Sayani Sen";

ReverseWords rw = new ReverseWords();
Console.WriteLine(rw.Solution(str));
