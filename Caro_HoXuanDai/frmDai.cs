using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Caro_HoXuanDai
{
    public partial class frmDai : Form
    {
        public bool isStart = false;
        private bool isPlayerX = true;
        private string player1Name = "";
        private string player2Name = "";
        private int undo1 = 3;
        private int undo2 = 3;
        private Button lastMoveButton = null;
        private string currentPlayer = "";
        private int win1 = 0;
        private int win2 = 0;
        private int totalGames = 0;
        public string TimeDown
        {
            get => lbl_time.Text;
            set => lbl_time.Text = value;
        }

        Color xBackColor = Color.Chocolate;
        Color xForeColor = Color.White;

        Color oBackColor = Color.Wheat;
        Color oForeColor = Color.Chocolate;

        #region Properties
        cls_HoXuanDai caro;
        #endregion

        public frmDai()
        {
            InitializeComponent();
            DisableButtons();
            caro = new cls_HoXuanDai(pnBoardChess, lblPlayer1, lblPlayer2,btnUndo1, gameTimer, btnUndo2, 
                lblWin1, lblWin2, lblLuot, lbl_time, lblUndo1, lblUndo2, btnClear, this);
            caro.CreateButtons();
            caro.BtnUndo1.Enabled = false;
            caro.BtnUndo2.Enabled = false;
            caro.BtnClear.Enabled = false;
        }
        public void SetPlayerNames(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            lblPlayer1.Text = player1Name;
            lblPlayer2.Text = player2Name;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnUndo1.Enabled = false;
            btnUndo2.Enabled = false;
            InputNamePlayer inputNamePlayer = new InputNamePlayer();
            inputNamePlayer.Owner = this;
            inputNamePlayer.ShowDialog();
            cls_HoXuanDai.IsStart = true;
            foreach (Control control in pnBoardChess.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                    button.BackColor = Color.White;
                    button.ForeColor = SystemColors.ControlText;
                }
            }
            EnableButtons();
            lblUndo1.Text = undo1.ToString();
            lblUndo2.Text = undo2.ToString();
            win1 = 0;
            win2 = 0;
            totalGames = 0;
            UpdateWinLabels();
            lblLuot.Text = "X";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            caro.LblLuot.Text = "X";
            foreach (Control control in pnBoardChess.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Text = "";
                    button.BackColor = Color.White;
                    button.ForeColor = SystemColors.ControlText;
                }
            }
            undo1 = 3;
            undo2 = 3;
            lblUndo1.Text = undo1.ToString();
            lblUndo2.Text = undo2.ToString();

            // Reset the player's turn to X         
            isPlayerX = true;
            btnUndo1.Enabled = false;
            btnUndo2.Enabled = false;
            EnableButtons();
            gameTimer.Stop();
            caro.GameTimeInSeconds = 15;
            lbl_time.Text = caro.GameTimeInSeconds.ToString();

            caro.IsPlayerX = true;
        }
        private void btnUndo1_Click(object sender, EventArgs e)
        {
            caro.btnUndo1_Click();
        }
        private void btnUndo2_Click(object sender, EventArgs e)
        {
            caro.btnUndo2_Click();
        }
        private void DisableButtons()
        {
            foreach (Control control in pnBoardChess.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = false;
                }
            }
        }
        private void EnableButtons()
        {
            caro.EnableButtons();
        }
        private void UpdateWinLabels()
        {
            lblWin1.Text = $"{win1} / {totalGames}";
            lblWin2.Text = $"{win2} / {totalGames}";
        }
        private void SaveResultsToFile()
        {
            // Thay đổi đường dẫn tệp tin txt theo địa chỉ bạn muốn lưu.
            string filePath = "D:\\Study\\Nam4_HK1\\LapTrinhWindows\\Ketqua.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Tên người chơi 1: " + player1Name);
                sw.WriteLine("Tên người chơi 2: " + player2Name);
                sw.WriteLine("Số lượt undo của người chơi 1: " + undo1);
                sw.WriteLine("Số lượt undo của người chơi 2: " + undo2);
                sw.WriteLine("Tổng số trận thắng của người chơi 1: " + lblWin1);
                sw.WriteLine("Tổng số trận thắng của người chơi 2: " + lblWin2);
            }
            MessageBox.Show("Kết quả đã được lưu vào tệp tin.");
        }

        private void btnPrint(object sender, EventArgs e)
        {
            SaveResultsToFile();
        }
    }
}
