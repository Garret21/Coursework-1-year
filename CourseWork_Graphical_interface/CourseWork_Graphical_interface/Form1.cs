//Программа для вычисления площади фигуры, ограниченной тремя кривыми
//Программист Летов Н.Е.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CourseWorkDLL;

namespace CourseWork_Graphical_interface
{
    public partial class Form1 : Form
    {
        expressions box = new expressions();
        point[] Cross_Points_1_2, Cross_Points_2_3, Cross_Points_1_3;
        value_with_error square;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void next_button_1_Click(object sender, EventArgs e)
        {
            box.a = double.Parse(a_value_box.Text);
            box.b = double.Parse(b_value_box.Text);
            box.c = double.Parse(c_value_box.Text);

            back_button_1.Enabled = true;
            next_button_1.Visible = false;
            next_button_2.Visible = true;
            parametries_title_label.Visible = false;
            A_value_label.Visible = false;
            a_value_box.Visible = false;
            b_value_label.Visible = false;
            b_value_box.Visible = false;
            c_value_label.Visible = false;
            c_value_box.Visible = false;
            limit_title_label.Visible = true;
            left_limit_label.Visible = true;
            left_limit_box.Visible = true;
            right_limit_label.Visible = true;
            right_limit_box.Visible = true;
        }

        private void back_button_1_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            back_button_1.Enabled = false;
            next_button_1.Visible = true;
            next_button_2.Visible = false;
            parametries_title_label.Visible = true;
            A_value_label.Visible = true;
            a_value_box.Visible = true;
            b_value_label.Visible = true;
            b_value_box.Visible = true;
            c_value_label.Visible = true;
            c_value_box.Visible = true;
            limit_title_label.Visible = false;
            left_limit_label.Visible = false;
            left_limit_box.Visible = false;
            right_limit_label.Visible = false;
            right_limit_box.Visible = false;
        }

        private void next_button_2_Click(object sender, EventArgs e)
        {
            if (!Cross_Points.Check_Limits(double.Parse(left_limit_box.Text),double.Parse(right_limit_box.Text)))
                error_label.Visible = true;
            else
            {
                error_label.Visible = false;
                limit_title_label.Visible = false;
                left_limit_label.Visible = false;
                left_limit_box.Visible = false;
                right_limit_label.Visible = false;
                right_limit_box.Visible = false;
                back_button_2.Visible = true;
                fault_label.Visible = true;
                eps_label.Visible = true;
                eps_box.Visible = true;
                partition_label.Visible = true;
                partition_box.Visible = true;
                next_button_2.Visible = false;
                calculate_button.Visible = true;
                back_button_1.Visible = false;
            }
        }

        private void back_button_2_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;
            limit_title_label.Visible = true;
            left_limit_label.Visible = true;
            left_limit_box.Visible = true;
            right_limit_label.Visible = true;
            right_limit_box.Visible = true;
            back_button_2.Visible = false;
            parametries_title_label.Visible = false;
            eps_label.Visible = false;
            eps_box.Visible = false;
            partition_label.Visible = false;
            partition_box.Visible = false;
            next_button_2.Visible = true;
            calculate_button.Visible = false;
            back_button_1.Visible = true;
            fault_label.Visible = false;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            if (!(Square.Check_Partition(int.Parse(partition_box.Text)) && Cross_Points.Check_Epsilon(double.Parse(eps_box.Text)))) error_label.Visible = true;
            else
            {
                Cross_Points_1_2 = Cross_Points.Find_Cross_Points(double.Parse(left_limit_box.Text),
                                                                  double.Parse(right_limit_box.Text),
                                                                  double.Parse(eps_box.Text), box.F1, box.F2);

                Cross_Points_2_3 = Cross_Points.Find_Cross_Points(double.Parse(left_limit_box.Text),
                                                                  double.Parse(right_limit_box.Text),
                                                                  double.Parse(eps_box.Text), box.F2, box.F3);

                Cross_Points_1_3 = Cross_Points.Find_Cross_Points(double.Parse(left_limit_box.Text),
                                                                  double.Parse(right_limit_box.Text),
                                                                  double.Parse(eps_box.Text), box.F1, box.F3);
                error_label.Visible = false;
                back_button_2.Visible = false;
                calculate_button.Visible = false;
                print_points_button.Visible = true;
                eps_label.Visible = false;
                eps_box.Visible = false;
                partition_label.Visible = false;
                partition_box.Visible = false;
                fault_label.Visible = false;
            }
        }
        private void print_points_button_Click(object sender, EventArgs e)
        {
            cross_point_label.Visible = true;
            hint_1_2_label.Visible = true;
            hint_1_3_label.Visible = true;
            hint_2_3_label.Visible = true;
            print_1_2_label.Text = String.Format("({0:f5},{1:f5})",Cross_Points_1_2[0].x,Cross_Points_1_2[0].y);
            print_1_2_label.Visible = true;
            print_2_3_label.Text = String.Format("({0:f5},{1:f5})", Cross_Points_2_3[0].x, Cross_Points_2_3[0].y);
            print_2_3_label.Visible = true;
            print_1_3_label.Text = String.Format("({0:f5},{1:f5})", Cross_Points_1_3[0].x, Cross_Points_1_3[0].y);
            print_1_3_label.Visible = true;
            print_points_button.Visible = false;
            area_button.Visible = true;
            
        }

        private void area_button_Click(object sender, EventArgs e)
        {
            cross_point_label.Visible = false;
            hint_1_2_label.Visible = false;
            hint_1_3_label.Visible = false;
            hint_2_3_label.Visible = false;
            print_1_2_label.Visible = false;
            print_2_3_label.Visible = false;
            print_1_3_label.Visible = false;
            square = Square.Final_Square(Cross_Points_2_3[0].x, Cross_Points_1_2[0].x, Cross_Points_1_3[0].x,
                                                          box.F2, box.F1, box.F3, double.Parse(eps_box.Text) , int.Parse(partition_box.Text));
            
            area_button.Visible = false;
            print_area_button.Visible = true;
        }

        private void print_area_button_Click(object sender, EventArgs e)
        {
            area_label.Text = String.Format("Площадь фигуры равна {0:f8},\nпри погрешности {1:f8}", square.value, square.error);
            area_label.Visible = true;
            print_area_button.Visible = false;
        }
    }
}
