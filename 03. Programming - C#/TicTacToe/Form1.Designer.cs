
namespace TicTacToe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bTwo = new System.Windows.Forms.Button();
            this.bOne = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.bNine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bEight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bSeven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.bFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.bFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bThree, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bTwo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bStart, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bTwo
            // 
            this.bTwo.Location = new System.Drawing.Point(269, 3);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(260, 106);
            this.bTwo.TabIndex = 0;
            this.bTwo.UseVisualStyleBackColor = true;
            this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
            // 
            // bOne
            // 
            this.bOne.Location = new System.Drawing.Point(3, 3);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(260, 106);
            this.bOne.TabIndex = 1;
            this.bOne.UseVisualStyleBackColor = true;
            this.bOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bOne_MouseClick);
            // 
            // bThree
            // 
            this.bThree.Location = new System.Drawing.Point(535, 3);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(262, 106);
            this.bThree.TabIndex = 2;
            this.bThree.UseVisualStyleBackColor = true;
            this.bThree.Click += new System.EventHandler(this.bThree_Click);
            // 
            // bFour
            // 
            this.bFour.Location = new System.Drawing.Point(3, 115);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(260, 106);
            this.bFour.TabIndex = 3;
            this.bFour.UseVisualStyleBackColor = true;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bFive
            // 
            this.bFive.Location = new System.Drawing.Point(269, 115);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(260, 106);
            this.bFive.TabIndex = 4;
            this.bFive.UseVisualStyleBackColor = true;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bSix
            // 
            this.bSix.Location = new System.Drawing.Point(535, 115);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(262, 106);
            this.bSix.TabIndex = 5;
            this.bSix.UseVisualStyleBackColor = true;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bSeven
            // 
            this.bSeven.Location = new System.Drawing.Point(3, 227);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(260, 106);
            this.bSeven.TabIndex = 6;
            this.bSeven.UseVisualStyleBackColor = true;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // bEight
            // 
            this.bEight.Location = new System.Drawing.Point(269, 227);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(260, 106);
            this.bEight.TabIndex = 7;
            this.bEight.UseVisualStyleBackColor = true;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bNine
            // 
            this.bNine.Location = new System.Drawing.Point(535, 227);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(262, 106);
            this.bNine.TabIndex = 8;
            this.bNine.UseVisualStyleBackColor = true;
            this.bNine.Click += new System.EventHandler(this.bNine_Click);
            // 
            // bStart
            // 
            this.bStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bStart.Location = new System.Drawing.Point(339, 372);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(119, 42);
            this.bStart.TabIndex = 9;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bStart;
    }
}

