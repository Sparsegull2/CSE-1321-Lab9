/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab9B
*/

using System;

class Lab9B
{

    public static void Main(string[] args)
    {
        int[] list = new int[11];
        Console.WriteLine("Please enter 11 numbers:");
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write("Integer " + (i + 1) + ": ");
            list[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nWhat is the target number: ");
        int target = int.Parse(Console.ReadLine());
        bool exist = false;
        int temp;
        for (int j=0;j<list.Length-1;j++)
        {
            for (int k=0;k<list.Length-j-1;k++) 
            { 
                if (list[k] > list[k + 1])
                {
                    temp = list[k];
                    list[k] = list[k + 1];
                    list[k + 1] = temp;
                } 
            }
        }
        Console.Write("\nThe sorted set is: ");
        foreach (int i in list)
        {
            Console.Write(i+" ");
        }
        int mid, high=list.Length-1, low=0;
        
        while (high >= low)
        {
            mid = (high + low) / 2;
            Console.WriteLine("\nLow is "+low);
            Console.WriteLine("\nHigh is "+high);
            Console.WriteLine("\nMid is "+mid);
            Console.WriteLine("\nSearching");
            if (list[mid] == target)
            {
                exist= true;
                break;
            }
            else if (target<list[mid])
            {
                high= mid-1;
            }
            else
            {
                low = mid + 1;
            }
        }
        if (exist == true) Console.WriteLine("\nThe target is in the set.");
        else Console.WriteLine("\nThe target is not in the set.");
    }
}
