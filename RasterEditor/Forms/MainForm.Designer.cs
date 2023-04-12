namespace RasterEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panTools = new System.Windows.Forms.Panel();
            this.toolStripWidth = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.px1 = new System.Windows.Forms.ToolStripMenuItem();
            this.px2 = new System.Windows.Forms.ToolStripMenuItem();
            this.px4 = new System.Windows.Forms.ToolStripMenuItem();
            this.px8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.panColorSelected = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainDraw = new RasterEditor.BufferedPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.px16 = new System.Windows.Forms.ToolStripMenuItem();
            this.px64 = new System.Windows.Forms.ToolStripMenuItem();
            this.px32 = new System.Windows.Forms.ToolStripMenuItem();
            this.panTools.SuspendLayout();
            this.toolStripWidth.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTools
            // 
            this.panTools.BackColor = System.Drawing.Color.MintCream;
            this.panTools.Controls.Add(this.btnClear);
            this.panTools.Controls.Add(this.toolStripWidth);
            this.panTools.Controls.Add(this.toolStrip);
            this.panTools.Controls.Add(this.btnGreen);
            this.panTools.Controls.Add(this.btnBlue);
            this.panTools.Controls.Add(this.btnBlack);
            this.panTools.Controls.Add(this.btnWhite);
            this.panTools.Controls.Add(this.btnRed);
            this.panTools.Controls.Add(this.btnColorDialog);
            this.panTools.Controls.Add(this.panColorSelected);
            resources.ApplyResources(this.panTools, "panTools");
            this.panTools.Name = "panTools";
            // 
            // toolStripWidth
            // 
            this.toolStripWidth.BackColor = System.Drawing.Color.White;
            this.toolStripWidth.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton});
            resources.ApplyResources(this.toolStripWidth, "toolStripWidth");
            this.toolStripWidth.Name = "toolStripWidth";
            // 
            // toolStripSplitButton
            // 
            this.toolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.px1,
            this.px2,
            this.px4,
            this.px8,
            this.px16,
            this.px32,
            this.px64});
            this.toolStripSplitButton.Image = global::RasterEditor.Properties.Resources.Width;
            this.toolStripSplitButton.Name = "toolStripSplitButton";
            resources.ApplyResources(this.toolStripSplitButton, "toolStripSplitButton");
            // 
            // px1
            // 
            this.px1.Name = "px1";
            resources.ApplyResources(this.px1, "px1");
            this.px1.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // px2
            // 
            this.px2.Name = "px2";
            resources.ApplyResources(this.px2, "px2");
            this.px2.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // px4
            // 
            this.px4.Name = "px4";
            resources.ApplyResources(this.px4, "px4");
            this.px4.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // px8
            // 
            this.px8.Name = "px8";
            resources.ApplyResources(this.px8, "px8");
            this.px8.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line,
            this.Rectangle,
            this.Pencil});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = global::RasterEditor.Properties.Resources.line16;
            resources.ApplyResources(this.Line, "Line");
            this.Line.Name = "Line";
            this.Line.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = global::RasterEditor.Properties.Resources.rectange16;
            resources.ApplyResources(this.Rectangle, "Rectangle");
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = global::RasterEditor.Properties.Resources.pencil16;
            resources.ApplyResources(this.Pencil, "Pencil");
            this.Pencil.Name = "Pencil";
            this.Pencil.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnGreen, "btnGreen");
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.btnBlue, "btnBlue");
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnBlack, "btnBlack");
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnWhite, "btnWhite");
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnRed, "btnRed");
            this.btnRed.Name = "btnRed";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnColorDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnColorDialog.FlatAppearance.BorderSize = 0;
            this.btnColorDialog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnColorDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnColorDialog, "btnColorDialog");
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.UseVisualStyleBackColor = false;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // panColorSelected
            // 
            this.panColorSelected.BackColor = System.Drawing.Color.Black;
            this.panColorSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.panColorSelected, "panColorSelected");
            this.panColorSelected.Name = "panColorSelected";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.referenceToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            resources.ApplyResources(this.referenceToolStripMenuItem, "referenceToolStripMenuItem");
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            resources.ApplyResources(this.aboutMeToolStripMenuItem, "aboutMeToolStripMenuItem");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // mainDraw
            // 
            resources.ApplyResources(this.mainDraw, "mainDraw");
            this.mainDraw.Name = "mainDraw";
            this.mainDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.mainDraw_Paint);
            this.mainDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainDraw_MouseDown);
            this.mainDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainDraw_MouseMove);
            this.mainDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainDraw_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // px16
            // 
            this.px16.Name = "px16";
            resources.ApplyResources(this.px16, "px16");
            this.px16.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // px64
            // 
            this.px64.Name = "px64";
            resources.ApplyResources(this.px64, "px64");
            this.px64.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // px32
            // 
            this.px32.Name = "px32";
            resources.ApplyResources(this.px32, "px32");
            this.px32.Click += new System.EventHandler(this.toolStripWidth_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainDraw);
            this.Controls.Add(this.panTools);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.panTools.ResumeLayout(false);
            this.panTools.PerformLayout();
            this.toolStripWidth.ResumeLayout(false);
            this.toolStripWidth.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BufferedPanel mainDraw;
        private System.Windows.Forms.Panel panTools;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel panColorSelected;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.ToolStrip toolStripWidth;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem px1;
        private System.Windows.Forms.ToolStripMenuItem px2;
        private System.Windows.Forms.ToolStripMenuItem px4;
        private System.Windows.Forms.ToolStripMenuItem px8;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem px16;
        private System.Windows.Forms.ToolStripMenuItem px32;
        private System.Windows.Forms.ToolStripMenuItem px64;
    }
}

