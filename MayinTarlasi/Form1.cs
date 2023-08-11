using System.Windows.Forms;

namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        Dictionary<Button, (int, int)> dicBomb = new Dictionary<Button, (int, int)>();

        Dictionary<Button, (int, int)> dicN = new Dictionary<Button, (int, int)>();

        DialogResult tekrarOyna, ayniAyar, yeniOyun;

        string tempName = "Mayın Tarlası";

        (int, int) temp;
        int count, countTemp, tempBomb, count2 = 10, x, y;

        Button[,] buttons = new Button[10, 10];
        private void Form1_Load(object sender, EventArgs e)
        {
            FormSettings();
            TableMaker(count2);
        }
        private void BombCheck(object? sender, MouseEventArgs e)
        {
            timer1.Start();
            Button btn = sender as Button;
            if (dicBomb.ContainsKey(btn))
            {
                timer1.Stop();
                MessageBox.Show("Bombaya tıklandı\nOynu kaybettiniz.");
                timer2.Enabled = true;
                timer2.Start();
                foreach (var item in buttons)
                {
                    item.Enabled = false;
                }
                foreach (var item in dicBomb.Keys)
                {
                    item.BackColor = Color.Red;
                }
                btnYardım.Focus();
            }
            else
            {
                temp = dicN[btn];
                x = temp.Item1;
                y = temp.Item2;
                dicN.Remove(btn);
                buttons[x, y].Enabled = false;
                buttons[x, y].BackColor = Color.Green;
                if (dicN.Count == 0)
                {
                    MessageBox.Show("Tebrikler Oynu kazandınız");
                    DialogRes();
                }
                else
                {
                    int count = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            if (i == 0 && j == 0)
                                continue;
                            if (dicBomb.ContainsValue((x + i, y + j)))
                            {
                                count++;
                            }

                        }
                    }
                    btn.Text = count.ToString();
                }

            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            LabelSetter();
            if (count == 0)
            {
                foreach (var item in buttons)
                {
                    item.Enabled = false;
                }
                timer1.Stop();
                MessageBox.Show("Süreniz dolduğu için kaybettiniz!");
                DialogRes();
            }
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {

            bool flag1, flag2;
            string tempX = "";
            flag1 = int.TryParse(txtMayin.Text, out tempBomb);
            flag2 = int.TryParse(txtSure.Text, out count);
            if (flag1 && flag2 && count >= 30&& tempBomb > 0)
            {
                countTemp = count;
                RestartGame();
                btnBaslat.TabStop = false;
                btnYeni.TabStop = false;
                btnYardım.TabStop = false;
                btnRestart.TabStop = false;
            }
            else
            {
                if (!flag1)
                    tempX += "Mayın alanını doğru giriniz. ";
                if (flag1 && tempBomb < 0)
                    tempX += "Mayın alanı 0 veya 0'dan küçük olamaz. ";
                if (!flag2)
                    tempX += "Sürenin doğru girildiğinden emin olunuz. ";
                if (count < 30 && flag2)
                    tempX += "Süre 30 saniyeden az olamaz.";
                MessageBox.Show(tempX);
                return;
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            count2--;
            if (count2 == 0)
            {
                timer2.Stop();
                DialogRes();
                count2 = 10;
            }

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            yeniOyun = MessageBox.Show("Yeni bir oyun oluşturmak istediğinizden emin misiniz ?", tempName, MessageBoxButtons.YesNo);
            if (yeniOyun == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        private void btnYardım_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Oynu başlatmak için önce mayın ve süre bilgisini girin ve başlat butonuna basın.\n2) Yeni ayarlarla oyun oynamak için yeni oyun butonuna tıklayın.\n3) Ayarları yapıp oynu başlattıktan sonra Restart butonu aktive olacaktır.Aynı ayarlarla oynamak için Restart butonuna basın.\n4) Ekrandaki butonlara tıklayınca bombaya denk gelmediyseniz butonun üzerinde bir numara belirecektir.\n5) Bu numara butonun etrafında kaç tane mayın olduğunu göstermektedir.\n6)Oynu kazanmak için tüm mayınsız alanlara tıklamnız lazım\nİyi eğlenceler!\n© 2023 Burak.Ozky");
        }
        //oynu aynı ayarlarla tekrar başlatmayı sağlayan method
        private void RestartGame()
        {
            dicBomb.Clear();
            dicN.Clear();
            foreach (var item in buttons)
            {
                item.Text = string.Empty;
                item.BackColor = Color.White;
                item.Enabled = true;
            }
            count = countTemp;
            btnBaslat.Enabled = false;
            txtMayin.Enabled = false;
            txtSure.Enabled = false;
            int temp = 10;
            timer1.Stop();
            timer2.Stop();
            count2 = 10;
            LabelSetter();
            BombMaker(tempBomb, temp);
            btnRestart.Enabled = true;
        }
        //Form ayarlarını yapan metot
        private void FormSettings()
        {
            txtMayin.TabIndex = 0;
            txtSure.TabIndex = 1;
            btnBaslat.TabIndex = 2;
            btnYeni.TabIndex = 3;
            btnRestart.TabIndex = 4;
            btnYardım.TabIndex = 5;
            label1.Enabled = false;
            label2.Enabled = false;
            btnRestart.Enabled = false;
            this.Name = tempName;
            this.Text = tempName;
            this.Size = new Size(500, 345);
            this.AutoSize = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        //sürenin ayarlandığı method
        private void LabelSetter()
        {
            string tempSaniye = count % 60 < 10 ? "0" + (count % 60).ToString() : (count % 60).ToString();
            int tempDakika = (count / 60);
            label1.Text = tempDakika > 0 ? $"{tempDakika}:{tempSaniye}" : $"{tempSaniye}";
        }
        //Bombaların oluşturulduğu method
        private void BombMaker(int bomb, int x)
        {
            for (int i = 0; i < bomb; i++)
            {
                int tempI = new Random().Next(0, x);
                int tempY = new Random().Next(0, x);
                temp = (new Random().Next(0, x), new Random().Next(0, x));
                if (!dicBomb.ContainsValue((tempI, tempY)))
                    dicBomb.Add( buttons[tempI, tempY], (tempI, tempY));
                else
                    i--;
            }
            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                {
                    if (!dicBomb.ContainsValue((i, j)))
                        dicN.Add(buttons[i,j], (i, j));
                    else
                        buttons[i, j].Text = "bomb";

                    buttons[i, j].Enabled = true;

                }

        }
        //buttonların oluşturulduğu metot
        private void TableMaker(int temp)
        {
            x = 5;
            y = 0;
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < temp; j++)
                {

                    buttons[i, j] = new Button()
                    {

                        Size = new Size(30, 30),
                        Location = new Point(x, y),

                    };

                    x += 31;
                    buttons[i, j].TabStop = false;
                    buttons[i, j].Enabled = false;


                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].MouseClick += BombCheck;
                }

                y += 30;
                x = 5;
            }
        }
        //devam etmek istiyor musun popupunu çalıştıran metot
        private void DialogRes()
        {
            tekrarOyna = MessageBox.Show("Devam etmek istiyor musunuz ?", tempName, MessageBoxButtons.YesNo);
            if (tekrarOyna == DialogResult.Yes)
            {
                ayniAyar = MessageBox.Show("Aynı ayarlarla oynamak ister misiniz ?", tempName, MessageBoxButtons.YesNo);

                if (ayniAyar == DialogResult.Yes)
                {
                    RestartGame();
                }
                else
                {
                    Application.Restart();
                    Environment.Exit(0);
                }

            }
            else
            {
                MessageBox.Show("Uygulama sonlandırıldı");
                Application.Exit();
            }
        }
        private void btnBaslat_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = sender as Button;
            if (e.KeyCode == Keys.Enter)
            {
                btn.Select();
            }
        }
    }
}