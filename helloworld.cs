/*入门hello world*/
// using System;
// namespace HelloWorldApp
// {
// 	class HelloWorld
// 	{
// 		static void Main(string[] args)
// 		{
// 			Console.WriteLine("Helllo World");
// 			Console.ReadKey();
// 		}
// 	}
// }

/*sizeof使用*/
// using System;

// namespace DataTypeApplication
// {
//    class Program
//    {
//       static void Main(string[] args)
//       {
//          Console.WriteLine("Size of int: {0}", sizeof(int));
//          Console.ReadLine();
//       }
//    }
// }
/*程序结构*/
// using System;	// using关键字，包含命名空间，一个程序可以包含多个using语句
// namespace Animal // namespace声明，包含一系列class类
// {
// 	class AnimalName // class关键字声明一个类
// 	{

// 		string dog;		//成员变量
// 		string cat;
// 		public void SetName()	//成员函数
// 		{
// 			dog="Hely";
// 			cat="Moly";
// 		}
// 		public void getName()	//成员函数
// 		{
// 			Console.WriteLine("Dog's Name {0}",dog);
// 			Console.WriteLine("Cat's Name {0}",cat);
// 		}

// 	}
// 	class AnimalDisplay
// 	{
// 		static void Main(string[] args)
// 		{
// 			AnimalName animal = new AnimalName();	//实例化一个类
// 			animal.SetName();	//调用类函数
// 			animal.getName();
// 			Console.ReadLine();
// 		}
// 	}
// }

//字符类型
// using System;
// namespace TypesLength
// {
// 	class type
// 	{
		
// 		static void Main(string[] args)
// 		{
// 			DE d = new DE();
// 			Console.WriteLine("{0}",d.str);
// 			Console.WriteLine("{0}",d.str1);
// 			Console.WriteLine("{0}",d.str2);
// 			Console.ReadLine();
// 		}
// 	}
// 	class Str
// 	{
// 		public string str = "www.baidu.com";
// 		public string str1 = @"https:/www.baidu.com";
// 		public string str2 = @"随便输入字符串=====
// 		hahahahhahahahahahahhah----
// 		ennenenennenen。。。。。。
// 		";
// 	}
// }
/* 方法调用 */
// using System;

// public class ConstTest 
// {
//     class SampleClass
//     {
//         public int x;
//         public int y;
//         public const int c1 = 5;
//         public const int c2 = c1 + 5;

//         public SampleClass(int p1, int p2) 
//         {
//             x = p1; 
//             y = p2;
//         }
//     }

//     static void Main()
//     {
//         SampleClass mC = new SampleClass(11, 22);
//         Console.WriteLine("x = {0}, y = {1}", mC.x, mC.y);
//         Console.WriteLine("c1 = {0}, c2 = {1}", 
//                           SampleClass.c1, SampleClass.c2);
//         Console.ReadLine()
//     }
// }
/* 封装 */
// using System;
// public class AccessModify
// {
// 	class AllTest
// 	{
// 		public int weigh;
// 		protected string name;//如果没有方法，这个变量将不能被访问
// 		private double age;
// 		internal int room;

// 		double GetRoom()
// 		{
// 			return room;
// 		}

// 		public void Display()
// 		{
// 			Console.WriteLine("room : {0} hao", room);
// 		}

// 		// protected void SetName(string str)
// 		// {
// 		// 	name = str;
// 		// }
// 		// public void setAge(double ages)
// 		// {
// 		// 	age = ages;
// 		// }
// 		static void Main(string[] args)
// 		{
// 			Console.WriteLine("=====");
// 		}
// 	}
// 	class ExecuteTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			AllTest all = new AllTest();
// 			all.weigh = 30;
// 			// all.name = "Helly";
// 			// all.age = 12;
// 			all.room = 3;
// 			all.SetName("helly");
// 			all.setAge(23.2);
// 			all.Display();
// 			Console.ReadLine();

// 		}
// 	}
// }
/* 参数传递*/
// using System;
// public class Argstest
// {
// 	class SwapTest
// 	{
// 		// 值传递
// 		public void swapV(int a, int b)
// 		{
// 			int temp;
// 			temp = a;
// 			a = b;
// 			b = temp;

