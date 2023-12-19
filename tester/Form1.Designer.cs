namespace tester {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorRate_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.left_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.right_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.method_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.negative_radioButton = new System.Windows.Forms.RadioButton();
            this.positive_radioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.coef_textBox = new System.Windows.Forms.TextBox();
            this.generateTests_button = new System.Windows.Forms.Button();
            this.test_button = new System.Windows.Forms.Button();
            this.read_button = new System.Windows.Forms.Button();
            this.saveTests_button = new System.Windows.Forms.Button();
            this.save_result_button = new System.Windows.Forms.Button();
            this.test_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passed_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.failed_textBox = new System.Windows.Forms.TextBox();
            this.step_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.button_plotTimes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRate_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество тест-кейсов";
            // 
            // count_numericUpDown
            // 
            this.count_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_numericUpDown.Location = new System.Drawing.Point(210, 15);
            this.count_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.count_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.count_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_numericUpDown.Name = "count_numericUpDown";
            this.count_numericUpDown.Size = new System.Drawing.Size(145, 26);
            this.count_numericUpDown.TabIndex = 1;
            this.count_numericUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // errorRate_numericUpDown
            // 
            this.errorRate_numericUpDown.DecimalPlaces = 3;
            this.errorRate_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorRate_numericUpDown.Location = new System.Drawing.Point(210, 105);
            this.errorRate_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.errorRate_numericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.errorRate_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.errorRate_numericUpDown.Name = "errorRate_numericUpDown";
            this.errorRate_numericUpDown.Size = new System.Drawing.Size(145, 26);
            this.errorRate_numericUpDown.TabIndex = 3;
            this.errorRate_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(87, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Погрешность";
            // 
            // left_numericUpDown
            // 
            this.left_numericUpDown.DecimalPlaces = 3;
            this.left_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left_numericUpDown.Location = new System.Drawing.Point(210, 138);
            this.left_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.left_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.left_numericUpDown.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.left_numericUpDown.Name = "left_numericUpDown";
            this.left_numericUpDown.Size = new System.Drawing.Size(145, 26);
            this.left_numericUpDown.TabIndex = 5;
            this.left_numericUpDown.Value = new decimal(new int[] {
            31,
            0,
            0,
            -2147418112});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(80, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Левая граница";
            // 
            // right_numericUpDown
            // 
            this.right_numericUpDown.DecimalPlaces = 3;
            this.right_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right_numericUpDown.Location = new System.Drawing.Point(210, 171);
            this.right_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.right_numericUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.right_numericUpDown.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.right_numericUpDown.Name = "right_numericUpDown";
            this.right_numericUpDown.Size = new System.Drawing.Size(145, 26);
            this.right_numericUpDown.TabIndex = 7;
            this.right_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Правая граница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Метод";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // method_comboBox
            // 
            this.method_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method_comboBox.FormattingEnabled = true;
            this.method_comboBox.Items.AddRange(new object[] {
            "парабол",
            "трапеции",
            "Монте-Карло"});
            this.method_comboBox.Location = new System.Drawing.Point(209, 265);
            this.method_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.method_comboBox.Name = "method_comboBox";
            this.method_comboBox.Size = new System.Drawing.Size(146, 28);
            this.method_comboBox.TabIndex = 9;
            this.method_comboBox.Text = "парабол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.negative_radioButton);
            this.groupBox1.Controls.Add(this.positive_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(43, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // negative_radioButton
            // 
            this.negative_radioButton.AutoSize = true;
            this.negative_radioButton.Location = new System.Drawing.Point(156, 18);
            this.negative_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.negative_radioButton.Name = "negative_radioButton";
            this.negative_radioButton.Size = new System.Drawing.Size(120, 24);
            this.negative_radioButton.TabIndex = 1;
            this.negative_radioButton.Text = "Негативные";
            this.negative_radioButton.UseVisualStyleBackColor = true;
            // 
            // positive_radioButton
            // 
            this.positive_radioButton.AutoSize = true;
            this.positive_radioButton.Checked = true;
            this.positive_radioButton.Location = new System.Drawing.Point(24, 18);
            this.positive_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.positive_radioButton.Name = "positive_radioButton";
            this.positive_radioButton.Size = new System.Drawing.Size(121, 24);
            this.positive_radioButton.TabIndex = 0;
            this.positive_radioButton.TabStop = true;
            this.positive_radioButton.Text = "Позитивные";
            this.positive_radioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(39, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Коэффициенты полинома через пробел";
            // 
            // coef_textBox
            // 
            this.coef_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_textBox.Location = new System.Drawing.Point(20, 338);
            this.coef_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.coef_textBox.Name = "coef_textBox";
            this.coef_textBox.ReadOnly = true;
            this.coef_textBox.Size = new System.Drawing.Size(343, 26);
            this.coef_textBox.TabIndex = 13;
            // 
            // generateTests_button
            // 
            this.generateTests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateTests_button.Location = new System.Drawing.Point(20, 377);
            this.generateTests_button.Margin = new System.Windows.Forms.Padding(2);
            this.generateTests_button.Name = "generateTests_button";
            this.generateTests_button.Size = new System.Drawing.Size(145, 54);
            this.generateTests_button.TabIndex = 14;
            this.generateTests_button.Text = "Сгенерировать тест-кейсы";
            this.generateTests_button.UseVisualStyleBackColor = true;
            this.generateTests_button.Click += new System.EventHandler(this.generateTests_button_Click);
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.test_button.Enabled = false;
            this.test_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_button.Location = new System.Drawing.Point(20, 437);
            this.test_button.Margin = new System.Windows.Forms.Padding(2);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(342, 40);
            this.test_button.TabIndex = 15;
            this.test_button.Text = "Пройти";
            this.test_button.UseVisualStyleBackColor = false;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // read_button
            // 
            this.read_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_button.Location = new System.Drawing.Point(217, 377);
            this.read_button.Margin = new System.Windows.Forms.Padding(2);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(145, 54);
            this.read_button.TabIndex = 16;
            this.read_button.Text = "Загрузить тест-кейсы";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // saveTests_button
            // 
            this.saveTests_button.Enabled = false;
            this.saveTests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTests_button.Location = new System.Drawing.Point(20, 481);
            this.saveTests_button.Margin = new System.Windows.Forms.Padding(2);
            this.saveTests_button.Name = "saveTests_button";
            this.saveTests_button.Size = new System.Drawing.Size(342, 40);
            this.saveTests_button.TabIndex = 17;
            this.saveTests_button.Text = "Сохранить тест-кейсы";
            this.saveTests_button.UseVisualStyleBackColor = true;
            this.saveTests_button.Click += new System.EventHandler(this.saveTests_button_Click);
            // 
            // save_result_button
            // 
            this.save_result_button.Enabled = false;
            this.save_result_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_result_button.Location = new System.Drawing.Point(20, 526);
            this.save_result_button.Margin = new System.Windows.Forms.Padding(2);
            this.save_result_button.Name = "save_result_button";
            this.save_result_button.Size = new System.Drawing.Size(342, 40);
            this.save_result_button.TabIndex = 18;
            this.save_result_button.Text = "Сохранить результат";
            this.save_result_button.UseVisualStyleBackColor = true;
            this.save_result_button.Click += new System.EventHandler(this.save_result_button_Click);
            // 
            // test_textBox
            // 
            this.test_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_textBox.Location = new System.Drawing.Point(375, 44);
            this.test_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.test_textBox.Multiline = true;
            this.test_textBox.Name = "test_textBox";
            this.test_textBox.ReadOnly = true;
            this.test_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.test_textBox.Size = new System.Drawing.Size(235, 599);
            this.test_textBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(436, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Тест-кейсы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(645, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Пройденные тест-кейсы";
            // 
            // passed_textBox
            // 
            this.passed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passed_textBox.Location = new System.Drawing.Point(624, 44);
            this.passed_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.passed_textBox.Multiline = true;
            this.passed_textBox.Name = "passed_textBox";
            this.passed_textBox.ReadOnly = true;
            this.passed_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passed_textBox.Size = new System.Drawing.Size(232, 599);
            this.passed_textBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(886, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Непройденные тест-кейсы";
            // 
            // failed_textBox
            // 
            this.failed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.failed_textBox.Location = new System.Drawing.Point(870, 44);
            this.failed_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.failed_textBox.Multiline = true;
            this.failed_textBox.Name = "failed_textBox";
            this.failed_textBox.ReadOnly = true;
            this.failed_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.failed_textBox.Size = new System.Drawing.Size(234, 599);
            this.failed_textBox.TabIndex = 23;
            // 
            // step_numericUpDown
            // 
            this.step_numericUpDown.DecimalPlaces = 6;
            this.step_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.step_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.step_numericUpDown.Location = new System.Drawing.Point(210, 211);
            this.step_numericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.step_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.step_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.step_numericUpDown.Name = "step_numericUpDown";
            this.step_numericUpDown.Size = new System.Drawing.Size(145, 26);
            this.step_numericUpDown.TabIndex = 26;
            this.step_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.step_numericUpDown.ValueChanged += new System.EventHandler(this.step_numericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(35, 211);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Шаг интегрирования";
            // 
            // button_plotTimes
            // 
            this.button_plotTimes.Enabled = false;
            this.button_plotTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plotTimes.Location = new System.Drawing.Point(20, 581);
            this.button_plotTimes.Margin = new System.Windows.Forms.Padding(2);
            this.button_plotTimes.Name = "button_plotTimes";
            this.button_plotTimes.Size = new System.Drawing.Size(342, 40);
            this.button_plotTimes.TabIndex = 27;
            this.button_plotTimes.Text = "Нарисовать графики";
            this.button_plotTimes.UseVisualStyleBackColor = true;
            this.button_plotTimes.Click += new System.EventHandler(this.button_plotTimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 652);
            this.Controls.Add(this.button_plotTimes);
            this.Controls.Add(this.step_numericUpDown);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.failed_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passed_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.test_textBox);
            this.Controls.Add(this.save_result_button);
            this.Controls.Add(this.saveTests_button);
            this.Controls.Add(this.read_button);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.generateTests_button);
            this.Controls.Add(this.coef_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.method_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.right_numericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.left_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errorRate_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.count_numericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Тестирование Абрамян, Галанов";
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRate_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count_numericUpDown;
        private System.Windows.Forms.NumericUpDown errorRate_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown left_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown right_numericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox method_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton negative_radioButton;
        private System.Windows.Forms.RadioButton positive_radioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coef_textBox;
        private System.Windows.Forms.Button generateTests_button;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.Button saveTests_button;
        private System.Windows.Forms.Button save_result_button;
        private System.Windows.Forms.TextBox test_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passed_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox failed_textBox;
        private System.Windows.Forms.NumericUpDown step_numericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_plotTimes;
    }
}

