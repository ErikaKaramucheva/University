
namespace Hangman
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
            this.PImage = new System.Windows.Forms.PictureBox();
            this.bStart = new System.Windows.Forms.Button();
            this.TBWord = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bYA = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bQ = new System.Windows.Forms.Button();
            this.bAA = new System.Windows.Forms.Button();
            this.bSHT = new System.Windows.Forms.Button();
            this.bSH = new System.Windows.Forms.Button();
            this.bCH = new System.Windows.Forms.Button();
            this.bTS = new System.Windows.Forms.Button();
            this.bH = new System.Windows.Forms.Button();
            this.bF = new System.Windows.Forms.Button();
            this.bU = new System.Windows.Forms.Button();
            this.bT = new System.Windows.Forms.Button();
            this.bS = new System.Windows.Forms.Button();
            this.bR = new System.Windows.Forms.Button();
            this.bP = new System.Windows.Forms.Button();
            this.bO = new System.Windows.Forms.Button();
            this.bN = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.bL = new System.Windows.Forms.Button();
            this.bK = new System.Windows.Forms.Button();
            this.bIi = new System.Windows.Forms.Button();
            this.bI = new System.Windows.Forms.Button();
            this.bZ = new System.Windows.Forms.Button();
            this.bJ = new System.Windows.Forms.Button();
            this.bE = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bG = new System.Windows.Forms.Button();
            this.bV = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PImage
            // 
            this.PImage.Location = new System.Drawing.Point(422, 12);
            this.PImage.Name = "PImage";
            this.PImage.Size = new System.Drawing.Size(365, 426);
            this.PImage.TabIndex = 0;
            this.PImage.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(315, 404);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(91, 34);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Старт";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bStart_MouseClick);
            // 
            // TBWord
            // 
            this.TBWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TBWord.Location = new System.Drawing.Point(107, 86);
            this.TBWord.Name = "TBWord";
            this.TBWord.Size = new System.Drawing.Size(257, 30);
            this.TBWord.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.bYA, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.bC, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.bQ, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.bAA, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.bSHT, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.bSH, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bCH, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.bTS, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.bH, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.bF, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bU, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.bT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bS, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.bR, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.bP, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bO, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bM, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bL, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.bK, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.bIi, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bI, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bZ, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bJ, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bE, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.bD, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.bG, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bV, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bA, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 210);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 188);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // bYA
            // 
            this.bYA.Location = new System.Drawing.Point(338, 151);
            this.bYA.Name = "bYA";
            this.bYA.Size = new System.Drawing.Size(66, 34);
            this.bYA.TabIndex = 29;
            this.bYA.Text = "Я";
            this.bYA.UseVisualStyleBackColor = true;
            this.bYA.Click += new System.EventHandler(this.bYA_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(271, 151);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(61, 34);
            this.bC.TabIndex = 28;
            this.bC.Text = "Ю";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bQ
            // 
            this.bQ.Location = new System.Drawing.Point(204, 151);
            this.bQ.Name = "bQ";
            this.bQ.Size = new System.Drawing.Size(61, 34);
            this.bQ.TabIndex = 27;
            this.bQ.Text = "Ь";
            this.bQ.UseVisualStyleBackColor = true;
            this.bQ.Click += new System.EventHandler(this.bQ_Click);
            // 
            // bAA
            // 
            this.bAA.Location = new System.Drawing.Point(137, 151);
            this.bAA.Name = "bAA";
            this.bAA.Size = new System.Drawing.Size(61, 34);
            this.bAA.TabIndex = 26;
            this.bAA.Text = "Ъ";
            this.bAA.UseVisualStyleBackColor = true;
            this.bAA.Click += new System.EventHandler(this.bAA_Click);
            // 
            // bSHT
            // 
            this.bSHT.Location = new System.Drawing.Point(70, 151);
            this.bSHT.Name = "bSHT";
            this.bSHT.Size = new System.Drawing.Size(61, 34);
            this.bSHT.TabIndex = 25;
            this.bSHT.Text = "Щ";
            this.bSHT.UseVisualStyleBackColor = true;
            this.bSHT.Click += new System.EventHandler(this.bSHT_Click);
            // 
            // bSH
            // 
            this.bSH.Location = new System.Drawing.Point(3, 151);
            this.bSH.Name = "bSH";
            this.bSH.Size = new System.Drawing.Size(61, 34);
            this.bSH.TabIndex = 24;
            this.bSH.Text = "Ш";
            this.bSH.UseVisualStyleBackColor = true;
            this.bSH.Click += new System.EventHandler(this.bSH_Click);
            // 
            // bCH
            // 
            this.bCH.Location = new System.Drawing.Point(338, 114);
            this.bCH.Name = "bCH";
            this.bCH.Size = new System.Drawing.Size(66, 31);
            this.bCH.TabIndex = 23;
            this.bCH.Text = "Ч";
            this.bCH.UseVisualStyleBackColor = true;
            this.bCH.Click += new System.EventHandler(this.bCH_Click);
            // 
            // bTS
            // 
            this.bTS.Location = new System.Drawing.Point(271, 114);
            this.bTS.Name = "bTS";
            this.bTS.Size = new System.Drawing.Size(61, 31);
            this.bTS.TabIndex = 22;
            this.bTS.Text = "Ц";
            this.bTS.UseVisualStyleBackColor = true;
            this.bTS.Click += new System.EventHandler(this.bTS_Click);
            // 
            // bH
            // 
            this.bH.Location = new System.Drawing.Point(204, 114);
            this.bH.Name = "bH";
            this.bH.Size = new System.Drawing.Size(61, 31);
            this.bH.TabIndex = 21;
            this.bH.Text = "Х";
            this.bH.UseVisualStyleBackColor = true;
            this.bH.Click += new System.EventHandler(this.bH_Click);
            // 
            // bF
            // 
            this.bF.Location = new System.Drawing.Point(137, 114);
            this.bF.Name = "bF";
            this.bF.Size = new System.Drawing.Size(61, 31);
            this.bF.TabIndex = 20;
            this.bF.Text = "Ф";
            this.bF.UseVisualStyleBackColor = true;
            this.bF.Click += new System.EventHandler(this.bF_Click);
            // 
            // bU
            // 
            this.bU.Location = new System.Drawing.Point(70, 114);
            this.bU.Name = "bU";
            this.bU.Size = new System.Drawing.Size(61, 31);
            this.bU.TabIndex = 19;
            this.bU.Text = "У";
            this.bU.UseVisualStyleBackColor = true;
            this.bU.Click += new System.EventHandler(this.bU_Click);
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(3, 114);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(61, 31);
            this.bT.TabIndex = 18;
            this.bT.Text = "Т";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            // 
            // bS
            // 
            this.bS.Location = new System.Drawing.Point(338, 77);
            this.bS.Name = "bS";
            this.bS.Size = new System.Drawing.Size(66, 31);
            this.bS.TabIndex = 17;
            this.bS.Text = "С";
            this.bS.UseVisualStyleBackColor = true;
            this.bS.Click += new System.EventHandler(this.bS_Click);
            // 
            // bR
            // 
            this.bR.Location = new System.Drawing.Point(271, 77);
            this.bR.Name = "bR";
            this.bR.Size = new System.Drawing.Size(61, 31);
            this.bR.TabIndex = 16;
            this.bR.Text = "Р";
            this.bR.UseVisualStyleBackColor = true;
            this.bR.Click += new System.EventHandler(this.bR_Click);
            // 
            // bP
            // 
            this.bP.Location = new System.Drawing.Point(204, 77);
            this.bP.Name = "bP";
            this.bP.Size = new System.Drawing.Size(61, 31);
            this.bP.TabIndex = 15;
            this.bP.Text = "П";
            this.bP.UseVisualStyleBackColor = true;
            this.bP.Click += new System.EventHandler(this.bP_Click);
            // 
            // bO
            // 
            this.bO.Location = new System.Drawing.Point(137, 77);
            this.bO.Name = "bO";
            this.bO.Size = new System.Drawing.Size(61, 31);
            this.bO.TabIndex = 14;
            this.bO.Text = "О";
            this.bO.UseVisualStyleBackColor = true;
            this.bO.Click += new System.EventHandler(this.bO_Click);
            // 
            // bN
            // 
            this.bN.Location = new System.Drawing.Point(70, 77);
            this.bN.Name = "bN";
            this.bN.Size = new System.Drawing.Size(61, 31);
            this.bN.TabIndex = 13;
            this.bN.Text = "Н";
            this.bN.UseVisualStyleBackColor = true;
            this.bN.Click += new System.EventHandler(this.bN_Click);
            // 
            // bM
            // 
            this.bM.Location = new System.Drawing.Point(3, 77);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(61, 31);
            this.bM.TabIndex = 12;
            this.bM.Text = "М";
            this.bM.UseVisualStyleBackColor = true;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // bL
            // 
            this.bL.Location = new System.Drawing.Point(338, 40);
            this.bL.Name = "bL";
            this.bL.Size = new System.Drawing.Size(66, 31);
            this.bL.TabIndex = 11;
            this.bL.Text = "Л";
            this.bL.UseVisualStyleBackColor = true;
            this.bL.Click += new System.EventHandler(this.bL_Click);
            // 
            // bK
            // 
            this.bK.Location = new System.Drawing.Point(271, 40);
            this.bK.Name = "bK";
            this.bK.Size = new System.Drawing.Size(61, 31);
            this.bK.TabIndex = 10;
            this.bK.Text = "К";
            this.bK.UseVisualStyleBackColor = true;
            this.bK.Click += new System.EventHandler(this.bK_Click);
            // 
            // bIi
            // 
            this.bIi.Location = new System.Drawing.Point(204, 40);
            this.bIi.Name = "bIi";
            this.bIi.Size = new System.Drawing.Size(61, 31);
            this.bIi.TabIndex = 9;
            this.bIi.Text = "Й";
            this.bIi.UseVisualStyleBackColor = true;
            this.bIi.Click += new System.EventHandler(this.bIi_Click);
            // 
            // bI
            // 
            this.bI.Location = new System.Drawing.Point(137, 40);
            this.bI.Name = "bI";
            this.bI.Size = new System.Drawing.Size(61, 31);
            this.bI.TabIndex = 8;
            this.bI.Text = "И";
            this.bI.UseVisualStyleBackColor = true;
            this.bI.Click += new System.EventHandler(this.bI_Click);
            // 
            // bZ
            // 
            this.bZ.Location = new System.Drawing.Point(70, 40);
            this.bZ.Name = "bZ";
            this.bZ.Size = new System.Drawing.Size(61, 31);
            this.bZ.TabIndex = 7;
            this.bZ.Text = "З";
            this.bZ.UseVisualStyleBackColor = true;
            this.bZ.Click += new System.EventHandler(this.bZ_Click);
            // 
            // bJ
            // 
            this.bJ.Location = new System.Drawing.Point(3, 40);
            this.bJ.Name = "bJ";
            this.bJ.Size = new System.Drawing.Size(61, 31);
            this.bJ.TabIndex = 6;
            this.bJ.Text = "Ж";
            this.bJ.UseVisualStyleBackColor = true;
            this.bJ.Click += new System.EventHandler(this.bJ_Click);
            // 
            // bE
            // 
            this.bE.Location = new System.Drawing.Point(338, 3);
            this.bE.Name = "bE";
            this.bE.Size = new System.Drawing.Size(66, 31);
            this.bE.TabIndex = 5;
            this.bE.Text = "Е";
            this.bE.UseVisualStyleBackColor = true;
            this.bE.Click += new System.EventHandler(this.bE_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(271, 3);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(61, 31);
            this.bD.TabIndex = 4;
            this.bD.Text = "Д";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bG
            // 
            this.bG.Location = new System.Drawing.Point(204, 3);
            this.bG.Name = "bG";
            this.bG.Size = new System.Drawing.Size(61, 31);
            this.bG.TabIndex = 3;
            this.bG.Text = "Г";
            this.bG.UseVisualStyleBackColor = true;
            this.bG.Click += new System.EventHandler(this.bG_Click);
            // 
            // bV
            // 
            this.bV.Location = new System.Drawing.Point(137, 3);
            this.bV.Name = "bV";
            this.bV.Size = new System.Drawing.Size(61, 31);
            this.bV.TabIndex = 2;
            this.bV.Text = "В";
            this.bV.UseVisualStyleBackColor = true;
            this.bV.Click += new System.EventHandler(this.bV_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(70, 3);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(61, 31);
            this.bB.TabIndex = 1;
            this.bB.Text = "Б";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // bA
            // 
            this.bA.Location = new System.Drawing.Point(3, 3);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(61, 31);
            this.bA.TabIndex = 0;
            this.bA.Text = "А";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Изберете буква";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Можете ли да познаете думата?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TBWord);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.PImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PImage;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox TBWord;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bYA;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bQ;
        private System.Windows.Forms.Button bAA;
        private System.Windows.Forms.Button bSHT;
        private System.Windows.Forms.Button bSH;
        private System.Windows.Forms.Button bCH;
        private System.Windows.Forms.Button bTS;
        private System.Windows.Forms.Button bH;
        private System.Windows.Forms.Button bF;
        private System.Windows.Forms.Button bU;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bS;
        private System.Windows.Forms.Button bR;
        private System.Windows.Forms.Button bP;
        private System.Windows.Forms.Button bO;
        private System.Windows.Forms.Button bN;
        private System.Windows.Forms.Button bM;
        private System.Windows.Forms.Button bL;
        private System.Windows.Forms.Button bK;
        private System.Windows.Forms.Button bIi;
        private System.Windows.Forms.Button bI;
        private System.Windows.Forms.Button bZ;
        private System.Windows.Forms.Button bJ;
        private System.Windows.Forms.Button bE;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bG;
        private System.Windows.Forms.Button bV;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bA;
    }
}

