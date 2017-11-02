using Gif.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gif_Maker
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.step1;
            this.AsyncWorkingChanged += MainF_AsyncWorkingChanged;
        }

        #region Async event

        event EventHandler AsyncWorkingChanged;

        int tasksLeft = 0;

        void MainF_AsyncWorkingChanged(object value, EventArgs e)
        {
            string t = (string)value;
            if (t == "")
            {
                tasksLeft--;
                if (tasksLeft > 0)
                    workingL.Invoke((MethodInvoker)(() => workingL.Text = "Quedan " + tasksLeft + " tarea(s) pendiente(s)"));
                else
                {
                    workingL.Invoke((MethodInvoker)(() => workingL.Text = "Sin tareas pendientes"));
                    workingPB.Invoke((MethodInvoker)(() => workingPB.Style = ProgressBarStyle.Continuous));
                }
            }
            else
            {
                tasksLeft++;
                workingL.Invoke((MethodInvoker)(() => workingL.Text = t));
                workingPB.Invoke((MethodInvoker)(() => workingPB.Style = ProgressBarStyle.Marquee));
                workingPB.Invoke((MethodInvoker)(() => workingPB.MarqueeAnimationSpeed = 30));
            }
        }

        #endregion

        #region Gif encoder and decoder

        async Task CreateGif(string[] images, string output, int delay, int repeat) {
            Image[] imgs = new Image[images.Length];
            for (int i = 0; i < imgs.Length; i++)
                imgs[i] = Image.FromFile(images[i]);

            await CreateGif(imgs, output, delay, repeat);
        }

        async Task CreateGif(Image[] images, string output, int delay, int repeat) {
            await Task.Factory.StartNew(() =>
            {
                AsyncWorkingChanged("Creando gif animado...", new EventArgs());
                AnimatedGifEncoder e = new AnimatedGifEncoder();
                e.Start(output);
                e.SetDelay(delay);
                e.SetRepeat(repeat);
                for (int i = 0; i < images.Length; i++)
                {
                    float percentage = (float)i / (float)images.Length * 100f;
                    AsyncWorkingChanged("", new EventArgs());
                    AsyncWorkingChanged("Creando gif animado " + percentage.ToString("#.##") + "%", new EventArgs());
                    e.AddFrame(images[i]);
                }
                e.Finish();

                AsyncWorkingChanged("", new EventArgs());
            });
        }

        async Task ExtractGif(string image, string output, string name)
        {
            await Task.Factory.StartNew(() =>
            {
                AsyncWorkingChanged("Extrayendo gif...", new EventArgs());

                var ext = Path.GetExtension(output + @"\" + name);
                name = Path.GetFileNameWithoutExtension(name);
                var imf = GetImageFormat(ext);
                if (imf == ImageFormat.Png)
                    ext = ".png";

                GifDecoder d = new GifDecoder();
                d.Read(image);
                for (int i = 0; i < d.GetFrameCount(); i++)
                {
                    float percentage = (float)i / (float)d.GetFrameCount() * 100f;
                    AsyncWorkingChanged("", new EventArgs());
                    AsyncWorkingChanged("Extrayendo gif " + percentage.ToString("#.##") + "%", new EventArgs());

                    Image frame = d.GetFrame(i);
                    frame.Save(output + @"\" + name + " " + (i + 1) + ext, imf);
                }

                AsyncWorkingChanged("", new EventArgs());
            });
        }

        async Task<Image[]> GetImages(string gif)
        {
            return await Task.Factory.StartNew<Image[]>(() =>
            {
                AsyncWorkingChanged("Decodificando gif...", new EventArgs());

                GifDecoder d = new GifDecoder();
                d.Read(gif);
                Image[] images = new Image[d.GetFrameCount()];

                for (int i = 0; i < images.Length; i++)
                    images[i] = d.GetFrame(i);

                AsyncWorkingChanged("", new EventArgs());

                return images;
            });
        }

        ImageFormat GetImageFormat(string extension)
        {
            switch (extension)
            {
                case ".png":
                    return ImageFormat.Png;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".gif":
                    return ImageFormat.Gif;
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".tif":
                case ".tiff":
                    return ImageFormat.Tiff;
                default:
                    return ImageFormat.Png;
            }
        }

        #endregion

        #region Settings changed

        void fpsRB_CheckedChanged(object sender, EventArgs e)
        {
            fpsNUD.Enabled = fpsRB.Checked;
            delayNUD.Enabled = !fpsRB.Checked;
        }

        void fpsNUD_ValueChanged(object sender, EventArgs e)
        {
            if (fpsNUD.Enabled)
                delayNUD.Value = 1000m / fpsNUD.Value;
        }

        void delayNUD_ValueChanged(object sender, EventArgs e)
        {
            if (delayNUD.Enabled)
                fpsNUD.Value = 1000m / delayNUD.Value;
        }

        void repeatCB_CheckedChanged(object sender, EventArgs e)
        {
            repeatNUD.Enabled = repeatCB.Checked;
        }

        #endregion

        #region Tool Strip Menu Items

        async void encodeGifTSMI_Click(object sender, EventArgs e)
        {
            if (imgsToGifOFD.ShowDialog() == DialogResult.OK)
            {
                saveGifSFD.FileName = Path.GetFileNameWithoutExtension(imgsToGifOFD.FileName);
                if (saveGifSFD.ShowDialog() == DialogResult.OK)
                {
                    await CreateGif(imgsToGifOFD.FileNames, saveGifSFD.FileName, (int)delayNUD.Value,
                        repeatNUD.Enabled ? (int)repeatNUD.Value : -1);
                    SayGifSaved(saveGifSFD.FileName);
                }
            }
        }

        void SayGifSaved(string path) {
            MessageBox.Show("El gif animado se ha creado correctamente en:\r\n" + path,
                "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void decodeGifTSMI_Click(object sender, EventArgs e)
        {
            if (gifToImgsOFD.ShowDialog() == DialogResult.OK)
                PromptSaveImages(gifToImgsOFD.FileName);
        }

        async void PromptSaveImages(string path) {
            saveImagesSFD.FileName = Path.GetFileNameWithoutExtension(path);
            if (saveImagesSFD.ShowDialog() == DialogResult.OK)
            {
                string f = Path.GetDirectoryName(saveImagesSFD.FileName);
                await ExtractGif(path, f, Path.GetFileName(saveImagesSFD.FileName));
                MessageBox.Show("Las imágenes del gif se han extraido correctamente en:\r\n" + f, "Completado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        async void addImagesTSMI_Click(object sender, EventArgs e)
        {
            if (imgsToGifOFD.ShowDialog() == DialogResult.OK)
                foreach (var file in imgsToGifOFD.FileNames)
                    if (Path.GetExtension(file) == ".gif")
                        foreach (var img in await GetImages(file))
                            AddImgToGif(img);
                    else
                        AddImgToGif(file);
        }

        void saveCurrentTSMI_Click(object sender, EventArgs e) { SaveCurrentGif(); }

        async void SaveCurrentGif() {
            if (saveGifSFD.ShowDialog() == DialogResult.OK)
            {
                Image[] imgs = new Image[imagesFLP.Controls.Count];
                for (int i = 0; i < imgs.Length; i++)
                    imgs[i] = ((PictureBox)imagesFLP.Controls[i]).Image;

                await CreateGif(imgs, saveGifSFD.FileName, (int)delayNUD.Value,
                        repeatNUD.Enabled ? (int)repeatNUD.Value : -1);
            }
        }

        void supportTSMI_Click(object sender, EventArgs e)
        {
            Process.Start("http://lonamiwebs.github.io/contacto");
        }

        #endregion

        #region Drag'n'drop

        private void endecodeP_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        async void endecodeP_DragDrop(object sender, DragEventArgs e)
        {
            var imgs = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (imgs.Length == 1)
                if (Path.GetExtension(imgs[0]) == ".gif")
                    PromptSaveImages(imgs[0]);
                else
                    AddImgToGif(imgs[0]);
            else if (ContainsGif(imgs))
                for (int i = 0; i < imgs.Length; i++)
                    if (Path.GetExtension(imgs[i]) != ".gif")
                        AddImgToGif(imgs[i]);
                    else
                        foreach (var img in await GetImages(imgs[i]))
                            AddImgToGif(img);
            else if (saveGifSFD.ShowDialog() == DialogResult.OK)
            {
                await CreateGif(imgs, saveGifSFD.FileName, (int)delayNUD.Value,
                    repeatNUD.Enabled ? (int)repeatNUD.Value : -1);
                SayGifSaved(saveGifSFD.FileName);
            }

        }

        bool ContainsGif(string[] imgs) {
            foreach (var img in imgs)
                if (Path.GetExtension(img) == ".gif")
                    return true;

            return false;
        }

        async void imagesFLP_DragDrop(object sender, DragEventArgs e)
        {
            var imgs = (string[])e.Data.GetData(DataFormats.FileDrop);

            for (int i = 0; i < imgs.Length; i++)
                if (Path.GetExtension(imgs[i]) != ".gif")
                    AddImgToGif(imgs[i]);
                else
                    foreach (var img in await GetImages(imgs[i]))
                        AddImgToGif(img);
        }

        #endregion

        #region Current gif

        List<Image> currentGifImages = new List<Image>();

        void newCurrentGifB_Click(object sender, EventArgs e)
        {
            currentGifImages.Clear();
            RefreshCurrentGifImages();
        }

        private void saveCurrentGifB_Click(object sender, EventArgs e)
        {
            SaveCurrentGif();
        }

        void AddImgToGif(string img) { AddImgToGif(Image.FromFile(img)); }

        void AddImgToGif(Image img)
        {
            currentGifImages.Add(img);
            RefreshCurrentGifImages();
        }

        void RefreshCurrentGifImages() {
            imagesFLP.Controls.Clear();

            foreach (var img in currentGifImages)
                imagesFLP.Controls.Add(NewPictureBox(img));
        }

        PictureBox NewPictureBox(Image image) {
            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.MouseClick += pictureBox_MouseClick;
            pictureBox.GotFocus += imagesFLP_Enter;
            pictureBox.ContextMenuStrip = imageCMS;
            return pictureBox;
        }

        void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == 0)
                foreach (var control in imagesFLP.Controls)
                {
                    ((PictureBox)control).BorderStyle = BorderStyle.None;
                    ((PictureBox)control).BackColor = SystemColors.Control;
                }

            ((PictureBox)sender).BorderStyle = BorderStyle.FixedSingle;
            ((PictureBox)sender).BackColor = SystemColors.Highlight;

            imagesFLP.Focus();
        }

        private void imagesFLP_Enter(object sender, EventArgs e)
        {
            imagesFLP.Focus();
        }

        private void imagesFLP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveHighlighted();
        }

        private void removeSelectedTSMI_Click(object sender, EventArgs e)
        {
            RemoveHighlighted();
        }

        void RemoveHighlighted()
        {
            List<int> indicies = new List<int>();
            for (int i = 0; i < imagesFLP.Controls.Count; i++)
                if (((PictureBox)imagesFLP.Controls[i]).BorderStyle == BorderStyle.FixedSingle)
                    indicies.Add(i);

            for (int i = indicies.Count; i > 0; i--)
            {
                currentGifImages.RemoveAt(indicies[i - 1]);
                RefreshCurrentGifImages();
            }
        }
        private void imagesFLP_ControlAdded(object sender, ControlEventArgs e)
        {
            currentGifInfoL.Text = "Imágenes actuales: " + currentGifImages.Count;
        }

        #endregion

        #region Animated icon

        int iconIndex = 0;

        private void iconT_Tick(object sender, EventArgs e)
        {
            var icons = new Icon[3] {
                Properties.Resources.step1,
                Properties.Resources.step2,
                Properties.Resources.step3 };

            this.Icon = icons[iconIndex];

            iconIndex = iconIndex < icons.Length - 1 ? iconIndex + 1 : 0;
        }

        #endregion

        private void checkUpdatesTSMI_Click(object sender, EventArgs e)
        {
            new UpdateChecker.UpdateChecker(System.Reflection.Assembly.GetExecutingAssembly().Location, "gifm").Show();
        }
    }
}
