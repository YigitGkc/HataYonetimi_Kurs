namespace HataYonetimi_Kurs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHataYonetimsiz = new System.Windows.Forms.Button();
            this.btnHataYonetimli = new System.Windows.Forms.Button();
            this.btnHataYonetimliMesaj = new System.Windows.Forms.Button();
            this.HataYonetimliMesaj2 = new System.Windows.Forms.Button();
            this.btnHataYonetimliFinally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnHataYonetimsiz
            // 
            this.btnHataYonetimsiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHataYonetimsiz.Location = new System.Drawing.Point(12, 38);
            this.btnHataYonetimsiz.Name = "btnHataYonetimsiz";
            this.btnHataYonetimsiz.Size = new System.Drawing.Size(193, 70);
            this.btnHataYonetimsiz.TabIndex = 1;
            this.btnHataYonetimsiz.Text = "HataYonetimsiz";
            this.btnHataYonetimsiz.UseVisualStyleBackColor = true;
            this.btnHataYonetimsiz.Click += new System.EventHandler(this.BtnHataYonetimsiz_Click);
            // 
            // btnHataYonetimli
            // 
            this.btnHataYonetimli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHataYonetimli.Location = new System.Drawing.Point(12, 114);
            this.btnHataYonetimli.Name = "btnHataYonetimli";
            this.btnHataYonetimli.Size = new System.Drawing.Size(193, 70);
            this.btnHataYonetimli.TabIndex = 1;
            this.btnHataYonetimli.Text = "Hata Yonetimli";
            this.btnHataYonetimli.UseVisualStyleBackColor = true;
            this.btnHataYonetimli.Click += new System.EventHandler(this.BtnHataYonetimli_Click);
            // 
            // btnHataYonetimliMesaj
            // 
            this.btnHataYonetimliMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHataYonetimliMesaj.Location = new System.Drawing.Point(12, 190);
            this.btnHataYonetimliMesaj.Name = "btnHataYonetimliMesaj";
            this.btnHataYonetimliMesaj.Size = new System.Drawing.Size(193, 70);
            this.btnHataYonetimliMesaj.TabIndex = 1;
            this.btnHataYonetimliMesaj.Text = "Hata Yonetimli - Mesaj";
            this.btnHataYonetimliMesaj.UseVisualStyleBackColor = true;
            this.btnHataYonetimliMesaj.Click += new System.EventHandler(this.BtnHataYonetimliMesaj_Click);
            // 
            // HataYonetimliMesaj2
            // 
            this.HataYonetimliMesaj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HataYonetimliMesaj2.Location = new System.Drawing.Point(12, 266);
            this.HataYonetimliMesaj2.Name = "HataYonetimliMesaj2";
            this.HataYonetimliMesaj2.Size = new System.Drawing.Size(193, 70);
            this.HataYonetimliMesaj2.TabIndex = 1;
            this.HataYonetimliMesaj2.Text = "Hata Yonetimli - Mesaj 2";
            this.HataYonetimliMesaj2.UseVisualStyleBackColor = true;
            // 
            // btnHataYonetimliFinally
            // 
            this.btnHataYonetimliFinally.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHataYonetimliFinally.Location = new System.Drawing.Point(12, 342);
            this.btnHataYonetimliFinally.Name = "btnHataYonetimliFinally";
            this.btnHataYonetimliFinally.Size = new System.Drawing.Size(193, 70);
            this.btnHataYonetimliFinally.TabIndex = 1;
            this.btnHataYonetimliFinally.Text = "Hata Yonetimli -Finally";
            this.btnHataYonetimliFinally.UseVisualStyleBackColor = true;
            this.btnHataYonetimliFinally.Click += new System.EventHandler(this.BtnHataYonetimliFinally_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 429);
            this.Controls.Add(this.btnHataYonetimliFinally);
            this.Controls.Add(this.HataYonetimliMesaj2);
            this.Controls.Add(this.btnHataYonetimliMesaj);
            this.Controls.Add(this.btnHataYonetimli);
            this.Controls.Add(this.btnHataYonetimsiz);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHataYonetimsiz;
        private System.Windows.Forms.Button btnHataYonetimli;
        private System.Windows.Forms.Button btnHataYonetimliMesaj;
        private System.Windows.Forms.Button HataYonetimliMesaj2;
        private System.Windows.Forms.Button btnHataYonetimliFinally;
    }
}

