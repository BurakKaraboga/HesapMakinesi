namespace Hesap_Makinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1Button = new System.Windows.Forms.Button();
            this.rakam2Button = new System.Windows.Forms.Button();
            this.Rakam3Button = new System.Windows.Forms.Button();
            this.rakam6Button = new System.Windows.Forms.Button();
            this.rakam5Button = new System.Windows.Forms.Button();
            this.rakam4Button = new System.Windows.Forms.Button();
            this.rakam9Button = new System.Windows.Forms.Button();
            this.rakam8Button = new System.Windows.Forms.Button();
            this.rakam7Button = new System.Windows.Forms.Button();
            this.eşittirButton = new System.Windows.Forms.Button();
            this.rakam0Button = new System.Windows.Forms.Button();
            this.temizleButton = new System.Windows.Forms.Button();
            this.bölmeButton = new System.Windows.Forms.Button();
            this.çarpıButton = new System.Windows.Forms.Button();
            this.eksiButton = new System.Windows.Forms.Button();
            this.artıButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(-2, 0);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(318, 68);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rakam1Button
            // 
            this.rakam1Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1Button.Location = new System.Drawing.Point(-2, 71);
            this.rakam1Button.Name = "rakam1Button";
            this.rakam1Button.Size = new System.Drawing.Size(75, 75);
            this.rakam1Button.TabIndex = 1;
            this.rakam1Button.Text = "1";
            this.rakam1Button.UseVisualStyleBackColor = false;
            this.rakam1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // rakam2Button
            // 
            this.rakam2Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2Button.Location = new System.Drawing.Point(79, 71);
            this.rakam2Button.Name = "rakam2Button";
            this.rakam2Button.Size = new System.Drawing.Size(75, 75);
            this.rakam2Button.TabIndex = 2;
            this.rakam2Button.Text = "2";
            this.rakam2Button.UseVisualStyleBackColor = false;
            this.rakam2Button.Click += new System.EventHandler(this.rakam2Button_Click);
            // 
            // Rakam3Button
            // 
            this.Rakam3Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Rakam3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rakam3Button.Location = new System.Drawing.Point(160, 71);
            this.Rakam3Button.Name = "Rakam3Button";
            this.Rakam3Button.Size = new System.Drawing.Size(75, 75);
            this.Rakam3Button.TabIndex = 3;
            this.Rakam3Button.Text = "3";
            this.Rakam3Button.UseVisualStyleBackColor = false;
            this.Rakam3Button.Click += new System.EventHandler(this.Rakam3Button_Click);
            // 
            // rakam6Button
            // 
            this.rakam6Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6Button.Location = new System.Drawing.Point(160, 152);
            this.rakam6Button.Name = "rakam6Button";
            this.rakam6Button.Size = new System.Drawing.Size(75, 75);
            this.rakam6Button.TabIndex = 6;
            this.rakam6Button.Text = "6";
            this.rakam6Button.UseVisualStyleBackColor = false;
            this.rakam6Button.Click += new System.EventHandler(this.rakam6Button_Click);
            // 
            // rakam5Button
            // 
            this.rakam5Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5Button.Location = new System.Drawing.Point(79, 152);
            this.rakam5Button.Name = "rakam5Button";
            this.rakam5Button.Size = new System.Drawing.Size(75, 75);
            this.rakam5Button.TabIndex = 5;
            this.rakam5Button.Text = "5";
            this.rakam5Button.UseVisualStyleBackColor = false;
            this.rakam5Button.Click += new System.EventHandler(this.rakam5Button_Click);
            // 
            // rakam4Button
            // 
            this.rakam4Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4Button.Location = new System.Drawing.Point(-2, 152);
            this.rakam4Button.Name = "rakam4Button";
            this.rakam4Button.Size = new System.Drawing.Size(75, 75);
            this.rakam4Button.TabIndex = 1;
            this.rakam4Button.Text = "4";
            this.rakam4Button.UseVisualStyleBackColor = false;
            this.rakam4Button.Click += new System.EventHandler(this.rakam4Button_Click);
            // 
            // rakam9Button
            // 
            this.rakam9Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam9Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9Button.Location = new System.Drawing.Point(160, 233);
            this.rakam9Button.Name = "rakam9Button";
            this.rakam9Button.Size = new System.Drawing.Size(75, 75);
            this.rakam9Button.TabIndex = 9;
            this.rakam9Button.Text = "9";
            this.rakam9Button.UseVisualStyleBackColor = false;
            this.rakam9Button.Click += new System.EventHandler(this.rakam9Button_Click);
            // 
            // rakam8Button
            // 
            this.rakam8Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam8Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8Button.Location = new System.Drawing.Point(79, 233);
            this.rakam8Button.Name = "rakam8Button";
            this.rakam8Button.Size = new System.Drawing.Size(75, 75);
            this.rakam8Button.TabIndex = 8;
            this.rakam8Button.Text = "8";
            this.rakam8Button.UseVisualStyleBackColor = false;
            this.rakam8Button.Click += new System.EventHandler(this.rakam8Button_Click);
            // 
            // rakam7Button
            // 
            this.rakam7Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7Button.Location = new System.Drawing.Point(-2, 233);
            this.rakam7Button.Name = "rakam7Button";
            this.rakam7Button.Size = new System.Drawing.Size(75, 75);
            this.rakam7Button.TabIndex = 7;
            this.rakam7Button.Text = "7";
            this.rakam7Button.UseVisualStyleBackColor = false;
            this.rakam7Button.Click += new System.EventHandler(this.rakam7Button_Click);
            // 
            // eşittirButton
            // 
            this.eşittirButton.BackColor = System.Drawing.Color.Bisque;
            this.eşittirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eşittirButton.Location = new System.Drawing.Point(160, 314);
            this.eşittirButton.Name = "eşittirButton";
            this.eşittirButton.Size = new System.Drawing.Size(75, 75);
            this.eşittirButton.TabIndex = 12;
            this.eşittirButton.Text = "=";
            this.eşittirButton.UseVisualStyleBackColor = false;
            this.eşittirButton.Click += new System.EventHandler(this.eşittirButton_Click);
            // 
            // rakam0Button
            // 
            this.rakam0Button.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rakam0Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0Button.Location = new System.Drawing.Point(79, 314);
            this.rakam0Button.Name = "rakam0Button";
            this.rakam0Button.Size = new System.Drawing.Size(75, 75);
            this.rakam0Button.TabIndex = 11;
            this.rakam0Button.Text = "0";
            this.rakam0Button.UseVisualStyleBackColor = false;
            this.rakam0Button.Click += new System.EventHandler(this.rakam0Button_Click);
            // 
            // temizleButton
            // 
            this.temizleButton.BackColor = System.Drawing.Color.Red;
            this.temizleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButton.ForeColor = System.Drawing.Color.White;
            this.temizleButton.Location = new System.Drawing.Point(-2, 314);
            this.temizleButton.Name = "temizleButton";
            this.temizleButton.Size = new System.Drawing.Size(75, 75);
            this.temizleButton.TabIndex = 10;
            this.temizleButton.Text = "C";
            this.temizleButton.UseVisualStyleBackColor = false;
            this.temizleButton.Click += new System.EventHandler(this.temizleButton_Click);
            // 
            // bölmeButton
            // 
            this.bölmeButton.BackColor = System.Drawing.Color.Pink;
            this.bölmeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bölmeButton.Location = new System.Drawing.Point(241, 314);
            this.bölmeButton.Name = "bölmeButton";
            this.bölmeButton.Size = new System.Drawing.Size(75, 75);
            this.bölmeButton.TabIndex = 16;
            this.bölmeButton.Text = "/";
            this.bölmeButton.UseVisualStyleBackColor = false;
            this.bölmeButton.Click += new System.EventHandler(this.button13_Click);
            // 
            // çarpıButton
            // 
            this.çarpıButton.BackColor = System.Drawing.Color.Pink;
            this.çarpıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çarpıButton.Location = new System.Drawing.Point(241, 233);
            this.çarpıButton.Name = "çarpıButton";
            this.çarpıButton.Size = new System.Drawing.Size(75, 75);
            this.çarpıButton.TabIndex = 15;
            this.çarpıButton.Text = "*";
            this.çarpıButton.UseVisualStyleBackColor = false;
            this.çarpıButton.Click += new System.EventHandler(this.button14_Click);
            // 
            // eksiButton
            // 
            this.eksiButton.BackColor = System.Drawing.Color.Pink;
            this.eksiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksiButton.Location = new System.Drawing.Point(241, 152);
            this.eksiButton.Name = "eksiButton";
            this.eksiButton.Size = new System.Drawing.Size(75, 75);
            this.eksiButton.TabIndex = 14;
            this.eksiButton.Text = "-";
            this.eksiButton.UseVisualStyleBackColor = false;
            this.eksiButton.Click += new System.EventHandler(this.eksiButton_Click);
            // 
            // artıButton
            // 
            this.artıButton.BackColor = System.Drawing.Color.Pink;
            this.artıButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.artıButton.Location = new System.Drawing.Point(241, 71);
            this.artıButton.Name = "artıButton";
            this.artıButton.Size = new System.Drawing.Size(75, 75);
            this.artıButton.TabIndex = 13;
            this.artıButton.Text = "+";
            this.artıButton.UseVisualStyleBackColor = false;
            this.artıButton.Click += new System.EventHandler(this.artıButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 387);
            this.Controls.Add(this.bölmeButton);
            this.Controls.Add(this.çarpıButton);
            this.Controls.Add(this.eksiButton);
            this.Controls.Add(this.artıButton);
            this.Controls.Add(this.eşittirButton);
            this.Controls.Add(this.rakam0Button);
            this.Controls.Add(this.temizleButton);
            this.Controls.Add(this.rakam9Button);
            this.Controls.Add(this.rakam8Button);
            this.Controls.Add(this.rakam7Button);
            this.Controls.Add(this.rakam6Button);
            this.Controls.Add(this.rakam5Button);
            this.Controls.Add(this.rakam4Button);
            this.Controls.Add(this.Rakam3Button);
            this.Controls.Add(this.rakam2Button);
            this.Controls.Add(this.rakam1Button);
            this.Controls.Add(this.ekranLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1Button;
        private System.Windows.Forms.Button rakam2Button;
        private System.Windows.Forms.Button Rakam3Button;
        private System.Windows.Forms.Button rakam6Button;
        private System.Windows.Forms.Button rakam5Button;
        private System.Windows.Forms.Button rakam4Button;
        private System.Windows.Forms.Button rakam9Button;
        private System.Windows.Forms.Button rakam8Button;
        private System.Windows.Forms.Button rakam7Button;
        private System.Windows.Forms.Button eşittirButton;
        private System.Windows.Forms.Button rakam0Button;
        private System.Windows.Forms.Button temizleButton;
        private System.Windows.Forms.Button bölmeButton;
        private System.Windows.Forms.Button çarpıButton;
        private System.Windows.Forms.Button eksiButton;
        private System.Windows.Forms.Button artıButton;
    }
}

