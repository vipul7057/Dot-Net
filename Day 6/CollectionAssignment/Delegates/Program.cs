using System;

public delegate void MyDelegate();
public delegate int newDel(int a , int b);
public class Program
{
	public static void Main()
	{
		Demo demo = new Demo();
		MyDelegate del = new MyDelegate(demo.Display);
		del();
		
		del = new MyDelegate(demo.Show);
		del();
		Console.WriteLine(demo.CallFunction(new newDel(demo.add),20,30));
		Console.WriteLine(demo.CallFunction(new newDel(demo.sub),120,20));
		}
}

public class Demo
{
	public void Display()
	{
		Console.WriteLine("Display Function");
	}
	
	public void Show()
	{
		Console.WriteLine("Show Function");
	}
	
	public int add(int a,int b)
	{
		return a+b;
	}
	
	public int sub(int a,int b)
	{
		return a - b;
	}
	
	public int CallFunction(newDel del,int a,int b)
	{
		return del(a,b);
	}
}
