
namespace LearningChallenge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblLost = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.Location = new System.Drawing.Point(57, 68);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(171, 148);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
            this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaper.Location = new System.Drawing.Point(308, 68);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(169, 148);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissor.BackgroundImage")));
            this.btnScissor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScissor.Location = new System.Drawing.Point(535, 68);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(168, 148);
            this.btnScissor.TabIndex = 2;
            this.btnScissor.Text = "Scissor";
            this.btnScissor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(308, 323);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.Location = new System.Drawing.Point(308, 286);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(154, 25);
            this.lblComputerChoice.TabIndex = 4;
            this.lblComputerChoice.Text = "Computer Choice:";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Location = new System.Drawing.Point(605, 276);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(53, 25);
            this.lblWon.TabIndex = 5;
            this.lblWon.Text = "Won:";
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.Location = new System.Drawing.Point(605, 313);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(49, 25);
            this.lblLost.TabIndex = 6;
            this.lblLost.Text = "Lost:";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(605, 350);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(57, 25);
            this.lblDraw.TabIndex = 7;
            this.lblDraw.Text = "Draw:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(605, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RockPaperScissor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComputerChoice;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblTotal;
    }
}