// 		}
// 		//引用传递
// 		public void swpaQ(ref int a, ref int b)
// 		{
// 			int temp;
// 			temp = a;
// 			a = b;
// 			b = temp;
// 		}
// 		//输出传递
// 		public void getValue(out int x, out int y)
// 		{
// 			int temp = Convert.ToInt32(Console.ReadLine());
// 			x = temp;
// 			y = x*x;
// 		}
// 	}
// 	class TestMain
// 	{
// 		static void Main(string[] args)
// 		{
// 			SwapTest sw = new SwapTest();
// 			int a = 345;
// 			int b = 567;
// 			sw.swapV(a,b);
// 			Console.WriteLine("a: {0}",a);
// 			Console.WriteLine("b: {0}",b);

// 			sw.swpaQ(ref a,ref b);
// 			Console.WriteLine("a: {0}",a);
// 			Console.WriteLine("b: {0}",b);

// 			sw.getValue(out a, out b);
// 			Console.WriteLine("a: {0}",a);
// 			Console.WriteLine("b: {0}",b);
// 			Console.ReadLine();
// 		}
// 	}
// }

/*循环*/
// using System;
// public class loopTest
// {
// 	class loop
// 	{
// 		public void loopFun(int a)
// 		{
// 			if (a == 15)
// 			{
// 				Console.WriteLine("-------- a=15 --------");
// 			}
// 			else
// 			{
// 				switch (a)
// 				{
// 					case 16:
// 						Console.WriteLine(" a 等于 16", a--);
// 						break;
// 					case 14:
// 						Console.WriteLine(" a 等于 14", a++);
// 						break;
// 					default:
// 						a++;
// 						Console.WriteLine("case->defalut: a 的值： {0}", a);
// 						break;
// 				}
// 				// do
// 				// {
// 				// 	a++;
// 				// 	Console.WriteLine("a 的值： {0}", a);
// 				// } while (a!=15);
// 				for(; a<15 ; a++)
// 				{
// 					Console.WriteLine("a 的值： {0}", a);
// 				}
// 			}
// 		}
// 	}
// 	class TestMain
// 	{
// 		static void Main(string[] args)
// 		{

// 			Console.WriteLine("请输入一个小于15的数值");
// 			int x= Convert.ToInt32(Console.ReadLine());;
// 			loop l = new loop();
// 			l.loopFun(x);
// 			Console.ReadLine();
// 		}
// 	}
// }
/*可空类型*/
// using System;
// public class NullTest
// {
// 	class nullTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			int? i=3;
// 			double? j = 3.1415926;
// 			double? d = new double?();
// 			double? k = d ?? j;
// 			Console.WriteLine("i value is {0}",i);
// 			Console.WriteLine("j value is {0}",j);
// 			Console.WriteLine("d value is {0}",d);
// 			Console.WriteLine("k value is {0}",k);
// 			Console.ReadLine();
// 		}
// 	}
// }

/*数组类型*/
// public class ArrayTest
// {
// 	class arrTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			//赋值方式1（声明+初始化+赋值）
// 			double[] arrd1;
// 			arrd1 = new double[10];
// 			arrd1[1] = 34.001;

// 			//赋值方式2（初始化+赋值）
// 			double[] arrd2= new double[10];
// 			arrd2[1] = 34.001;

// 			//赋值方式3（声明赋值）
// 			double[] arrd3 = {11,12,13,14,18.001};

// 			//赋值方式4（初始化赋值）
// 			double[] arrd4 = new double[5] {11,12,13,14,18.001};

// 			//赋值方式4（初始化赋值-省略大小）
// 			double[] arrd5 = new double[] {11,12,13,14,18.001};

// 			Console.WriteLine("value is {0}",arrd1[1]);
// 			Console.WriteLine("value is {0}",arrd2[1]);
// 			Console.WriteLine("value is {0}",arrd3[1]);
// 			Console.WriteLine("value is {0}",arrd4[1]);
// 			Console.WriteLine("value is {0}",arrd5[1]);

