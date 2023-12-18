namespace math_sinifi_826
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblKare = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblUst = new System.Windows.Forms.Label();
            this.lblYuvarlama = new System.Windows.Forms.Label();
            this.lblYukari = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.lblAsagi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 98);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(132, 35);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 51);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // lblKare
            // 
            this.lblKare.AutoSize = true;
            this.lblKare.Location = new System.Drawing.Point(211, 54);
            this.lblKare.Name = "lblKare";
            this.lblKare.Size = new System.Drawing.Size(82, 13);
            this.lblKare.TabIndex = 2;
            this.lblKare.Text = "kare hesaplama";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Location = new System.Drawing.Point(211, 79);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(46, 13);
            this.lblKok.TabIndex = 3;
            this.lblKok.Text = "karekök";
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Location = new System.Drawing.Point(211, 109);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(46, 13);
            this.lblUst.TabIndex = 4;
            this.lblUst.Text = "üst alma";
            this.lblUst.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblYuvarlama
            // 
            this.lblYuvarlama.AutoSize = true;
            this.lblYuvarlama.Location = new System.Drawing.Point(211, 140);
            this.lblYuvarlama.Name = "lblYuvarlama";
            this.lblYuvarlama.Size = new System.Drawing.Size(55, 13);
            this.lblYuvarlama.TabIndex = 5;
            this.lblYuvarlama.Text = "yuvarlama";
            // 
            // lblYukari
            // 
            this.lblYukari.AutoSize = true;
            this.lblYukari.Location = new System.Drawing.Point(211, 190);
            this.lblYukari.Name = "lblYukari";
            this.lblYukari.Size = new System.Drawing.Size(93, 13);
            this.lblYukari.TabIndex = 7;
            this.lblYukari.Text = "sayı yukarı yuvarla";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Location = new System.Drawing.Point(211, 217);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(68, 13);
            this.lblMutlak.TabIndex = 8;
            this.lblMutlak.Text = "mutlak değer";
            // 
            // lblAsagi
            // 
            this.lblAsagi.AutoSize = true;
            this.lblAsagi.Location = new System.Drawing.Point(214, 170);
            this.lblAsagi.Name = "lblAsagi";
            this.lblAsagi.Size = new System.Drawing.Size(93, 13);
            this.lblAsagi.TabIndex = 9;
            this.lblAsagi.Text = "sayı yukarı yuvarla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAsagi);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblYukari);
            this.Controls.Add(this.lblYuvarlama);
            this.Controls.Add(this.lblUst);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblKare);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblKare;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Label lblYuvarlama;
        private System.Windows.Forms.Label lblYukari;
        private System.Windows.Forms.Label lblMutlak;
        private System.Windows.Forms.Label lblAsagi;
    }
}

