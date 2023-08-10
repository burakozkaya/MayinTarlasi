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
            label1.Location = new Point(501, 44);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 44);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Kalan Süre:";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(430, 120);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(109, 40);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // txtMayin
            // 
            txtMayin.Location = new Point(430, 62);
            txtMayin.Name = "txtMayin";
            txtMayin.PlaceholderText = "Mayın sayısını girin";
            txtMayin.Size = new Size(109, 23);
            txtMayin.TabIndex = 3;
            // 
            // txtSure
            // 
            txtSure.Location = new Point(430, 91);
            txtSure.Name = "txtSure";
            txtSure.PlaceholderText = "Süre bilgisini girin";
            txtSure.Size = new Size(109, 23);
            txtSure.TabIndex = 4;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 395);
            Controls.Add(txtSure);
            Controls.Add(txtMayin);
            Controls.Add(btnBaslat);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}