// 			int[] arrI = new int[10];
// 			//初始化
// 			for(int i=0; i <10; i++)
// 			{
// 				arrI[i]=i+100;
// 			}
// 			//循环遍历
// 			foreach(int j in arrI)
// 			{
// 				int i = j - 100;
// 				Console.WriteLine("arrI[{0}] = {1}", i,j) ;
// 			}

// 			Console.ReadLine();
// 		}
// 	}
// }
// public class ArrayTest
// {
// 	class arrTest
// 	{
// 		public void Arrs()
// 		{
// 			int[,] a = new int[3,2] {{1,1},{2,2},{3,3}};//3行2列的二维数组
// 			int[][] b = new int[2][] {new int[]{22,33,44},new int[]{88,99}};//交错数组


// 		}

// 		public double getAverage(int[] arr, int size)
// 		{
// 			int i;
// 			double avg;
// 			int sum=0;
// 			for(i=0;i<size;i++)
// 			{
// 				sum += arr[i];
// 			}
// 			avg = (double)sum / size;
// 			return avg;
// 		}
// 	}
// 	class MainTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			arrTest arr = new arrTest();
// 			int[] num = new int[]{100,201,301,401};
// 			double avg;
// 			avg = arr.getAverage(num, num.Length);
// 			Console.WriteLine("average is {0}",avg);
// 			//Array方法
// 			Array.Sort(num);//排序
// 			Array.Reverse(num);//逆转
// 			Console.ReadKey();
// 		}
// 	}
// }

/*结构体*/
// struct Books
// {
// 	public string title;
// 	public int book_id;
// 	public string subject;
// 	public string author;

// 	public void getValues(string t, string a, string s, int id)
// 	   {
// 	      title = t;
// 	      author = a;
// 	      subject = s;
// 	      book_id =id; 
// 	   }
// 	   public void display()
// 	   {
// 	      Console.WriteLine("Title : {0}", title);
// 	      Console.WriteLine("Author : {0}", author);
// 	      Console.WriteLine("Subject : {0}", subject);
// 	      Console.WriteLine("Book_id :{0}", book_id);
// 	   }
// }
// public class structTest
// {
// 	static void Main(string[] args)
// 	{
// 		Books Book1 = new Books(); /* 声明 Book1，类型为 Book */
// 		Books Book2 = new Books(); /* 声明 Book2，类型为 Book */

// 		Book1.getValues("C Programming","Nuha Ali", "C Programming Tutorial",6495407);
// 		Book2.getValues("Telecom Billing","Zara Ali", "Telecom Billing Tutorial", 6495700);

// 		Book1.display();
// 		Book2.display();

// 		Console.ReadKey();
// 	}

// }
/*枚举类型*/
// enum Days
// {
// 	Sun,Mon,Tue,Wed,Thu,Fri,Sat
// }
// public class MainTest
// {
// 	static void Main(string[] args)
// 	{
// 		int x = (int)Days.Sun;
// 		int y = (int)Days.Fri;

// 		Console.WriteLine("Sun = {0}", x);
// 		Console.WriteLine("Fri  = {0}", y);

// 		Console.ReadKey();
// 	}
// }
// /*类的构造函数*/
// namespace test
// {
// 	class Add
// 	{
// 		public int x;
// 		public int y;
// 		//构造函数
// 		public Add(int a, int b)
// 		{
// 			Console.WriteLine("默认构造函数");
// 			x = a;
// 			y = b;
// 		}
// 		//析构函数
// 		~Add()
// 		{
// 			Console.WriteLine("对象已删除");
// 		}

// 		int getValue()
// 		{
// 			return x+y;
// 		}

// 		static void Main(string[] args)
// 		{
// 			Add a = new Add(3,4);
// 			int num = a.getValue();
// 			Console.WriteLine("add value  = {0}", num);
// 			Console.ReadKey();
// 		}
// 	}
// }
/*类的静态成员和函数*/
// namespace staticTest
// {
// 	class staticTest
// 	{
// 		public static int num;//静态变量
// 		public int a = 4;
// 		public void Count()
// 		{
// 			num++;
// 		}
// 		public int getNum()
// 		{
// 			return num;
// 		}
// 		public static int getNum_s()//静态函数，只能访问静态变量,类调用
// 		{
// 			return a;
// 		}
// 	}

