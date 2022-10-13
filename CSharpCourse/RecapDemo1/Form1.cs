using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8]; // buttonlar için dizi nesnesi oluşturur
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); // her buton ayrı nesnedir
                    buttons[i, j].Width = 100; // butonun genişliği
                    buttons[i, j].Height = 100; // butonun yüksekliği
                    buttons[i, j].Left = left; // butonun soldan konumu
                    buttons[i, j].Top = top; // butonun yukarıdan konumu
                    left += 100; // her buton eklendikten sonra 100 px saga kaydıracak
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                left = 0; // saga kaydırmaı sıfırlamak lazım çünkü artık bir satır aşağı kayacak
                top += 100; // her bir satır sonrasında 100 px aşağı kaydıracak
            }
        }
    }
}
