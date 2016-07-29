namespace LiveTest
{
    partial class LiveMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.numericUpDownMatrix = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeginRatio = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.viewForm1 = new LiveTest.ViewForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRatio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrix";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(564, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(39, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(609, 6);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Round";
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(223, 6);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(37, 19);
            this.txtRound.TabIndex = 7;
            this.txtRound.Text = "100";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.viewForm1);
            this.panel1.Location = new System.Drawing.Point(14, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 369);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "BeginRatio";
            // 
            // timerSpeed
            // 
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(382, 6);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(176, 45);
            this.trackBar.TabIndex = 13;
            this.trackBar.Value = 1;
            // 
            // numericUpDownMatrix
            // 
            this.numericUpDownMatrix.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMatrix.Location = new System.Drawing.Point(55, 6);
            this.numericUpDownMatrix.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownMatrix.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMatrix.Name = "numericUpDownMatrix";
            this.numericUpDownMatrix.Size = new System.Drawing.Size(37, 19);
            this.numericUpDownMatrix.TabIndex = 14;
            this.numericUpDownMatrix.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownBeginRatio
            // 
            this.numericUpDownBeginRatio.Location = new System.Drawing.Point(339, 6);
            this.numericUpDownBeginRatio.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownBeginRatio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBeginRatio.Name = "numericUpDownBeginRatio";
            this.numericUpDownBeginRatio.Size = new System.Drawing.Size(37, 19);
            this.numericUpDownBeginRatio.TabIndex = 16;
            this.numericUpDownBeginRatio.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(98, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(44, 23);
            this.btnColor.TabIndex = 17;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // viewForm1
            // 
            this.viewForm1.BackColor = System.Drawing.Color.White;
            this.viewForm1.column = 0;
            this.viewForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewForm1.lineColor = System.Drawing.Color.Empty;
            this.viewForm1.Location = new System.Drawing.Point(0, 0);
            this.viewForm1.lstCreature = null;
            this.viewForm1.Name = "viewForm1";
            this.viewForm1.row = 0;
            this.viewForm1.Size = new System.Drawing.Size(633, 369);
            this.viewForm1.TabIndex = 0;
            // 
            // LiveMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 434);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.numericUpDownBeginRatio);
            this.Controls.Add(this.numericUpDownMatrix);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Name = "LiveMain";
            this.Text = "Live";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginRatio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Panel panel1;
        private ViewForm viewForm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerSpeed;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownBeginRatio;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
    }
}

