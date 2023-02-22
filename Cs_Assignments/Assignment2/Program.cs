
using Assignment2;
using System.Net.Sockets;
//Note: Will use correct method naming conventions next Assignment, did not learn until now

//1
CopyArray ca = new CopyArray();
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] copy = ca.copyArray(arr);
Console.WriteLine($"Original Array: {arr}");


Console.WriteLine($"Copy Array: {copy}");


//3
//FindPrimesInRange fp = new FindPrimesInRange();
int[] primes = FindPrimesInRange.findPrimesInRange(1, 15);
for (int i = 0; i < primes.Length; i++)
{
    Console.Write($"{primes[i]} ");
}
Console.WriteLine();

//4
RotatedSum rs = new RotatedSum();
int[] sums = rs.rotatedSum();

for (int i = 0; i < sums.Length; i++)
{
    Console.Write($"{sums[i]} ");
}
Console.WriteLine();

//5
LongestSequence ls = new LongestSequence();
ls.longestSequence();

//7



//Strings

//1 
ReverseString revstr = new ReverseString();
revstr.reverseString();

//2
ReverseSentence revsen = new ReverseSentence();
revsen.reverseSentence();

//3 Console.WriteLine(sbyte.MaxValue);
AllPalindromes ap = new AllPalindromes();
string input = "Hi, exe? ABBA! Hog fully a string: ExE.Bob";
ap.allPalindromes(input);

//4

string urlstr = "https://www.apple.com/iphone";
string urlstr2 = "www.apple.com";
string urlstr3 = "www.apple.com/iphone";
ParseURL ps = new ParseURL();
ps.parseURL(urlstr3);



