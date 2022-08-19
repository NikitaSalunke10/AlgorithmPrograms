using AlgorithmPrograms;

float ans;
int[] arr = new int[168];
int j=0;
Console.WriteLine("Prime numbers are: ");
for(int num = 0; num <= 1000; num++)// this for loop is to find primt number from 0-1000
{
    int flag = 0;
    if (num == 0 || num == 1) //this if is used to skip 0 and 1 
        continue;
    for (int i = 2; i <= num/2; i++) 
    {
        ans = num % i;// remainder is calculated 
        if (ans == 0)// check whether remainder is 0 or not if yes then value of count is set to 1 and come out of this for loop
        {
            flag = 1;
            break;
        }
    }
    if(flag == 0) // if count value remains 0 then the number is a prime number
    {
        //Console.WriteLine(num);
        arr[j] = num;
        j++;
    }    
}
for (int i = 0; i < arr.Length; i++)
{
    FindAnagramPalindrome.findPalindrome(arr[i]);
    //FindAnagramPalindrome.findAnagram(arr, arr[i]);
}