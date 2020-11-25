
namespace Clock
{
    partial class ClockForm
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabClock = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabSW = new System.Windows.Forms.TabPage();
            this.txtElapsed = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblElapsed = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnUnclickable = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tab.SuspendLayout();
            this.tabClock.SuspendLayout();
            this.tabSW.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.tabClock);
            this.tab.Controls.Add(this.tabSW);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(511, 199);
            this.tab.TabIndex = 0;
            // 
            // tabClock
            // 
            this.tabClock.Controls.Add(this.checkBox1);
            this.tabClock.Controls.Add(this.textBox4);
            this.tabClock.Location = new System.Drawing.Point(4, 22);
            this.tabClock.Name = "tabClock";
            this.tabClock.Padding = new System.Windows.Forms.Padding(3);
            this.tabClock.Size = new System.Drawing.Size(503, 173);
            this.tabClock.TabIndex = 0;
            this.tabClock.Text = "Clock";
            this.tabClock.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 6);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(491, 138);
            this.textBox4.TabIndex = 0;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // tabSW
            // 
            this.tabSW.Controls.Add(this.txtElapsed);
            this.tabSW.Controls.Add(this.txtEnd);
            this.tabSW.Controls.Add(this.txtStart);
            this.tabSW.Controls.Add(this.lblElapsed);
            this.tabSW.Controls.Add(this.lblEnd);
            this.tabSW.Controls.Add(this.lblStart);
            this.tabSW.Controls.Add(this.btnUnclickable);
            this.tabSW.Controls.Add(this.btnEnd);
            this.tabSW.Controls.Add(this.btnStart);
            this.tabSW.Location = new System.Drawing.Point(4, 22);
            this.tabSW.Name = "tabSW";
            this.tabSW.Padding = new System.Windows.Forms.Padding(3);
            this.tabSW.Size = new System.Drawing.Size(503, 173);
            this.tabSW.TabIndex = 1;
            this.tabSW.Text = "Stopwatch";
            this.tabSW.UseVisualStyleBackColor = true;
            // 
            // txtElapsed
            // 
            this.txtElapsed.Location = new System.Drawing.Point(251, 131);
            this.txtElapsed.Name = "txtElapsed";
            this.txtElapsed.Size = new System.Drawing.Size(180, 20);
            this.txtElapsed.TabIndex = 8;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(251, 76);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(180, 20);
            this.txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(251, 21);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(180, 20);
            this.txtStart.TabIndex = 6;
            // 
            // lblElapsed
            // 
            this.lblElapsed.AutoSize = true;
            this.lblElapsed.Location = new System.Drawing.Point(160, 134);
            this.lblElapsed.Name = "lblElapsed";
            this.lblElapsed.Size = new System.Drawing.Size(85, 13);
            this.lblElapsed.TabIndex = 5;
            this.lblElapsed.Text = "Time Elapsed (s)";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(160, 79);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(52, 13);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "End Time";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(160, 24);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(55, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Start Time";
            // 
            // btnUnclickable
            // 
            this.btnUnclickable.Enabled = false;
            this.btnUnclickable.Location = new System.Drawing.Point(6, 116);
            this.btnUnclickable.Name = "btnUnclickable";
            this.btnUnclickable.Size = new System.Drawing.Size(148, 49);
            this.btnUnclickable.TabIndex = 2;
            this.btnUnclickable.Text = "&Unclickable Button";
            this.btnUnclickable.UseVisualStyleBackColor = false;
            this.btnUnclickable.Click += new System.EventHandler(this.btnUnclickable_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(6, 61);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(148, 49);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "&End Timing";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 49);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start Timing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 150);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Paused";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 223);
            this.Controls.Add(this.tab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClockForm";
            this.Text = "Clocky";
            this.TopMost = true;
            this.tab.ResumeLayout(false);
            this.tabClock.ResumeLayout(false);
            this.tabClock.PerformLayout();
            this.tabSW.ResumeLayout(false);
            this.tabSW.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabClock;
        private System.Windows.Forms.TabPage tabSW;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtElapsed;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblElapsed;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnUnclickable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

