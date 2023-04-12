using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasterEditor
{
    public partial class MainForm : Form
    {
        int x1, y1, x2, y2, lineWidth;
        bool mouseDown;
        Bitmap snapshot, tempDraw;
        Color foreColor;
        string selectedTool, full_name_of_image = "Моя_картинка";
        public MainForm()
        {
            InitializeComponent();

            snapshot = new Bitmap(mainDraw.ClientRectangle.Width-5, this.ClientRectangle.Height-125);
            foreColor = Color.Black;
            selectedTool = "Pencil";
            lineWidth = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Graphics graphics = mainDraw.CreateGraphics();
            graphics.Clear(SystemColors.Window);
            snapshot.Dispose();
            snapshot = new Bitmap(mainDraw.ClientRectangle.Width-5, this.ClientRectangle.Height- 125);
        }

        private void mainDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                x2 = e.X;
                y2 = e.Y;
                mainDraw.Invalidate();
                mainDraw.Update();
            }
        }

        private void mainDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            x1 = e.X;
            y1 = e.Y;

            tempDraw = (Bitmap)snapshot.Clone();
        }

        private void mainDraw_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            snapshot = (Bitmap)tempDraw.Clone();
        }
        private void mainDraw_Paint(object sender, PaintEventArgs e)
        {
            switch (selectedTool)
            {
                case "Line":
                    if (tempDraw != null)
                    {
                        tempDraw = (Bitmap)snapshot.Clone();
                        Graphics g = Graphics.FromImage(tempDraw);
                        Pen myPen = new Pen(foreColor, lineWidth);
                        g.DrawLine(myPen, x1, y1, x2, y2);
                        myPen.Dispose();
                        e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                        g.Dispose();
                    }
                    break;

                case "Rectangle":
                    if (tempDraw != null)
                    {
                        tempDraw = (Bitmap)snapshot.Clone();
                        Graphics g = Graphics.FromImage(tempDraw);
                        Pen myPen = new Pen(foreColor, lineWidth);
                        g.DrawRectangle(myPen, x1, y1, x2 - x1, y2 - y1);
                        myPen.Dispose();
                        e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                        g.Dispose();
                    }
                    break;

                case "Pencil":
                    if (tempDraw != null)
                    {
                        Graphics g = Graphics.FromImage(tempDraw);
                        Pen myPen = new Pen(foreColor, lineWidth);
                        myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(myPen, x1, y1, x2, y2);
                        myPen.Dispose();
                        e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
                        g.Dispose();
                        x1 = x2;
                        y1 = y2;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            foreach (ToolStripButton btn in toolStrip.Items)
            {
                btn.Checked = false;
            }

            ToolStripButton btnClicked = sender as ToolStripButton;
            btnClicked.Checked = true;
            selectedTool = btnClicked.Name;
        }
        private void toolStripWidth_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem itm in toolStripSplitButton.DropDownItems)
            {
                itm.Checked = false;
            }

            ToolStripMenuItem itmClicked = sender as ToolStripMenuItem;
            itmClicked.Checked = true;

            lineWidth = int.Parse(itmClicked.Text.Remove(2));
        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreColor = colorDialog.Color;
                panColorSelected.BackColor = foreColor;
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            panColorSelected.BackColor = button.BackColor;
            foreColor = button.BackColor;
        }


        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    snapshot.Dispose();
                    full_name_of_image = open_dialog.FileName;
                    snapshot = new Bitmap(open_dialog.FileName);
                    tempDraw = new Bitmap(open_dialog.FileName);

                    mainDraw.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Impossible to open selected file",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.FileName = full_name_of_image;
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|ImageFiles(*.GIF) | *.GIF | Image Files(*.PNG) | *.PNG | All files(*.*) | *.* ";
            savedialog.ShowHelp = true;
            // If selected, save
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    snapshot.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                catch
                {
                    MessageBox.Show("Impossible to save image", "FATAL ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
