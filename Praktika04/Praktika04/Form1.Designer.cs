
namespace Praktika04
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRadius = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSetting
            // 
            this.menuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuColor,
            this.menuRadius,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuSetting.Name = "menuSetting";
            this.menuSetting.Size = new System.Drawing.Size(127, 20);
            this.menuSetting.Text = "Настройки рисунка";
            // 
            // menuColor
            // 
            this.menuColor.Name = "menuColor";
            this.menuColor.Size = new System.Drawing.Size(180, 22);
            this.menuColor.Text = "Изменить цвет";
            this.menuColor.Click += new System.EventHandler(this.menuColor_Click);
            // 
            // menuRadius
            // 
            this.menuRadius.Name = "menuRadius";
            this.menuRadius.Size = new System.Drawing.Size(180, 22);
            this.menuRadius.Text = "Изменить радиус";
            this.menuRadius.Click += new System.EventHandler(this.menuRadius_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "Выход";
            // 
            // picCircle
            // 
            this.picCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCircle.Location = new System.Drawing.Point(0, 27);
            this.picCircle.Name = "picCircle";
            this.picCircle.Size = new System.Drawing.Size(800, 512);
            this.picCircle.TabIndex = 1;
            this.picCircle.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.picCircle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSetting;
        private System.Windows.Forms.ToolStripMenuItem menuColor;
        private System.Windows.Forms.ToolStripMenuItem menuRadius;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.PictureBox picCircle;
    }
}

