namespace ex_heranca
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
            this.btn_exec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_cartao = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(172, 23);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(100, 75);
            this.btn_exec.TabIndex = 0;
            this.btn_exec.Text = "Armazenar e Demonstrar";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(49, 20);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(49, 46);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 20);
            this.txt_rg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "RG:";
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(49, 72);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(100, 20);
            this.txt_cartao.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cartão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exibir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cartão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RG:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome:";
            // 
            // lbl_cartao
            // 
            this.lbl_cartao.AutoSize = true;
            this.lbl_cartao.Location = new System.Drawing.Point(59, 199);
            this.lbl_cartao.Name = "lbl_cartao";
            this.lbl_cartao.Size = new System.Drawing.Size(53, 13);
            this.lbl_cartao.TabIndex = 13;
            this.lbl_cartao.Text = "lbl_cartao";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(59, 173);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(32, 13);
            this.lbl_rg.TabIndex = 12;
            this.lbl_rg.Text = "lbl_rg";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(59, 147);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 13);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "lbl_nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_cartao);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_cartao;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_nome;
    }
}

