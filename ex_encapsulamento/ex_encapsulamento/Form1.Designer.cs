namespace ex_encapsulamento
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
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_shownome = new System.Windows.Forms.Label();
            this.lbl_mostrar_nome = new System.Windows.Forms.Label();
            this.lbl_mostrar_cpf = new System.Windows.Forms.Label();
            this.lbl_showcpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(195, 12);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(121, 51);
            this.btn_set.TabIndex = 0;
            this.btn_set.Text = "Armazenar por Set";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(195, 103);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(121, 51);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Ler por Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(75, 13);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Digite o nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(13, 26);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(149, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(13, 82);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(149, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(12, 65);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(69, 13);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "Digite o CPF:";
            // 
            // lbl_shownome
            // 
            this.lbl_shownome.AutoSize = true;
            this.lbl_shownome.Location = new System.Drawing.Point(15, 122);
            this.lbl_shownome.Name = "lbl_shownome";
            this.lbl_shownome.Size = new System.Drawing.Size(82, 13);
            this.lbl_shownome.TabIndex = 6;
            this.lbl_shownome.Text = "Nome do aluno:";
            // 
            // lbl_mostrar_nome
            // 
            this.lbl_mostrar_nome.AutoSize = true;
            this.lbl_mostrar_nome.Location = new System.Drawing.Point(103, 122);
            this.lbl_mostrar_nome.Name = "lbl_mostrar_nome";
            this.lbl_mostrar_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_mostrar_nome.TabIndex = 7;
            this.lbl_mostrar_nome.Text = "Nome";
            // 
            // lbl_mostrar_cpf
            // 
            this.lbl_mostrar_cpf.AutoSize = true;
            this.lbl_mostrar_cpf.Location = new System.Drawing.Point(103, 142);
            this.lbl_mostrar_cpf.Name = "lbl_mostrar_cpf";
            this.lbl_mostrar_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_mostrar_cpf.TabIndex = 9;
            this.lbl_mostrar_cpf.Text = "CPF";
            // 
            // lbl_showcpf
            // 
            this.lbl_showcpf.AutoSize = true;
            this.lbl_showcpf.Location = new System.Drawing.Point(15, 142);
            this.lbl_showcpf.Name = "lbl_showcpf";
            this.lbl_showcpf.Size = new System.Drawing.Size(74, 13);
            this.lbl_showcpf.TabIndex = 8;
            this.lbl_showcpf.Text = "CPF do aluno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 182);
            this.Controls.Add(this.lbl_mostrar_cpf);
            this.Controls.Add(this.lbl_showcpf);
            this.Controls.Add(this.lbl_mostrar_nome);
            this.Controls.Add(this.lbl_shownome);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_shownome;
        private System.Windows.Forms.Label lbl_mostrar_nome;
        private System.Windows.Forms.Label lbl_mostrar_cpf;
        private System.Windows.Forms.Label lbl_showcpf;
    }
}

