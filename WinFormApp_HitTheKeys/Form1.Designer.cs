namespace WinFormApp_HitTheKeys
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
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.accuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(80, 78);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(120, 95);
      this.listBox1.TabIndex = 0;
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
      this.checkedListBox1.MultiColumn = true;
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(856, 131);
      this.checkedListBox1.TabIndex = 1;
      this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
      // 
      // timer1
      // 
      this.timer1.Interval = 800;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.accuracyLabel,
            this.toolStripStatusLabel1,
            this.difficultyProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 109);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(856, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
      // 
      // correctLabel
      // 
      this.correctLabel.Name = "correctLabel";
      this.correctLabel.Size = new System.Drawing.Size(58, 17);
      this.correctLabel.Text = "Correct: 0";
      this.correctLabel.Click += new System.EventHandler(this.correctLabel_Click);
      // 
      // missedLabel
      // 
      this.missedLabel.Name = "missedLabel";
      this.missedLabel.Size = new System.Drawing.Size(56, 17);
      this.missedLabel.Text = "Missed: 0";
      // 
      // totalLabel
      // 
      this.totalLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
      this.totalLabel.Name = "totalLabel";
      this.totalLabel.Size = new System.Drawing.Size(44, 17);
      this.totalLabel.Text = "Total: 0";
      // 
      // accuracyLabel
      // 
      this.accuracyLabel.Name = "accuracyLabel";
      this.accuracyLabel.Size = new System.Drawing.Size(75, 17);
      this.accuracyLabel.Text = "Accuracy 0%";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(506, 17);
      this.toolStripStatusLabel1.Spring = true;
      this.toolStripStatusLabel1.Text = "Text: Difficulty";
      this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // difficultyProgressBar
      // 
      this.difficultyProgressBar.Maximum = 701;
      this.difficultyProgressBar.Name = "difficultyProgressBar";
      this.difficultyProgressBar.Size = new System.Drawing.Size(100, 16);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(856, 131);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.checkedListBox1);
      this.Controls.Add(this.listBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "Hit buttons!";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
    }
}

