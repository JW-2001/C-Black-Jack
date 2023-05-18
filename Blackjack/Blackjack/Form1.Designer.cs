namespace Blackjack
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDealer = new System.Windows.Forms.TextBox();
            this.txtYourHand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayerCount = new System.Windows.Forms.Label();
            this.lblDealerCount = new System.Windows.Forms.Label();
            this.LblWait = new System.Windows.Forms.Label();
            this.txttest = new System.Windows.Forms.TextBox();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnHold = new System.Windows.Forms.Button();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblDealerOver = new System.Windows.Forms.Label();
            this.lblTie = new System.Windows.Forms.Label();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.lblDealerWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer\'s cards";
            // 
            // txtDealer
            // 
            this.txtDealer.Location = new System.Drawing.Point(321, 62);
            this.txtDealer.Name = "txtDealer";
            this.txtDealer.ReadOnly = true;
            this.txtDealer.Size = new System.Drawing.Size(120, 20);
            this.txtDealer.TabIndex = 1;
            this.txtDealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYourHand
            // 
            this.txtYourHand.Location = new System.Drawing.Point(321, 190);
            this.txtYourHand.Name = "txtYourHand";
            this.txtYourHand.ReadOnly = true;
            this.txtYourHand.Size = new System.Drawing.Size(120, 20);
            this.txtYourHand.TabIndex = 2;
            this.txtYourHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your hand";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(282, 237);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(92, 30);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw card";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(321, 273);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 33);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayerCount
            // 
            this.lblPlayerCount.AutoSize = true;
            this.lblPlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCount.Location = new System.Drawing.Point(447, 188);
            this.lblPlayerCount.Name = "lblPlayerCount";
            this.lblPlayerCount.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerCount.TabIndex = 7;
            // 
            // lblDealerCount
            // 
            this.lblDealerCount.AutoSize = true;
            this.lblDealerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCount.Location = new System.Drawing.Point(447, 62);
            this.lblDealerCount.Name = "lblDealerCount";
            this.lblDealerCount.Size = new System.Drawing.Size(0, 20);
            this.lblDealerCount.TabIndex = 8;
            // 
            // LblWait
            // 
            this.LblWait.AutoSize = true;
            this.LblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWait.Location = new System.Drawing.Point(218, 122);
            this.LblWait.Name = "LblWait";
            this.LblWait.Size = new System.Drawing.Size(0, 20);
            this.LblWait.TabIndex = 9;
            this.LblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttest
            // 
            this.txttest.Location = new System.Drawing.Point(612, 450);
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(120, 20);
            this.txttest.TabIndex = 10;
            this.txttest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.Location = new System.Drawing.Point(330, 122);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(0, 20);
            this.lblLose.TabIndex = 11;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(278, 122);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(199, 20);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "Please press \"Start Game\"";
            // 
            // btnHold
            // 
            this.btnHold.Location = new System.Drawing.Point(385, 237);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(92, 30);
            this.btnHold.TabIndex = 13;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.Location = new System.Drawing.Point(284, 122);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(0, 20);
            this.lblYouWin.TabIndex = 14;
            // 
            // lblDealerOver
            // 
            this.lblDealerOver.AutoSize = true;
            this.lblDealerOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerOver.Location = new System.Drawing.Point(278, 122);
            this.lblDealerOver.Name = "lblDealerOver";
            this.lblDealerOver.Size = new System.Drawing.Size(0, 20);
            this.lblDealerOver.TabIndex = 15;
            // 
            // lblTie
            // 
            this.lblTie.AutoSize = true;
            this.lblTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTie.Location = new System.Drawing.Point(218, 122);
            this.lblTie.Name = "lblTie";
            this.lblTie.Size = new System.Drawing.Size(0, 20);
            this.lblTie.TabIndex = 16;
            // 
            // txttest2
            // 
            this.txttest2.Location = new System.Drawing.Point(612, 476);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(120, 20);
            this.txttest2.TabIndex = 17;
            this.txttest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDealerWin
            // 
            this.lblDealerWin.AutoSize = true;
            this.lblDealerWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerWin.Location = new System.Drawing.Point(310, 122);
            this.lblDealerWin.Name = "lblDealerWin";
            this.lblDealerWin.Size = new System.Drawing.Size(0, 20);
            this.lblDealerWin.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 518);
            this.Controls.Add(this.lblDealerWin);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.lblTie);
            this.Controls.Add(this.lblDealerOver);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.txttest);
            this.Controls.Add(this.LblWait);
            this.Controls.Add(this.lblDealerCount);
            this.Controls.Add(this.lblPlayerCount);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYourHand);
            this.Controls.Add(this.txtDealer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDealer;
        private System.Windows.Forms.TextBox txtYourHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerCount;
        private System.Windows.Forms.Label lblDealerCount;
        private System.Windows.Forms.Label LblWait;
        private System.Windows.Forms.TextBox txttest;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Label lblDealerOver;
        private System.Windows.Forms.Label lblTie;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.Label lblDealerWin;
    }
}

