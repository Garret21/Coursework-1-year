using System;


namespace CourseWorkDLL
{
    public struct point
    {
        public double x, y;
    }

    public struct value_with_error
    {
        public double value, error;
    }

    public delegate double function(double f);

    public class expressions
    {
        public double a, b, c;

        public expressions()
        {
            a = b = c = 0;
        }

        public expressions(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public expressions(expressions data)
        {
            a = data.a;
            b = data.b;
            c = data.c;
        }

        ~expressions()
        {
        }

        public double F1(double _x_)
        {
            return Math.Pow(b, 2) / _x_ * Math.Cos(_x_ * 0.5);
        }

        public double F2(double _x_)
        {
            return Math.Log(1 + Math.Pow(a, 2) + Math.Pow(_x_, 2));
        }

        public double F3(double _x_)
        {
            return Math.Pow(c, 2) * Math.Exp(-Math.Pow(b, 2) * Math.Pow(_x_, 2));
        }
    }

    public class Cross_Points
    {
        public static point[] Find_Cross_Points(double low, double high, double eps, function first_function, function second_function)
        {
            point[] cross_Cross_Points = new point[0];
            int num_periods = Convert.ToInt32(((high - low) / eps) + 1);
            double x1 = low, x2;
            for (int i = 2; i <= num_periods; i++)
            {
                x2 = x1 + eps;
                if ((first_function(x2) - second_function(x2)) * (first_function(x1) - second_function(x1)) < 0)
                {
                    Array.Resize(ref cross_Cross_Points, cross_Cross_Points.Length + 1);
                    cross_Cross_Points[cross_Cross_Points.Length - 1].x = Clarification(x1, x2, eps, first_function, second_function);
                    cross_Cross_Points[cross_Cross_Points.Length - 1].y = second_function(cross_Cross_Points[cross_Cross_Points.GetUpperBound(0)].x);

                }
                x1 = x2;
            }
            return cross_Cross_Points;
        }

        private static double Clarification(double lower_bound, double higher_bound, double _eps, function first_function, function second_function)
        {
            int n = 0;
            double centr;
            do
            {
                centr = (lower_bound + higher_bound) * 0.5;
                if ((first_function(centr) - second_function(centr)) * (first_function(lower_bound) - second_function(lower_bound)) <= 0) higher_bound = centr;
                else lower_bound = centr;
                double turn = Math.Abs(lower_bound - higher_bound);
                n++;
            }
            while (Math.Abs(lower_bound - higher_bound) >= _eps);
            return centr;
        }

        public static void Print_Point(string hint, string comment, point[] array)
        {
            Console.WriteLine(hint);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(comment, array[i].x, array[i].y);
            }
        }

        public static bool Check_Epsilon(double epsilon)
        {
            return ((epsilon < 1) && (epsilon > 0))? true : false;
        }

        public static bool Check_Limits(double low_limit, double high_limit)
        {
            return (high_limit > low_limit) ? true : false;
        }
    }

    public class Square
    {
        public static value_with_error Final_Square(double lower_limit, double medium_limit, double higher_limit,
                                     function left_high_term, function right_high_term, function low_term, double epsilon,
                                     int start_partition)
        {
            value_with_error square = new value_with_error();
            double integral_value, double_accuracy_integral_value;
            bool flag = true;
            do
            {
                integral_value = Combine_Summ(lower_limit, medium_limit, left_high_term, low_term, start_partition) +
                                Combine_Summ(medium_limit, higher_limit, right_high_term, low_term, start_partition);
                double_accuracy_integral_value = Combine_Summ(lower_limit, medium_limit, left_high_term, low_term, 2 * start_partition) +
                                Combine_Summ(medium_limit, higher_limit, right_high_term, low_term, 2 * start_partition);
                double fault = Error_Calculation(integral_value, double_accuracy_integral_value);
                if (fault > epsilon) start_partition = 2 * start_partition;
                else 
                {
                    flag = false;
                    square.value = integral_value;
                    square.error = fault;
                }
            }
            while (flag);
            return square; ;
        }

        public static bool Check_Partition(int partition)
        {
            return ((partition % 2 == 0) && (partition > 0)) ? true : false;             
        }

        private static double Error_Calculation(double value, double double_accuracy_value)
        {
            return Math.Abs(value - double_accuracy_value) / 15;
        }

        private static double Combine_Summ(double left_border, double right_border, function high_term, function _low_term, int fragmentation)
        {
            return Integral(left_border, right_border, fragmentation, high_term) - Integral(left_border, right_border, fragmentation, _low_term);
        }

        private static double Integral(double lower_bound, double higher_bound, int segment_number, function term)
        {
            double step = (higher_bound - lower_bound) / segment_number;
            double integral_sum = step / 3 * (term(lower_bound) + term(higher_bound)
                                         + 2 * Summarize(lower_bound, segment_number, step, term, true)
                                         + 4 * Summarize(lower_bound, segment_number, step, term, false));
            return integral_sum;
        }

        private static double Summarize(double lower__bound, int fragmentation_number, double _step, function equation, bool parity)
        {
            double result = 0;
            int startpoint = (parity) ? 1 : 2;
            for (int k = startpoint; k < fragmentation_number; k += 2)
            {
                lower__bound = lower__bound + 2 * _step;
                result += equation(lower__bound);
            }
            return result;
        }

        public static void Print_Square(string hint, value_with_error value)
        {
            Console.WriteLine(hint.ToString(), value.value, value.error);
        }

    }
}
