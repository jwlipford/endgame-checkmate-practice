namespace EndgameCheckmatePractice
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(512, 512);
            this.board.TabIndex = 0;
            // 
            // btn_KQ_vs_K
            // 
            this.btn_KQ_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KQ_vs_K.Location = new System.Drawing.Point(588, 66);
            this.btn_KQ_vs_K.Name = "btn_KQ_vs_K";
            this.btn_KQ_vs_K.Size = new System.Drawing.Size(90, 30);
            this.btn_KQ_vs_K.TabIndex = 1;
            this.btn_KQ_vs_K.Text = "K+Q vs K";
            this.btn_KQ_vs_K.UseVisualStyleBackColor = true;
            this.btn_KQ_vs_K.Click += new System.EventHandler(this.btn_KQ_vs_K_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(588, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btn_KR_vs_K
            // 
            this.btn_KR_vs_K.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KR_vs_K.Location = new System.Drawing.Point(588, 102);
            this.btn_KR_vs_K.Name = "btn_KR_vs_K";
            this.btn_KR_vs_K.Size = new System.Drawing.Size(90, 30);
            this.btn_KR_vs_K.TabIndex = 3;
            this.btn_KR_vs_K.Text = "K+R vs K";
            this.btn_KR_vs_K.UseVisualStyleBackColor = true;
            this.btn_KR_vs_K.Click += new System.EventHandler(this.btn_KR_vs_K_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(740, 535);
            this.Controls.Add(this.btn_KR_vs_K);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btn_KQ_vs_K);
            this.Controls.Add(this.board);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 574);
            this.MinimumSize = new System.Drawing.Size(96, 96);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Button btn_KQ_vs_K;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btn_KR_vs_K;
    }
}

