using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_HoXuanDai
{
    public partial class InputNamePlayer : Form
    {
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public InputNamePlayer()
        {
            InitializeComponent();
        }

        private void btnStartClick_InputName(object sender, EventArgs e)
        {
            frmDai inputName = new frmDai();
            if (txtPlayer1.TextLength == 0 || txtPlayer2.TextLength == 0)
            {
                MessageBox.Show("Tên người chơi không được để trống!");
            }
            else
            {
                string player1Name = txtPlayer1.Text;
                string player2Name = txtPlayer2.Text;
                if (this.Owner is frmDai frmDai)
                {
                    frmDai.SetPlayerNames(player1Name, player2Name);
                }
                this.Close();
            }
        }
    }
}
