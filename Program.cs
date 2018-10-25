using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Owner
    {
        public Owner(int Id)
        {
            int Identity = Id;
            string name = "Татьяна";
            var org = "BSTU";
        }
    }
    class Set
    {
        public int[] array;

        public Set(int dlina)
        {

            array = new int[dlina];
        }
        public class Date
        {
            public Date() { }
        }
        public Set() { }
        Random random = new Random();
        public Set(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Output(Set RandomArray)
        {
            for (int i = RandomArray.array.Length - 1; i >= 0; i--)
            {
                Console.Write(RandomArray.array[i] + " ");
            }
            Console.WriteLine();
        }

        public void Push(Set RandomArray, int str, int dlina)
        {
            int count = 0, i = 0;
            while (RandomArray.array[i] != 0)
            {
                count++; i++;
            }
            RandomArray.array[count] = str;
        }

        public static Set operator *(Set A, Set B)
        {
            Set rezult = new Set(A.array.Length);
            int z = 0;
            for (int i = 0; i < A.array.Length; i++)
            {
                for (int j = 0; j < B.array.Length; j++)
                {
                    if (A.array[i] == B.array[j])
                    {
                        A.array[z] = B.array[j];
                        z++;
                    }
                }
            }
            for (int i = 0; i < z; i++)
            {
                int podm = A.array[i];

                rezult.array[i] = podm;

            }
            return rezult;
        }

        public static Set operator -(Set B, Set C)
        {
            Set rezult = new Set(B.array.Length);
            Stack<int> vs = new Stack<int>();
            int size = B.array.Length;
            int element = 0;
            int k = 2;
            for (int i = 0; i < B.array.Length; i++)
            {
                if (B.array[i] == k)
                {
                    element++;
                }
                else
                {
                    vs.Push(B.array[i]);
                }
            }
            size = size - element;
            for (int i = 0; i < size; i++)
            {
                B.array[i] = vs.Pop();
            }
            for (int i = 0; i < size; i++)
            {
                int ravn = B.array[i];
                rezult.array[i] = ravn;
            }
            return rezult;
        }
        public static bool operator <(Set A, Set B)
        {

            Set newMass = new Set();
            Set newMass2 = new Set();
            if (A.array.Length > B.array.Length)
            {
                Console.WriteLine("Размер большего множества: " + A.array.Length);
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool operator &(Set A, Set B)
        {
            int r = 5;
            for (int i = 0; i < A.array.Length; i++)
            {
                if (A.array[i] == r)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator >(Set A, Set B)
        {
            Set newMass = new Set(A.array.Length);
            int t = 0;
            for (int i = 0; i < A.array.Length; i++)
            {
                for (int j = 0; j < B.array.Length; j++)
                {
                    if (A.array[i] == B.array[j])
                    {
                        t++;

                    }

                }

            }
            if (t == B.array.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    public static class StringExtension
    {
        public static string AddPoint(this string str, string c)
        {
           string rez = str.Insert(str.Length, c);
            return rez;
        }
       
    }
     class MathOperation
    {
        public static int MaxArr(int[] arr)
        {
           int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public static int MinArr(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        public static int Count(int[] arr)
        {
            int count = 0;
            int col;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
            }
            col = count;
            return col;
        }

    }
   class Del
    {
        public  int[] NULIK(int[] arr)
        {
            Stack<int> vs = new Stack<int>();
            int size = arr.Length;
            int element = 0;
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                {
                    element++;
                }
                else
                {
                    vs.Push(arr[i]);
                }
            }
            size = size - element;

            for (int i = 0; i < size; i++)
            {
                arr[i] = vs.Pop();
            }

           
            return arr;
        }

    }
   

    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите размер множества A: ");
                int size1 = Convert.ToInt32(Console.ReadLine());
                Set A = new Set(size1);
                Console.WriteLine("Введите размер множества B: ");
                int size2 = Convert.ToInt32(Console.ReadLine());
                Set B = new Set(size2);
                Console.WriteLine("Введите размер множества C: ");
                int size3 = Convert.ToInt32(Console.ReadLine());
                Set C = new Set(size3);

                Console.WriteLine("Введите элементы множества:");
                Console.WriteLine("Множество А:");
                for (int i = 0; i < size1; i++)
                {
                    int str1 = Convert.ToInt32(Console.ReadLine());
                    A.Push(A, str1, size1);
                }
                Console.WriteLine("Множество В:");
                for (int i = 0; i < size2; i++)
                {
                    int str2 = Convert.ToInt32(Console.ReadLine());
                    B.Push(B, str2, size2);
                }
                Console.WriteLine("Множество С:");
                for (int i = 0; i < size3; i++)
                {
                    int str3 = Convert.ToInt32(Console.ReadLine());
                    C.Push(C, str3, size3);
                }


                Console.WriteLine("Вывод множества А:");
                A.Output(A);
                Console.WriteLine("Вывод множества B:");
                B.Output(B);
                Console.WriteLine("Вывод множества C:");
                C.Output(C);


                  Set s1 = A * B;
                  Console.WriteLine("Проверка пересечения множеств: ");
                  s1.Output(s1);

                 Set s2 = B - C;
                 s2.Output(s2);
                Console.WriteLine("Сравнение множеств: ");
                bool s3 = A < B;

                if (s3 == true)
                {
                    Console.WriteLine("A>B");
                }
                else
                {
                    Console.WriteLine("A<B");
                }
                bool s4 = A > B;
                if (s4 == true)
                {
                    Console.WriteLine("Есть подмножество");
                }
                else
                {
                    Console.WriteLine("Нет подмножества");
                }

                bool s5 = A & B;
                if (s5 == true)
                {
                    Console.WriteLine("Элемент найден");
                }
                else
                {
                    Console.WriteLine("Элемент не найден");
                }

            Set.Date today = new Set.Date();

            string s = "Привет мир";
            string c = ".";
            string ir = s.AddPoint(c);
            Console.WriteLine(ir);

            Console.ReadLine();
            Del del = new Del();
            int[] mass = new int[] {4, 0, 1, 26, 1, 0, 0, 7 };
            mass= del.NULIK(mass);
            for (int i=0;i<mass.Length-3;i++)
            {
                Console.Write(mass[i] + ",");
            }
            Console.WriteLine();
            MathOperation maxMass = new MathOperation();

            int max = MathOperation.MaxArr(mass);
            int min = MathOperation.MinArr(mass);
            int col = MathOperation.Count(mass);
            Console.WriteLine("Максимальный элемент: " + max + " " + "Минимальный элемент: " + min + " " + "Количество элементов: " + col);
        }
    }
}