// 	class MainTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			staticTest s1 = new staticTest();
// 			staticTest s2 = new staticTest();

// 			s1.Count();
// 			Console.WriteLine("s1 -> num : {0}", s1.getNum());
// 			Console.WriteLine("s2 -> num : {0}", s2.getNum());
// 			Console.WriteLine("s2 -> num : {0}", staticTest.getNum_s());
// 			Console.ReadKey();
// 		}
// 	}
// }
/*C#继承
<访问修饰符> class <基类>{...}
class <派生类>：<基类>{...}
*/

// namespace InheritTest
// {
// 	//定义基类
// 	class Animal
// 	{
// 		//成员变量
// 		public int age;
// 		public string name;

// 		//构造函数
// 		public Animal(int a, string n)
// 		{
// 			age = a;
// 			name = n;
// 		}
// 		//成员函数
// 		public void eat()
// 		{
// 			Console.WriteLine("{0} age= {1} need eat!",name, age);
// 		}
// 	}
// 	class Dog: Animal
// 	{
// 		public double weigh;
// 		public Dog(int a, string n):base(a,n)
// 		{}
// 		new public void eat()//加上new是因为报了warning CS0108
// 		{
// 			base.eat();
// 			Console.WriteLine("weigh={0}",weigh);
// 		}
// 		public void setWeigh(double w)
// 		{
// 			weigh = w;
// 		}
// 	}
// 	class ExecuteTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			Dog d = new Dog(12,"Helly");
// 			d.setWeigh(34.2);
// 			d.eat();
// 			Console.ReadKey();
// 		}
// 	}
// }
/*
继承https://www.runoob.com/csharp/csharp-inheritance.html中例子
同样会报CS0108警告
*/
// namespace RectangleApplication
// {
//    class Rectangle
//    {
//       // 成员变量
//       protected double length;
//       protected double width;
//       public Rectangle(double l, double w)
//       {
//          length = l;
//          width = w;
//       }
//       public double GetArea()
//       {
//          return length * width;
//       }
//       public void Display()
//       {
//          Console.WriteLine("长度： {0}", length);
//          Console.WriteLine("宽度： {0}", width);
//          Console.WriteLine("面积： {0}", GetArea());
//       }
//    }//end class Rectangle  
//    class Tabletop : Rectangle
//    {
//       private double cost;
//       public Tabletop(double l, double w) : base(l, w)
//       { }
//       public double GetCost()
//       {
//          //double cost;
//          cost = GetArea() * 70;
//          return cost;
//       }
//       public void Display()
//       {
//          base.Display();
//          Console.WriteLine("成本： {0}", GetCost());
//       }
//    }
//    class ExecuteRectangle
//    {
//       static void Main(string[] args)
//       {
//          Tabletop t = new Tabletop(4.5, 7.5);
//          t.Display();
//          Console.ReadLine();
//       }
//    }
// }

/*多重继承*/

// namespace InheritTest
// {
// 	//定义基类
// 	class Animal
// 	{
// 		//成员变量
// 		public int age;
// 		public string name;

// 		//构造函数
// 		public Animal(int a, string n)
// 		{
// 			age = a;
// 			name = n;
// 		}
// 		//成员函数
// 		public void eat()
// 		{
// 			Console.WriteLine("{0} age= {1} need eat!",name, age);
// 		}
// 	}
// 	//接口 基类
// 	public interface Fly
// 	{
// 		void fly();
// 	}
// 	class Dog: Animal,Fly
// 	{
// 		public double weigh;
// 		public Dog(int a, string n):base(a,n)
// 		{}
// 		new public void eat()//加上new是因为报了warning CS0108
// 		{
// 			base.eat();
// 			Console.WriteLine("weigh={0}",weigh);
// 		}
// 		public void setWeigh(double w)
// 		{
// 			weigh = w;
// 		}
// 		public void fly()
// 		{
// 			Console.WriteLine("Can Fly !!");
// 		}
// 	}
// 	class ExecuteTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			Dog d = new Dog(12,"Helly");
// 			d.setWeigh(34.2);
// 			d.eat();
// 			d.fly();
// 			Console.ReadKey();
// 		}
// 	}
// }

