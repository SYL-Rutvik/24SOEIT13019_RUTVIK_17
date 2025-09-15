using System;

class Demo
{
    private int n1;
    static int n2 = 20;

    
    public Demo(int num1)
    {
        n1 = num1;
    }

   
    public int N1
    {
        get { return n1; }
        set { n1 = value; }
    }

    public static int N2
    {
        get { return n2; }
        set { n2 = value; }
    }

    
    public int Add()
    {
        return n1 + n2;
    }

    public int Multiply()
    {
        return n1 * n2;
    }
}

class task_7
{
    static void Main(string[] args)
    {
        Demo obj = new Demo(10); 

        Console.WriteLine("Addition = " + obj.Add());       
        Console.WriteLine("Multiplication = " + obj.Multiply()); 
    }
}
