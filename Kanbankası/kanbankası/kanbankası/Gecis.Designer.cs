namespace kanbankası
{
    partial class Gecis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gecis));
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GecisProgressBar = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GecisProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kan Bankası Yönetim Sistemi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GecisProgressBar
            // 
            this.GecisProgressBar.AnimationSpeed = 0.6F;
            this.GecisProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.GecisProgressBar.BaseColor = System.Drawing.Color.White;
            this.GecisProgressBar.Controls.Add(this.pictureBox1);
            this.GecisProgressBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.GecisProgressBar.IdleOffset = 20;
            this.GecisProgressBar.Image = null;
            this.GecisProgressBar.ImageSize = new System.Drawing.Size(52, 52);
            this.GecisProgressBar.Location = new System.Drawing.Point(215, 60);
            this.GecisProgressBar.Name = "GecisProgressBar";
            this.GecisProgressBar.ProgressMaxColor = System.Drawing.Color.Red;
            this.GecisProgressBar.ProgressMinColor = System.Drawing.Color.Red;
            this.GecisProgressBar.ProgressOffset = 20;
            this.GecisProgressBar.ProgressThickness = 10;
            this.GecisProgressBar.Size = new System.Drawing.Size(246, 246);
            this.GecisProgressBar.TabIndex = 1;
            this.GecisProgressBar.Click += new System.EventHandler(this.gunaCircleProgressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 337);
            this.Controls.Add(this.GecisProgressBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gecis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GecisProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaCircleProgressBar GecisProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

