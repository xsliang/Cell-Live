namespace LiveTest
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
            this.components = new System.ComponentModel.Container();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBeginRatio = new System.Windows.Forms.TextBox();
            this.viewForm1 = new LiveTest.ViewForm();
            this.timerSpeed = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(45, 6);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(37, 19);
            this.txtRow.TabIndex = 0;
            this.txtRow.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cloumn";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(137, 6);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(37, 19);
            this.txtColumn.TabIndex = 2;
            this.txtColumn.Text = "30";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(491, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(572, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
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
            this.txtRound.Location = new System.Drawing.Point(229, 6);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(37, 19);
            this.txtRound.TabIndex = 7;
            this.txtRound.Text = "100";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            "Fast",
            "Middle",
            "Slow"});
            this.cmbSpeed.Location = new System.Drawing.Point(407, 5);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(78, 20);
            this.cmbSpeed.TabIndex = 9;
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.viewForm1);
            this.panel1.Location = new System.Drawing.Point(14, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 393);
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
            // txtBeginRatio
            // 
            this.txtBeginRatio.Location = new System.Drawing.Point(339, 6);
            this.txtBeginRatio.Name = "txtBeginRatio";
            this.txtBeginRatio.Size = new System.Drawing.Size(37, 19);
            this.txtBeginRatio.TabIndex = 11;
            this.txtBeginRatio.Text = "50";
            // 
            // viewForm1
            // 
            this.viewForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewForm1.Location = new System.Drawing.Point(6, 6);
            this.viewForm1.Name = "viewForm1";
            this.viewForm1.Size = new System.Drawing.Size(621, 379);
            this.viewForm1.TabIndex = 0;
            // 
            // timerSpeed
            // 
            this.timerSpeed.Tick += new System.EventHandler(this.timerSpeed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBeginRatio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Panel panel1;
        private ViewForm viewForm1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBeginRatio;
        private System.Windows.Forms.Timer timerSpeed;
    }
}

