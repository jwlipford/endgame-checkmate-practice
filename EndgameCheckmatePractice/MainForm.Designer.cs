namespace EndgameCheckmatePractice
{
    partial class MainForm
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
            this.board = new System.Windows.Forms.Panel();
            this.btn_KQ_vs_K = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn_KR_vs_K = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_KRR_vs_K = new System.Windows.Forms.Button();
            this.btn_KN_vs_K = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFileA = new System.Windows.Forms.Label();
            this.lblFileB = new System.Windows.Forms.Label();
            this.lblFileC = new System.Windows.Forms.Label();
            this.lblRank8 = new System.Windows.Forms.Label();
            this.lblRank7 = new System.Windows.Forms.Label();
            this.lblRank6 = new System.Windows.Forms.Label();
            this.lblRank5 = new System.Windows.Forms.Label();
            this.lblRank1 = new System.Windows.Forms.Label();
            this.lblRank2 = new System.Windows.Forms.Label();
            this.lblRank3 = new System.Windows.Forms.Label();
            this.lblRank4 = new System.Windows.Forms.Label();
            this.lblFileD = new System.Windows.Forms.Label();
            this.lblFileH = new System.Windows.Forms.Label();
            this.lblFileG = new System.Windows.Forms.Label();
            this.lblFileF = new System.Windows.Forms.Label();
            this.lblFileE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(39, 12);
            this.board.Margin = new System.Windows.Forms.Padding(0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(512, 512);
            this.board.TabIndex = 0;
            // 
            // btn_KQ_vs_K
            // 
            this.btn_KQ_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KQ_vs_K.Location = new System.Drawing.Point(609, 59);
            this.btn_KQ_vs_K.Name = "btn_KQ_vs_K";
            this.btn_KQ_vs_K.Size = new System.Drawing.Size(106, 30);
            this.btn_KQ_vs_K.TabIndex = 1;
            this.btn_KQ_vs_K.Text = "(K+Q vs K)";
            this.btn_KQ_vs_K.UseVisualStyleBackColor = true;
            this.btn_KQ_vs_K.Click += new System.EventHandler(this.btn_KQ_vs_K_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(626, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btn_KR_vs_K
            // 
            this.btn_KR_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KR_vs_K.Location = new System.Drawing.Point(609, 95);
            this.btn_KR_vs_K.Name = "btn_KR_vs_K";
            this.btn_KR_vs_K.Size = new System.Drawing.Size(106, 30);
            this.btn_KR_vs_K.TabIndex = 3;
            this.btn_KR_vs_K.Text = "(K+R vs K)";
            this.btn_KR_vs_K.UseVisualStyleBackColor = true;
            this.btn_KR_vs_K.Click += new System.EventHandler(this.btn_KR_vs_K_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(626, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_KRR_vs_K
            // 
            this.btn_KRR_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KRR_vs_K.Location = new System.Drawing.Point(609, 131);
            this.btn_KRR_vs_K.Name = "btn_KRR_vs_K";
            this.btn_KRR_vs_K.Size = new System.Drawing.Size(106, 30);
            this.btn_KRR_vs_K.TabIndex = 5;
            this.btn_KRR_vs_K.Text = "K+R+R vs K";
            this.btn_KRR_vs_K.UseVisualStyleBackColor = true;
            this.btn_KRR_vs_K.Click += new System.EventHandler(this.btn_KRR_vs_K_Click);
            // 
            // btn_KN_vs_K
            // 
            this.btn_KN_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KN_vs_K.Location = new System.Drawing.Point(609, 167);
            this.btn_KN_vs_K.Name = "btn_KN_vs_K";
            this.btn_KN_vs_K.Size = new System.Drawing.Size(106, 30);
            this.btn_KN_vs_K.TabIndex = 6;
            this.btn_KN_vs_K.Text = "K+N vs K";
            this.btn_KN_vs_K.UseVisualStyleBackColor = true;
            this.btn_KN_vs_K.Click += new System.EventHandler(this.btn_KN_vs_K_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(626, 432);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFileA
            // 
            this.lblFileA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileA.Location = new System.Drawing.Point(39, 524);
            this.lblFileA.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileA.Name = "lblFileA";
            this.lblFileA.Size = new System.Drawing.Size(64, 24);
            this.lblFileA.TabIndex = 8;
            this.lblFileA.Text = "A";
            this.lblFileA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileB
            // 
            this.lblFileB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileB.Location = new System.Drawing.Point(103, 524);
            this.lblFileB.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileB.Name = "lblFileB";
            this.lblFileB.Size = new System.Drawing.Size(64, 24);
            this.lblFileB.TabIndex = 9;
            this.lblFileB.Text = "B";
            this.lblFileB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileC
            // 
            this.lblFileC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileC.Location = new System.Drawing.Point(167, 524);
            this.lblFileC.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileC.Name = "lblFileC";
            this.lblFileC.Size = new System.Drawing.Size(64, 24);
            this.lblFileC.TabIndex = 10;
            this.lblFileC.Text = "C";
            this.lblFileC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank8
            // 
            this.lblRank8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank8.Location = new System.Drawing.Point(12, 12);
            this.lblRank8.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank8.Name = "lblRank8";
            this.lblRank8.Size = new System.Drawing.Size(24, 64);
            this.lblRank8.TabIndex = 11;
            this.lblRank8.Text = "8";
            this.lblRank8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank7
            // 
            this.lblRank7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank7.Location = new System.Drawing.Point(12, 76);
            this.lblRank7.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank7.Name = "lblRank7";
            this.lblRank7.Size = new System.Drawing.Size(24, 64);
            this.lblRank7.TabIndex = 12;
            this.lblRank7.Text = "7";
            this.lblRank7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank6
            // 
            this.lblRank6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank6.Location = new System.Drawing.Point(12, 140);
            this.lblRank6.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank6.Name = "lblRank6";
            this.lblRank6.Size = new System.Drawing.Size(24, 64);
            this.lblRank6.TabIndex = 13;
            this.lblRank6.Text = "6";
            this.lblRank6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank5
            // 
            this.lblRank5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank5.Location = new System.Drawing.Point(12, 204);
            this.lblRank5.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank5.Name = "lblRank5";
            this.lblRank5.Size = new System.Drawing.Size(24, 64);
            this.lblRank5.TabIndex = 14;
            this.lblRank5.Text = "5";
            this.lblRank5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank1
            // 
            this.lblRank1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank1.Location = new System.Drawing.Point(12, 460);
            this.lblRank1.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank1.Name = "lblRank1";
            this.lblRank1.Size = new System.Drawing.Size(24, 64);
            this.lblRank1.TabIndex = 18;
            this.lblRank1.Text = "1";
            this.lblRank1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank2
            // 
            this.lblRank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank2.Location = new System.Drawing.Point(12, 396);
            this.lblRank2.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank2.Name = "lblRank2";
            this.lblRank2.Size = new System.Drawing.Size(24, 64);
            this.lblRank2.TabIndex = 17;
            this.lblRank2.Text = "2";
            this.lblRank2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank3
            // 
            this.lblRank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank3.Location = new System.Drawing.Point(12, 332);
            this.lblRank3.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank3.Name = "lblRank3";
            this.lblRank3.Size = new System.Drawing.Size(24, 64);
            this.lblRank3.TabIndex = 16;
            this.lblRank3.Text = "3";
            this.lblRank3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRank4
            // 
            this.lblRank4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRank4.Location = new System.Drawing.Point(12, 268);
            this.lblRank4.Margin = new System.Windows.Forms.Padding(0);
            this.lblRank4.Name = "lblRank4";
            this.lblRank4.Size = new System.Drawing.Size(24, 64);
            this.lblRank4.TabIndex = 15;
            this.lblRank4.Text = "4";
            this.lblRank4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileD
            // 
            this.lblFileD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileD.Location = new System.Drawing.Point(231, 524);
            this.lblFileD.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileD.Name = "lblFileD";
            this.lblFileD.Size = new System.Drawing.Size(64, 24);
            this.lblFileD.TabIndex = 19;
            this.lblFileD.Text = "D";
            this.lblFileD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileH
            // 
            this.lblFileH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileH.Location = new System.Drawing.Point(487, 524);
            this.lblFileH.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileH.Name = "lblFileH";
            this.lblFileH.Size = new System.Drawing.Size(64, 24);
            this.lblFileH.TabIndex = 23;
            this.lblFileH.Text = "H";
            this.lblFileH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileG
            // 
            this.lblFileG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileG.Location = new System.Drawing.Point(423, 524);
            this.lblFileG.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileG.Name = "lblFileG";
            this.lblFileG.Size = new System.Drawing.Size(64, 24);
            this.lblFileG.TabIndex = 22;
            this.lblFileG.Text = "G";
            this.lblFileG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileF
            // 
            this.lblFileF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileF.Location = new System.Drawing.Point(359, 524);
            this.lblFileF.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileF.Name = "lblFileF";
            this.lblFileF.Size = new System.Drawing.Size(64, 24);
            this.lblFileF.TabIndex = 21;
            this.lblFileF.Text = "E";
            this.lblFileF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFileE
            // 
            this.lblFileE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileE.Location = new System.Drawing.Point(295, 524);
            this.lblFileE.Margin = new System.Windows.Forms.Padding(0);
            this.lblFileE.Name = "lblFileE";
            this.lblFileE.Size = new System.Drawing.Size(64, 24);
            this.lblFileE.TabIndex = 20;
            this.lblFileE.Text = "F";
            this.lblFileE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(764, 557);
            this.Controls.Add(this.lblFileH);
            this.Controls.Add(this.lblFileG);
            this.Controls.Add(this.lblFileF);
            this.Controls.Add(this.lblFileE);
            this.Controls.Add(this.lblFileD);
            this.Controls.Add(this.lblRank1);
            this.Controls.Add(this.lblRank2);
            this.Controls.Add(this.lblRank3);
            this.Controls.Add(this.lblRank4);
            this.Controls.Add(this.lblRank5);
            this.Controls.Add(this.lblRank6);
            this.Controls.Add(this.lblRank7);
            this.Controls.Add(this.lblRank8);
            this.Controls.Add(this.lblFileC);
            this.Controls.Add(this.lblFileB);
            this.Controls.Add(this.lblFileA);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn_KN_vs_K);
            this.Controls.Add(this.btn_KRR_vs_K);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_KR_vs_K);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_KQ_vs_K);
            this.Controls.Add(this.board);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 596);
            this.MinimumSize = new System.Drawing.Size(160, 160);
            this.Name = "MainForm";
            this.Text = "Endgame Checkmate Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button btn_KQ_vs_K;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_KR_vs_K;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_KRR_vs_K;
        private System.Windows.Forms.Button btn_KN_vs_K;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFileA;
        private System.Windows.Forms.Label lblFileB;
        private System.Windows.Forms.Label lblFileC;
        private System.Windows.Forms.Label lblRank8;
        private System.Windows.Forms.Label lblRank7;
        private System.Windows.Forms.Label lblRank6;
        private System.Windows.Forms.Label lblRank5;
        private System.Windows.Forms.Label lblRank1;
        private System.Windows.Forms.Label lblRank2;
        private System.Windows.Forms.Label lblRank3;
        private System.Windows.Forms.Label lblRank4;
        private System.Windows.Forms.Label lblFileD;
        private System.Windows.Forms.Label lblFileH;
        private System.Windows.Forms.Label lblFileG;
        private System.Windows.Forms.Label lblFileF;
        private System.Windows.Forms.Label lblFileE;
    }
}

