using leetcode.arrays_and_hashing;
var obj = new EncodeDecodeStrings();

List<string> strings = new List<string>{ "leet", "code", "loves", "you" };

Console.WriteLine(obj.encode(strings)); 
foreach(string s in obj.decode(obj.encode(strings))) {
    Console.WriteLine(s.To);
}
string