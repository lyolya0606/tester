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
            this.leftStep_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rightStep_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRate_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftStep_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStep_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество тест-кейсов";
            // 
            // count_numericUpDown
            // 
            this.count_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count_numericUpDown.Location = new System.Drawing.Point(280, 18);
            this.count_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_numericUpDown.Name = "count_numericUpDown";
            this.count_numericUpDown.Size = new System.Drawing.Size(193, 30);
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
            this.errorRate_numericUpDown.Location = new System.Drawing.Point(280, 129);
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
            this.errorRate_numericUpDown.Size = new System.Drawing.Size(193, 30);
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
            this.label2.Location = new System.Drawing.Point(116, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Погрешность";
            // 
            // left_numericUpDown
            // 
            this.left_numericUpDown.DecimalPlaces = 3;
            this.left_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.left_numericUpDown.Location = new System.Drawing.Point(280, 170);
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
            this.left_numericUpDown.Size = new System.Drawing.Size(193, 30);
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
            this.label3.Location = new System.Drawing.Point(106, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Левая граница";
            // 
            // right_numericUpDown
            // 
            this.right_numericUpDown.DecimalPlaces = 3;
            this.right_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.right_numericUpDown.Location = new System.Drawing.Point(280, 211);
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
            this.right_numericUpDown.Size = new System.Drawing.Size(193, 30);
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
            this.label4.Location = new System.Drawing.Point(97, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Правая граница";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(179, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Метод";
            // 
            // method_comboBox
            // 
            this.method_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.method_comboBox.FormattingEnabled = true;
            this.method_comboBox.Items.AddRange(new object[] {
            "парабол",
            "трапеции",
            "Монте-Карло"});
            this.method_comboBox.Location = new System.Drawing.Point(280, 418);
            this.method_comboBox.Name = "method_comboBox";
            this.method_comboBox.Size = new System.Drawing.Size(193, 33);
            this.method_comboBox.TabIndex = 9;
            this.method_comboBox.Text = "парабол";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.negative_radioButton);
            this.groupBox1.Controls.Add(this.positive_radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(57, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // negative_radioButton
            // 
            this.negative_radioButton.AutoSize = true;
            this.negative_radioButton.Location = new System.Drawing.Point(208, 22);
            this.negative_radioButton.Name = "negative_radioButton";
            this.negative_radioButton.Size = new System.Drawing.Size(144, 29);
            this.negative_radioButton.TabIndex = 1;
            this.negative_radioButton.Text = "Негативные";
            this.negative_radioButton.UseVisualStyleBackColor = true;
            // 
            // positive_radioButton
            // 
            this.positive_radioButton.AutoSize = true;
            this.positive_radioButton.Checked = true;
            this.positive_radioButton.Location = new System.Drawing.Point(32, 22);
            this.positive_radioButton.Name = "positive_radioButton";
            this.positive_radioButton.Size = new System.Drawing.Size(149, 29);
            this.positive_radioButton.TabIndex = 0;
            this.positive_radioButton.TabStop = true;
            this.positive_radioButton.Text = "Позитивные";
            this.positive_radioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(43, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(397, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Коэффициенты полинома через пробел";
            // 
            // coef_textBox
            // 
            this.coef_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coef_textBox.Location = new System.Drawing.Point(17, 509);
            this.coef_textBox.Name = "coef_textBox";
            this.coef_textBox.Size = new System.Drawing.Size(456, 30);
            this.coef_textBox.TabIndex = 13;
            this.coef_textBox.Text = "1 2 3 4";
            // 
            // generateTests_button
            // 
            this.generateTests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateTests_button.Location = new System.Drawing.Point(17, 558);
            this.generateTests_button.Name = "generateTests_button";
            this.generateTests_button.Size = new System.Drawing.Size(193, 67);
            this.generateTests_button.TabIndex = 14;
            this.generateTests_button.Text = "Сгенерировать тест-кейсы";
            this.generateTests_button.UseVisualStyleBackColor = true;
            this.generateTests_button.Click += new System.EventHandler(this.generateTests_button_Click);
            // 
            // test_button
            // 
            this.test_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.test_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_button.Location = new System.Drawing.Point(17, 631);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(456, 49);
            this.test_button.TabIndex = 15;
            this.test_button.Text = "Пройти";
            this.test_button.UseVisualStyleBackColor = false;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // read_button
            // 
            this.read_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.read_button.Location = new System.Drawing.Point(280, 558);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(193, 67);
            this.read_button.TabIndex = 16;
            this.read_button.Text = "Загрузить тест-кейсы";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // saveTests_button
            // 
            this.saveTests_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveTests_button.Location = new System.Drawing.Point(17, 686);
            this.saveTests_button.Name = "saveTests_button";
            this.saveTests_button.Size = new System.Drawing.Size(456, 49);
            this.saveTests_button.TabIndex = 17;
            this.saveTests_button.Text = "Сохранить тест-кейсы";
            this.saveTests_button.UseVisualStyleBackColor = true;
            this.saveTests_button.Click += new System.EventHandler(this.saveTests_button_Click);
            // 
            // save_result_button
            // 
            this.save_result_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_result_button.Location = new System.Drawing.Point(17, 741);
            this.save_result_button.Name = "save_result_button";
            this.save_result_button.Size = new System.Drawing.Size(456, 49);
            this.save_result_button.TabIndex = 18;
            this.save_result_button.Text = "Сохранить результат";
            this.save_result_button.UseVisualStyleBackColor = true;
            this.save_result_button.Click += new System.EventHandler(this.save_result_button_Click);
            // 
            // test_textBox
            // 
            this.test_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.test_textBox.Location = new System.Drawing.Point(500, 54);
            this.test_textBox.Multiline = true;
            this.test_textBox.Name = "test_textBox";
            this.test_textBox.ReadOnly = true;
            this.test_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.test_textBox.Size = new System.Drawing.Size(312, 736);
            this.test_textBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(581, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Тест-кейсы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(860, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Пройденные тест-кейсы";
            // 
            // passed_textBox
            // 
            this.passed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passed_textBox.Location = new System.Drawing.Point(832, 54);
            this.passed_textBox.Multiline = true;
            this.passed_textBox.Name = "passed_textBox";
            this.passed_textBox.ReadOnly = true;
            this.passed_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passed_textBox.Size = new System.Drawing.Size(308, 736);
            this.passed_textBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1181, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(263, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Непройденные тест-кейсы";
            // 
            // failed_textBox
            // 
            this.failed_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.failed_textBox.Location = new System.Drawing.Point(1160, 54);
            this.failed_textBox.Multiline = true;
            this.failed_textBox.Name = "failed_textBox";
            this.failed_textBox.ReadOnly = true;
            this.failed_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.failed_textBox.Size = new System.Drawing.Size(310, 736);
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
            this.step_numericUpDown.Location = new System.Drawing.Point(280, 260);
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
            this.step_numericUpDown.Size = new System.Drawing.Size(193, 30);
            this.step_numericUpDown.TabIndex = 26;
            this.step_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(47, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Шаг интегрирования";
            // 
            // leftStep_numericUpDown
            // 
            this.leftStep_numericUpDown.DecimalPlaces = 6;
            this.leftStep_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftStep_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.leftStep_numericUpDown.Location = new System.Drawing.Point(102, 346);
            this.leftStep_numericUpDown.Maximum = new decimal(new int[] {
            499999,
            0,
            0,
            393216});
            this.leftStep_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.leftStep_numericUpDown.Name = "leftStep_numericUpDown";
            this.leftStep_numericUpDown.Size = new System.Drawing.Size(127, 30);
            this.leftStep_numericUpDown.TabIndex = 28;
            this.leftStep_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(112, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Границы шага интегрирования";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(57, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "от";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(268, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "до";
            // 
            // rightStep_numericUpDown
            // 
            this.rightStep_numericUpDown.DecimalPlaces = 6;
            this.rightStep_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightStep_numericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.rightStep_numericUpDown.Location = new System.Drawing.Point(313, 346);
            this.rightStep_numericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.rightStep_numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            393216});
            this.rightStep_numericUpDown.Name = "rightStep_numericUpDown";
            this.rightStep_numericUpDown.Size = new System.Drawing.Size(127, 30);
            this.rightStep_numericUpDown.TabIndex = 30;
            this.rightStep_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 802);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rightStep_numericUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.leftStep_numericUpDown);
            this.Controls.Add(this.label11);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Тестирование Бездудная, Колесникова, Рухлова";
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRate_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.step_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftStep_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightStep_numericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown leftStep_numericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown rightStep_numericUpDown;
    }
}

