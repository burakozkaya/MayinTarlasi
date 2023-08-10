namespace MayinTarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        Dictionary<(int, int), string> dic = new Dictionary<(int, int), string>();
        Dictionary<(int, int), string> dicN = new Dictionary<(int, int), string>();
        DialogResult tekrarOyna;

        (int, int) temp;
        int count;
        int count2 = 10;

        Button[,] buttons = new Button[10, 10];
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Name = "Mayın Tarlası";
            this.AutoSize = false;
            this.Size = new Size(600, 400);
            TableMaker(count2);
        }





        private void BombCheck(object? sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            int x, y;
            x = 1;
            y = 1;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if (buttons[i, j] == btn)
                    {
                        x = i;
                        y = j;
                        i = 10;
                        j = 10;
                    }
                }
            temp = (x, y);
            if (dic.ContainsKey(temp))
            {
                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                dicN.Remove((x, y));
                buttons[x, y].Enabled = false;
                buttons[x, y].BackColor = Color.Green;
                if (dicN.Count == 0)
                {
                    MessageBox.Show("Tebrikler Oynu kazandınız");
                    DialogRes();
                }

                int count = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0)
                            continue;
                        if (dic.ContainsKey((x + i, y + j)))
                        {
                            count++;
                        }

                    }
                }
                btn.Text = count.ToString();

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
                MessageBox.Show("Süreniz dolmuştur");
                DialogRes();
            }
        }



        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            count = int.Parse(txtSure.Text);
            int tempBomb = int.Parse(txtMayin.Text);
            int temp = 10;
            LabelSetter();
            BombMaker(tempBomb, temp);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count2--;
            if (count2 == 0)
            {

                timer2.Stop();
                MessageBox.Show("Oynu kaybettiniz.");
                DialogRes();
            }
        }
        private void LabelSetter()
        {
            string tempSaniye = count % 60 < 10 ? "0" + (count % 60).ToString() : (count % 60).ToString();
            int tempDakika = (count / 60);
            label1.Text = tempDakika > 0 ? $"{tempDakika}:{tempSaniye}" : $"{tempSaniye}";
        }

        private void BombMaker(int bomb, int x)
        {
            for (int i = 0; i < bomb; i++)
            {
                temp = (new Random().Next(0, x), new Random().Next(0, x));
                if (!dic.ContainsKey(temp))
                    dic.Add(temp, "bomb");
                else
                    i--;
            }
            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                {
                    if (!dic.ContainsKey((i, j)))
                        dicN.Add((i, j), "neutral");
                      else
                        buttons[i, j].Text = "bomb";

                     buttons[i, j].Enabled = true;

                }

        }
        private void TableMaker(int temp)
        {

            int x = 0;
            int y = 0;
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
                x = 0;
            }
        }

        private void DialogRes()
        {
            tekrarOyna = MessageBox.Show("Devam etmek istiyor musunuz ?", "Mayın Tarlası", MessageBoxButtons.YesNo);
            if (tekrarOyna == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Uygulama sonlandırıldı");
                Application.Exit();
            }
        }
    }
}