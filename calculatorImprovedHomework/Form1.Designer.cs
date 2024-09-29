namespace calculatorImprovedHomework
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seven = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.five = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.allClear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.leftArr = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Info;
            this.seven.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(104, 199);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(58, 46);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.Info;
            this.displayBox.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(104, 139);
            this.displayBox.MaxLength = 9999999;
            this.displayBox.Name = "displayBox";
            this.displayBox.ReadOnly = true;
            this.displayBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.displayBox.Size = new System.Drawing.Size(419, 46);
            this.displayBox.TabIndex = 1;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.displayBox.TextChanged += new System.EventHandler(this.displayBox_TextChanged);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.Info;
            this.five.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(194, 269);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(58, 46);
            this.five.TabIndex = 2;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.Info;
            this.zero.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(194, 403);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(58, 46);
            this.zero.TabIndex = 3;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Info;
            this.three.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(288, 337);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(58, 46);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Info;
            this.two.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(194, 337);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(58, 46);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Info;
            this.one.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(104, 337);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(58, 46);
            this.one.TabIndex = 6;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.Info;
            this.six.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(288, 269);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(58, 46);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.Info;
            this.four.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(104, 269);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(58, 46);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.Info;
            this.nine.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(288, 199);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(58, 46);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.Info;
            this.eight.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(194, 199);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(58, 46);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Info;
            this.minus.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(370, 403);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(58, 46);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Info;
            this.plus.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(370, 337);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(58, 46);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.Info;
            this.multiply.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(370, 269);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(58, 46);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.Info;
            this.divide.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(370, 199);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 46);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // allClear
            // 
            this.allClear.BackColor = System.Drawing.SystemColors.Info;
            this.allClear.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClear.Location = new System.Drawing.Point(444, 335);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(79, 114);
            this.allClear.TabIndex = 15;
            this.allClear.Text = "AC";
            this.allClear.UseVisualStyleBackColor = false;
            this.allClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.Info;
            this.dot.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(104, 403);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(58, 46);
            this.dot.TabIndex = 16;
            this.dot.Text = ".";
            this.dot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // leftArr
            // 
            this.leftArr.BackColor = System.Drawing.SystemColors.Info;
            this.leftArr.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftArr.Location = new System.Drawing.Point(444, 198);
            this.leftArr.Name = "leftArr";
            this.leftArr.Size = new System.Drawing.Size(79, 117);
            this.leftArr.TabIndex = 17;
            this.leftArr.Text = "←";
            this.leftArr.UseVisualStyleBackColor = false;
            this.leftArr.Click += new System.EventHandler(this.leftArr_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.SystemColors.Info;
            this.equal.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(288, 401);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(58, 46);
            this.equal.TabIndex = 18;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.displayBox);
            this.panel1.Controls.Add(this.equal);
            this.panel1.Controls.Add(this.seven);
            this.panel1.Controls.Add(this.leftArr);
            this.panel1.Controls.Add(this.five);
            this.panel1.Controls.Add(this.dot);
            this.panel1.Controls.Add(this.zero);
            this.panel1.Controls.Add(this.allClear);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.divide);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.multiply);
            this.panel1.Controls.Add(this.one);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.six);
            this.panel1.Controls.Add(this.minus);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.eight);
            this.panel1.Controls.Add(this.nine);
            this.panel1.Location = new System.Drawing.Point(369, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 573);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1345, 710);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button allClear;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button leftArr;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Panel panel1;
    }
}

