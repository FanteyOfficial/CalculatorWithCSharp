namespace Calculator
{
    partial class Calculator
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
            this.Display = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B0 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.Sottr = new System.Windows.Forms.Button();
            this.Molt = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.Ugual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Display.Dock = System.Windows.Forms.DockStyle.Top;
            this.Display.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Margin = new System.Windows.Forms.Padding(0);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(250, 29);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.SystemColors.Control;
            this.B1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(0, 129);
            this.B1.Margin = new System.Windows.Forms.Padding(0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(50, 50);
            this.B1.TabIndex = 1;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.addNumber);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.SystemColors.Control;
            this.B2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(50, 129);
            this.B2.Margin = new System.Windows.Forms.Padding(0);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(50, 50);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.addNumber);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.SystemColors.Control;
            this.B3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(100, 129);
            this.B3.Margin = new System.Windows.Forms.Padding(0);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(50, 50);
            this.B3.TabIndex = 3;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.addNumber);
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.SystemColors.Control;
            this.B4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B4.Location = new System.Drawing.Point(0, 79);
            this.B4.Margin = new System.Windows.Forms.Padding(0);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(50, 50);
            this.B4.TabIndex = 4;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = false;
            this.B4.Click += new System.EventHandler(this.addNumber);
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.SystemColors.Control;
            this.B5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B5.Location = new System.Drawing.Point(50, 79);
            this.B5.Margin = new System.Windows.Forms.Padding(0);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(50, 50);
            this.B5.TabIndex = 5;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = false;
            this.B5.Click += new System.EventHandler(this.addNumber);
            // 
            // B6
            // 
            this.B6.BackColor = System.Drawing.SystemColors.Control;
            this.B6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B6.Location = new System.Drawing.Point(100, 79);
            this.B6.Margin = new System.Windows.Forms.Padding(0);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(50, 50);
            this.B6.TabIndex = 6;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = false;
            this.B6.Click += new System.EventHandler(this.addNumber);
            // 
            // B7
            // 
            this.B7.BackColor = System.Drawing.SystemColors.Control;
            this.B7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B7.Location = new System.Drawing.Point(0, 29);
            this.B7.Margin = new System.Windows.Forms.Padding(0);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(50, 50);
            this.B7.TabIndex = 7;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = false;
            this.B7.Click += new System.EventHandler(this.addNumber);
            // 
            // B8
            // 
            this.B8.BackColor = System.Drawing.SystemColors.Control;
            this.B8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B8.Location = new System.Drawing.Point(50, 29);
            this.B8.Margin = new System.Windows.Forms.Padding(0);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(50, 50);
            this.B8.TabIndex = 8;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = false;
            this.B8.Click += new System.EventHandler(this.addNumber);
            // 
            // B9
            // 
            this.B9.BackColor = System.Drawing.SystemColors.Control;
            this.B9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B9.Location = new System.Drawing.Point(100, 29);
            this.B9.Margin = new System.Windows.Forms.Padding(0);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(50, 50);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = false;
            this.B9.Click += new System.EventHandler(this.addNumber);
            // 
            // B0
            // 
            this.B0.BackColor = System.Drawing.SystemColors.Control;
            this.B0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B0.Location = new System.Drawing.Point(50, 179);
            this.B0.Margin = new System.Windows.Forms.Padding(0);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(50, 50);
            this.B0.TabIndex = 10;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = false;
            this.B0.Click += new System.EventHandler(this.addNumber);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.SystemColors.Control;
            this.Point.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Point.Location = new System.Drawing.Point(100, 179);
            this.Point.Margin = new System.Windows.Forms.Padding(0);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(50, 50);
            this.Point.TabIndex = 11;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.pointClick);
            // 
            // Sum
            // 
            this.Sum.BackColor = System.Drawing.SystemColors.Control;
            this.Sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(150, 179);
            this.Sum.Margin = new System.Windows.Forms.Padding(0);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(50, 50);
            this.Sum.TabIndex = 12;
            this.Sum.Tag = "";
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = false;
            this.Sum.Click += new System.EventHandler(this.addOper);
            // 
            // Sottr
            // 
            this.Sottr.BackColor = System.Drawing.SystemColors.Control;
            this.Sottr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sottr.Location = new System.Drawing.Point(150, 129);
            this.Sottr.Margin = new System.Windows.Forms.Padding(0);
            this.Sottr.Name = "Sottr";
            this.Sottr.Size = new System.Drawing.Size(50, 50);
            this.Sottr.TabIndex = 13;
            this.Sottr.Tag = "";
            this.Sottr.Text = "-";
            this.Sottr.UseVisualStyleBackColor = false;
            this.Sottr.Click += new System.EventHandler(this.addOper);
            // 
            // Molt
            // 
            this.Molt.BackColor = System.Drawing.SystemColors.Control;
            this.Molt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Molt.Location = new System.Drawing.Point(150, 79);
            this.Molt.Margin = new System.Windows.Forms.Padding(0);
            this.Molt.Name = "Molt";
            this.Molt.Size = new System.Drawing.Size(50, 50);
            this.Molt.TabIndex = 14;
            this.Molt.Tag = "";
            this.Molt.Text = "X";
            this.Molt.UseVisualStyleBackColor = false;
            this.Molt.Click += new System.EventHandler(this.addOper);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.Control;
            this.Div.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(150, 29);
            this.Div.Margin = new System.Windows.Forms.Padding(0);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(50, 50);
            this.Div.TabIndex = 15;
            this.Div.Tag = "";
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.addOper);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.Control;
            this.C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(0, 179);
            this.C.Margin = new System.Windows.Forms.Padding(0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(50, 50);
            this.C.TabIndex = 16;
            this.C.Tag = "";
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.canc);
            // 
            // Mod
            // 
            this.Mod.BackColor = System.Drawing.SystemColors.Control;
            this.Mod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mod.Location = new System.Drawing.Point(200, 29);
            this.Mod.Margin = new System.Windows.Forms.Padding(0);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(50, 50);
            this.Mod.TabIndex = 17;
            this.Mod.Tag = "";
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = false;
            this.Mod.Click += new System.EventHandler(this.addOper);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.Control;
            this.CE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CE.Location = new System.Drawing.Point(200, 79);
            this.CE.Margin = new System.Windows.Forms.Padding(0);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(50, 50);
            this.CE.TabIndex = 18;
            this.CE.Tag = "";
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.ce);
            // 
            // Ugual
            // 
            this.Ugual.BackColor = System.Drawing.SystemColors.Control;
            this.Ugual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ugual.Location = new System.Drawing.Point(200, 129);
            this.Ugual.Margin = new System.Windows.Forms.Padding(0);
            this.Ugual.Name = "Ugual";
            this.Ugual.Size = new System.Drawing.Size(50, 100);
            this.Ugual.TabIndex = 19;
            this.Ugual.Text = "=";
            this.Ugual.UseVisualStyleBackColor = false;
            this.Ugual.Click += new System.EventHandler(this.calculate);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(250, 229);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Sottr);
            this.Controls.Add(this.Molt);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.Ugual);
            this.Controls.Add(this.Display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Display;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button B4;
        private Button B5;
        private Button B6;
        private Button B7;
        private Button B8;
        private Button B9;
        private Button B0;
        private Button Point;
        private Button Sum;
        private Button Sottr;
        private Button Molt;
        private Button Div;
        private Button C;
        private Button Mod;
        private Button CE;
        private Button Ugual;
    }
}