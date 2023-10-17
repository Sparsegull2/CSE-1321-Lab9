/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab9A
*/

using System;

class Lab9A
{

    public static void Main(string[] args)
    {
        int[] list=new int[10];
        Console.WriteLine("Please enter 10 numbers:");
        for(int i=0; i<list.Length; i++)
        {
            Console.Write("Integer "+ (i + 1)+": ");
            list[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nWhat is the target number: ");
        int target=int.Parse(Console.ReadLine());
        bool exist=false;
        foreach(int num in list)
        {
            if (target == num)
            {
                exist = true;
                
                break;
            }
        }
        if (exist == true) Console.WriteLine("\nThe target is in the set.");
        else Console.WriteLine("\nThe target is not in the set.");
    }
}
