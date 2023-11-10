using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maslab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте структуру данных "стек".Напишите программу, содержащую описание стека и моделирующую работу стека, реализовав все указанные здесь методы.Программа считывает последовательность команд и в зависимости от команды выполняет ту или иную операцию. После выполнения каждой команды программа должна вывести одну строчку.Возможные команды для программы:

            //push n
            //Добавить в стек число n(значение n задается после команды).Программа должна вывести ok.
            //pop
            //Удалить из стека последний элемент. Программа должна вывести его значение.
            //back
            //Программа должна вывести значение последнего элемента, не удаляя его из стека.
            //size
            //Программа должна вывести количество элементов в стеке.
            //clear
            //Программа должна очистить стек и вывести ok.
            //exit
            //Программа должна вывести bye и завершить работу.
            //Входные данные
            //Команды управления стеком вводятся в описанном ранее формате по 1 на строке.


            int[] stack = new int[0];
            bool run = true, aoelem = false;

            string buf;int buf2=0;

            while (run == true)
            {
                buf = Console.ReadLine();

                if (buf.StartsWith("push")) { buf2 = Convert.ToInt32(buf.Substring(5)); buf = "push"; }

                    switch (buf)
                    {
                        case "push":

                        if (size(stack) <= 100)
                        {
                            push(buf2, ref stack);

                            aoelem = true;
                            Console.WriteLine("OK ");
                        }

                        break;
                        case "pop"://Удалить из стека последний элемент. Программа должна вывести его значение.

                        if (aoelem == true)
                            {
                            int last = pop(ref stack);

                                Console.WriteLine(last);

                            if (size(stack) == 0) aoelem = false;
                            }

                            break;
                        case "back"://Программа должна вывести значение последнего элемента, не удаляя его из стека.

                        if (aoelem == true)
                            {
                            Console.WriteLine(back(stack));
                        }

                            break;
                        case "size":

                            if (aoelem == true)
                            {
                            Console.WriteLine(size(stack));
                        }

                            break;
                        case "clear":

                            if (aoelem == true)
                            {
                            clear(ref stack);

                            Console.WriteLine("OK ");

                            aoelem = false;
                        }

                            break;
                        case "exit":
                        Console.WriteLine("Bye");
                        run = false;
                            break;

                    }
            }
        }

        public static void push(int num, ref int[] stack)
        {

            Array.Resize(ref stack, stack.Length + 1);
            stack[stack.Length - 1] = num;

            return;

        }

        public static int pop(ref int[] stack)
        {
            int last = stack[stack.Length - 1];
            Array.Resize(ref stack,stack.Length-1);

            return last;

        }

        public static int back(int[] stack)
        {
            int last= stack[stack.Length-1];

            return last;
        }

        public static int size(int[] stack)
        {
            return stack.Length;

        }

        public static void clear(ref int[] stack)
        {
            //Array.Resize(ref stack,0);

            int k = size(stack);
            while (k > 0)
            {
                pop(ref stack);
                k--;
            }
        }

    }
}
