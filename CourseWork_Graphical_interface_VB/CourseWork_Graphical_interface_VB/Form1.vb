'Программа для вычисления площади фигуры, ограниченной тремя кривыми
'Программист Летов Н.Е.

Imports CourseWorkDLL

Public Class Form1

    Public box = New expressions()
    Public Cross_Points_1_2, Cross_Points_2_3, Cross_Points_1_3 As point()
    Public plaza = New value_with_error()


    Private Sub exit_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_button.Click
        Close()
    End Sub

    Private Sub next_button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_button_1.Click
        box.a = CDbl(a_value_box.Text)
        box.b = CDbl(b_value_box.Text)
        box.c = CDbl(c_value_box.Text)

        back_button_1.Enabled = True
        next_button_1.Visible = False
        next_button_2.Visible = True
        parametries_title_label.Visible = False
        A_value_label.Visible = False
        a_value_box.Visible = False
        b_value_label.Visible = False
        b_value_box.Visible = False
        c_value_label.Visible = False
        c_value_box.Visible = False
        limit_title_label.Visible = True
        left_limit_label.Visible = True
        left_limit_box.Visible = True
        right_limit_label.Visible = True
        right_limit_box.Visible = True
    End Sub

    Private Sub back_button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_button_1.Click
        error_label.Visible = False
        back_button_1.Enabled = False
        next_button_1.Visible = True
        next_button_2.Visible = False
        parametries_title_label.Visible = True
        A_value_label.Visible = True
        a_value_box.Visible = True
        b_value_label.Visible = True
        b_value_box.Visible = True
        c_value_label.Visible = True
        c_value_box.Visible = True
        limit_title_label.Visible = False
        left_limit_label.Visible = False
        left_limit_box.Visible = False
        right_limit_label.Visible = False
        right_limit_box.Visible = False
    End Sub

    Private Sub next_button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles next_button_2.Click
        If (Not Cross_Points.Check_Limits(CDbl(left_limit_box.Text), CDbl(right_limit_box.Text))) Then
            error_label.Visible = True
        Else
            error_label.Visible = False
            limit_title_label.Visible = False
            left_limit_label.Visible = False
            left_limit_box.Visible = False
            right_limit_label.Visible = False
            right_limit_box.Visible = False
            back_button_2.Visible = True
            fault_label.Visible = True
            eps_label.Visible = True
            eps_box.Visible = True
            partition_label.Visible = True
            partition_box.Visible = True
            next_button_2.Visible = False
            calculate_button.Visible = True
            back_button_1.Visible = False
        End If
    End Sub

    Private Sub back_button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_button_2.Click
        error_label.Visible = False
        limit_title_label.Visible = True
        left_limit_label.Visible = True
        left_limit_box.Visible = True
        right_limit_label.Visible = True
        right_limit_box.Visible = True
        back_button_2.Visible = False
        parametries_title_label.Visible = False
        eps_label.Visible = False
        eps_box.Visible = False
        partition_label.Visible = False
        partition_box.Visible = False
        next_button_2.Visible = True
        calculate_button.Visible = False
        back_button_1.Visible = True
        fault_label.Visible = False
    End Sub

    Private Sub calculate_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate_button.Click
        If (Not (Square.Check_Partition(CInt(partition_box.Text)) And Cross_Points.Check_Epsilon(CDbl(eps_box.Text)))) Then
            error_label.Visible = True
        Else

            Cross_Points_1_2 = Cross_Points.Find_Cross_Points(CDbl(left_limit_box.Text),
                                                              CDbl(right_limit_box.Text),
                                                              CDbl(eps_box.Text), AddressOf box.F1, AddressOf box.F2)

            Cross_Points_2_3 = Cross_Points.Find_Cross_Points(CDbl(left_limit_box.Text),
                                                              CDbl(right_limit_box.Text),
                                                              CDbl(eps_box.Text), AddressOf box.F2, AddressOf box.F3)

            Cross_Points_1_3 = Cross_Points.Find_Cross_Points(CDbl(left_limit_box.Text),
                                                              CDbl(right_limit_box.Text),
                                                              CDbl(eps_box.Text), AddressOf box.F1, AddressOf box.F3)
            error_label.Visible = False
            back_button_2.Visible = False
            calculate_button.Visible = False
            print_points_button.Visible = True
            eps_label.Visible = False
            eps_box.Visible = False
            partition_label.Visible = False
            partition_box.Visible = False
            fault_label.Visible = False
        End If
    End Sub

    Private Sub print_points_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_points_button.Click
        cross_point_label.Visible = True
        hint_1_2_label.Visible = True
        hint_1_3_label.Visible = True
        hint_2_3_label.Visible = True
        print_1_2_label.Text = String.Format("({0:f5},{1:f5})", Cross_Points_1_2(0).x, Cross_Points_1_2(0).y)
        print_1_2_label.Visible = True
        print_2_3_label.Text = String.Format("({0:f5},{1:f5})", Cross_Points_2_3(0).x, Cross_Points_2_3(0).y)
        print_2_3_label.Visible = True
        print_1_3_label.Text = String.Format("({0:f5},{1:f5})", Cross_Points_1_3(0).x, Cross_Points_1_3(0).y)
        print_1_3_label.Visible = True
        print_points_button.Visible = False
        area_button.Visible = True
    End Sub

    Private Sub area_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles area_button.Click
        cross_point_label.Visible = False
        hint_1_2_label.Visible = False
        hint_1_3_label.Visible = False
        hint_2_3_label.Visible = False
        print_1_2_label.Visible = False
        print_2_3_label.Visible = False
        print_1_3_label.Visible = False
        plaza = Square.Final_Square(Cross_Points_2_3(0).x, Cross_Points_1_2(0).x, Cross_Points_1_3(0).x,
                                                      AddressOf box.F2, AddressOf box.F1, AddressOf box.F3, CDbl(eps_box.Text), CInt(partition_box.Text))
        area_button.Visible = False
        print_area_button.Visible = True
    End Sub

    Private Sub print_area_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print_area_button.Click
        area_label.Text = String.Format("Площадь фигуры равна {0:f8}," & vbLf & "при погрешности {1:f8}", plaza.value, plaza.error)
        area_label.Visible = True
        print_area_button.Visible = False
    End Sub
End Class
