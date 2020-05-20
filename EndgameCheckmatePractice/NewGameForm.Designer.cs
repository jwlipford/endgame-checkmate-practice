namespace EndgameCheckmatePractice
{
    partial class NewGameForm
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
            this.labelChoose = new System.Windows.Forms.Label();
            this.lblVersus = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbWK = new System.Windows.Forms.PictureBox();
            this.pbWQ = new System.Windows.Forms.PictureBox();
            this.lblP0 = new System.Windows.Forms.Label();
            this.nudQueen = new System.Windows.Forms.NumericUpDown();
            this.nudRook = new System.Windows.Forms.NumericUpDown();
            this.lblP1 = new System.Windows.Forms.Label();
            this.pbWR = new System.Windows.Forms.PictureBox();
            this.nudBishop = new System.Windows.Forms.NumericUpDown();
            this.lblP2 = new System.Windows.Forms.Label();
            this.pbWB = new System.Windows.Forms.PictureBox();
            this.nudKnight = new System.Windows.Forms.NumericUpDown();
            this.lblP3 = new System.Windows.Forms.Label();
            this.pbWN = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbBK = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNumPieces = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBK)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.ForeColor = System.Drawing.Color.White;
            this.labelChoose.Location = new System.Drawing.Point(165, 9);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(321, 20);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Choose your Pieces! (You can have up to 8.)";
            // 
            // lblVersus
            // 
            this.lblVersus.AutoSize = true;
            this.lblVersus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersus.Location = new System.Drawing.Point(498, 59);
            this.lblVersus.Name = "lblVersus";
            this.lblVersus.Size = new System.Drawing.Size(55, 20);
            this.lblVersus.TabIndex = 2;
            this.lblVersus.Text = "versus";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(386, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbWK
            // 
            this.pbWK.Image = global::EndgameCheckmatePractice.Properties.Resources.white_king;
            this.pbWK.Location = new System.Drawing.Point(36, 55);
            this.pbWK.Name = "pbWK";
            this.pbWK.Size = new System.Drawing.Size(32, 32);
            this.pbWK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWK.TabIndex = 0;
            this.pbWK.TabStop = false;
            // 
            // pbWQ
            // 
            this.pbWQ.Image = global::EndgameCheckmatePractice.Properties.Resources.white_queen;
            this.pbWQ.Location = new System.Drawing.Point(136, 55);
            this.pbWQ.Name = "pbWQ";
            this.pbWQ.Size = new System.Drawing.Size(32, 32);
            this.pbWQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWQ.TabIndex = 27;
            this.pbWQ.TabStop = false;
            // 
            // lblP0
            // 
            this.lblP0.AutoSize = true;
            this.lblP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP0.ForeColor = System.Drawing.Color.White;
            this.lblP0.Location = new System.Drawing.Point(74, 59);
            this.lblP0.Name = "lblP0";
            this.lblP0.Size = new System.Drawing.Size(18, 20);
            this.lblP0.TabIndex = 28;
            this.lblP0.Text = "+";
            // 
            // nudQueen
            // 
            this.nudQueen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudQueen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudQueen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQueen.ForeColor = System.Drawing.Color.White;
            this.nudQueen.Location = new System.Drawing.Point(98, 60);
            this.nudQueen.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudQueen.Name = "nudQueen";
            this.nudQueen.Size = new System.Drawing.Size(32, 22);
            this.nudQueen.TabIndex = 29;
            this.nudQueen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudQueen.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // nudRook
            // 
            this.nudRook.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudRook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudRook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRook.ForeColor = System.Drawing.Color.White;
            this.nudRook.Location = new System.Drawing.Point(198, 60);
            this.nudRook.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudRook.Name = "nudRook";
            this.nudRook.Size = new System.Drawing.Size(32, 22);
            this.nudRook.TabIndex = 32;
            this.nudRook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRook.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.Color.White;
            this.lblP1.Location = new System.Drawing.Point(174, 59);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(18, 20);
            this.lblP1.TabIndex = 31;
            this.lblP1.Text = "+";
            // 
            // pbWR
            // 
            this.pbWR.Image = global::EndgameCheckmatePractice.Properties.Resources.white_rook;
            this.pbWR.Location = new System.Drawing.Point(236, 55);
            this.pbWR.Name = "pbWR";
            this.pbWR.Size = new System.Drawing.Size(32, 32);
            this.pbWR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWR.TabIndex = 30;
            this.pbWR.TabStop = false;
            // 
            // nudBishop
            // 
            this.nudBishop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudBishop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudBishop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBishop.ForeColor = System.Drawing.Color.White;
            this.nudBishop.Location = new System.Drawing.Point(298, 60);
            this.nudBishop.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudBishop.Name = "nudBishop";
            this.nudBishop.Size = new System.Drawing.Size(32, 22);
            this.nudBishop.TabIndex = 35;
            this.nudBishop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBishop.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP2.ForeColor = System.Drawing.Color.White;
            this.lblP2.Location = new System.Drawing.Point(274, 59);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(18, 20);
            this.lblP2.TabIndex = 34;
            this.lblP2.Text = "+";
            // 
            // pbWB
            // 
            this.pbWB.Image = global::EndgameCheckmatePractice.Properties.Resources.white_bishop;
            this.pbWB.Location = new System.Drawing.Point(336, 55);
            this.pbWB.Name = "pbWB";
            this.pbWB.Size = new System.Drawing.Size(32, 32);
            this.pbWB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWB.TabIndex = 33;
            this.pbWB.TabStop = false;
            // 
            // nudKnight
            // 
            this.nudKnight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nudKnight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKnight.ForeColor = System.Drawing.Color.White;
            this.nudKnight.Location = new System.Drawing.Point(398, 60);
            this.nudKnight.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudKnight.Name = "nudKnight";
            this.nudKnight.Size = new System.Drawing.Size(32, 22);
            this.nudKnight.TabIndex = 38;
            this.nudKnight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKnight.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP3.ForeColor = System.Drawing.Color.White;
            this.lblP3.Location = new System.Drawing.Point(374, 59);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(18, 20);
            this.lblP3.TabIndex = 37;
            this.lblP3.Text = "+";
            // 
            // pbWN
            // 
            this.pbWN.Image = global::EndgameCheckmatePractice.Properties.Resources.white_knight;
            this.pbWN.Location = new System.Drawing.Point(436, 55);
            this.pbWN.Name = "pbWN";
            this.pbWN.Size = new System.Drawing.Size(32, 32);
            this.pbWN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWN.TabIndex = 36;
            this.pbWN.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(18, 20);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "1";
            // 
            // pbBK
            // 
            this.pbBK.Image = global::EndgameCheckmatePractice.Properties.Resources.black_king;
            this.pbBK.Location = new System.Drawing.Point(580, 55);
            this.pbBK.Name = "pbBK";
            this.pbBK.Size = new System.Drawing.Size(32, 32);
            this.pbBK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBK.TabIndex = 40;
            this.pbBK.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(280, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNumPieces
            // 
            this.lblNumPieces.AutoSize = true;
            this.lblNumPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPieces.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblNumPieces.Location = new System.Drawing.Point(92, 124);
            this.lblNumPieces.Name = "lblNumPieces";
            this.lblNumPieces.Size = new System.Drawing.Size(150, 20);
            this.lblNumPieces.TabIndex = 42;
            this.lblNumPieces.Text = "Number of pieces: 1";
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(630, 161);
            this.Controls.Add(this.lblNumPieces);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbBK);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.nudKnight);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.pbWN);
            this.Controls.Add(this.nudBishop);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.pbWB);
            this.Controls.Add(this.nudRook);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.pbWR);
            this.Controls.Add(this.nudQueen);
            this.Controls.Add(this.lblP0);
            this.Controls.Add(this.pbWQ);
            this.Controls.Add(this.pbWK);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblVersus);
            this.Controls.Add(this.labelChoose);
            this.MaximizeBox = false;
            this.Name = "NewGameForm";
            this.Text = "New Game";
            this.Load += new System.EventHandler(this.NewGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label lblVersus;
        private System.Windows.Forms.PictureBox pbWK;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pbWQ;
        private System.Windows.Forms.Label lblP0;
        private System.Windows.Forms.NumericUpDown nudQueen;
        private System.Windows.Forms.NumericUpDown nudRook;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.PictureBox pbWR;
        private System.Windows.Forms.NumericUpDown nudBishop;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.PictureBox pbWB;
        private System.Windows.Forms.NumericUpDown nudKnight;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.PictureBox pbWN;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbBK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNumPieces;
    }
}