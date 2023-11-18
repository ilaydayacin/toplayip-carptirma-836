namespace toplayıp_çarptırma_ve_5_ekleme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtS1 = new System.Windows.Forms.TextBox();
            this.txtS2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtS1
            // 
            this.txtS1.Location = new System.Drawing.Point(97, 85);
            this.txtS1.Name = "txtS1";
            this.txtS1.Size = new System.Drawing.Size(175, 20);
            this.txtS1.TabIndex = 0;
            // 
            // txtS2
            // 
            this.txtS2.Location = new System.Drawing.Point(97, 129);
            this.txtS2.Name = "txtS2";
            this.txtS2.Size = new System.Drawing.Size(175, 20);
            this.txtS2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı 2";
            // 
            // btnHesap
            // 
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(97, 182);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(148, 96);
            this.btnHesap.TabIndex = 4;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 314);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtS2);
            this.Controls.Add(this.txtS1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtS1;
        private System.Windows.Forms.TextBox txtS2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesap;
    }
}

