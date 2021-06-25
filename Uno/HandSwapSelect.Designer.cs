namespace Uno
{
    partial class HandSwapSelect
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
            this.selectPlayerOne = new System.Windows.Forms.Button();
            this.selectPlayerTwo = new System.Windows.Forms.Button();
            this.selectPlayerThree = new System.Windows.Forms.Button();
            this.selectPlayerFour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectPlayerOne
            // 
            this.selectPlayerOne.BackColor = System.Drawing.Color.Red;
            this.selectPlayerOne.Enabled = false;
            this.selectPlayerOne.Location = new System.Drawing.Point(51, 97);
            this.selectPlayerOne.Name = "selectPlayerOne";
            this.selectPlayerOne.Size = new System.Drawing.Size(91, 107);
            this.selectPlayerOne.TabIndex = 0;
            this.selectPlayerOne.Text = "Player 1";
            this.selectPlayerOne.UseVisualStyleBackColor = false;
            this.selectPlayerOne.Visible = false;
            this.selectPlayerOne.Click += new System.EventHandler(this.selectPlayerOne_Click);
            // 
            // selectPlayerTwo
            // 
            this.selectPlayerTwo.BackColor = System.Drawing.Color.Chartreuse;
            this.selectPlayerTwo.Enabled = false;
            this.selectPlayerTwo.Location = new System.Drawing.Point(148, 97);
            this.selectPlayerTwo.Name = "selectPlayerTwo";
            this.selectPlayerTwo.Size = new System.Drawing.Size(91, 107);
            this.selectPlayerTwo.TabIndex = 1;
            this.selectPlayerTwo.Text = "Player 2";
            this.selectPlayerTwo.UseVisualStyleBackColor = false;
            this.selectPlayerTwo.Visible = false;
            this.selectPlayerTwo.Click += new System.EventHandler(this.selectPlayerTwo_Click);
            // 
            // selectPlayerThree
            // 
            this.selectPlayerThree.BackColor = System.Drawing.Color.Orchid;
            this.selectPlayerThree.Enabled = false;
            this.selectPlayerThree.Location = new System.Drawing.Point(245, 97);
            this.selectPlayerThree.Name = "selectPlayerThree";
            this.selectPlayerThree.Size = new System.Drawing.Size(91, 107);
            this.selectPlayerThree.TabIndex = 2;
            this.selectPlayerThree.Text = "Player 3";
            this.selectPlayerThree.UseVisualStyleBackColor = false;
            this.selectPlayerThree.Visible = false;
            this.selectPlayerThree.Click += new System.EventHandler(this.selectPlayerThree_Click);
            // 
            // selectPlayerFour
            // 
            this.selectPlayerFour.BackColor = System.Drawing.Color.Yellow;
            this.selectPlayerFour.Enabled = false;
            this.selectPlayerFour.Location = new System.Drawing.Point(342, 97);
            this.selectPlayerFour.Name = "selectPlayerFour";
            this.selectPlayerFour.Size = new System.Drawing.Size(91, 107);
            this.selectPlayerFour.TabIndex = 3;
            this.selectPlayerFour.Text = "Player 4";
            this.selectPlayerFour.UseVisualStyleBackColor = false;
            this.selectPlayerFour.Visible = false;
            this.selectPlayerFour.Click += new System.EventHandler(this.selectPlayerFour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Player To Swap With";
            // 
            // HandSwapSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPlayerFour);
            this.Controls.Add(this.selectPlayerThree);
            this.Controls.Add(this.selectPlayerTwo);
            this.Controls.Add(this.selectPlayerOne);
            this.Name = "HandSwapSelect";
            this.Text = "HandSwapSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectPlayerOne;
        private System.Windows.Forms.Button selectPlayerTwo;
        private System.Windows.Forms.Button selectPlayerThree;
        private System.Windows.Forms.Button selectPlayerFour;
        private System.Windows.Forms.Label label1;
    }
}