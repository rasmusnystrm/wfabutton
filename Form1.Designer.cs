
namespace WFAovningar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Change text";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl1.Location = new System.Drawing.Point(207, 224);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(71, 38);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "label1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Click";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbl2.Location = new System.Drawing.Point(340, 239);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 23);
            this.lbl2.TabIndex = 4;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "aaa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_MouseClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button5_MouseClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(55, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 36);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button6_MouseClick);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(585, 51);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(125, 43);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseClick);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(491, 113);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(125, 43);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseClick);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(672, 113);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(125, 43);
            this.btnRight.TabIndex = 10;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseClick);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(585, 177);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(125, 43);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(602, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 12;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label1;
    }
}

