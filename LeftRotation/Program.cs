using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        int rotations = d % arr.Count;
        for (int rotation = 0; rotation < rotations; rotation++)
        {
            int firstNum=arr[0];
           
            for (int j = 1; j < arr.Count; j++)
            {
                arr[j-1]= arr[j];
            }
            arr[arr.Count-1]= firstNum;
        }
        return arr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
         List<int> list = new List<int> { 1, 2, 3, 4, 5 };
       List<int> otherList= Result.rotateLeft(2,list);
        foreach (var item in otherList)
        {
            Console.Write(item);
        }
    }
}
