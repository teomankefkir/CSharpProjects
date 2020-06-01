using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class frmPiano : Form
    {
        public frmPiano()
        {
            InitializeComponent();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(200, 500); 
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(250, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(300, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(350, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(400, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(450, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(500, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(550, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(600, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(650, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(700, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnCSharp_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(200, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnDSharp_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(250, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnFSharp_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(350, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Fq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnGSharp_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(400, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Gq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnBb_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(450, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnCSharp1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(550, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void btnDSharp1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Console.Beep(600, 500);
            }
            if (radioButton2.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }
    }
}
