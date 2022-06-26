namespace MyLib;
using static System.Console;

public class Class1
{
    public static int[] GetRandomArray(int size)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(100);
        }
        return result;
    }

    ///<summary>
    ///Metod2
    ///<summary>
    public static int[] GetRandomArray(int size, int minValue, int maxValue)
    {
        int[] result = new int[size];
        for (int i = 0; i < size; i++)
        {
            result[i] = new Random().Next(minValue, maxValue+1);
        }
        return result;
    }

    ///<summary>
    ///Metod3
    ///<summary>
    public static int[] GetArrayFromString(string arrayStr)
    {
        string[] arS=arrayStr.Split(new String [] {" ", ",", ", "},StringSplitOptions.RemoveEmptyEntries);
        int[] result=new int[arS.Length];
        for(int i=0; i < arS.Length; i++)
        {
            result[i]=int.Parse(arS[i]);
        }
        return result;
    }

    public static void printArray(int[] array) // Печать массива
    {
        Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Write(array[i]);
            Write(i < array.Length-1 ? ", " : "");
        }
        Write("]");
    }

    public static string arrayToString (int[] array) // Печать массива
    {
        string str = "";
        str+="[";
        for (int i = 0; i < array.Length; i++)
        {
             str+=(array[i]);
             str+=(i < array.Length-1 ? ", " : "");
        }
         str+=("]");
     return str;
    }
}
