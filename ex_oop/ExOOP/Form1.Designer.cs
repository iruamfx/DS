namespace ExOOP
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_somar = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o numero 1:";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(15, 26);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(15, 66);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o numero 2:";
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(159, 23);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(75, 23);
            this.btn_somar.TabIndex = 4;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(15, 105);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // btn_subtract
            // 
            this.btn_subtract.Location = new System.Drawing.Point(159, 52);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(75, 23);
            this.btn_subtract.TabIndex = 7;
            this.btn_subtract.Text = "Subtrair";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(159, 79);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 23);
            this.btn_divide.TabIndex = 8;
            this.btn_divide.Text = "Dividir";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(159, 105);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_multiply.TabIndex = 9;
            this.btn_multiply.Text = "Multiplicar";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_play.Image = global::ExOOP.Properties.Resources.songs_audio_music_6074;
            this.btn_play.Location = new System.Drawing.Point(12, 137);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(222, 23);
            this.btn_play.TabIndex = 10;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 172);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_subtract);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora OOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_play;
    }
}

