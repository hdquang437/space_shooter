using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Shooter.Control
{
    public partial class InstructionScreen : UserControl
    {
        int currentPage;
        public InstructionScreen()
        {
            InitializeComponent();
            currentPage = 1;
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_pre_top_Click(object sender, EventArgs e)
        {
            if (currentPage == 3)
            {
                currentPage -= 1;
                btn_pre_bot.Visible = true;
                btn_next_bot.Visible = true;
                btn_next_top.Visible = false;
                btn_pre_top.Visible = false;
            }
            refreshInstruction();
        }

        private void btn_next_top_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                currentPage += 1;
                btn_pre_bot.Visible = true;
                btn_next_bot.Visible = true;
                btn_next_top.Visible = false;
                btn_pre_top.Visible = false;
            }
            refreshInstruction();
        }

        private void btn_pre_bot_Click(object sender, EventArgs e)
        {
            if (currentPage == 2)
            {
                currentPage -= 1;
                btn_pre_bot.Visible = false;
                btn_next_bot.Visible = false;
                btn_next_top.Visible = true;
                btn_pre_top.Visible = false;
            }
            refreshInstruction();
        }

        private void btn_next_bot_Click(object sender, EventArgs e)
        {
            if (currentPage == 2)
            {
                currentPage += 1;
                btn_pre_bot.Visible = false;
                btn_next_bot.Visible = false;
                btn_next_top.Visible = false;
                btn_pre_top.Visible = true;
            }
            refreshInstruction();
        }

        private void refreshInstruction()
        {
            switch (currentPage)
            {
                case 1:
                    {
                        this.BackgroundImage = Properties.Resources.instruc_1;
                    }
                    break;
                case 2:
                    {
                        this.BackgroundImage = Properties.Resources.instruc_2;
                    }
                    break;
                case 3:
                    {
                        this.BackgroundImage = Properties.Resources.instruc_3;
                    }
                    break;
                default:
                    {
                        this.BackgroundImage = Properties.Resources.instruc_1;
                    }
                    break;
            }
        }
    }
}
