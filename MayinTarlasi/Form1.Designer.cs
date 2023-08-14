namespace MayinTarlasi
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            btnBaslat = new Button();
            txtMayin = new TextBox();
            txtSure = new TextBox();
            timer2 = new System.Windows.Forms.Timer(components);
            btnYeni = new Button();
            btnRestart = new Button();
            btnYardım = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(795, 91);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(29, 36);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(648, 91);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 36);
            label2.TabIndex = 1;
            label2.Text = "Kalan Süre:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(648, 269);
            btnBaslat.Margin = new Padding(6);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(202, 85);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            btnBaslat.KeyDown += btnBaslat_KeyDown;
            // 
            // txtMayin
            // 
            txtMayin.Location = new Point(648, 145);
            txtMayin.Margin = new Padding(6);
            txtMayin.Name = "txtMayin";
            txtMayin.PlaceholderText = "Mayın sayısını girin";
            txtMayin.Size = new Size(199, 39);
            txtMayin.TabIndex = 3;
            // 
            // txtSure
            // 
            txtSure.Location = new Point(648, 207);
            txtSure.Margin = new Padding(6);
            txtSure.Name = "txtSure";
            txtSure.PlaceholderText = "Süre bilgisini girin";
            txtSure.Size = new Size(199, 39);
            txtSure.TabIndex = 4;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(648, 367);
            btnYeni.Margin = new Padding(6);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(202, 85);
            btnYeni.TabIndex = 5;
            btnYeni.Text = "Yeni Oyun";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            btnYeni.KeyDown += btnBaslat_KeyDown;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(648, 465);
            btnRestart.Margin = new Padding(6);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(202, 85);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            btnRestart.KeyDown += btnBaslat_KeyDown;
            // 
            // btnYardım
            // 
            btnYardım.Location = new Point(648, 563);
            btnYardım.Margin = new Padding(6);
            btnYardım.Name = "btnYardım";
            btnYardım.Size = new Size(202, 85);
            btnYardım.TabIndex = 7;
            btnYardım.Text = "Yardım";
            btnYardım.UseVisualStyleBackColor = true;
            btnYardım.Click += btnYardım_Click;
            btnYardım.KeyDown += btnBaslat_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(813, 35);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 8;
            // 
            // label4
            // 
            label4.Location = new Point(648, 35);
            label4.Name = "label4";
            label4.Size = new Size(159, 40);
            label4.TabIndex = 9;
            label4.Text = "Kalan bomba:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(866, 663);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnYardım);
            Controls.Add(btnRestart);
            Controls.Add(btnYeni);
            Controls.Add(txtSure);
            Controls.Add(txtMayin);
            Controls.Add(btnBaslat);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
        private Button btnBaslat;
        private TextBox txtMayin;
        private TextBox txtSure;
        private System.Windows.Forms.Timer timer2;
        private Button btnYeni;
        private Button btnRestart;
        private Button btnYardım;
        private Label label3;
        private Label label4;
    }
}