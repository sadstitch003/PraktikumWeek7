namespace PraktikumWeek7
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
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxInput = new System.Windows.Forms.TextBox();
            this.TBoxHurufAwal = new System.Windows.Forms.TextBox();
            this.TBoxHurufAkhir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKonversi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblHasilKonversi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kalimat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf";
            // 
            // TBoxInput
            // 
            this.TBoxInput.Location = new System.Drawing.Point(155, 20);
            this.TBoxInput.Name = "TBoxInput";
            this.TBoxInput.Size = new System.Drawing.Size(388, 22);
            this.TBoxInput.TabIndex = 2;
            // 
            // TBoxHurufAwal
            // 
            this.TBoxHurufAwal.Location = new System.Drawing.Point(155, 58);
            this.TBoxHurufAwal.Name = "TBoxHurufAwal";
            this.TBoxHurufAwal.Size = new System.Drawing.Size(128, 22);
            this.TBoxHurufAwal.TabIndex = 3;
            // 
            // TBoxHurufAkhir
            // 
            this.TBoxHurufAkhir.Location = new System.Drawing.Point(415, 58);
            this.TBoxHurufAkhir.Name = "TBoxHurufAkhir";
            this.TBoxHurufAkhir.Size = new System.Drawing.Size(128, 22);
            this.TBoxHurufAkhir.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi";
            // 
            // BtnKonversi
            // 
            this.BtnKonversi.Location = new System.Drawing.Point(155, 106);
            this.BtnKonversi.Name = "BtnKonversi";
            this.BtnKonversi.Size = new System.Drawing.Size(388, 23);
            this.BtnKonversi.TabIndex = 6;
            this.BtnKonversi.Text = "Konversi!";
            this.BtnKonversi.UseVisualStyleBackColor = true;
            this.BtnKonversi.Click += new System.EventHandler(this.BtnKonversi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasil :";
            // 
            // LblHasilKonversi
            // 
            this.LblHasilKonversi.AutoSize = true;
            this.LblHasilKonversi.Location = new System.Drawing.Point(152, 147);
            this.LblHasilKonversi.Name = "LblHasilKonversi";
            this.LblHasilKonversi.Size = new System.Drawing.Size(64, 16);
            this.LblHasilKonversi.TabIndex = 8;
            this.LblHasilKonversi.Text = "OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 184);
            this.Controls.Add(this.LblHasilKonversi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnKonversi);
            this.Controls.Add(this.TBoxHurufAkhir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxHurufAwal);
            this.Controls.Add(this.TBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Konfersi Huruf Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxInput;
        private System.Windows.Forms.TextBox TBoxHurufAwal;
        private System.Windows.Forms.TextBox TBoxHurufAkhir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnKonversi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHasilKonversi;
    }
}

