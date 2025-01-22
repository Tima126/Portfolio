namespace Gamelife
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numDensiti = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numResult = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButStart = new System.Windows.Forms.Button();
            this.ButStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDensiti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ButStop);
            this.splitContainer1.Panel1.Controls.Add(this.ButStart);
            this.splitContainer1.Panel1.Controls.Add(this.numDensiti);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.numResult);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(986, 450);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.TabIndex = 0;
            // 
            // numDensiti
            // 
            this.numDensiti.Location = new System.Drawing.Point(14, 66);
            this.numDensiti.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDensiti.Name = "numDensiti";
            this.numDensiti.Size = new System.Drawing.Size(120, 20);
            this.numDensiti.TabIndex = 3;
            this.numDensiti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDensiti.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Плотность";
            // 
            // numResult
            // 
            this.numResult.Location = new System.Drawing.Point(14, 27);
            this.numResult.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numResult.Name = "numResult";
            this.numResult.Size = new System.Drawing.Size(120, 20);
            this.numResult.TabIndex = 1;
            this.numResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numResult.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Разрешение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 446);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(14, 92);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(120, 34);
            this.ButStart.TabIndex = 4;
            this.ButStart.Text = "Старт";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // ButStop
            // 
            this.ButStop.Location = new System.Drawing.Point(14, 132);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(120, 36);
            this.ButStop.TabIndex = 5;
            this.ButStop.Text = "Стоп";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDensiti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numResult;
        private System.Windows.Forms.NumericUpDown numDensiti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButStop;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.Timer timer1;
    }
}

