namespace ex_crud
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_plate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.btn_change);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_color);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_plate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão Carros";
            // 
            // btn_clean
            // 
            this.btn_clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clean.Image = global::ex_crud.Properties.Resources._3792081_broom_halloween_magic_witch_1090491;
            this.btn_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clean.Location = new System.Drawing.Point(430, 114);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(100, 55);
            this.btn_clean.TabIndex = 13;
            this.btn_clean.Text = "Apagar";
            this.btn_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_change.Image = global::ex_crud.Properties.Resources.refresh_106672_1_;
            this.btn_change.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_change.Location = new System.Drawing.Point(324, 114);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(100, 55);
            this.btn_change.TabIndex = 12;
            this.btn_change.Text = "Alterar";
            this.btn_change.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_delete.Image = global::ex_crud.Properties.Resources.business_deletethedatabase_exit_db_delete_busines_2346;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.Location = new System.Drawing.Point(218, 114);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 55);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Apagar";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_query
            // 
            this.btn_query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_query.Image = global::ex_crud.Properties.Resources.search_book_open_search_locate_6178;
            this.btn_query.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_query.Location = new System.Drawing.Point(112, 114);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(100, 55);
            this.btn_query.TabIndex = 10;
            this.btn_query.Text = "Consultar";
            this.btn_query.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(531, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.Image = global::ex_crud.Properties.Resources.devices_floppydisk_dispositivos_691;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(9, 114);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 55);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Salvar";
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(9, 33);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(149, 20);
            this.txt_id.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código:";
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(185, 78);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(149, 20);
            this.txt_color.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor:";
            // 
            // txt_plate
            // 
            this.txt_plate.Location = new System.Drawing.Point(185, 33);
            this.txt_plate.Name = "txt_plate";
            this.txt_plate.Size = new System.Drawing.Size(149, 20);
            this.txt_plate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(11, 77);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(149, 20);
            this.txt_model.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 395);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_plate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_change;
    }
}

