using System;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public partial class Form1 : Form
    {
        private int boxW = 20;
        private int boxH = 20;
        private int w, h;
        private Label[,] lab;
        private Life life;
        private Color cNone = Color.White;
        private Color cLive = Color.Black;
        private Color cBorn = Color.Yellow;
        private Color cDied = Color.Gray;

        public Form1()
        {
            InitializeComponent();
            InitLabels();
        }

        private void InitLabels()
        {
            w = (panel1.Width - 1) / boxW;
            h = (panel1.Height - 1) / boxH;

            life = new Life(w, h);
            lab = new Label[w, h];

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    AddLabel(x, y);
                }
            }
        }

        private void AddLabel(int x, int y)
        {
            lab[x, y] = new Label
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(x * boxW, y * boxH),
                Size = new Size(boxW + 1, boxH + 1),
                Parent = panel1
            };
            lab[x, y].MouseClick += LabelMouseClick;
        }

        private void RefreshScene()
        {
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    switch (life.GetMap(x, y))
                    {
                        case 0: lab[x, y].BackColor = cNone; break;
                        case 1: lab[x, y].BackColor = cLive; break;
                        case 2: lab[x, y].BackColor = cDied; break;
                        case -1: lab[x, y].BackColor = cBorn; break;
                    }
                }
            }
        }

        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            int x = (sender as Label).Location.X / boxW;
            int y = (sender as Label).Location.Y / boxH;

            int color = life.Turn(x, y);
            lab[x, y].BackColor = color == 1 ? cLive : cNone;
        }

        private void step1_Click(object sender, EventArgs e)
        {
            life.Step1();
            RefreshScene();
        }

        private void step2_Click(object sender, EventArgs e)
        {
            life.Step2();
            RefreshScene();
        }

        private void step12_Click(object sender, EventArgs e)
        {
            life.Step1();
            life.Step2();
            RefreshScene();
        }

        private void timerControl_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            life.Step1();
            life.Step2();
            RefreshScene();
        }
    }
}
