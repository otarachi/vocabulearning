namespace Vocabulearning
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.learntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtDelay = new System.Windows.Forms.NumericUpDown();
            this.txtInterval = new System.Windows.Forms.NumericUpDown();
            this.txtAnimationDuration = new System.Windows.Forms.NumericUpDown();
            this.txtRepeat = new System.Windows.Forms.NumericUpDown();
            this.txtTimeLearnt = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFontTitle = new System.Windows.Forms.NumericUpDown();
            this.txtFontContent = new System.Windows.Forms.NumericUpDown();
            this.txtHeight = new System.Windows.Forms.NumericUpDown();
            this.txtWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.popupNotifier1 = new Vocabulearning.PopupNotifier();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnimationDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeLearnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 54);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings..";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dict:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(308, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Notification Title";
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Delay [ms]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Animation interval [ms]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Repeat after [ms]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Time to learnt:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learntToolStripMenuItem,
            this.neverToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 48);
            this.contextMenuStrip1.MouseEnter += new System.EventHandler(this.OptionsMenu_MouseEnter);
            // 
            // learntToolStripMenuItem
            // 
            this.learntToolStripMenuItem.Name = "learntToolStripMenuItem";
            this.learntToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.learntToolStripMenuItem.Text = "Learnt it";
            // 
            // neverToolStripMenuItem
            // 
            this.neverToolStripMenuItem.Name = "neverToolStripMenuItem";
            this.neverToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.neverToolStripMenuItem.Text = "Never show it";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "AnimationDuration [ms]:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Learning How to Learn";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(133, 40);
            this.txtDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(58, 20);
            this.txtDelay.TabIndex = 23;
            this.txtDelay.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(134, 66);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(57, 20);
            this.txtInterval.TabIndex = 24;
            this.txtInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtAnimationDuration
            // 
            this.txtAnimationDuration.Location = new System.Drawing.Point(134, 92);
            this.txtAnimationDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtAnimationDuration.Name = "txtAnimationDuration";
            this.txtAnimationDuration.Size = new System.Drawing.Size(57, 20);
            this.txtAnimationDuration.TabIndex = 25;
            this.txtAnimationDuration.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(134, 118);
            this.txtRepeat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(57, 20);
            this.txtRepeat.TabIndex = 26;
            this.txtRepeat.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // txtTimeLearnt
            // 
            this.txtTimeLearnt.Location = new System.Drawing.Point(134, 144);
            this.txtTimeLearnt.Name = "txtTimeLearnt";
            this.txtTimeLearnt.Size = new System.Drawing.Size(57, 20);
            this.txtTimeLearnt.TabIndex = 27;
            this.txtTimeLearnt.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFontTitle
            // 
            this.txtFontTitle.Location = new System.Drawing.Point(299, 117);
            this.txtFontTitle.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtFontTitle.Name = "txtFontTitle";
            this.txtFontTitle.Size = new System.Drawing.Size(57, 20);
            this.txtFontTitle.TabIndex = 37;
            this.txtFontTitle.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtFontContent
            // 
            this.txtFontContent.Location = new System.Drawing.Point(299, 91);
            this.txtFontContent.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.txtFontContent.Name = "txtFontContent";
            this.txtFontContent.Size = new System.Drawing.Size(57, 20);
            this.txtFontContent.TabIndex = 36;
            this.txtFontContent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(299, 65);
            this.txtHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtHeight.Minimum = new decimal(new int[] {
            74,
            0,
            0,
            0});
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(57, 20);
            this.txtHeight.TabIndex = 35;
            this.txtHeight.Value = new decimal(new int[] {
            74,
            0,
            0,
            0});
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(298, 39);
            this.txtWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtWidth.Minimum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(58, 20);
            this.txtWidth.TabIndex = 34;
            this.txtWidth.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Font Content";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Font Vocabulary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Height";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Width";
            // 
            // popupNotifier1
            // 
            this.popupNotifier1.BodyColor = System.Drawing.Color.Transparent;
            this.popupNotifier1.ButtonHoverColor = System.Drawing.Color.White;
            this.popupNotifier1.ContentFont = new System.Drawing.Font("Segoe UI", 10F);
            this.popupNotifier1.ContentText = null;
            this.popupNotifier1.Image = null;
            this.popupNotifier1.ImageSize = new System.Drawing.Size(48, 48);
            this.popupNotifier1.OptionsMenu = this.contextMenuStrip1;
            this.popupNotifier1.Size = new System.Drawing.Size(300, 74);
            this.popupNotifier1.TitleColor = System.Drawing.SystemColors.ControlText;
            this.popupNotifier1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.popupNotifier1.TitleText = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 182);
            this.Controls.Add(this.txtFontTitle);
            this.Controls.Add(this.txtFontContent);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimeLearnt);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.txtAnimationDuration);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Vocabulearning Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnimationDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeLearnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFontContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem learntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private PopupNotifier popupNotifier1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.NumericUpDown txtDelay;
        private System.Windows.Forms.NumericUpDown txtInterval;
        private System.Windows.Forms.NumericUpDown txtAnimationDuration;
        private System.Windows.Forms.NumericUpDown txtRepeat;
        private System.Windows.Forms.NumericUpDown txtTimeLearnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown txtFontTitle;
        private System.Windows.Forms.NumericUpDown txtFontContent;
        private System.Windows.Forms.NumericUpDown txtHeight;
        private System.Windows.Forms.NumericUpDown txtWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