/*虚函数*/
// namespace InheritTest
// {
// 	//定义抽象类
// 	abstract class Animal
// 	{
// 		//声明虚函数
// 		public virtual void fly(){
// 			Console.WriteLine("基类的虚函数");
// 		}
// 	}
// 	//派生类-继承类
// 	class Dog: Animal
// 	{
// 		public double weigh;
// 		public void setWeigh(double w)
// 		{
// 			weigh = w;
// 		}
// 		public override void fly(){
// 			Console.WriteLine("继承类Dog 实现");
// 			base.fly();
// 		}
// 	}
// 	//派生类
// 	class cat: Animal
// 	{
// 		public override void fly()
// 		{
// 			Console.WriteLine("继承类Cat 实现");
// 			base.fly();
// 		}
// 	}

// 	class ExecuteTest
// 	{
// 		static void Main(string[] args)
// 		{
// 			Dog d = new Dog();
// 			d.setWeigh(34.2);
// 			d.fly();
// 			Console.ReadKey();
// 		}
// 	}
// }

/*运算符重载*/
// namespace InheritTest
// {
// 	class Box
// 	{
// 		private double length;
// 		private double width;
// 		private double height;

// 		public double getVolume()
// 		{
// 			return length*width*height;
// 		}

// 		public void setLength(double len)
// 		{
// 			length = len;
// 		}

// 		public void setWidth(double wid)
// 		{
// 			width = wid;
// 		}

// 		public void setHeigh(double hei)
// 		{
// 			height = hei;
// 		}

// 		public static Box operator+ (Box b, Box c)//运算符+重载
// 		{
// 		   Box box = new Box();
// 		   box.length = b.length + c.length;
// 		   box.width = b.width + c.width;
// 		   box.height = b.height + c.height;
// 		   return box;
// 		}
// 		static void Main(string[] args)
// 		{
// 			Box Box1 = new Box();         // 声明 Box1，类型为 Box
// 	        Box Box2 = new Box();         // 声明 Box2，类型为 Box
// 	        Box Box3 = new Box();         // 声明 Box3，类型为 Box
// 	        double volume = 0.0;          // 体积

// 	         // Box1 详述
// 	        Box1.setLength(6.0);
// 	        Box1.setWidth(7.0);
// 	        Box1.setHeigh(5.0);

// 	         // Box2 详述
// 	        Box2.setLength(12.0);
// 	        Box2.setWidth(13.0);
// 	        Box2.setHeigh(10.0);

// 	         // Box1 的体积
// 	        volume = Box1.getVolume();
// 	        Console.WriteLine("Box1 的体积： {0}", volume);

// 	         // Box2 的体积
// 	        volume = Box2.getVolume();
// 	        Console.WriteLine("Box2 的体积： {0}", volume);

// 	         // 把两个对象相加
// 	        Box3 = Box1 + Box2;

// 	         // Box3 的体积
// 	        volume = Box3.getVolume();
// 	        Console.WriteLine("Box3 的体积： {0}", volume);
// 			Console.ReadKey();
// 		}
// 	}
	
// }

/*接口 interface实现*/
// interface InterfaceTest	//接口1
// {
// 	//接口成员函数
// 	void InerMethod();
// }

// interface InterfaceTest2	//接口2继承接口1
// {
// 	void InterMethod2();
// }

// class InterfaceImplementer: InterfaceTest2	//实现类继承接口2
// {
// 	static void Main()
// 	{
// 		InterfaceImplementer inter = new InterfaceImplementer();
// 		inter.InerMethod();
// 		inter.InterMethod2();
// 		Console.ReadKey();
// 	}
// 	public void InerMethod()
// 	{
// 		Console.WriteLine("InerMethod()接口函数被调用");
// 	}
// 	public void InterMethod2()
// 	{
// 		Console.WriteLine("InterMethod2()接口函数被调用====");
// 	}
// }

