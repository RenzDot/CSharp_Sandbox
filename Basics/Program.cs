//Arrays
int[] array = { 12, 3, 4, 5 };
int[] sub = new int[2];
int length = array.Length;
Array.Copy(array, 2, sub, 0, 2);                            //Sub Array {4,5}
Console.WriteLine($"Sub Array: {string.Join(",", sub)}");   //Print array contents with string.join

int[,] matrix1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
int[][] matrix2 = new int[2][] { new int[] { 1, 2 }, new int[] { 1, 2 } };
Console.WriteLine($"matrix[1,0] = {matrix1[1,0]}");

//Lists
var intList = new List<int>() { 1, 2, 3, 4 };
intList.Add(5);
intList.Count();
var subList = intList.GetRange(3,0);
Console.WriteLine($"Sub List: {string.Join(",", subList)}");

//Dictionary
var dict = new Dictionary<string, int>();
dict.Add("One", 1); 
dict.Add("Two", 2);
dict["Two"]++;
int price = dict["Two"];
Console.WriteLine("Dictionary: " + price);

//Strings
string myString = "hello";
myString.Count();
myString.ToLower();
myString.CompareTo("HelLo");
string subString = myString.Substring(3, 2);
Console.WriteLine("Substring: " + subString);
foreach (char c in myString) { /*Do string stuff*/ }

//Parsing
int myInt = 12345;
char[] chars = myInt.ToString().ToCharArray();  //Int -> char[]
String str = myInt.ToString();                  //Int -> String
List<int> list = array.ToList();                //Array -> List
int intFromString = int.Parse(str);             //String -> int
int intFromChar = int.Parse(new string(chars)); //char[] -> int
string strFromChar = new string(chars);         //char[] -> string
array = list.ToArray();                         //List -> Array

//Null Propogation
string? nullString = null;
Console.WriteLine(nullString ?? "null propogation says no");
for (int i = 0; i < length; i++) {}

//Maths
int n = 3;
bool isDivisibleByThree = (n % 3 == 0);
Console.WriteLine(isDivisibleByThree.ToString());
Console.ReadLine();