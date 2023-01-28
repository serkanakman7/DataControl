
namespace ozkan
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
            this.dqwTablo = new System.Windows.Forms.DataGridView();
            this.btnVeriGiris = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dqwTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dqwTablo
            // 
            this.dqwTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwTablo.Location = new System.Drawing.Point(0, 88);
            this.dqwTablo.Name = "dqwTablo";
            this.dqwTablo.RowHeadersWidth = 51;
            this.dqwTablo.RowTemplate.Height = 24;
            this.dqwTablo.Size = new System.Drawing.Size(801, 360);
            this.dqwTablo.TabIndex = 0;
            this.dqwTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwTablo_CellClick);
            // 
            // btnVeriGiris
            // 
            this.btnVeriGiris.Location = new System.Drawing.Point(698, 12);
            this.btnVeriGiris.Name = "btnVeriGiris";
            this.btnVeriGiris.Size = new System.Drawing.Size(90, 25);
            this.btnVeriGiris.TabIndex = 1;
            this.btnVeriGiris.Text = "VeriGirisi";
            this.btnVeriGiris.UseVisualStyleBackColor = true;
            this.btnVeriGiris.Click += new System.EventHandler(this.btnVeriGiris_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(698, 43);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVeriGiris);
            this.Controls.Add(this.dqwTablo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwTablo;
        private System.Windows.Forms.Button btnVeriGiris;
        private System.Windows.Forms.Button btnExit;
    }
}

