namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(258, 50);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnZero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnZero.Location = new System.Drawing.Point(12, 351);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(60, 60);
            this.btnZero.TabIndex = 1;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDot.Location = new System.Drawing.Point(78, 351);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 60);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEquals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquals.Location = new System.Drawing.Point(144, 351);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 60);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDivision.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDivision.Location = new System.Drawing.Point(210, 351);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(60, 60);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOne.Location = new System.Drawing.Point(12, 285);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(60, 60);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTwo.Location = new System.Drawing.Point(78, 285);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(60, 60);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnThree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThree.Location = new System.Drawing.Point(144, 285);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(60, 60);
            this.btnThree.TabIndex = 1;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMultiplication.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiplication.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMultiplication.Location = new System.Drawing.Point(210, 285);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(60, 60);
            this.btnMultiplication.TabIndex = 1;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFour.Location = new System.Drawing.Point(12, 219);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(60, 60);
            this.btnFour.TabIndex = 1;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeven.Location = new System.Drawing.Point(12, 153);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(60, 60);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBS.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnBS.FlatAppearance.BorderSize = 0;
            this.btnBS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnBS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBS.Location = new System.Drawing.Point(12, 87);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(60, 60);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "BS";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFive.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFive.Location = new System.Drawing.Point(78, 219);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(60, 60);
            this.btnFive.TabIndex = 1;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEight.Location = new System.Drawing.Point(78, 153);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(60, 60);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCE.Location = new System.Drawing.Point(78, 87);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(60, 60);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSix.Location = new System.Drawing.Point(144, 219);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(60, 60);
            this.btnSix.TabIndex = 1;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNine.Location = new System.Drawing.Point(144, 153);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(60, 60);
            this.btnNine.TabIndex = 1;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.NumericValue);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnC.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnC.Location = new System.Drawing.Point(144, 87);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 60);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinus.Location = new System.Drawing.Point(210, 219);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlus.Location = new System.Drawing.Point(210, 153);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.OperationalFunction);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPM.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPM.Location = new System.Drawing.Point(210, 87);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(60, 60);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "+/-";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 423);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPM;
    }
}

