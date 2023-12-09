using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro_HoXuanDai
{
    class cls_HoXuanDai
    {
        #region Properties
        private Panel pnBoardChess;
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Button btnUndo1;
        private Button btnUndo2;
        private Label lblUndo1;
        private Label lblUndo2;
        private Label lblWin1;
        private Label lblWin2;
        private Label lblLuot;
        private Label lbl_time;
        private Timer gameTimer;
        private Button btnClear;

        private bool isStart = false;
        private bool isPlayerX = true;
        private string player1Name = "";
        private string player2Name = "";
        private int undo1 = 3;
        private int undo2 = 3;
        private Button lastMoveButton = null;
        private int gameTimeInSeconds = 15;
        private string currentPlayer = "";
        private int win1 = 0;
        private int win2 = 0;
        private int totalGames = 0;

        private frmDai FrmDai;

        Color xBackColor = Color.Chocolate;
        Color xForeColor = Color.White;

        Color oBackColor = Color.Wheat;
        Color oForeColor = Color.Chocolate;

        int numRows = 18;
        int numCols = 24;

        public Panel PnBoardChess { get => pnBoardChess; set => pnBoardChess = value; }
        
        public Button BtnUndo1 { get => btnUndo1; set => btnUndo1 = value; }
        public Button BtnUndo2 { get => btnUndo2; set => btnUndo2 = value; }
        public Label LblWin1 { get => lblWin1; set => lblWin1 = value; }
        public Label LblWin2 { get => lblWin2; set => lblWin2 = value; }
        public Label LblLuot { get => lblLuot; set => lblLuot = value; }
        public Label Lbl_time { get => lbl_time; set => lbl_time = value; }
        public Label LblPlayer1 { get => lblPlayer1; set => lblPlayer1 = value; }
        public Label LblPlayer2 { get => lblPlayer2; set => lblPlayer2 = value; }
        public Label LblUndo1 { get => lblUndo1; set => lblUndo1 = value; }
        public Label LblUndo2 { get => lblUndo2; set => lblUndo2 = value; }
        public Timer GameTimer { get => gameTimer; set => gameTimer = value; }
        public Button BtnClear { get => btnClear; set => btnClear = value; }
        public static bool IsStart { get; internal set; }
        public frmDai FrmDai1 { get => FrmDai; set => FrmDai = value; }
        public int GameTimeInSeconds { get => gameTimeInSeconds; set => gameTimeInSeconds = value; }
        public bool IsPlayerX { get => isPlayerX; set => isPlayerX = value; }

        #endregion

        #region Initialize
        public cls_HoXuanDai(Panel PnBoardChess, Label lblPlayer1, Label lblPlayer2, Button btnUndo1, Timer gameTimer,
            Button btnUndo2, Label lblWin1, Label lblWin2, Label lblLuot, Label lbl_time, Label lblUndo1, Label lblUndo2,
            Button btnClear, frmDai frmDai)
        {
            this.pnBoardChess = PnBoardChess;
            this.lblPlayer1 = lblPlayer1;
            this.lblPlayer2 = lblPlayer2;
            this.btnUndo1 = btnUndo1;
            this.btnUndo2 = btnUndo2;
            this.lblUndo1 = lblUndo1;
            this.lblUndo2 = lblUndo2;
            this.lblWin1 = lblWin1;
            this.lblWin2 = lblWin2;
            this.lblLuot = lblLuot;
            this.lbl_time = lbl_time;
            this.GameTimer = gameTimer;
            this.btnClear = btnClear;
            this.isStart = false;
            this.FrmDai1 = frmDai;

            this.GameTimer.Tick += GameTimer_Tick;

            this.IsPlayerX = isPlayerX;
        }
        #endregion

        #region Methods

        public void CreateButtons()
        {
            int buttonWidth = PnBoardChess.Width / numCols;
            int buttonHeight = PnBoardChess.Height / numRows;

            for (int row = 0; row < numRows; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    Button cell = new Button();
                    cell.Width = buttonWidth;
                    cell.Height = buttonHeight;
                    cell.FlatStyle = FlatStyle.Popup;

                    // Tính toán vị trí của button
                    int left = col * buttonWidth;
                    int top = row * buttonHeight;

                    cell.Left = left;
                    cell.Top = top;

                    // Thêm sự kiện Click cho button
                    cell.Click += Button_Click;

                    PnBoardChess.Controls.Add(cell);
                }
            }
        }  
        public void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (!IsStart) return;
            if (LblPlayer1.Text.Length == 0 || LblPlayer2.Text.Length == 0)
            {
                DisableButtons();
                LblUndo1.Text = "";
                LblUndo2.Text = "";
                LblWin1.Text = "";
                LblWin2.Text = "";
                BtnUndo1.Enabled = false;
                BtnUndo2.Enabled = false;
                LblLuot.Text = "";
                Lbl_time.Text = "";
                BtnClear.Enabled = false;
                
            }
            else
            {
                if (clickedButton.Text == "") // Kiểm tra nếu nút chưa được chọn
                {
                    if (IsPlayerX)
                    {
                        LblLuot.Text = "O";
                        GameTimeInSeconds = 15; // Đặt lại thời gian
                        FrmDai1.TimeDown = GameTimeInSeconds.ToString(); // Cập nhật label thời gian
                        currentPlayer = player1Name;
                        if (undo1 > 0)
                        {
                            BtnUndo1.Enabled = true;
                        }
                        else
                        {
                            BtnUndo1.Enabled = false;
                        }
                        BtnUndo2.Enabled = false;
                        clickedButton.Text = "X";
                        clickedButton.BackColor = xBackColor;
                        clickedButton.ForeColor = xForeColor;
                        GameTimer.Start();
                    }
                    else
                    {
                        LblLuot.Text = "X";
                        GameTimeInSeconds = 15; // Đặt lại thời gian
                        FrmDai1.TimeDown = GameTimeInSeconds.ToString(); // Cập nhật label thời gian
                        currentPlayer = player2Name;
                        if (undo2 > 0)
                        {
                            BtnUndo2.Enabled = true;
                        }
                        else
                        {
                            BtnUndo2.Enabled = false;
                        }
                        BtnUndo1.Enabled = false;
                        clickedButton.Text = "O"; // Đặt O vào nút
                        clickedButton.BackColor = oBackColor; // Đặt màu nền cho O
                        clickedButton.ForeColor = oForeColor; // Đặt màu cho chữ O   
                        GameTimer.Start();
                    }
                    clickedButton.Font = new Font(clickedButton.Font.FontFamily, 14, FontStyle.Bold);
                    clickedButton.TextAlign = ContentAlignment.MiddleCenter;

                    lastMoveButton = clickedButton;
                    BtnClear.Enabled = true;

                    string winner = CheckWin(clickedButton);
                    string winName = IsPlayerX ? lblPlayer1.Text : lblPlayer2.Text;
                    if (winner != null)
                    {
                        if (IsPlayerX == true)
                        {
                            win1++;                          
                            GameTimer.Stop();
                        }
                        else
                        {
                            win2++;
                            
                            GameTimer.Stop();
                        }
                        totalGames++;
                        UpdateWinLabels();
                        // Hiển thị thông báo chiến thắng
                        MessageBox.Show("Người chơi " + winName + " chiến thắng!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisableButtons();
                        LblLuot.Text = "";
                        BtnUndo1.Enabled = false;
                        BtnUndo2.Enabled = false;                    
                    }
                    IsPlayerX = !IsPlayerX; // Chuyển lượt chơi cho người chơi tiếp theo
                }
            }
        }
        public Button GetCellAt(int row, int col)
        {
            foreach (Button cell in PnBoardChess.Controls.OfType<Button>())
            {
                int cellCol = (cell.Left - PnBoardChess.Left) / cell.Width;
                int cellRow = (cell.Top - PnBoardChess.Top) / cell.Height;

                if (cellRow == row && cellCol == col)
                {
                    return cell;
                }
            }

            return null;
        }
        public bool CheckHorizontalWin(int row, int col, string playerSymbol)
        {
            int count = 1;

            // Kiểm tra qua bên trái của ô hiện tại
            for (int c = col - 1; c >= 0; c--)
            {
                if (GetCellAt(row, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            // Kiểm tra qua bên phải của ô hiện tại
            for (int c = col + 1; c < numCols; c++)
            {
                if (GetCellAt(row, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            return count >= 5;
        }
        public bool CheckVerticalWin(int row, int col, string playerSymbol)
        {
            int count = 1;

            // Kiểm tra phía trên ô hiện tại
            for (int r = row - 1; r >= 0; r--)
            {
                if (GetCellAt(r, col).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            // Kiểm tra phía dưới ô hiện tại
            for (int r = row + 1; r < numRows; r++)
            {
                if (GetCellAt(r, col).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            return count >= 5;
        }
        public bool CheckDiagonalWin(int row, int col, string playerSymbol)
        {
            int count = 1;

            // Kiểm tra đường chéo trái trên
            for (int r = row - 1, c = col - 1; r >= 0 && c >= 0; r--, c--)
            {
                if (GetCellAt(r, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            // Kiểm tra đường chéo phải dưới
            for (int r = row + 1, c = col + 1; r < numRows && c < numCols; r++, c++)
            {
                if (GetCellAt(r, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            if (count >= 5)
            {
                return true;
            }

            count = 1;

            // Kiểm tra đường chéo trái dưới
            for (int r = row + 1, c = col - 1; r < numRows && c >= 0; r++, c--)
            {
                if (GetCellAt(r, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            // Kiểm tra đường chéo phải trên
            for (int r = row - 1, c = col + 1; r >= 0 && c < numCols; r--, c++)
            {
                if (GetCellAt(r, c).Text == playerSymbol)
                {
                    count++;
                }
                else
                {
                    break; // Nếu không gặp dấu của người chơi, thoát vòng lặp
                }
            }

            return count >= 5;
        }
        public string CheckWin(Button cell)
        {
            int col = (cell.Left - PnBoardChess.Left) / cell.Width;
            int row = (cell.Top - PnBoardChess.Top) / cell.Height;
            string playerSymbol = cell.Text;

            if (CheckHorizontalWin(row, col, playerSymbol) ||
                CheckVerticalWin(row, col, playerSymbol) ||
                CheckDiagonalWin(row, col, playerSymbol))
            {
                return playerSymbol == "X" ? player1Name : player2Name;
            }

            return null;
        }
        public void btnUndo1_Click()
        {
            if (IsStart)
            {
                if (lastMoveButton != null && lastMoveButton.Text == "X")
                {
                    lastMoveButton.Text = "";
                    lastMoveButton.BackColor = Color.White;
                    lastMoveButton.ForeColor = SystemColors.ControlText;
                    undo1--;
                    lblUndo1.Text = undo1.ToString();
                    IsPlayerX = true;
                    lastMoveButton = null;
                    lblLuot.Text = "X";
                }

                if (undo1 == 0)
                {
                    btnUndo1.Enabled = false;
                }
            }
        }
        public void btnUndo2_Click()
        {
            if (IsStart)
            {
                if (lastMoveButton != null && lastMoveButton.Text == "O")
                {
                    lastMoveButton.Text = "";
                    lastMoveButton.BackColor = Color.White;
                    lastMoveButton.ForeColor = SystemColors.ControlText;
                    undo2--;
                    lblUndo2.Text = undo2.ToString();
                    IsPlayerX = false;
                    lastMoveButton = null;
                    lblLuot.Text = "O";
                }

                if (undo2 == 0)
                {
                    btnUndo2.Enabled = false;
                }
            }
        }
        public void GameTimer_Tick(object sender, EventArgs e)
        {
            GameTimeInSeconds--;
            Lbl_time.Text = GameTimeInSeconds.ToString();
            FrmDai1.TimeDown = GameTimeInSeconds.ToString();

            if (GameTimeInSeconds == 0)
            {
                GameTimer.Stop(); // Dừng đồng hồ đếm thời gian             
                string winnerName = IsPlayerX ? LblPlayer2.Text : LblPlayer1.Text;
                if (IsPlayerX)
                {
                    win2++;
                }
                else
                {
                    win1++;
                }
                totalGames++;
                UpdateWinLabels();

                MessageBox.Show("Hết thời gian, " + winnerName + " thắng!", "Time's up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableButtons(); // Tắt các button
            }
        }
        public void DisableButtons()
        {
            foreach (Control control in pnBoardChess.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = false;
                }
            }
        }
        public void EnableButtons()
        {
            foreach (Control control in pnBoardChess.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Enabled = true;
                }
            }
        }
        public void UpdateWinLabels()
        {
            lblWin1.Text = $"{win1} / {totalGames}";
            lblWin2.Text = $"{win2} / {totalGames}";
        }
        #endregion
    }
}
