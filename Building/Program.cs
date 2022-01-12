/*g System;

namespace Building
{
    class Building
    {
        // Constructer Create Program 
        /*public int Floore;
        public int Area;
        public int Occupants;
        public int Function()
        {

            return Area / Occupants; 
        }
        public  Building(int f, int a,int o)
        {
            Floore = f;
            Area = a;
            Occupants = o;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2,2500,4);
            Building office = new Building(3,4200,25);
            Building School = new Building(4, 5000, 30);
            int AreaPP;
           
          
            AreaPP = house.Function();
            Console.WriteLine("House Has\n" + house.Floore + "\tFloore\n" + house.Area + "\tTotal Area\n " + house.Occupants + "\tOccupants\n" + AreaPP + "Per Person ");
            house.Function();
             AreaPP = office.Function();
            Console.WriteLine("office Has\n" + office.Floore + "\tFloore\n" + office.Area + "\tTotal Area\n " + office.Occupants + "\tOccupants\n"+AreaPP+"Per Person " );
            Console.WriteLine("office Has\n" + School.Floore + "\tFloore\n" + School.Area + "\tTotal Area\n " + School.Occupants + "\tOccupants\n" + AreaPP + "\tPer Person ");
        */
/*
// Destructer Create Pergram
public int hight;
public int width;

public Building(int w, int h)
{
    hight = h;
    width = w;
}
public int area()
{
    return width * hight;
}
internal class Program
{
    static void Main(string[] args)
    {
        Building ob = new Building(10, 20);
        Building ob1 = new Building(12, 20);
        Console.WriteLine("Total Area " + ob.area());
        Console.WriteLine("Total Area " + ob1.area());

    }
}

// How to Print Array Element Using Dotnet 
internal class Program
{
 static void Main(String [] agr)
    {
        int[] sample = new int[10];
        int i;
        for(i=0;i<11;i++)
        {
            sample[i] = i;
            Console.WriteLine("[" + i + "]" + sample[i]);
        }
    }

  }

// How to Create Two D Array Using For Loops 
internal class Program
{
    static void Main(String[] ager)
    {
        int[,] sample = new int[5, 6];

        for(int t=0;t<5;t++)
        {
            for (int i = 0; t < 6; i++)
            {
                sample[t, i] = (t * 4) + i + 1;
                Console.Write("Sample Array Table\n"+ sample[t, i]);
            }
            Console.WriteLine(t);
        }


    }
}
}
}

// How Create Array Squares Any Number
using System;
class Squares
{
    static void Main()
    {
        int[,] sqrs = {
 { 1, 1 },
 { 2, 4 },
 { 3, 9 },
 { 4, 16 },
 { 5, 25 },
 { 6, 36 },
 { 7, 49 },
 { 8, 64 },
 { 9, 81 },
 { 10, 100 }
 };
        int i, j;
        for (i = 0; i <20:i++)
        {
            for (j = 0; j < 4; j++)
                Console.Write(sqrs[i, j] + " ");
            Console.WriteLine();
        }
    }
}

using System;
class Program
{
    static void Main(String[] arge)
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;
        Console.WriteLine("Enter the Array Size Value");
        int n = Convert.ToInt32(Console.ReadLine());
        // store Value in ONE 
        for (i = 0; i < n; i++)
        {
            jagged[0][i] = i;
        }
        // storeValue in Seconds 
        for (i = 0; i < 3; i++)
        {
            jagged[1][i] = i;
        }
        // Store Value in Third Array
        for (i = 0; i < 5; i++)
        {
            jagged[2][i] = i;
        }
        // Display Value 
        for (i = 0; i < 4; i++)
        {
            Console.Write(jagged[0][i] + "  ");
        }
        Console.WriteLine();
        for (i = 0; i < 3; i++)
        {
            Console.Write(jagged[1][i] + "  ");
        }
        Console.WriteLine();
        for (i = 0; i < 5; i++)
        {
            Console.Write(jagged[2][i] + "  ");
        }
        Console.WriteLine();
    }
}

//How Arguments Are Passed
using System;
 
    class Test
    {
        public void NoChanged(int i, int j)
        {
            i = i + j;
            j = -j;

        }
    }
class Program {
    static void Main(String [] agre)
    {
        Test ob = new Test();
        int a = 15, b = 20;
        Console.WriteLine("a and b before call: " +
 a + " " + b);
        ob.NoChanged(a, b);
        Console.WriteLine("a and b after call: " +
  a + " " + b);
    }
}

// Write A Program Ref By Value 
using System;
class Test
{
    public void sqr(ref int i)
    {
        i = i * i;
    }
}
class Program
{
    static void Main(String [] arge)
    {
        Test ob = new Test();
       int a=5;
        Console.WriteLine("BeforeValue " + a);
        ob.sqr(ref a);
        Console.WriteLine("After Value " + a);
    }
}
*/
using System;
class TestValue
{
    public void Swapvalue(ref int a, ref int b)
    {
        int t;
        t = a;
        a = b;
        b = t;

    }

}
class Program
{
    static void Main(String [] age)
    {
        TestValue ob = new TestValue();
        int x = 10, y = 20;
        Console.WriteLine("Before value X And Y" + x + " " + y + " ");
        ob.Swapvalue(ref x, ref y);
        Console.WriteLine(" value X And Y" + x + " " + y + " ");
    }
}