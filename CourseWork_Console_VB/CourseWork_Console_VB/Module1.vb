'Программа для вычисления площади фигуры, ограниченной тремя кривыми
'Программист Летов Н.Е.


Imports CourseWorkDLL

Module Module1

    Public Function Input_Value(ByVal hint As String) As String()
        Console.Write(hint)
        Return Console.ReadLine().Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
    End Function

    Sub Main()
        Const max_counter As Integer = 3

        '<Ввод>
        Console.Title = "Вычисление площади фигуры, ограниченной тремя кривыми."
        Dim row As String() = Input_Value("Введите значения параметров через пробел(a b c): ")
        Dim a = CDbl(row(0)),
            b = CDbl(row(1)),
            c = CDbl(row(2))
        Dim flag As Boolean = True, counter As Integer = 1
        Dim down_limit, up_limit As Double
        Do
            row = Input_Value("Введите границы вычисления фигуры по x через пробел(min max): ")
            down_limit = CDbl(row(0))
            up_limit = CDbl(row(1))
            up_limit = Double.Parse(row(1))
            If (Cross_Points.Check_Limits(down_limit, up_limit)) Then
                flag = False
            Else
                Try
                    If (counter = max_counter) Then
                        Throw New System.ArgumentException()
                    End If
                Catch
                    Console.WriteLine("Данные некорректны. количество попыток истекло. Завершение программы...")
                    Console.ReadLine()
                    Environment.Exit(13)
                End Try
                    Console.WriteLine("Некорректные значения!!! повторите ввод данных!!! попытка {0},{1}", counter, max_counter)
                    counter += 1
            End If
        Loop While (flag)
        flag = True
        counter = 1
        Dim partition As Integer, eps As Double
        Do
            row = Input_Value("Введите точность и чётное количество разбиений для интегрирования" & vbLf & "через пробел (eps partition): ")
            eps = CDbl(row(0))
            partition = CInt(row(1))
            If (Square.Check_Partition(partition) And Cross_Points.Check_Epsilon(eps)) Then
                flag = False
            Else
                Try
                    If (counter = max_counter) Then
                        Throw New System.ArgumentException()
                    End If
                Catch ex As Exception
                    Console.WriteLine("Данные некорректны. количество попыток истекло. Завершение программы...")
                    Console.ReadLine()
                    Environment.Exit(13)
                End Try
                Console.WriteLine("Некорректное значение!!! повторите ввод данных!!! попытка {0},{1}", counter, max_counter)
                counter += 1
            End If
        Loop While (flag)
        '</ввод>

        Dim box As expressions = New expressions(a, b, c)

        '<вычисление точек пересечения>
        Dim Cross_Points_1_2 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, AddressOf box.F1, AddressOf box.F2)

        Dim Cross_Points_2_3 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, AddressOf box.F2, AddressOf box.F3)

        Dim Cross_Points_1_3 = Cross_Points.Find_Cross_Points(down_limit, up_limit, eps, AddressOf box.F1, AddressOf box.F3)
        '</вычисление точек пересечения>

        '<вычисление площади>
        Dim plaza As value_with_error = Square.Final_Square(Cross_Points_2_3(0).x, Cross_Points_1_2(0).x, Cross_Points_1_3(0).x,
                                                         AddressOf box.F2, AddressOf box.F1, AddressOf box.F3, eps, partition)
        '</вычисление площади>

        '<вывод результатов>
        Cross_Points.Print_Point("первая и вторая функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_1_2)
        Cross_Points.Print_Point("вторая и третья функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_2_3)
        Cross_Points.Print_Point("первая и третья функции:", "точка пересечения равна ({0:f8};{1:f8})", Cross_Points_1_3)
        Square.Print_Square("Площадь фигуры равна {0:f8}, при погрешности {1:e4}", plaza)
        Console.ReadLine()
        '</вывод результатов>
    End Sub

End Module
