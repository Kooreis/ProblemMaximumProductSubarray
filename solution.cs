using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, -2, -3, 0, 7, -8, -2 };
        Console.WriteLine("Maximum Sub array product is " + MaxSubarrayProduct(arr));
    }