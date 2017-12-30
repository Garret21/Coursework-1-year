<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.error_label = New System.Windows.Forms.Label()
        Me.area_label = New System.Windows.Forms.Label()
        Me.print_area_button = New System.Windows.Forms.Button()
        Me.area_button = New System.Windows.Forms.Button()
        Me.print_1_3_label = New System.Windows.Forms.Label()
        Me.print_2_3_label = New System.Windows.Forms.Label()
        Me.print_1_2_label = New System.Windows.Forms.Label()
        Me.hint_1_3_label = New System.Windows.Forms.Label()
        Me.hint_2_3_label = New System.Windows.Forms.Label()
        Me.hint_1_2_label = New System.Windows.Forms.Label()
        Me.cross_point_label = New System.Windows.Forms.Label()
        Me.print_points_button = New System.Windows.Forms.Button()
        Me.calculate_button = New System.Windows.Forms.Button()
        Me.back_button_2 = New System.Windows.Forms.Button()
        Me.partition_box = New System.Windows.Forms.TextBox()
        Me.eps_box = New System.Windows.Forms.TextBox()
        Me.eps_label = New System.Windows.Forms.Label()
        Me.partition_label = New System.Windows.Forms.Label()
        Me.fault_label = New System.Windows.Forms.Label()
        Me.right_limit_box = New System.Windows.Forms.TextBox()
        Me.left_limit_box = New System.Windows.Forms.TextBox()
        Me.next_button_2 = New System.Windows.Forms.Button()
        Me.parametries_title_label = New System.Windows.Forms.Label()
        Me.limit_title_label = New System.Windows.Forms.Label()
        Me.right_limit_label = New System.Windows.Forms.Label()
        Me.left_limit_label = New System.Windows.Forms.Label()
        Me.back_button_1 = New System.Windows.Forms.Button()
        Me.next_button_1 = New System.Windows.Forms.Button()
        Me.c_value_box = New System.Windows.Forms.TextBox()
        Me.b_value_box = New System.Windows.Forms.TextBox()
        Me.a_value_box = New System.Windows.Forms.TextBox()
        Me.c_value_label = New System.Windows.Forms.Label()
        Me.b_value_label = New System.Windows.Forms.Label()
        Me.A_value_label = New System.Windows.Forms.Label()
        Me.exit_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'error_label
        '
        Me.error_label.AutoSize = True
        Me.error_label.ForeColor = System.Drawing.Color.Red
        Me.error_label.Location = New System.Drawing.Point(94, 127)
        Me.error_label.Name = "error_label"
        Me.error_label.Size = New System.Drawing.Size(141, 13)
        Me.error_label.TabIndex = 69
        Me.error_label.Text = "Некорректные значения!!!"
        Me.error_label.Visible = False
        '
        'area_label
        '
        Me.area_label.AutoSize = True
        Me.area_label.Location = New System.Drawing.Point(74, 43)
        Me.area_label.Name = "area_label"
        Me.area_label.Size = New System.Drawing.Size(52, 13)
        Me.area_label.TabIndex = 68
        Me.area_label.Text = "площадь"
        Me.area_label.Visible = False
        '
        'print_area_button
        '
        Me.print_area_button.Location = New System.Drawing.Point(150, 187)
        Me.print_area_button.Name = "print_area_button"
        Me.print_area_button.Size = New System.Drawing.Size(75, 39)
        Me.print_area_button.TabIndex = 67
        Me.print_area_button.Text = "Вывод площади"
        Me.print_area_button.UseVisualStyleBackColor = True
        Me.print_area_button.Visible = False
        '
        'area_button
        '
        Me.area_button.Location = New System.Drawing.Point(150, 186)
        Me.area_button.Name = "area_button"
        Me.area_button.Size = New System.Drawing.Size(75, 40)
        Me.area_button.TabIndex = 66
        Me.area_button.Text = "Вычислить площадь"
        Me.area_button.UseVisualStyleBackColor = True
        Me.area_button.Visible = False
        '
        'print_1_3_label
        '
        Me.print_1_3_label.AutoSize = True
        Me.print_1_3_label.Location = New System.Drawing.Point(203, 91)
        Me.print_1_3_label.Name = "print_1_3_label"
        Me.print_1_3_label.Size = New System.Drawing.Size(25, 13)
        Me.print_1_3_label.TabIndex = 65
        Me.print_1_3_label.Text = "1_3"
        Me.print_1_3_label.Visible = False
        '
        'print_2_3_label
        '
        Me.print_2_3_label.AutoSize = True
        Me.print_2_3_label.Location = New System.Drawing.Point(203, 65)
        Me.print_2_3_label.Name = "print_2_3_label"
        Me.print_2_3_label.Size = New System.Drawing.Size(25, 13)
        Me.print_2_3_label.TabIndex = 64
        Me.print_2_3_label.Text = "2_3"
        Me.print_2_3_label.Visible = False
        '
        'print_1_2_label
        '
        Me.print_1_2_label.AutoSize = True
        Me.print_1_2_label.Location = New System.Drawing.Point(203, 37)
        Me.print_1_2_label.Name = "print_1_2_label"
        Me.print_1_2_label.Size = New System.Drawing.Size(25, 13)
        Me.print_1_2_label.TabIndex = 63
        Me.print_1_2_label.Text = "1_2"
        Me.print_1_2_label.Visible = False
        '
        'hint_1_3_label
        '
        Me.hint_1_3_label.AutoSize = True
        Me.hint_1_3_label.Location = New System.Drawing.Point(74, 91)
        Me.hint_1_3_label.Name = "hint_1_3_label"
        Me.hint_1_3_label.Size = New System.Drawing.Size(104, 13)
        Me.hint_1_3_label.TabIndex = 62
        Me.hint_1_3_label.Text = "1-ая и 3-я функции:"
        Me.hint_1_3_label.Visible = False
        '
        'hint_2_3_label
        '
        Me.hint_2_3_label.AutoSize = True
        Me.hint_2_3_label.Location = New System.Drawing.Point(74, 65)
        Me.hint_2_3_label.Name = "hint_2_3_label"
        Me.hint_2_3_label.Size = New System.Drawing.Size(104, 13)
        Me.hint_2_3_label.TabIndex = 61
        Me.hint_2_3_label.Text = "2-ая и 3-я функции:"
        Me.hint_2_3_label.Visible = False
        '
        'hint_1_2_label
        '
        Me.hint_1_2_label.AutoSize = True
        Me.hint_1_2_label.Location = New System.Drawing.Point(68, 37)
        Me.hint_1_2_label.Name = "hint_1_2_label"
        Me.hint_1_2_label.Size = New System.Drawing.Size(110, 13)
        Me.hint_1_2_label.TabIndex = 60
        Me.hint_1_2_label.Text = "1-ая и 2-ая функции:"
        Me.hint_1_2_label.Visible = False
        '
        'cross_point_label
        '
        Me.cross_point_label.AutoSize = True
        Me.cross_point_label.Location = New System.Drawing.Point(103, 11)
        Me.cross_point_label.Name = "cross_point_label"
        Me.cross_point_label.Size = New System.Drawing.Size(108, 13)
        Me.cross_point_label.TabIndex = 59
        Me.cross_point_label.Text = "Точки пересечения:"
        Me.cross_point_label.Visible = False
        '
        'print_points_button
        '
        Me.print_points_button.Location = New System.Drawing.Point(60, 187)
        Me.print_points_button.Name = "print_points_button"
        Me.print_points_button.Size = New System.Drawing.Size(84, 39)
        Me.print_points_button.TabIndex = 58
        Me.print_points_button.Text = "вывод точек пересечения."
        Me.print_points_button.UseVisualStyleBackColor = True
        Me.print_points_button.Visible = False
        '
        'calculate_button
        '
        Me.calculate_button.Location = New System.Drawing.Point(60, 186)
        Me.calculate_button.Name = "calculate_button"
        Me.calculate_button.Size = New System.Drawing.Size(84, 39)
        Me.calculate_button.TabIndex = 57
        Me.calculate_button.Text = "Вычислить точки пересечения."
        Me.calculate_button.UseVisualStyleBackColor = True
        Me.calculate_button.Visible = False
        '
        'back_button_2
        '
        Me.back_button_2.Location = New System.Drawing.Point(60, 151)
        Me.back_button_2.Name = "back_button_2"
        Me.back_button_2.Size = New System.Drawing.Size(75, 23)
        Me.back_button_2.TabIndex = 56
        Me.back_button_2.Text = "Назад"
        Me.back_button_2.UseVisualStyleBackColor = True
        Me.back_button_2.Visible = False
        '
        'partition_box
        '
        Me.partition_box.Location = New System.Drawing.Point(170, 75)
        Me.partition_box.Name = "partition_box"
        Me.partition_box.Size = New System.Drawing.Size(100, 20)
        Me.partition_box.TabIndex = 55
        Me.partition_box.Text = "10"
        Me.partition_box.Visible = False
        '
        'eps_box
        '
        Me.eps_box.Location = New System.Drawing.Point(170, 43)
        Me.eps_box.Name = "eps_box"
        Me.eps_box.Size = New System.Drawing.Size(100, 20)
        Me.eps_box.TabIndex = 54
        Me.eps_box.Text = "0,01"
        Me.eps_box.Visible = False
        '
        'eps_label
        '
        Me.eps_label.AutoSize = True
        Me.eps_label.Location = New System.Drawing.Point(42, 50)
        Me.eps_label.Name = "eps_label"
        Me.eps_label.Size = New System.Drawing.Size(119, 13)
        Me.eps_label.TabIndex = 53
        Me.eps_label.Text = "Точность выч-я точек:"
        Me.eps_label.Visible = False
        '
        'partition_label
        '
        Me.partition_label.AutoSize = True
        Me.partition_label.Location = New System.Drawing.Point(38, 78)
        Me.partition_label.Name = "partition_label"
        Me.partition_label.Size = New System.Drawing.Size(126, 13)
        Me.partition_label.TabIndex = 52
        Me.partition_label.Text = "Количество разбиений:"
        Me.partition_label.Visible = False
        '
        'fault_label
        '
        Me.fault_label.AutoSize = True
        Me.fault_label.Location = New System.Drawing.Point(74, 17)
        Me.fault_label.Name = "fault_label"
        Me.fault_label.Size = New System.Drawing.Size(184, 13)
        Me.fault_label.TabIndex = 51
        Me.fault_label.Text = "Точность и количество разбиений:"
        Me.fault_label.Visible = False
        '
        'right_limit_box
        '
        Me.right_limit_box.Location = New System.Drawing.Point(149, 69)
        Me.right_limit_box.Name = "right_limit_box"
        Me.right_limit_box.Size = New System.Drawing.Size(100, 20)
        Me.right_limit_box.TabIndex = 50
        Me.right_limit_box.Text = "4"
        Me.right_limit_box.Visible = False
        '
        'left_limit_box
        '
        Me.left_limit_box.Location = New System.Drawing.Point(149, 46)
        Me.left_limit_box.Name = "left_limit_box"
        Me.left_limit_box.Size = New System.Drawing.Size(100, 20)
        Me.left_limit_box.TabIndex = 49
        Me.left_limit_box.Text = "0"
        Me.left_limit_box.Visible = False
        '
        'next_button_2
        '
        Me.next_button_2.Location = New System.Drawing.Point(150, 151)
        Me.next_button_2.Name = "next_button_2"
        Me.next_button_2.Size = New System.Drawing.Size(75, 23)
        Me.next_button_2.TabIndex = 48
        Me.next_button_2.Text = "Далее"
        Me.next_button_2.UseVisualStyleBackColor = True
        Me.next_button_2.Visible = False
        '
        'parametries_title_label
        '
        Me.parametries_title_label.AutoSize = True
        Me.parametries_title_label.Location = New System.Drawing.Point(94, 11)
        Me.parametries_title_label.Name = "parametries_title_label"
        Me.parametries_title_label.Size = New System.Drawing.Size(122, 13)
        Me.parametries_title_label.TabIndex = 47
        Me.parametries_title_label.Text = "Значения параметров:"
        '
        'limit_title_label
        '
        Me.limit_title_label.AutoSize = True
        Me.limit_title_label.Location = New System.Drawing.Point(97, 27)
        Me.limit_title_label.Name = "limit_title_label"
        Me.limit_title_label.Size = New System.Drawing.Size(133, 13)
        Me.limit_title_label.TabIndex = 46
        Me.limit_title_label.Text = "Область поиска фигуры:"
        Me.limit_title_label.Visible = False
        '
        'right_limit_label
        '
        Me.right_limit_label.AutoSize = True
        Me.right_limit_label.Location = New System.Drawing.Point(57, 76)
        Me.right_limit_label.Name = "right_limit_label"
        Me.right_limit_label.Size = New System.Drawing.Size(92, 13)
        Me.right_limit_label.TabIndex = 45
        Me.right_limit_label.Text = "Правая граница:"
        Me.right_limit_label.Visible = False
        '
        'left_limit_label
        '
        Me.left_limit_label.AutoSize = True
        Me.left_limit_label.Location = New System.Drawing.Point(57, 50)
        Me.left_limit_label.Name = "left_limit_label"
        Me.left_limit_label.Size = New System.Drawing.Size(86, 13)
        Me.left_limit_label.TabIndex = 44
        Me.left_limit_label.Text = "Левая граница:"
        Me.left_limit_label.Visible = False
        '
        'back_button_1
        '
        Me.back_button_1.Enabled = False
        Me.back_button_1.Location = New System.Drawing.Point(60, 151)
        Me.back_button_1.Name = "back_button_1"
        Me.back_button_1.Size = New System.Drawing.Size(75, 23)
        Me.back_button_1.TabIndex = 43
        Me.back_button_1.Text = "Назад"
        Me.back_button_1.UseVisualStyleBackColor = True
        '
        'next_button_1
        '
        Me.next_button_1.Location = New System.Drawing.Point(150, 151)
        Me.next_button_1.Name = "next_button_1"
        Me.next_button_1.Size = New System.Drawing.Size(75, 23)
        Me.next_button_1.TabIndex = 42
        Me.next_button_1.Text = "Далее"
        Me.next_button_1.UseVisualStyleBackColor = True
        '
        'c_value_box
        '
        Me.c_value_box.Location = New System.Drawing.Point(141, 86)
        Me.c_value_box.Name = "c_value_box"
        Me.c_value_box.Size = New System.Drawing.Size(100, 20)
        Me.c_value_box.TabIndex = 41
        Me.c_value_box.Text = "9"
        '
        'b_value_box
        '
        Me.b_value_box.Location = New System.Drawing.Point(141, 60)
        Me.b_value_box.Name = "b_value_box"
        Me.b_value_box.Size = New System.Drawing.Size(100, 20)
        Me.b_value_box.TabIndex = 40
        Me.b_value_box.Text = "7"
        '
        'a_value_box
        '
        Me.a_value_box.Location = New System.Drawing.Point(141, 34)
        Me.a_value_box.Name = "a_value_box"
        Me.a_value_box.Size = New System.Drawing.Size(100, 20)
        Me.a_value_box.TabIndex = 39
        Me.a_value_box.Text = "1"
        '
        'c_value_label
        '
        Me.c_value_label.AutoSize = True
        Me.c_value_label.Location = New System.Drawing.Point(68, 87)
        Me.c_value_label.Name = "c_value_label"
        Me.c_value_label.Size = New System.Drawing.Size(67, 13)
        Me.c_value_label.TabIndex = 38
        Me.c_value_label.Text = "Значение c:"
        '
        'b_value_label
        '
        Me.b_value_label.AutoSize = True
        Me.b_value_label.Location = New System.Drawing.Point(68, 63)
        Me.b_value_label.Name = "b_value_label"
        Me.b_value_label.Size = New System.Drawing.Size(67, 13)
        Me.b_value_label.TabIndex = 37
        Me.b_value_label.Text = "Значение b:"
        '
        'A_value_label
        '
        Me.A_value_label.AutoSize = True
        Me.A_value_label.Location = New System.Drawing.Point(68, 37)
        Me.A_value_label.Name = "A_value_label"
        Me.A_value_label.Size = New System.Drawing.Size(67, 13)
        Me.A_value_label.TabIndex = 36
        Me.A_value_label.Text = "Значение a:"
        '
        'exit_button
        '
        Me.exit_button.Location = New System.Drawing.Point(244, 229)
        Me.exit_button.Name = "exit_button"
        Me.exit_button.Size = New System.Drawing.Size(75, 23)
        Me.exit_button.TabIndex = 35
        Me.exit_button.Text = "Выход"
        Me.exit_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 262)
        Me.Controls.Add(Me.error_label)
        Me.Controls.Add(Me.area_label)
        Me.Controls.Add(Me.print_area_button)
        Me.Controls.Add(Me.area_button)
        Me.Controls.Add(Me.print_1_3_label)
        Me.Controls.Add(Me.print_2_3_label)
        Me.Controls.Add(Me.print_1_2_label)
        Me.Controls.Add(Me.hint_1_3_label)
        Me.Controls.Add(Me.hint_2_3_label)
        Me.Controls.Add(Me.hint_1_2_label)
        Me.Controls.Add(Me.cross_point_label)
        Me.Controls.Add(Me.print_points_button)
        Me.Controls.Add(Me.calculate_button)
        Me.Controls.Add(Me.back_button_2)
        Me.Controls.Add(Me.partition_box)
        Me.Controls.Add(Me.eps_box)
        Me.Controls.Add(Me.eps_label)
        Me.Controls.Add(Me.partition_label)
        Me.Controls.Add(Me.fault_label)
        Me.Controls.Add(Me.right_limit_box)
        Me.Controls.Add(Me.left_limit_box)
        Me.Controls.Add(Me.next_button_2)
        Me.Controls.Add(Me.parametries_title_label)
        Me.Controls.Add(Me.limit_title_label)
        Me.Controls.Add(Me.right_limit_label)
        Me.Controls.Add(Me.left_limit_label)
        Me.Controls.Add(Me.back_button_1)
        Me.Controls.Add(Me.next_button_1)
        Me.Controls.Add(Me.c_value_box)
        Me.Controls.Add(Me.b_value_box)
        Me.Controls.Add(Me.a_value_box)
        Me.Controls.Add(Me.c_value_label)
        Me.Controls.Add(Me.b_value_label)
        Me.Controls.Add(Me.A_value_label)
        Me.Controls.Add(Me.exit_button)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents error_label As System.Windows.Forms.Label
    Private WithEvents area_label As System.Windows.Forms.Label
    Private WithEvents print_area_button As System.Windows.Forms.Button
    Private WithEvents area_button As System.Windows.Forms.Button
    Private WithEvents print_1_3_label As System.Windows.Forms.Label
    Private WithEvents print_2_3_label As System.Windows.Forms.Label
    Private WithEvents print_1_2_label As System.Windows.Forms.Label
    Private WithEvents hint_1_3_label As System.Windows.Forms.Label
    Private WithEvents hint_2_3_label As System.Windows.Forms.Label
    Private WithEvents hint_1_2_label As System.Windows.Forms.Label
    Private WithEvents cross_point_label As System.Windows.Forms.Label
    Private WithEvents print_points_button As System.Windows.Forms.Button
    Private WithEvents calculate_button As System.Windows.Forms.Button
    Private WithEvents back_button_2 As System.Windows.Forms.Button
    Private WithEvents eps_box As System.Windows.Forms.TextBox
    Private WithEvents eps_label As System.Windows.Forms.Label
    Private WithEvents partition_label As System.Windows.Forms.Label
    Private WithEvents fault_label As System.Windows.Forms.Label
    Private WithEvents right_limit_box As System.Windows.Forms.TextBox
    Private WithEvents left_limit_box As System.Windows.Forms.TextBox
    Private WithEvents next_button_2 As System.Windows.Forms.Button
    Private WithEvents parametries_title_label As System.Windows.Forms.Label
    Private WithEvents limit_title_label As System.Windows.Forms.Label
    Private WithEvents right_limit_label As System.Windows.Forms.Label
    Private WithEvents left_limit_label As System.Windows.Forms.Label
    Private WithEvents back_button_1 As System.Windows.Forms.Button
    Private WithEvents next_button_1 As System.Windows.Forms.Button
    Private WithEvents c_value_box As System.Windows.Forms.TextBox
    Private WithEvents b_value_box As System.Windows.Forms.TextBox
    Private WithEvents a_value_box As System.Windows.Forms.TextBox
    Private WithEvents c_value_label As System.Windows.Forms.Label
    Private WithEvents b_value_label As System.Windows.Forms.Label
    Private WithEvents A_value_label As System.Windows.Forms.Label
    Private WithEvents exit_button As System.Windows.Forms.Button
    Private WithEvents partition_box As System.Windows.Forms.TextBox

End Class
