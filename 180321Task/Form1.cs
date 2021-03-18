using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180321Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectImageBtn_Click(object sender, EventArgs e)
        {
            var openImage = new OpenFileDialog();

            openImage.Filter = "Image file (*.png) |";

            if (openImage.ShowDialog() == DialogResult.Cancel)
                return;

            userImage.Image = Image.FromFile(openImage.FileName);
        }

        private void OpenDescriptionBtn_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Text file (*.txt) |";

            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = (open.FileName.EndsWith(".txt")) ? open.FileName : $"{open.FileName}.txt";

            using (var sr = File.OpenText(fileName))
            {
                richTextBox1.Text = sr.ReadToEnd();
            }
        }

        private void SaveDescriptionBtn_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();

            save.Filter = "Text file(*.txt) |";

            if (save.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = (save.FileName.EndsWith(".txt")) ? save.FileName : $"{save.FileName}.txt";

            using (var sw = new StreamWriter(fileName))
            {
                sw.Write(richTextBox1.Text);
            }
        }

        private void TopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            DraggableForm.MouseDown(Cursor.Position, this.Location);
        }

        private void TopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            var newLocation = DraggableForm.MouseMove();

            if (newLocation != Point.Empty)
                this.Location = newLocation;
        }

        private void TopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            DraggableForm.MouseUp();
        }

        private void SaveCvBtn_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();

            save.Filter = "Json file(*.json) |";

            if (save.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = (save.FileName.EndsWith(".json")) ? save.FileName : $"{save.FileName}.json";


            var user = new User();

            user.Description = richTextBox1.Text;

            user.ImageBytes = ImageHelper.ConvertImageToBytes(userImage.Image);

            FileHelper.WriteToJson(fileName, user);
        }

        private void LoadCvBtn_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Json file (*.json) |";

            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = (open.FileName.EndsWith(".json")) ? open.FileName : $"{open.FileName}.json";

            var user = FileHelper.ReadFromJson(fileName);

            richTextBox1.Text = user.Description;
            userImage.Image = ImageHelper.ConvertBytesToImage(user.ImageBytes);
        }
    }
}
