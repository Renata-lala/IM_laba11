namespace ИМ_лаба11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chi_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.variance_label = new System.Windows.Forms.Label();
            this.error_labl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.error_average = new System.Windows.Forms.Label();
            this.mean_numeric = new System.Windows.Forms.NumericUpDown();
            this.variance_numeric = new System.Windows.Forms.NumericUpDown();
            this.size_numeric = new System.Windows.Forms.NumericUpDown();
            this.emp_var = new System.Windows.Forms.NumericUpDown();
            this.chi_emp = new System.Windows.Forms.NumericUpDown();
            this.emp_mean = new System.Windows.Forms.NumericUpDown();
            this.error_mean = new System.Windows.Forms.NumericUpDown();
            this.error_var = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_var)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chi_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_var)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mean";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Variance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sample Size";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(91, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(389, 34);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(882, 283);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(419, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(419, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Variance";
            // 
            // chi_label
            // 
            this.chi_label.AutoSize = true;
            this.chi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chi_label.Location = new System.Drawing.Point(419, 409);
            this.chi_label.Name = "chi_label";
            this.chi_label.Size = new System.Drawing.Size(40, 22);
            this.chi_label.TabIndex = 12;
            this.chi_label.Text = "Chi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(532, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 13;
            // 
            // variance_label
            // 
            this.variance_label.AutoSize = true;
            this.variance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variance_label.Location = new System.Drawing.Point(532, 372);
            this.variance_label.Name = "variance_label";
            this.variance_label.Size = new System.Drawing.Size(0, 22);
            this.variance_label.TabIndex = 14;
            // 
            // error_labl1
            // 
            this.error_labl1.AutoSize = true;
            this.error_labl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_labl1.Location = new System.Drawing.Point(658, 337);
            this.error_labl1.Name = "error_labl1";
            this.error_labl1.Size = new System.Drawing.Size(65, 22);
            this.error_labl1.TabIndex = 16;
            this.error_labl1.Text = "error=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(658, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "error=";
            // 
            // error_average
            // 
            this.error_average.AutoSize = true;
            this.error_average.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_average.Location = new System.Drawing.Point(742, 337);
            this.error_average.Name = "error_average";
            this.error_average.Size = new System.Drawing.Size(0, 22);
            this.error_average.TabIndex = 18;
            // 
            // mean_numeric
            // 
            this.mean_numeric.DecimalPlaces = 2;
            this.mean_numeric.Location = new System.Drawing.Point(150, 66);
            this.mean_numeric.Name = "mean_numeric";
            this.mean_numeric.Size = new System.Drawing.Size(120, 22);
            this.mean_numeric.TabIndex = 20;
            this.mean_numeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // variance_numeric
            // 
            this.variance_numeric.DecimalPlaces = 2;
            this.variance_numeric.Location = new System.Drawing.Point(150, 134);
            this.variance_numeric.Name = "variance_numeric";
            this.variance_numeric.Size = new System.Drawing.Size(120, 22);
            this.variance_numeric.TabIndex = 21;
            this.variance_numeric.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // size_numeric
            // 
            this.size_numeric.Location = new System.Drawing.Point(171, 192);
            this.size_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.size_numeric.Name = "size_numeric";
            this.size_numeric.Size = new System.Drawing.Size(120, 22);
            this.size_numeric.TabIndex = 22;
            this.size_numeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // emp_var
            // 
            this.emp_var.DecimalPlaces = 2;
            this.emp_var.Location = new System.Drawing.Point(523, 372);
            this.emp_var.Name = "emp_var";
            this.emp_var.Size = new System.Drawing.Size(68, 22);
            this.emp_var.TabIndex = 23;
            this.emp_var.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // chi_emp
            // 
            this.chi_emp.DecimalPlaces = 2;
            this.chi_emp.Location = new System.Drawing.Point(493, 412);
            this.chi_emp.Name = "chi_emp";
            this.chi_emp.Size = new System.Drawing.Size(71, 22);
            this.chi_emp.TabIndex = 24;
            this.chi_emp.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // emp_mean
            // 
            this.emp_mean.DecimalPlaces = 2;
            this.emp_mean.Location = new System.Drawing.Point(523, 337);
            this.emp_mean.Name = "emp_mean";
            this.emp_mean.Size = new System.Drawing.Size(68, 22);
            this.emp_mean.TabIndex = 25;
            this.emp_mean.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // error_mean
            // 
            this.error_mean.DecimalPlaces = 2;
            this.error_mean.Location = new System.Drawing.Point(748, 340);
            this.error_mean.Name = "error_mean";
            this.error_mean.Size = new System.Drawing.Size(71, 22);
            this.error_mean.TabIndex = 26;
            this.error_mean.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // error_var
            // 
            this.error_var.DecimalPlaces = 2;
            this.error_var.Location = new System.Drawing.Point(748, 375);
            this.error_var.Name = "error_var";
            this.error_var.Size = new System.Drawing.Size(71, 22);
            this.error_var.TabIndex = 27;
            this.error_var.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(658, 419);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Chi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(905, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Кол-во интервалов";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(1126, 337);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.error_var);
            this.Controls.Add(this.error_mean);
            this.Controls.Add(this.emp_mean);
            this.Controls.Add(this.chi_emp);
            this.Controls.Add(this.emp_var);
            this.Controls.Add(this.size_numeric);
            this.Controls.Add(this.variance_numeric);
            this.Controls.Add(this.mean_numeric);
            this.Controls.Add(this.error_average);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.error_labl1);
            this.Controls.Add(this.variance_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chi_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mean_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variance_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_var)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chi_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_mean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_var)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label chi_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label variance_label;
        private System.Windows.Forms.Label error_labl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label error_average;
        private System.Windows.Forms.NumericUpDown mean_numeric;
        private System.Windows.Forms.NumericUpDown variance_numeric;
        private System.Windows.Forms.NumericUpDown size_numeric;
        private System.Windows.Forms.NumericUpDown emp_var;
        private System.Windows.Forms.NumericUpDown chi_emp;
        private System.Windows.Forms.NumericUpDown emp_mean;
        private System.Windows.Forms.NumericUpDown error_mean;
        private System.Windows.Forms.NumericUpDown error_var;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

