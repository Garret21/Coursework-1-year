//Программа для вычисления площади фигуры, ограниченной тремя кривыми
//Программист Летов Н.Е.

using System;
using CourseWorkDLL;

namespace CourseWork_Console
{
    delegate bool condition(params bool[] values);
    class Program
    {
        static string[] Input_Value(string hint)
        {
            Console.Write(hint);
            return Console.ReadLine().Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
        }

        static void Main(string[] args)
        {
            const int max_counter = 3;

            //<Ввод>
            Console.Title = "Вычисление площади фигуры, ограниченной тремя кривыми.";
            string[] row = Input_Value("Введите значения параметров через пробел(a b c): ");
            double a = double.Parse(row[0]);
            double b = double.Parse(row[1]);
            double c = double.Parse(row[2]);
            double down_limit, up_limit;
            bool flag = true;
            int counter = 0;
            do
            {
                row = Input_Value
                    ("Введите границы вычисления фигуры по x через пробел(min max): ");
                down_limit = double.Parse(row[0]);
                up_limit = double.Parse(row[1]);
                
                if (Cross_Points.Check_Limits(down_limit, up_limit)) flag = false;
                else
                {
                    try
                    {
                        if (counter == max_counter)
                        {
                            throw new System.ArgumentException();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Данные некорректны. количество попыток истекло. Завершение программы...");
                        Console.ReadLine();
                        Environment.Exit(13);
                    }
                    Console.WriteLine("Некорректные значения!!! повторите ввод данных!!! попытка {0},{1}", counter+1, max_counter);
                    counter++;
                }
            }
            while (flag);
            double eps;
            int partition;
            flag = true;
            counter = 1;
            do
            {
                row = Input_Value("Введите точность и чётное количество разбиений для интегрирования\nчерез пробел(eps partition): ");
                eps = double.Parse(row[0]);
                partition = int.Parse(row[1]);

                if (((Square.Check_Partition(partition)) && Cross_Points.Check_Epsilon(eps)) || (counter > max_counter)) flag = false;
                else
                {
                    try
                    {
                        if (counter == max_counter)
                        {
                            throw new System.ArgumentException();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Данные некорректны. количество попыток истекло. Завершение программы...");
                        Console.ReadLine();
                        Environment.Exit(13);
                    }
                    Console.WriteLine("Некорректное значение!!! повторите ввод данных!!! попытка {0},{1}", counter, max_counter);
                    counter++;
                }    
            }
            while (flag);
            //</ввод>

            expressions box = new expressions(a, b, c);

            //<вычисление точек пересечения>
            point[] Cross_Points_1_2 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, box.F1, box.F2);
            point[] Cross_Points_2_3 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, box.F2, box.F3);
            point[] Cross_Points_1_3 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, box.F1, box.F3);
            //</вычисление точек пересечения>

            //<вычисление площади>
            value_with_error area = Square.Final_Square(Cross_Points_2_3[0].x, Cross_Points_1_2[0].x, Cross_Points_1_3[0].x,
                                                             box.F2, box.F1, box.F3, eps, partition);
            //</вычисление площади>

            //<вывод результатов>
            Cross_Points.Print_Point("первая и вторая функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_1_2);
            Cross_Points.Print_Point("вторая и третья функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_2_3);
            Cross_Points.Print_Point("первая и третья функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_1_3);
            Square.Print_Square("Площадь фигуры равна {0:f8}, при погрешности {1:e4}", area);
            Console.ReadLine();
            //</вывод результатов>
        }
    }
}