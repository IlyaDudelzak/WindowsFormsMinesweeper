namespace WindowsFormsMinesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.FileOpenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveReplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripTextBoxGameSize = new System.Windows.Forms.ToolStripTextBox();
            this.GameSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.chooseResousepackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveSaveReplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.еуыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripDropDownButton,
            this.GameToolStripDropDownButton,
            this.toolStripDropDownButtonView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(370, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileToolStripDropDownButton
            // 
            this.FileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenToolStripMenuItem1,
            this.FileSaveToolStripMenuItem});
            this.FileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FileToolStripDropDownButton.Image")));
            this.FileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton";
            this.FileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.FileToolStripDropDownButton.Text = "File";
            // 
            // FileOpenToolStripMenuItem1
            // 
            this.FileOpenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.FileOpenToolStripMenuItem1.Name = "FileOpenToolStripMenuItem1";
            this.FileOpenToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.FileOpenToolStripMenuItem1.Text = "Open Ctrl+O";
            this.FileOpenToolStripMenuItem1.Click += new System.EventHandler(this.OpenMap);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(206, 22);
            this.toolStripMenuItem2.Text = "Open map Ctrl+S";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.OpenMap);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(206, 22);
            this.toolStripMenuItem3.Text = "Open replay Ctrl+Shift+S";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.OpenReplay);
            // 
            // FileSaveToolStripMenuItem
            // 
            this.FileSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSaveMapToolStripMenuItem,
            this.FileSaveReplayToolStripMenuItem});
            this.FileSaveToolStripMenuItem.Name = "FileSaveToolStripMenuItem";
            this.FileSaveToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.FileSaveToolStripMenuItem.Text = "Save Ctrl+S";
            this.FileSaveToolStripMenuItem.Click += new System.EventHandler(this.SaveMap);
            // 
            // FileSaveMapToolStripMenuItem
            // 
            this.FileSaveMapToolStripMenuItem.Name = "FileSaveMapToolStripMenuItem";
            this.FileSaveMapToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.FileSaveMapToolStripMenuItem.Text = "Save map Ctrl+S";
            this.FileSaveMapToolStripMenuItem.Click += new System.EventHandler(this.SaveMap);
            // 
            // FileSaveReplayToolStripMenuItem
            // 
            this.FileSaveReplayToolStripMenuItem.Name = "FileSaveReplayToolStripMenuItem";
            this.FileSaveReplayToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.FileSaveReplayToolStripMenuItem.Text = "Save replay Ctrl+Shift+S";
            this.FileSaveReplayToolStripMenuItem.Click += new System.EventHandler(this.SaveReplay);
            // 
            // GameToolStripDropDownButton
            // 
            this.GameToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GameToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxGameSize,
            this.GameSizeComboBox,
            this.еуыеToolStripMenuItem});
            this.GameToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("GameToolStripDropDownButton.Image")));
            this.GameToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GameToolStripDropDownButton.Name = "GameToolStripDropDownButton";
            this.GameToolStripDropDownButton.Size = new System.Drawing.Size(51, 22);
            this.GameToolStripDropDownButton.Text = "Game";
            // 
            // toolStripTextBoxGameSize
            // 
            this.toolStripTextBoxGameSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxGameSize.Name = "toolStripTextBoxGameSize";
            this.toolStripTextBoxGameSize.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxGameSize.Text = "Game size";
            // 
            // GameSizeComboBox
            // 
            this.GameSizeComboBox.Items.AddRange(new object[] {
            "Beginner",
            "Intermerdiate",
            "Expert",
            "Custom"});
            this.GameSizeComboBox.Name = "GameSizeComboBox";
            this.GameSizeComboBox.Size = new System.Drawing.Size(121, 23);
            this.GameSizeComboBox.Text = "Beginner";
            this.GameSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.GameSizeComboBox_SelectedIndexChanged);
            // 
            // toolStripDropDownButtonView
            // 
            this.toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseResousepackToolStripMenuItem});
            this.toolStripDropDownButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonView.Image")));
            this.toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            this.toolStripDropDownButtonView.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButtonView.Text = "View";
            // 
            // chooseResousepackToolStripMenuItem
            // 
            this.chooseResousepackToolStripMenuItem.Name = "chooseResousepackToolStripMenuItem";
            this.chooseResousepackToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.chooseResousepackToolStripMenuItem.Text = "Choose Resousepack";
            this.chooseResousepackToolStripMenuItem.Click += new System.EventHandler(this.ChooseResoursepack);
            // 
            // FileSaveSaveReplayToolStripMenuItem
            // 
            this.FileSaveSaveReplayToolStripMenuItem.Name = "FileSaveSaveReplayToolStripMenuItem";
            this.FileSaveSaveReplayToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // еуыеToolStripMenuItem
            // 
            this.еуыеToolStripMenuItem.Name = "еуыеToolStripMenuItem";
            this.еуыеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.еуыеToolStripMenuItem.Text = "еуые";
            this.еуыеToolStripMenuItem.Click += new System.EventHandler(this.еуыеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileSaveSaveReplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton FileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem FileOpenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveReplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton GameToolStripDropDownButton;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGameSize;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripComboBox GameSizeComboBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem chooseResousepackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem еуыеToolStripMenuItem;
    }
}

