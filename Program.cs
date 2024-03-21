using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        ReorderPowerOf2 reorderPowerOf2 = new ReorderPowerOf2();
        Console.WriteLine(reorderPowerOf2.ReorderCount(10));
        Console.ReadLine();
    }
}