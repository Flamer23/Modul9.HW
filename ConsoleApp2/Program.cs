namespace Modul9.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание #1\n");

            Exception[] exceptions = new Exception[5] {new DivideByZeroException(), new ArgumentOutOfRangeException(), new IndexOutOfRangeException(), new InvalidCastException(), null};

            MyException myException = new MyException("My own exception.");
            exceptions[4] = myException;

            foreach (Exception ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("\nЗадание #2\n");

            string[] names = new string[5] { "Григорий","Анна", "Дмитрий", "Виктор", "Борис"  };
            Console.WriteLine("Выберите как сортировать массив:\n");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n1) А -> Я    2)Я -> А");
            bool flag = true;
            do
            {
                try
                {
                    int select = Convert.ToInt32(Console.ReadLine());
                    if ((select != 1) && (select != 2))
                    {
                        throw new MyException("Ошибка ввода. Выбран несуществующий вариант.");
                    }
                    else if(select == 1)
                    {
                        Array.Sort(names);
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        flag = false;
                    }
                    else if (select == 2)
                    {
                        Array.Sort (names);
                        Array.Reverse (names);
                        foreach (string name in names)
                        {
                            Console.WriteLine(name);
                        }
                        flag = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }while (flag);
            
        }

    }
}
