namespace FlyingBallGame
{
    partial class Form_FlyingBall
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
            this.label_Left = new System.Windows.Forms.Label();
            this.label_Top = new System.Windows.Forms.Label();
            this.label_Life = new System.Windows.Forms.Label();
            this.button_ControlTool = new System.Windows.Forms.Button();
            this.button_Ball = new System.Windows.Forms.Button();
            this.label_Right = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Left
            // 
            this.label_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Left.Location = new System.Drawing.Point(12, 9);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(24, 381);
            this.label_Left.TabIndex = 0;
            // 
            // label_Top
            // 
            this.label_Top.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_Top.Location = new System.Drawing.Point(12, 9);
            this.label_Top.Name = "label_Top";
            this.label_Top.Size = new System.Drawing.Size(566, 23);
            this.label_Top.TabIndex = 1;
            // 
            // label_Life
            // 
            this.label_Life.Location = new System.Drawing.Point(82, 412);
            this.label_Life.Name = "label_Life";
            this.label_Life.Size = new System.Drawing.Size(28, 23);
            this.label_Life.TabIndex = 2;
            this.label_Life.Text = "3";
            // 
            // button_ControlTool
            // 
            this.button_ControlTool.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_ControlTool.Location = new System.Drawing.Point(249, 367);
            this.button_ControlTool.Name = "button_ControlTool";
            this.button_ControlTool.Size = new System.Drawing.Size(75, 23);
            this.button_ControlTool.TabIndex = 4;
            this.button_ControlTool.UseVisualStyleBackColor = false;
            // 
            // button_Ball
            // 
            this.button_Ball.BackColor = System.Drawing.Color.Maroon;
            this.button_Ball.Location = new System.Drawing.Point(275, 200);
            this.button_Ball.Name = "button_Ball";
            this.button_Ball.Size = new System.Drawing.Size(20, 20);
            this.button_Ball.TabIndex = 5;
            this.button_Ball.UseVisualStyleBackColor = false;
            // 
            // label_Right
            // 
            this.label_Right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Right.Location = new System.Drawing.Point(554, 9);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(24, 381);
            this.label_Right.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(15, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Life left:";
            // 
            // Form_FlyingBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Ball);
            this.Controls.Add(this.button_ControlTool);
            this.Controls.Add(this.label_Life);
            this.Controls.Add(this.label_Top);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Left);
            this.Name = "Form_FlyingBall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_FlyingBall_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_FlyingBall_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Left;
        private System.Windows.Forms.Label label_Top;
        private System.Windows.Forms.Label label_Life;
        private System.Windows.Forms.Button button_ControlTool;
        private System.Windows.Forms.Button button_Ball;
        private System.Windows.Forms.Label label_Right;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

