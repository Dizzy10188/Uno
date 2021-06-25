using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uno
{
    public partial class HandSwapSelect : Form
    {
        public int ClickResult { get; private set; }

        public HandSwapSelect(int MaxPlayers, int CurrentPlayerIndex)
        {
            InitializeComponent();
            if(MaxPlayers >= 4 && CurrentPlayerIndex != 3)
            {
                selectPlayerFour.Enabled = true;
                selectPlayerFour.Visible = true;
            }
            if (MaxPlayers >= 3 && CurrentPlayerIndex != 2)
            {
                selectPlayerThree.Enabled = true;
                selectPlayerThree.Visible = true;
            }
            if (MaxPlayers >= 2 && CurrentPlayerIndex != 1)
            {
                selectPlayerTwo.Enabled = true;
                selectPlayerTwo.Visible = true;
            }
            if (MaxPlayers >= 1 && CurrentPlayerIndex != 0)
            {
                selectPlayerOne.Enabled = true;
                selectPlayerOne.Visible = true;
            }
        }

        private void selectPlayerOne_Click(object sender, EventArgs e)
        {
            ClickResult = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void selectPlayerTwo_Click(object sender, EventArgs e)
        {
            ClickResult = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void selectPlayerThree_Click(object sender, EventArgs e)
        {
            ClickResult = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void selectPlayerFour_Click(object sender, EventArgs e)
        {
            ClickResult = 3;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
