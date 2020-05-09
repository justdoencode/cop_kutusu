namespace cop_kutusu
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
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.rch_icerik = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_notekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_notsil = new System.Windows.Forms.Button();
            this.btn_copkutusu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_toplamnot = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(98, 24);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(156, 20);
            this.txt_baslik.TabIndex = 0;
            // 
            // rch_icerik
            // 
            this.rch_icerik.Location = new System.Drawing.Point(98, 70);
            this.rch_icerik.Name = "rch_icerik";
            this.rch_icerik.Size = new System.Drawing.Size(156, 96);
            this.rch_icerik.TabIndex = 1;
            this.rch_icerik.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_notekle);
            this.panel1.Controls.Add(this.txt_baslik);
            this.panel1.Controls.Add(this.rch_icerik);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 218);
            this.panel1.TabIndex = 2;
            // 
            // btn_notekle
            // 
            this.btn_notekle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notekle.Location = new System.Drawing.Point(98, 181);
            this.btn_notekle.Name = "btn_notekle";
            this.btn_notekle.Size = new System.Drawing.Size(75, 23);
            this.btn_notekle.TabIndex = 2;
            this.btn_notekle.Text = "NOT EKLE";
            this.btn_notekle.UseVisualStyleBackColor = true;
            this.btn_notekle.Click += new System.EventHandler(this.btn_notekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOT EKLE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.lbl_toplamnot);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_copkutusu);
            this.panel2.Controls.Add(this.btn_notsil);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(351, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 218);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Konu Başlığı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Konu İçeriği :";
            // 
            // btn_notsil
            // 
            this.btn_notsil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_notsil.Location = new System.Drawing.Point(15, 181);
            this.btn_notsil.Name = "btn_notsil";
            this.btn_notsil.Size = new System.Drawing.Size(75, 23);
            this.btn_notsil.TabIndex = 3;
            this.btn_notsil.Text = "NOT SİL";
            this.btn_notsil.UseVisualStyleBackColor = true;
            this.btn_notsil.Click += new System.EventHandler(this.btn_notsil_Click);
            // 
            // btn_copkutusu
            // 
            this.btn_copkutusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copkutusu.Location = new System.Drawing.Point(182, 181);
            this.btn_copkutusu.Name = "btn_copkutusu";
            this.btn_copkutusu.Size = new System.Drawing.Size(86, 23);
            this.btn_copkutusu.TabIndex = 5;
            this.btn_copkutusu.Text = "ÇÖP KUTUSU";
            this.btn_copkutusu.UseVisualStyleBackColor = true;
            this.btn_copkutusu.Click += new System.EventHandler(this.btn_copkutusu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(285, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toplam Not :";
            // 
            // lbl_toplamnot
            // 
            this.lbl_toplamnot.AutoSize = true;
            this.lbl_toplamnot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamnot.Location = new System.Drawing.Point(371, 186);
            this.lbl_toplamnot.Name = "lbl_toplamnot";
            this.lbl_toplamnot.Size = new System.Drawing.Size(14, 13);
            this.lbl_toplamnot.TabIndex = 7;
            this.lbl_toplamnot.Text = "0";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(96, 183);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(67, 20);
            this.txt_id.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 355);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.RichTextBox rch_icerik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_notekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_toplamnot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_copkutusu;
        private System.Windows.Forms.Button btn_notsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_id;
    }
}

