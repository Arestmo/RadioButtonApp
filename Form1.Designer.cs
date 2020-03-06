namespace RadioButtonApp
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
            this.Figury = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Figura_Prostokat = new System.Windows.Forms.RadioButton();
            this.Figura_Szescian = new System.Windows.Forms.RadioButton();
            this.Figura_kwadrat = new System.Windows.Forms.RadioButton();
            this.Obliczenia = new System.Windows.Forms.GroupBox();
            this.LiczPolePowCal = new System.Windows.Forms.RadioButton();
            this.LiczObjetosc = new System.Windows.Forms.RadioButton();
            this.LiczObwod = new System.Windows.Forms.RadioButton();
            this.LiczPole = new System.Windows.Forms.RadioButton();
            this.Val_1 = new System.Windows.Forms.TextBox();
            this.Val_2 = new System.Windows.Forms.TextBox();
            this.Val_3 = new System.Windows.Forms.TextBox();
            this.Val_1_label = new System.Windows.Forms.Label();
            this.Val_2_label = new System.Windows.Forms.Label();
            this.Val_3_label = new System.Windows.Forms.Label();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.LiczButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Figury.SuspendLayout();
            this.Obliczenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // Figury
            // 
            this.Figury.Controls.Add(this.radioButton5);
            this.Figury.Controls.Add(this.radioButton4);
            this.Figury.Controls.Add(this.Figura_Prostokat);
            this.Figury.Controls.Add(this.Figura_Szescian);
            this.Figury.Controls.Add(this.Figura_kwadrat);
            this.Figury.Location = new System.Drawing.Point(12, 12);
            this.Figury.Name = "Figury";
            this.Figury.Size = new System.Drawing.Size(123, 143);
            this.Figury.TabIndex = 0;
            this.Figury.TabStop = false;
            this.Figury.Text = "Wybierz Figurę";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 116);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Figura_Prostokat
            // 
            this.Figura_Prostokat.AutoSize = true;
            this.Figura_Prostokat.Location = new System.Drawing.Point(7, 68);
            this.Figura_Prostokat.Name = "Figura_Prostokat";
            this.Figura_Prostokat.Size = new System.Drawing.Size(70, 17);
            this.Figura_Prostokat.TabIndex = 2;
            this.Figura_Prostokat.TabStop = true;
            this.Figura_Prostokat.Text = "Prostokąt";
            this.Figura_Prostokat.UseVisualStyleBackColor = true;
            this.Figura_Prostokat.CheckedChanged += new System.EventHandler(this.Figura_Prostokat_CheckedChanged);
            // 
            // Figura_Szescian
            // 
            this.Figura_Szescian.AutoSize = true;
            this.Figura_Szescian.Location = new System.Drawing.Point(7, 44);
            this.Figura_Szescian.Name = "Figura_Szescian";
            this.Figura_Szescian.Size = new System.Drawing.Size(68, 17);
            this.Figura_Szescian.TabIndex = 1;
            this.Figura_Szescian.TabStop = true;
            this.Figura_Szescian.Text = "Sześcian";
            this.Figura_Szescian.UseVisualStyleBackColor = true;
            this.Figura_Szescian.CheckedChanged += new System.EventHandler(this.Figura_Szescian_CheckedChanged);
            // 
            // Figura_kwadrat
            // 
            this.Figura_kwadrat.AutoSize = true;
            this.Figura_kwadrat.Location = new System.Drawing.Point(7, 20);
            this.Figura_kwadrat.Name = "Figura_kwadrat";
            this.Figura_kwadrat.Size = new System.Drawing.Size(64, 17);
            this.Figura_kwadrat.TabIndex = 0;
            this.Figura_kwadrat.TabStop = true;
            this.Figura_kwadrat.Text = "Kwadrat";
            this.Figura_kwadrat.UseVisualStyleBackColor = true;
            this.Figura_kwadrat.CheckedChanged += new System.EventHandler(this.Figura_kwadrat_CheckedChanged);
            // 
            // Obliczenia
            // 
            this.Obliczenia.Controls.Add(this.LiczPolePowCal);
            this.Obliczenia.Controls.Add(this.LiczObjetosc);
            this.Obliczenia.Controls.Add(this.LiczObwod);
            this.Obliczenia.Controls.Add(this.LiczPole);
            this.Obliczenia.Location = new System.Drawing.Point(141, 12);
            this.Obliczenia.Name = "Obliczenia";
            this.Obliczenia.Size = new System.Drawing.Size(150, 143);
            this.Obliczenia.TabIndex = 1;
            this.Obliczenia.TabStop = false;
            this.Obliczenia.Text = "Wybierz co obliczyć";
            // 
            // LiczPolePowCal
            // 
            this.LiczPolePowCal.AutoSize = true;
            this.LiczPolePowCal.Location = new System.Drawing.Point(7, 92);
            this.LiczPolePowCal.Name = "LiczPolePowCal";
            this.LiczPolePowCal.Size = new System.Drawing.Size(112, 17);
            this.LiczPolePowCal.TabIndex = 3;
            this.LiczPolePowCal.TabStop = true;
            this.LiczPolePowCal.Text = "Pole P. Całkowitej";
            this.LiczPolePowCal.UseVisualStyleBackColor = true;
            // 
            // LiczObjetosc
            // 
            this.LiczObjetosc.AutoSize = true;
            this.LiczObjetosc.Location = new System.Drawing.Point(7, 68);
            this.LiczObjetosc.Name = "LiczObjetosc";
            this.LiczObjetosc.Size = new System.Drawing.Size(67, 17);
            this.LiczObjetosc.TabIndex = 2;
            this.LiczObjetosc.TabStop = true;
            this.LiczObjetosc.Text = "Objętość";
            this.LiczObjetosc.UseVisualStyleBackColor = true;
            // 
            // LiczObwod
            // 
            this.LiczObwod.AutoSize = true;
            this.LiczObwod.Location = new System.Drawing.Point(7, 44);
            this.LiczObwod.Name = "LiczObwod";
            this.LiczObwod.Size = new System.Drawing.Size(59, 17);
            this.LiczObwod.TabIndex = 1;
            this.LiczObwod.TabStop = true;
            this.LiczObwod.Text = "Obwód";
            this.LiczObwod.UseVisualStyleBackColor = true;
            this.LiczObwod.CheckedChanged += new System.EventHandler(this.LiczObwod_CheckedChanged);
            // 
            // LiczPole
            // 
            this.LiczPole.AutoSize = true;
            this.LiczPole.Location = new System.Drawing.Point(7, 20);
            this.LiczPole.Name = "LiczPole";
            this.LiczPole.Size = new System.Drawing.Size(46, 17);
            this.LiczPole.TabIndex = 0;
            this.LiczPole.TabStop = true;
            this.LiczPole.Text = "Pole";
            this.LiczPole.UseVisualStyleBackColor = true;
            this.LiczPole.CheckedChanged += new System.EventHandler(this.LiczPole_CheckedChanged);
            // 
            // Val_1
            // 
            this.Val_1.Location = new System.Drawing.Point(297, 28);
            this.Val_1.Name = "Val_1";
            this.Val_1.Size = new System.Drawing.Size(62, 20);
            this.Val_1.TabIndex = 2;
            // 
            // Val_2
            // 
            this.Val_2.Location = new System.Drawing.Point(297, 67);
            this.Val_2.Name = "Val_2";
            this.Val_2.Size = new System.Drawing.Size(62, 20);
            this.Val_2.TabIndex = 3;
            // 
            // Val_3
            // 
            this.Val_3.Location = new System.Drawing.Point(297, 106);
            this.Val_3.Name = "Val_3";
            this.Val_3.Size = new System.Drawing.Size(62, 20);
            this.Val_3.TabIndex = 4;
            // 
            // Val_1_label
            // 
            this.Val_1_label.AutoSize = true;
            this.Val_1_label.Location = new System.Drawing.Point(297, 12);
            this.Val_1_label.Name = "Val_1_label";
            this.Val_1_label.Size = new System.Drawing.Size(31, 13);
            this.Val_1_label.TabIndex = 5;
            this.Val_1_label.Text = "Val 1";
            // 
            // Val_2_label
            // 
            this.Val_2_label.AutoSize = true;
            this.Val_2_label.Location = new System.Drawing.Point(297, 51);
            this.Val_2_label.Name = "Val_2_label";
            this.Val_2_label.Size = new System.Drawing.Size(31, 13);
            this.Val_2_label.TabIndex = 6;
            this.Val_2_label.Text = "Val 2";
            // 
            // Val_3_label
            // 
            this.Val_3_label.AutoSize = true;
            this.Val_3_label.Location = new System.Drawing.Point(297, 90);
            this.Val_3_label.Name = "Val_3_label";
            this.Val_3_label.Size = new System.Drawing.Size(31, 13);
            this.Val_3_label.TabIndex = 7;
            this.Val_3_label.Text = "Val 3";
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(12, 162);
            this.Wynik.Multiline = true;
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(347, 43);
            this.Wynik.TabIndex = 8;
            // 
            // LiczButton
            // 
            this.LiczButton.Location = new System.Drawing.Point(297, 133);
            this.LiczButton.Name = "LiczButton";
            this.LiczButton.Size = new System.Drawing.Size(62, 23);
            this.LiczButton.TabIndex = 9;
            this.LiczButton.Text = "Licz";
            this.LiczButton.UseVisualStyleBackColor = true;
            this.LiczButton.Click += new System.EventHandler(this.LiczButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 212);
            this.Controls.Add(this.LiczButton);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Val_3_label);
            this.Controls.Add(this.Val_2_label);
            this.Controls.Add(this.Val_1_label);
            this.Controls.Add(this.Val_3);
            this.Controls.Add(this.Val_2);
            this.Controls.Add(this.Val_1);
            this.Controls.Add(this.Obliczenia);
            this.Controls.Add(this.Figury);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Figury.ResumeLayout(false);
            this.Figury.PerformLayout();
            this.Obliczenia.ResumeLayout(false);
            this.Obliczenia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Figury;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton Figura_Prostokat;
        private System.Windows.Forms.RadioButton Figura_Szescian;
        private System.Windows.Forms.RadioButton Figura_kwadrat;
        private System.Windows.Forms.GroupBox Obliczenia;
        private System.Windows.Forms.RadioButton LiczPolePowCal;
        private System.Windows.Forms.RadioButton LiczObjetosc;
        private System.Windows.Forms.RadioButton LiczObwod;
        private System.Windows.Forms.RadioButton LiczPole;
        private System.Windows.Forms.TextBox Val_1;
        private System.Windows.Forms.TextBox Val_2;
        private System.Windows.Forms.TextBox Val_3;
        private System.Windows.Forms.Label Val_1_label;
        private System.Windows.Forms.Label Val_2_label;
        private System.Windows.Forms.Label Val_3_label;
        private System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.Button LiczButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

