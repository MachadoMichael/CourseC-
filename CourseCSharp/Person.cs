using System;
namespace CourseCSharp
{
	public class Person
	{
		public string name;
		public int age;

        public static void OlderPerson()
        {
            Person x, y;
            x = new Person();
            y = new Person();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            x.name = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            x.age = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome da segunda pessoa:");
            y.name = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            y.age = int.Parse(Console.ReadLine());


            string older = x.age > y.age ? x.name : y.name;
            Console.WriteLine($"Pessoa mais velha: {older}");
        }

    }


}

