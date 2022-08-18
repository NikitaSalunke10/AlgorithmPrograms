Console.Write("Enter first string: ");
string str1 = Console.ReadLine();
Console.Write("Enter second string: ");
string str2 = Console.ReadLine();
char[] ch1 = str1.ToLower().ToCharArray(); // converting the string in lower case and into array
char[] ch2 = str2.ToLower().ToCharArray(); 
Array.Sort(ch1); //sort method is used to arrange alphabets in ascending order
Array.Sort(ch2);
str1 = new string(ch1); //the char array is store in the string
str2 = new string(ch2);
if(str1.Equals(str2)) //if condititon is true it means both strings are equal and below message is printed
{
    Console.WriteLine("Both strings are Anagram");
}
else
{
    Console.WriteLine("Both strings are not Anagram");
}