/*namespace命名空间*/
// using first;
// namespace first
// {
// 	class name
// 	{
// 		public void func()
// 		{
// 			Console.WriteLine("命名空间1----");
// 		}
// 	}
// }
// namespace second
// {
// 	class name
// 	{
// 		public void func()
// 		{
// 			Console.WriteLine("命名空间2!!!");
// 		}
// 	}
// }
// class MainTest
// {
// 	static void Main(string[] args)
// 	{
// 		name fc = new name();//可以直接使用，但注意first和second只能using一个
// 		fc.func();
// 		second.name sc = new second.name();
// 		sc.func();
// 		Console.ReadKey();
// 	}
// }

/* 预处理器 指令 */
// #define PI
// using System;
// namespace Preprocess
// {
// 	class Program
// 	{
// 		static void Main()
// 		{
// 			#if (PI)
// 				Console.WriteLine("PI");
				
// 			#elif (PII)
// 				#error Debug is defined
// 			#else
// 				#warning Not have PI or PII
// 			#endif
// 			Console.ReadKey();
// 		}
// 	}
// }

// preprocessor_warning.cs
// CS1030 expected
// #define DEBUG
// class MainClass 
// {
//     static void Main() 
//     {
// 		#if DEBUG
// 			#warning DEBUG is defined
// 		#endif
//     }
// }
/* try - catch - throw - finally */
// using System;
// namespace Error
// {
// 	class MainTest
// 	{
// 		static void Main()
// 		{
// 			int a = 1;
// 			try
// 			{
// 				Bases b = new Bases();
// 			}
// 			catch (NullReferenceException e)
// 			{
// 				Console.WriteLine("Exception caught: {0}", e);
// 			}
// 			finally
// 			{
// 				Console.WriteLine("Result: {0}", a);
// 			}
// 		}
// 	}
// }

/*异常处理
*/
// using System;
// namespace ErrorHandlingApplication
// {
//     class DivNumbers
//     {
//         int result;
//         DivNumbers()
//         {
//             result = 0;
//         }
//         public void division(int num1, int num2)
//         {
//             try
//             {
//                 result = num1 / num2;
//             }
//             catch (DivideByZeroException e)
//             {
//                 Console.WriteLine("Exception caught: {0}", e);
//             }
//             finally
//             {
//                 Console.WriteLine("Result: {0}", result);
//             }

//         }
//         static void Main(string[] args)
//         {
//             DivNumbers d = new DivNumbers();
//             d.division(25, 0);
//             Console.ReadKey();
//         }
//     }
// }

/*文件的输入和输出*/
using System;
using System.IO;
namespace FileOpe
{
	class readFile
	{
		public string path;
		//构造函数初始化赋值
		public readFile(string p)
		{
			path = p;
		}

		public void reading(FileStream F)
		{
			Console.WriteLine("Starting reading file");
			for (int i=1; i<= 20; i++)
			{
				Console.Write(F.ReadByte() + "");
			}

		}

		public void write(FileStream F)
		{
			for(int i=1; i<= 20; i++)
			{
				F.WriteByte((byte)i);
			}
		}
	}

	class MainTest
	{
		static void Main(string[] args)
		{
			string path = "D:\\liaga\\C#";
			readFile rf = new readFile(path);
			FileStream F = new FileStream("red.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,
				FileShare.ReadWrite);
			// for(int i=1; i<= 20; i++)
			// {
			// 	F.WriteByte((byte)i);
			// }
			rf.write(F);
			F.Position = 0;
			rf.reading(F);
			// for (int i=1; i<= 20; i++)
			// {
			// 	Console.Write(F.ReadByte() + "");
			// }

			F.Close();
			Console.ReadKey();
		}
	}
}


// using System;
// using System.IO;

// namespace FileIOApplication
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             FileStream F = new FileStream("test.dat", 
//             FileMode.OpenOrCreate, FileAccess.ReadWrite);

//             for (int i = 1; i <= 20; i++)
//             {
//                 F.WriteByte((byte)i);
//             }

//             F.Position = 0;

//             for (int i = 0; i <= 20; i++)
//             {
//                 Console.Write(F.ReadByte() + " ");
//             }
//             F.Close();
//             Console.ReadKey();
//         }
//     }
// }