namespace bibxmlzajecia28._11
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.b_dod_uz = new System.Windows.Forms.Button();
            this.b_usun_uz = new System.Windows.Forms.Button();
            this.b_zapis_uz = new System.Windows.Forms.Button();
            this.b_odczyt_uz = new System.Windows.Forms.Button();
            this.b_odczyt_ks = new System.Windows.Forms.Button();
            this.b_zapis_ks = new System.Windows.Forms.Button();
            this.b_usun_ks = new System.Windows.Forms.Button();
            this.b_dodaj_ks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(247, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(392, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(247, 294);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // b_dod_uz
            // 
            this.b_dod_uz.Location = new System.Drawing.Point(12, 325);
            this.b_dod_uz.Name = "b_dod_uz";
            this.b_dod_uz.Size = new System.Drawing.Size(102, 31);
            this.b_dod_uz.TabIndex = 2;
            this.b_dod_uz.Text = "Dodaj";
            this.b_dod_uz.UseVisualStyleBackColor = true;
            this.b_dod_uz.Click += new System.EventHandler(this.b_dod_uz_Click);
            // 
            // b_usun_uz
            // 
            this.b_usun_uz.Location = new System.Drawing.Point(12, 362);
            this.b_usun_uz.Name = "b_usun_uz";
            this.b_usun_uz.Size = new System.Drawing.Size(102, 31);
            this.b_usun_uz.TabIndex = 3;
            this.b_usun_uz.Text = "Usun";
            this.b_usun_uz.UseVisualStyleBackColor = true;
            this.b_usun_uz.Click += new System.EventHandler(this.b_usun_uz_Click);
            // 
            // b_zapis_uz
            // 
            this.b_zapis_uz.Location = new System.Drawing.Point(120, 325);
            this.b_zapis_uz.Name = "b_zapis_uz";
            this.b_zapis_uz.Size = new System.Drawing.Size(102, 31);
            this.b_zapis_uz.TabIndex = 4;
            this.b_zapis_uz.Text = "Zapis";
            this.b_zapis_uz.UseVisualStyleBackColor = true;
            this.b_zapis_uz.Click += new System.EventHandler(this.b_zapis_uz_Click);
            // 
            // b_odczyt_uz
            // 
            this.b_odczyt_uz.Location = new System.Drawing.Point(120, 362);
            this.b_odczyt_uz.Name = "b_odczyt_uz";
            this.b_odczyt_uz.Size = new System.Drawing.Size(102, 31);
            this.b_odczyt_uz.TabIndex = 5;
            this.b_odczyt_uz.Text = "Odczyt";
            this.b_odczyt_uz.UseVisualStyleBackColor = true;
            this.b_odczyt_uz.Click += new System.EventHandler(this.b_odczyt_uz_Click);
            // 
            // b_odczyt_ks
            // 
            this.b_odczyt_ks.Location = new System.Drawing.Point(500, 362);
            this.b_odczyt_ks.Name = "b_odczyt_ks";
            this.b_odczyt_ks.Size = new System.Drawing.Size(102, 31);
            this.b_odczyt_ks.TabIndex = 9;
            this.b_odczyt_ks.Text = "Odczyt";
            this.b_odczyt_ks.UseVisualStyleBackColor = true;
            this.b_odczyt_ks.Click += new System.EventHandler(this.b_odczyt_ks_Click);
            // 
            // b_zapis_ks
            // 
            this.b_zapis_ks.Location = new System.Drawing.Point(500, 325);
            this.b_zapis_ks.Name = "b_zapis_ks";
            this.b_zapis_ks.Size = new System.Drawing.Size(102, 31);
            this.b_zapis_ks.TabIndex = 8;
            this.b_zapis_ks.Text = "Zapis";
            this.b_zapis_ks.UseVisualStyleBackColor = true;
            this.b_zapis_ks.Click += new System.EventHandler(this.b_zapis_ks_Click);
            // 
            // b_usun_ks
            // 
            this.b_usun_ks.Location = new System.Drawing.Point(392, 362);
            this.b_usun_ks.Name = "b_usun_ks";
            this.b_usun_ks.Size = new System.Drawing.Size(102, 31);
            this.b_usun_ks.TabIndex = 7;
            this.b_usun_ks.Text = "Usun";
            this.b_usun_ks.UseVisualStyleBackColor = true;
            this.b_usun_ks.Click += new System.EventHandler(this.b_usun_ks_Click);
            // 
            // b_dodaj_ks
            // 
            this.b_dodaj_ks.Location = new System.Drawing.Point(392, 325);
            this.b_dodaj_ks.Name = "b_dodaj_ks";
            this.b_dodaj_ks.Size = new System.Drawing.Size(102, 31);
            this.b_dodaj_ks.TabIndex = 6;
            this.b_dodaj_ks.Text = "Dodaj";
            this.b_dodaj_ks.UseVisualStyleBackColor = true;
            this.b_dodaj_ks.Click += new System.EventHandler(this.b_dodaj_ks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uzytkownicy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ksiazki";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_odczyt_ks);
            this.Controls.Add(this.b_zapis_ks);
            this.Controls.Add(this.b_usun_ks);
            this.Controls.Add(this.b_dodaj_ks);
            this.Controls.Add(this.b_odczyt_uz);
            this.Controls.Add(this.b_zapis_uz);
            this.Controls.Add(this.b_usun_uz);
            this.Controls.Add(this.b_dod_uz);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button b_dod_uz;
        private Button b_usun_uz;
        private Button b_zapis_uz;
        private Button b_odczyt_uz;
        private Button b_odczyt_ks;
        private Button b_zapis_ks;
        private Button b_usun_ks;
        private Button b_dodaj_ks;
        private Label label1;
        private Label label2;
    }
}