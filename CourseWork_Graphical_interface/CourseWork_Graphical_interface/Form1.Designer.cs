namespace CourseWork_Graphical_interface
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit_button = new System.Windows.Forms.Button();
            this.A_value_label = new System.Windows.Forms.Label();
            this.b_value_label = new System.Windows.Forms.Label();
            this.c_value_label = new System.Windows.Forms.Label();
            this.a_value_box = new System.Windows.Forms.TextBox();
            this.b_value_box = new System.Windows.Forms.TextBox();
            this.c_value_box = new System.Windows.Forms.TextBox();
            this.next_button_1 = new System.Windows.Forms.Button();
            this.back_button_1 = new System.Windows.Forms.Button();
            this.left_limit_label = new System.Windows.Forms.Label();
            this.right_limit_label = new System.Windows.Forms.Label();
            this.limit_title_label = new System.Windows.Forms.Label();
            this.parametries_title_label = new System.Windows.Forms.Label();
            this.next_button_2 = new System.Windows.Forms.Button();
            this.left_limit_box = new System.Windows.Forms.TextBox();
            this.right_limit_box = new System.Windows.Forms.TextBox();
            this.fault_label = new System.Windows.Forms.Label();
            this.partition_label = new System.Windows.Forms.Label();
            this.eps_label = new System.Windows.Forms.Label();
            this.eps_box = new System.Windows.Forms.TextBox();
            this.partition_box = new System.Windows.Forms.TextBox();
            this.back_button_2 = new System.Windows.Forms.Button();
            this.calculate_button = new System.Windows.Forms.Button();
            this.print_points_button = new System.Windows.Forms.Button();
            this.cross_point_label = new System.Windows.Forms.Label();
            this.hint_1_2_label = new System.Windows.Forms.Label();
            this.hint_2_3_label = new System.Windows.Forms.Label();
            this.hint_1_3_label = new System.Windows.Forms.Label();
            this.print_1_2_label = new System.Windows.Forms.Label();
            this.print_2_3_label = new System.Windows.Forms.Label();
            this.print_1_3_label = new System.Windows.Forms.Label();
            this.area_button = new System.Windows.Forms.Button();
            this.print_area_button = new System.Windows.Forms.Button();
            this.area_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(195, 227);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // A_value_label
            // 
            this.A_value_label.AutoSize = true;
            this.A_value_label.Location = new System.Drawing.Point(12, 35);
            this.A_value_label.Name = "A_value_label";
            this.A_value_label.Size = new System.Drawing.Size(67, 13);
            this.A_value_label.TabIndex = 1;
            this.A_value_label.Text = "Значение a:";
            // 
            // b_value_label
            // 
            this.b_value_label.AutoSize = true;
            this.b_value_label.Location = new System.Drawing.Point(12, 61);
            this.b_value_label.Name = "b_value_label";
            this.b_value_label.Size = new System.Drawing.Size(67, 13);
            this.b_value_label.TabIndex = 2;
            this.b_value_label.Text = "Значение b:";
            // 
            // c_value_label
            // 
            this.c_value_label.AutoSize = true;
            this.c_value_label.Location = new System.Drawing.Point(12, 85);
            this.c_value_label.Name = "c_value_label";
            this.c_value_label.Size = new System.Drawing.Size(67, 13);
            this.c_value_label.TabIndex = 3;
            this.c_value_label.Text = "Значение c:";
            // 
            // a_value_box
            // 
            this.a_value_box.Location = new System.Drawing.Point(85, 32);
            this.a_value_box.Name = "a_value_box";
            this.a_value_box.Size = new System.Drawing.Size(100, 20);
            this.a_value_box.TabIndex = 4;
            this.a_value_box.Text = "1";
            // 
            // b_value_box
            // 
            this.b_value_box.Location = new System.Drawing.Point(85, 58);
            this.b_value_box.Name = "b_value_box";
            this.b_value_box.Size = new System.Drawing.Size(100, 20);
            this.b_value_box.TabIndex = 5;
            this.b_value_box.Text = "7";
            // 
            // c_value_box
            // 
            this.c_value_box.Location = new System.Drawing.Point(85, 84);
            this.c_value_box.Name = "c_value_box";
            this.c_value_box.Size = new System.Drawing.Size(100, 20);
            this.c_value_box.TabIndex = 6;
            this.c_value_box.Text = "9";
            // 
            // next_button_1
            // 
            this.next_button_1.Location = new System.Drawing.Point(94, 149);
            this.next_button_1.Name = "next_button_1";
            this.next_button_1.Size = new System.Drawing.Size(75, 23);
            this.next_button_1.TabIndex = 7;
            this.next_button_1.Text = "Далее";
            this.next_button_1.UseVisualStyleBackColor = true;
            this.next_button_1.Click += new System.EventHandler(this.next_button_1_Click);
            // 
            // back_button_1
            // 
            this.back_button_1.Enabled = false;
            this.back_button_1.Location = new System.Drawing.Point(4, 149);
            this.back_button_1.Name = "back_button_1";
            this.back_button_1.Size = new System.Drawing.Size(75, 23);
            this.back_button_1.TabIndex = 8;
            this.back_button_1.Text = "Назад";
            this.back_button_1.UseVisualStyleBackColor = true;
            this.back_button_1.Click += new System.EventHandler(this.back_button_1_Click);
            // 
            // left_limit_label
            // 
            this.left_limit_label.AutoSize = true;
            this.left_limit_label.Location = new System.Drawing.Point(2, 36);
            this.left_limit_label.Name = "left_limit_label";
            this.left_limit_label.Size = new System.Drawing.Size(86, 13);
            this.left_limit_label.TabIndex = 9;
            this.left_limit_label.Text = "Левая граница:";
            this.left_limit_label.Visible = false;
            // 
            // right_limit_label
            // 
            this.right_limit_label.AutoSize = true;
            this.right_limit_label.Location = new System.Drawing.Point(2, 62);
            this.right_limit_label.Name = "right_limit_label";
            this.right_limit_label.Size = new System.Drawing.Size(92, 13);
            this.right_limit_label.TabIndex = 10;
            this.right_limit_label.Text = "Правая граница:";
            this.right_limit_label.Visible = false;
            // 
            // limit_title_label
            // 
            this.limit_title_label.AutoSize = true;
            this.limit_title_label.Location = new System.Drawing.Point(42, 13);
            this.limit_title_label.Name = "limit_title_label";
            this.limit_title_label.Size = new System.Drawing.Size(133, 13);
            this.limit_title_label.TabIndex = 11;
            this.limit_title_label.Text = "Область поиска фигуры:";
            this.limit_title_label.Visible = false;
            // 
            // parametries_title_label
            // 
            this.parametries_title_label.AutoSize = true;
            this.parametries_title_label.Location = new System.Drawing.Point(38, 9);
            this.parametries_title_label.Name = "parametries_title_label";
            this.parametries_title_label.Size = new System.Drawing.Size(122, 13);
            this.parametries_title_label.TabIndex = 12;
            this.parametries_title_label.Text = "Значения параметров:";
            // 
            // next_button_2
            // 
            this.next_button_2.Location = new System.Drawing.Point(94, 149);
            this.next_button_2.Name = "next_button_2";
            this.next_button_2.Size = new System.Drawing.Size(75, 23);
            this.next_button_2.TabIndex = 13;
            this.next_button_2.Text = "Далее";
            this.next_button_2.UseVisualStyleBackColor = true;
            this.next_button_2.Visible = false;
            this.next_button_2.Click += new System.EventHandler(this.next_button_2_Click);
            // 
            // left_limit_box
            // 
            this.left_limit_box.Location = new System.Drawing.Point(94, 32);
            this.left_limit_box.Name = "left_limit_box";
            this.left_limit_box.Size = new System.Drawing.Size(100, 20);
            this.left_limit_box.TabIndex = 14;
            this.left_limit_box.Text = "0";
            this.left_limit_box.Visible = false;
            // 
            // right_limit_box
            // 
            this.right_limit_box.Location = new System.Drawing.Point(94, 55);
            this.right_limit_box.Name = "right_limit_box";
            this.right_limit_box.Size = new System.Drawing.Size(100, 20);
            this.right_limit_box.TabIndex = 15;
            this.right_limit_box.Text = "4";
            this.right_limit_box.Visible = false;
            // 
            // fault_label
            // 
            this.fault_label.AutoSize = true;
            this.fault_label.Location = new System.Drawing.Point(39, 16);
            this.fault_label.Name = "fault_label";
            this.fault_label.Size = new System.Drawing.Size(184, 13);
            this.fault_label.TabIndex = 16;
            this.fault_label.Text = "Точность и количество разбиений:";
            this.fault_label.Visible = false;
            // 
            // partition_label
            // 
            this.partition_label.AutoSize = true;
            this.partition_label.Location = new System.Drawing.Point(3, 77);
            this.partition_label.Name = "partition_label";
            this.partition_label.Size = new System.Drawing.Size(126, 13);
            this.partition_label.TabIndex = 17;
            this.partition_label.Text = "Количество разбиений:";
            this.partition_label.Visible = false;
            // 
            // eps_label
            // 
            this.eps_label.AutoSize = true;
            this.eps_label.Location = new System.Drawing.Point(7, 49);
            this.eps_label.Name = "eps_label";
            this.eps_label.Size = new System.Drawing.Size(119, 13);
            this.eps_label.TabIndex = 18;
            this.eps_label.Text = "Точность выч-я точек:";
            this.eps_label.Visible = false;
            // 
            // eps_box
            // 
            this.eps_box.Location = new System.Drawing.Point(135, 42);
            this.eps_box.Name = "eps_box";
            this.eps_box.Size = new System.Drawing.Size(100, 20);
            this.eps_box.TabIndex = 19;
            this.eps_box.Text = "0,01";
            this.eps_box.Visible = false;
            // 
            // partition_box
            // 
            this.partition_box.Location = new System.Drawing.Point(135, 74);
            this.partition_box.Name = "partition_box";
            this.partition_box.Size = new System.Drawing.Size(100, 20);
            this.partition_box.TabIndex = 20;
            this.partition_box.Text = "400";
            this.partition_box.Visible = false;
            // 
            // back_button_2
            // 
            this.back_button_2.Location = new System.Drawing.Point(4, 149);
            this.back_button_2.Name = "back_button_2";
            this.back_button_2.Size = new System.Drawing.Size(75, 23);
            this.back_button_2.TabIndex = 21;
            this.back_button_2.Text = "Назад";
            this.back_button_2.UseVisualStyleBackColor = true;
            this.back_button_2.Visible = false;
            this.back_button_2.Click += new System.EventHandler(this.back_button_2_Click);
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(4, 184);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(84, 39);
            this.calculate_button.TabIndex = 22;
            this.calculate_button.Text = "Вычислить точки пересечения.";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Visible = false;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // print_points_button
            // 
            this.print_points_button.Location = new System.Drawing.Point(4, 184);
            this.print_points_button.Name = "print_points_button";
            this.print_points_button.Size = new System.Drawing.Size(84, 39);
            this.print_points_button.TabIndex = 23;
            this.print_points_button.Text = "вывод точек пересечения.";
            this.print_points_button.UseVisualStyleBackColor = true;
            this.print_points_button.Visible = false;
            this.print_points_button.Click += new System.EventHandler(this.print_points_button_Click);
            // 
            // cross_point_label
            // 
            this.cross_point_label.AutoSize = true;
            this.cross_point_label.Location = new System.Drawing.Point(54, 3);
            this.cross_point_label.Name = "cross_point_label";
            this.cross_point_label.Size = new System.Drawing.Size(108, 13);
            this.cross_point_label.TabIndex = 24;
            this.cross_point_label.Text = "Точки пересечения:";
            this.cross_point_label.Visible = false;
            // 
            // hint_1_2_label
            // 
            this.hint_1_2_label.AutoSize = true;
            this.hint_1_2_label.Location = new System.Drawing.Point(19, 29);
            this.hint_1_2_label.Name = "hint_1_2_label";
            this.hint_1_2_label.Size = new System.Drawing.Size(110, 13);
            this.hint_1_2_label.TabIndex = 25;
            this.hint_1_2_label.Text = "1-ая и 2-ая функции:";
            this.hint_1_2_label.Visible = false;
            // 
            // hint_2_3_label
            // 
            this.hint_2_3_label.AutoSize = true;
            this.hint_2_3_label.Location = new System.Drawing.Point(25, 57);
            this.hint_2_3_label.Name = "hint_2_3_label";
            this.hint_2_3_label.Size = new System.Drawing.Size(104, 13);
            this.hint_2_3_label.TabIndex = 26;
            this.hint_2_3_label.Text = "2-ая и 3-я функции:";
            this.hint_2_3_label.Visible = false;
            // 
            // hint_1_3_label
            // 
            this.hint_1_3_label.AutoSize = true;
            this.hint_1_3_label.Location = new System.Drawing.Point(25, 83);
            this.hint_1_3_label.Name = "hint_1_3_label";
            this.hint_1_3_label.Size = new System.Drawing.Size(104, 13);
            this.hint_1_3_label.TabIndex = 27;
            this.hint_1_3_label.Text = "1-ая и 3-я функции:";
            this.hint_1_3_label.Visible = false;
            // 
            // print_1_2_label
            // 
            this.print_1_2_label.AutoSize = true;
            this.print_1_2_label.Location = new System.Drawing.Point(154, 29);
            this.print_1_2_label.Name = "print_1_2_label";
            this.print_1_2_label.Size = new System.Drawing.Size(25, 13);
            this.print_1_2_label.TabIndex = 28;
            this.print_1_2_label.Text = "1_2";
            this.print_1_2_label.Visible = false;
            // 
            // print_2_3_label
            // 
            this.print_2_3_label.AutoSize = true;
            this.print_2_3_label.Location = new System.Drawing.Point(154, 57);
            this.print_2_3_label.Name = "print_2_3_label";
            this.print_2_3_label.Size = new System.Drawing.Size(25, 13);
            this.print_2_3_label.TabIndex = 29;
            this.print_2_3_label.Text = "2_3";
            this.print_2_3_label.Visible = false;
            // 
            // print_1_3_label
            // 
            this.print_1_3_label.AutoSize = true;
            this.print_1_3_label.Location = new System.Drawing.Point(154, 83);
            this.print_1_3_label.Name = "print_1_3_label";
            this.print_1_3_label.Size = new System.Drawing.Size(25, 13);
            this.print_1_3_label.TabIndex = 30;
            this.print_1_3_label.Text = "1_3";
            this.print_1_3_label.Visible = false;
            // 
            // area_button
            // 
            this.area_button.Location = new System.Drawing.Point(94, 184);
            this.area_button.Name = "area_button";
            this.area_button.Size = new System.Drawing.Size(75, 40);
            this.area_button.TabIndex = 31;
            this.area_button.Text = "Вычислить площадь";
            this.area_button.UseVisualStyleBackColor = true;
            this.area_button.Visible = false;
            this.area_button.Click += new System.EventHandler(this.area_button_Click);
            // 
            // print_area_button
            // 
            this.print_area_button.Location = new System.Drawing.Point(94, 184);
            this.print_area_button.Name = "print_area_button";
            this.print_area_button.Size = new System.Drawing.Size(75, 39);
            this.print_area_button.TabIndex = 32;
            this.print_area_button.Text = "Вывод площади";
            this.print_area_button.UseVisualStyleBackColor = true;
            this.print_area_button.Visible = false;
            this.print_area_button.Click += new System.EventHandler(this.print_area_button_Click);
            // 
            // area_label
            // 
            this.area_label.AutoSize = true;
            this.area_label.Location = new System.Drawing.Point(36, 49);
            this.area_label.Name = "area_label";
            this.area_label.Size = new System.Drawing.Size(52, 13);
            this.area_label.TabIndex = 33;
            this.area_label.Text = "площадь";
            this.area_label.Visible = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(38, 125);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(141, 13);
            this.error_label.TabIndex = 34;
            this.error_label.Text = "Некорректные значения!!!";
            this.error_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.area_label);
            this.Controls.Add(this.print_area_button);
            this.Controls.Add(this.area_button);
            this.Controls.Add(this.print_1_3_label);
            this.Controls.Add(this.print_2_3_label);
            this.Controls.Add(this.print_1_2_label);
            this.Controls.Add(this.hint_1_3_label);
            this.Controls.Add(this.hint_2_3_label);
            this.Controls.Add(this.hint_1_2_label);
            this.Controls.Add(this.cross_point_label);
            this.Controls.Add(this.print_points_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.back_button_2);
            this.Controls.Add(this.partition_box);
            this.Controls.Add(this.eps_box);
            this.Controls.Add(this.eps_label);
            this.Controls.Add(this.partition_label);
            this.Controls.Add(this.fault_label);
            this.Controls.Add(this.right_limit_box);
            this.Controls.Add(this.left_limit_box);
            this.Controls.Add(this.next_button_2);
            this.Controls.Add(this.parametries_title_label);
            this.Controls.Add(this.limit_title_label);
            this.Controls.Add(this.right_limit_label);
            this.Controls.Add(this.left_limit_label);
            this.Controls.Add(this.back_button_1);
            this.Controls.Add(this.next_button_1);
            this.Controls.Add(this.c_value_box);
            this.Controls.Add(this.b_value_box);
            this.Controls.Add(this.a_value_box);
            this.Controls.Add(this.c_value_label);
            this.Controls.Add(this.b_value_label);
            this.Controls.Add(this.A_value_label);
            this.Controls.Add(this.exit_button);
            this.Name = "Form1";
            this.Text = "Вычисление площади фигуры, ограниченной тремя кривыми.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label A_value_label;
        private System.Windows.Forms.Label b_value_label;
        private System.Windows.Forms.Label c_value_label;
        private System.Windows.Forms.TextBox a_value_box;
        private System.Windows.Forms.TextBox b_value_box;
        private System.Windows.Forms.TextBox c_value_box;
        private System.Windows.Forms.Button next_button_1;
        private System.Windows.Forms.Button back_button_1;
        private System.Windows.Forms.Label left_limit_label;
        private System.Windows.Forms.Label right_limit_label;
        private System.Windows.Forms.Label limit_title_label;
        private System.Windows.Forms.Label parametries_title_label;
        private System.Windows.Forms.Button next_button_2;
        private System.Windows.Forms.TextBox left_limit_box;
        private System.Windows.Forms.TextBox right_limit_box;
        private System.Windows.Forms.Label fault_label;
        private System.Windows.Forms.Label partition_label;
        private System.Windows.Forms.Label eps_label;
        private System.Windows.Forms.TextBox eps_box;
        private System.Windows.Forms.TextBox partition_box;
        private System.Windows.Forms.Button back_button_2;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button print_points_button;
        private System.Windows.Forms.Label cross_point_label;
        private System.Windows.Forms.Label hint_1_2_label;
        private System.Windows.Forms.Label hint_2_3_label;
        private System.Windows.Forms.Label hint_1_3_label;
        private System.Windows.Forms.Label print_1_2_label;
        private System.Windows.Forms.Label print_2_3_label;
        private System.Windows.Forms.Label print_1_3_label;
        private System.Windows.Forms.Button area_button;
        private System.Windows.Forms.Button print_area_button;
        private System.Windows.Forms.Label area_label;
        private System.Windows.Forms.Label error_label;
    }
}

