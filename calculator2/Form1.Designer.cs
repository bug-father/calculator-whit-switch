namespace calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btn_power = new System.Windows.Forms.Button();
            this.lbl_oprand = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.lbl_History = new System.Windows.Forms.Label();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Radical = new System.Windows.Forms.Button();
            this.btn_ClearAll = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_devide = new System.Windows.Forms.Button();
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_Dot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Input
            // 
            this.txt_Input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_Input.Location = new System.Drawing.Point(2, 12);
            this.txt_Input.Multiline = true;
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(266, 54);
            this.txt_Input.TabIndex = 0;
            this.txt_Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Input_KeyPress);
            // 
            // btn_power
            // 
            this.btn_power.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_power.Location = new System.Drawing.Point(132, 155);
            this.btn_power.Name = "btn_power";
            this.btn_power.Size = new System.Drawing.Size(61, 30);
            this.btn_power.TabIndex = 1;
            this.btn_power.Text = "x^2";
            this.btn_power.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_power.UseVisualStyleBackColor = true;
            this.btn_power.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // lbl_oprand
            // 
            this.lbl_oprand.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_oprand.Location = new System.Drawing.Point(2, 67);
            this.lbl_oprand.Name = "lbl_oprand";
            this.lbl_oprand.Size = new System.Drawing.Size(266, 39);
            this.lbl_oprand.TabIndex = 2;
            // 
            // lbl_Result
            // 
            this.lbl_Result.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Result.Location = new System.Drawing.Point(2, 106);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(266, 39);
            this.lbl_Result.TabIndex = 3;
            // 
            // lbl_History
            // 
            this.lbl_History.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_History.Location = new System.Drawing.Point(274, 13);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(208, 384);
            this.lbl_History.TabIndex = 4;
            // 
            // btn_Log
            // 
            this.btn_Log.Location = new System.Drawing.Point(195, 148);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(61, 42);
            this.btn_Log.TabIndex = 5;
            this.btn_Log.Text = "log";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_Radical
            // 
            this.btn_Radical.Location = new System.Drawing.Point(72, 155);
            this.btn_Radical.Name = "btn_Radical";
            this.btn_Radical.Size = new System.Drawing.Size(61, 30);
            this.btn_Radical.TabIndex = 6;
            this.btn_Radical.Text = "√";
            this.btn_Radical.UseVisualStyleBackColor = true;
            this.btn_Radical.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_ClearAll
            // 
            this.btn_ClearAll.Location = new System.Drawing.Point(12, 155);
            this.btn_ClearAll.Name = "btn_ClearAll";
            this.btn_ClearAll.Size = new System.Drawing.Size(61, 30);
            this.btn_ClearAll.TabIndex = 7;
            this.btn_ClearAll.Text = "CLR";
            this.btn_ClearAll.UseVisualStyleBackColor = true;
            this.btn_ClearAll.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 195);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(54, 47);
            this.btn_1.TabIndex = 8;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(132, 195);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(54, 47);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(72, 195);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(54, 47);
            this.btn_2.TabIndex = 10;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(72, 248);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(54, 47);
            this.btn_5.TabIndex = 13;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(132, 248);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(54, 47);
            this.btn_6.TabIndex = 12;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 248);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(54, 47);
            this.btn_4.TabIndex = 11;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(72, 301);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(54, 47);
            this.btn_8.TabIndex = 16;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(132, 301);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(54, 47);
            this.btn_9.TabIndex = 15;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 301);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(54, 47);
            this.btn_7.TabIndex = 14;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(195, 196);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(61, 47);
            this.btn_sum.TabIndex = 17;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(195, 301);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(61, 47);
            this.btn_multi.TabIndex = 19;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(195, 248);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(61, 47);
            this.btn_minus.TabIndex = 18;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_devide
            // 
            this.btn_devide.Location = new System.Drawing.Point(195, 354);
            this.btn_devide.Name = "btn_devide";
            this.btn_devide.Size = new System.Drawing.Size(61, 42);
            this.btn_devide.TabIndex = 20;
            this.btn_devide.Text = "÷";
            this.btn_devide.UseVisualStyleBackColor = true;
            this.btn_devide.Click += new System.EventHandler(this.btn_ClearAll_Click);
            // 
            // btn_Equal
            // 
            this.btn_Equal.Location = new System.Drawing.Point(12, 354);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(54, 42);
            this.btn_Equal.TabIndex = 21;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = true;
            this.btn_Equal.Click += new System.EventHandler(this.btn_Equal_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(72, 354);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(54, 42);
            this.btn_0.TabIndex = 22;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_Dot
            // 
            this.btn_Dot.Location = new System.Drawing.Point(132, 354);
            this.btn_Dot.Name = "btn_Dot";
            this.btn_Dot.Size = new System.Drawing.Size(54, 42);
            this.btn_Dot.TabIndex = 23;
            this.btn_Dot.Text = ".";
            this.btn_Dot.UseVisualStyleBackColor = true;
            this.btn_Dot.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 401);
            this.Controls.Add(this.btn_Dot);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btn_devide);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_ClearAll);
            this.Controls.Add(this.btn_Radical);
            this.Controls.Add(this.btn_Log);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_oprand);
            this.Controls.Add(this.btn_power);
            this.Controls.Add(this.txt_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Input;
        private Button btn_power;
        private Label lbl_oprand;
        private Label lbl_Result;
        private Label lbl_History;
        private Button btn_Log;
        private Button btn_Radical;
        private Button btn_ClearAll;
        private Button btn_1;
        private Button btn_3;
        private Button btn_2;
        private Button btn_5;
        private Button btn_6;
        private Button btn_4;
        private Button btn_8;
        private Button btn_9;
        private Button btn_7;
        private Button btn_sum;
        private Button btn_multi;
        private Button btn_minus;
        private Button btn_devide;
        private Button btn_Equal;
        private Button btn_0;
        private Button btn_Dot;
    }
}