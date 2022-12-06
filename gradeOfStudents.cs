using System;
namespace Dec062022 {
    public class gradeOfStudents {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks of Hindi:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of Engilsh:");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks of Maths:");
            int m = Convert.ToInt32(Console.ReadLine());
            float total = h + e + m;
            double percentage = (total / 3);
            Console.Clear();
            if (percentage > 90F && percentage <= 100F)
                Console.WriteLine("Grade: A");
            else if (percentage >= 80F && percentage <= 90F)
                Console.WriteLine("Grade: B");
            else if (percentage >= 70F && percentage <= 79F)
                Console.WriteLine("Grade: C");
            else if (percentage >= 60F && percentage <= 69F)
                Console.WriteLine("Grade: D");
            else if (percentage >= 50F && percentage <= 59F)
                Console.WriteLine("Grade: E");
            else Console.WriteLine("Failed!");
            Console.WriteLine("-----------");
            Console.WriteLine($"Hindi:  {h}\nEnglish:{e}\nMaths:  {m}");
            Console.WriteLine("------------");
            Console.WriteLine($"Obt Marks:{total}");

        }
        }
}
