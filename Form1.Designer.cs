﻿namespace WeekReport
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
            this.weeklyDealTextBox = new System.Windows.Forms.TextBox();
            this.otchetTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.onControlButton = new System.Windows.Forms.Button();
            this.controlTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьНовуюНеделюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ToolStripMenuItemOrphoCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // weeklyDealTextBox
            // 
            this.weeklyDealTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.weeklyDealTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weeklyDealTextBox.Location = new System.Drawing.Point(6, 19);
            this.weeklyDealTextBox.Name = "weeklyDealTextBox";
            this.weeklyDealTextBox.Size = new System.Drawing.Size(532, 26);
            this.weeklyDealTextBox.TabIndex = 22;
            // 
            // otchetTextBox
            // 
            this.otchetTextBox.HideSelection = false;
            this.otchetTextBox.Location = new System.Drawing.Point(18, 91);
            this.otchetTextBox.Multiline = true;
            this.otchetTextBox.Name = "otchetTextBox";
            this.otchetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.otchetTextBox.Size = new System.Drawing.Size(532, 287);
            this.otchetTextBox.TabIndex = 14;
            this.otchetTextBox.TabStop = false;
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputTextBox.Location = new System.Drawing.Point(18, 393);
            this.inputTextBox.MaximumSize = new System.Drawing.Size(812, 33);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(532, 20);
            this.inputTextBox.TabIndex = 13;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressInTextBox);
            // 
            // onControlButton
            // 
            this.onControlButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.onControlButton.Location = new System.Drawing.Point(10, 347);
            this.onControlButton.Name = "onControlButton";
            this.onControlButton.Size = new System.Drawing.Size(205, 33);
            this.onControlButton.TabIndex = 25;
            this.onControlButton.Text = "НА КОНТРОЛЬ";
            this.onControlButton.UseVisualStyleBackColor = true;
            this.onControlButton.Click += new System.EventHandler(this.Button_OnControl_Click);
            // 
            // controlTextBox
            // 
            this.controlTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.controlTextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlTextBox.Location = new System.Drawing.Point(577, 52);
            this.controlTextBox.Multiline = true;
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.controlTextBox.Size = new System.Drawing.Size(205, 322);
            this.controlTextBox.TabIndex = 24;
            this.controlTextBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 27;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.начатьНовуюНеделюToolStripMenuItem,
            this.ToolStripMenuItemOrphoCheck,
            this.оПрограммеToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WeekReport.Properties.Resources.savedisk_floppydisk_guardar_1543;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MenuSave);
            // 
            // начатьНовуюНеделюToolStripMenuItem
            // 
            this.начатьНовуюНеделюToolStripMenuItem.Image = global::WeekReport.Properties.Resources.new_25355;
            this.начатьНовуюНеделюToolStripMenuItem.Name = "начатьНовуюНеделюToolStripMenuItem";
            this.начатьНовуюНеделюToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.начатьНовуюНеделюToolStripMenuItem.Text = "Начать новую неделю";
            this.начатьНовуюНеделюToolStripMenuItem.Click += new System.EventHandler(this.NewWeekMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::WeekReport.Properties.Resources.information_info_1565;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.weeklyDealTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 392);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Повторяющиеся дела";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.onControlButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(567, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 392);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "На контроле";
            // 
            // ToolStripMenuItemOrphoCheck
            // 
            this.ToolStripMenuItemOrphoCheck.CheckOnClick = true;
            this.ToolStripMenuItemOrphoCheck.Name = "ToolStripMenuItemOrphoCheck";
            this.ToolStripMenuItemOrphoCheck.Size = new System.Drawing.Size(210, 22);
            this.ToolStripMenuItemOrphoCheck.Text = "Проверять орфографию";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.otchetTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox weeklyDealTextBox;
        internal System.Windows.Forms.TextBox otchetTextBox;
        internal System.Windows.Forms.TextBox inputTextBox;
        internal System.Windows.Forms.Button onControlButton;
        internal System.Windows.Forms.TextBox controlTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьНовуюНеделюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOrphoCheck;
    }
}

