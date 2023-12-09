
namespace Caro_HoXuanDai
{
    partial class frmDai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDai));
            this.pnBoardChess = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnUndo1 = new System.Windows.Forms.Button();
            this.btnUndo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUndo1 = new System.Windows.Forms.Label();
            this.lblUndo2 = new System.Windows.Forms.Label();
            this.lblWin1 = new System.Windows.Forms.Label();
            this.lblWin2 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLuot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBoardChess
            // 
            this.pnBoardChess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBoardChess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBoardChess.Location = new System.Drawing.Point(166, 62);
            this.pnBoardChess.Margin = new System.Windows.Forms.Padding(500, 3, 500, 3);
            this.pnBoardChess.Name = "pnBoardChess";
            this.pnBoardChess.Size = new System.Drawing.Size(899, 645);
            this.pnBoardChess.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Peru;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(21, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 75);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Peru;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(1089, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 75);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer1.BackColor = System.Drawing.Color.Wheat;
            this.lblPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(12, 111);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(141, 45);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlayer2.BackColor = System.Drawing.Color.Wheat;
            this.lblPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(1084, 111);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(141, 45);
            this.lblPlayer2.TabIndex = 12;
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUndo1
            // 
            this.btnUndo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo1.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUndo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo1.Location = new System.Drawing.Point(36, 239);
            this.btnUndo1.Name = "btnUndo1";
            this.btnUndo1.Size = new System.Drawing.Size(87, 49);
            this.btnUndo1.TabIndex = 13;
            this.btnUndo1.Text = "Undo";
            this.btnUndo1.UseVisualStyleBackColor = false;
            this.btnUndo1.Click += new System.EventHandler(this.btnUndo1_Click);
            // 
            // btnUndo2
            // 
            this.btnUndo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo2.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUndo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo2.Location = new System.Drawing.Point(1115, 239);
            this.btnUndo2.Name = "btnUndo2";
            this.btnUndo2.Size = new System.Drawing.Size(87, 49);
            this.btnUndo2.TabIndex = 14;
            this.btnUndo2.Text = "Undo";
            this.btnUndo2.UseVisualStyleBackColor = false;
            this.btnUndo2.Click += new System.EventHandler(this.btnUndo2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Win";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1115, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 50);
            this.label2.TabIndex = 16;
            this.label2.Text = "Win";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUndo1
            // 
            this.lblUndo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUndo1.BackColor = System.Drawing.Color.Wheat;
            this.lblUndo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUndo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndo1.Location = new System.Drawing.Point(48, 291);
            this.lblUndo1.Name = "lblUndo1";
            this.lblUndo1.Size = new System.Drawing.Size(58, 39);
            this.lblUndo1.TabIndex = 17;
            this.lblUndo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUndo2
            // 
            this.lblUndo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUndo2.BackColor = System.Drawing.Color.Wheat;
            this.lblUndo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUndo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndo2.Location = new System.Drawing.Point(1130, 291);
            this.lblUndo2.Name = "lblUndo2";
            this.lblUndo2.Size = new System.Drawing.Size(58, 39);
            this.lblUndo2.TabIndex = 18;
            this.lblUndo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin1
            // 
            this.lblWin1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWin1.BackColor = System.Drawing.Color.Wheat;
            this.lblWin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin1.Location = new System.Drawing.Point(36, 422);
            this.lblWin1.Margin = new System.Windows.Forms.Padding(0);
            this.lblWin1.Name = "lblWin1";
            this.lblWin1.Size = new System.Drawing.Size(83, 45);
            this.lblWin1.TabIndex = 19;
            this.lblWin1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWin2
            // 
            this.lblWin2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWin2.BackColor = System.Drawing.Color.Wheat;
            this.lblWin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin2.Location = new System.Drawing.Point(1115, 422);
            this.lblWin2.Name = "lblWin2";
            this.lblWin2.Size = new System.Drawing.Size(83, 45);
            this.lblWin2.TabIndex = 20;
            this.lblWin2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_time
            // 
            this.lbl_time.BackColor = System.Drawing.Color.Tan;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(570, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(117, 44);
            this.lbl_time.TabIndex = 21;
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1139, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1109, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 24;
            this.label3.Text = "Lượt của";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLuot
            // 
            this.lblLuot.BackColor = System.Drawing.Color.Tan;
            this.lblLuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuot.ForeColor = System.Drawing.Color.Red;
            this.lblLuot.Location = new System.Drawing.Point(1140, 662);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(62, 45);
            this.lblLuot.TabIndex = 25;
            this.lblLuot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 66);
            this.button1.TabIndex = 26;
            this.button1.Text = "Kết quả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPrint);
            // 
            // frmDai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1237, 719);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLuot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lblWin2);
            this.Controls.Add(this.lblWin1);
            this.Controls.Add(this.lblUndo2);
            this.Controls.Add(this.lblUndo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUndo2);
            this.Controls.Add(this.btnUndo1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnBoardChess);
            this.Name = "frmDai";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBoardChess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnUndo1;
        private System.Windows.Forms.Button btnUndo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUndo1;
        private System.Windows.Forms.Label lblUndo2;
        private System.Windows.Forms.Label lblWin1;
        private System.Windows.Forms.Label lblWin2;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.Button button1;
    }
}

