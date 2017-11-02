namespace Gif_Maker
{
    partial class MainF
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveCurrentGifB = new System.Windows.Forms.Button();
            this.imgsToGifOFD = new System.Windows.Forms.OpenFileDialog();
            this.saveGifSFD = new System.Windows.Forms.SaveFileDialog();
            this.repeatL = new System.Windows.Forms.Label();
            this.repeatNUD = new System.Windows.Forms.NumericUpDown();
            this.repeatCB = new System.Windows.Forms.CheckBox();
            this.fpsNUD = new System.Windows.Forms.NumericUpDown();
            this.fpsRB = new System.Windows.Forms.RadioButton();
            this.intervalRB = new System.Windows.Forms.RadioButton();
            this.delayNUD = new System.Windows.Forms.NumericUpDown();
            this.infoL = new System.Windows.Forms.Label();
            this.endecodeP = new System.Windows.Forms.Panel();
            this.gifCreationGB = new System.Windows.Forms.GroupBox();
            this.imagesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.gifOptionsGB = new System.Windows.Forms.GroupBox();
            this.newCurrentGifB = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.gifTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeGifTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeGifTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.addImagesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.supportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gifToImgsOFD = new System.Windows.Forms.OpenFileDialog();
            this.saveImagesSFD = new System.Windows.Forms.SaveFileDialog();
            this.imageCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeSelectedTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addImagescmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.workingL = new System.Windows.Forms.Label();
            this.workingPB = new System.Windows.Forms.ProgressBar();
            this.iconT = new System.Windows.Forms.Timer(this.components);
            this.currentGifInfoL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).BeginInit();
            this.gifCreationGB.SuspendLayout();
            this.gifOptionsGB.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.imageCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveCurrentGifB
            // 
            this.saveCurrentGifB.Location = new System.Drawing.Point(189, 19);
            this.saveCurrentGifB.Name = "saveCurrentGifB";
            this.saveCurrentGifB.Size = new System.Drawing.Size(75, 23);
            this.saveCurrentGifB.TabIndex = 0;
            this.saveCurrentGifB.Text = "Guardar gif";
            this.saveCurrentGifB.UseVisualStyleBackColor = true;
            this.saveCurrentGifB.Click += new System.EventHandler(this.saveCurrentGifB_Click);
            // 
            // imgsToGifOFD
            // 
            this.imgsToGifOFD.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff|Todos los archivos|*";
            this.imgsToGifOFD.Multiselect = true;
            this.imgsToGifOFD.Title = "Elige las imágenes con las que quieras crear el gif";
            // 
            // saveGifSFD
            // 
            this.saveGifSFD.Filter = "Imagen animada|*.gif";
            this.saveGifSFD.Title = "Elige donde guardar el gif";
            // 
            // repeatL
            // 
            this.repeatL.AutoSize = true;
            this.repeatL.Location = new System.Drawing.Point(171, 86);
            this.repeatL.Name = "repeatL";
            this.repeatL.Size = new System.Drawing.Size(93, 13);
            this.repeatL.TabIndex = 14;
            this.repeatL.Text = "veces (0 = infinito)";
            // 
            // repeatNUD
            // 
            this.repeatNUD.Location = new System.Drawing.Point(84, 84);
            this.repeatNUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.repeatNUD.Name = "repeatNUD";
            this.repeatNUD.Size = new System.Drawing.Size(81, 20);
            this.repeatNUD.TabIndex = 13;
            // 
            // repeatCB
            // 
            this.repeatCB.AutoSize = true;
            this.repeatCB.Checked = true;
            this.repeatCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.repeatCB.Location = new System.Drawing.Point(6, 85);
            this.repeatCB.Name = "repeatCB";
            this.repeatCB.Size = new System.Drawing.Size(72, 17);
            this.repeatCB.TabIndex = 12;
            this.repeatCB.Text = "¿Repetir?";
            this.repeatCB.UseVisualStyleBackColor = true;
            this.repeatCB.CheckedChanged += new System.EventHandler(this.repeatCB_CheckedChanged);
            // 
            // fpsNUD
            // 
            this.fpsNUD.DecimalPlaces = 2;
            this.fpsNUD.Enabled = false;
            this.fpsNUD.Location = new System.Drawing.Point(115, 45);
            this.fpsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.fpsNUD.Name = "fpsNUD";
            this.fpsNUD.Size = new System.Drawing.Size(55, 20);
            this.fpsNUD.TabIndex = 11;
            this.fpsNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpsNUD.ValueChanged += new System.EventHandler(this.fpsNUD_ValueChanged);
            // 
            // fpsRB
            // 
            this.fpsRB.AutoSize = true;
            this.fpsRB.Location = new System.Drawing.Point(5, 45);
            this.fpsRB.Name = "fpsRB";
            this.fpsRB.Size = new System.Drawing.Size(104, 17);
            this.fpsRB.TabIndex = 10;
            this.fpsRB.Text = "Intervalo (en fps)";
            this.fpsRB.UseVisualStyleBackColor = true;
            this.fpsRB.CheckedChanged += new System.EventHandler(this.fpsRB_CheckedChanged);
            // 
            // intervalRB
            // 
            this.intervalRB.AutoSize = true;
            this.intervalRB.Checked = true;
            this.intervalRB.Location = new System.Drawing.Point(6, 19);
            this.intervalRB.Name = "intervalRB";
            this.intervalRB.Size = new System.Drawing.Size(103, 17);
            this.intervalRB.TabIndex = 9;
            this.intervalRB.TabStop = true;
            this.intervalRB.Text = "Intervalo (en ms)";
            this.intervalRB.UseVisualStyleBackColor = true;
            // 
            // delayNUD
            // 
            this.delayNUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.delayNUD.Location = new System.Drawing.Point(115, 19);
            this.delayNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delayNUD.Name = "delayNUD";
            this.delayNUD.Size = new System.Drawing.Size(55, 20);
            this.delayNUD.TabIndex = 8;
            this.delayNUD.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.delayNUD.ValueChanged += new System.EventHandler(this.delayNUD_ValueChanged);
            // 
            // infoL
            // 
            this.infoL.AutoSize = true;
            this.infoL.Location = new System.Drawing.Point(12, 24);
            this.infoL.Name = "infoL";
            this.infoL.Size = new System.Drawing.Size(189, 26);
            this.infoL.TabIndex = 15;
            this.infoL.Text = "Arrastra aquí un gif para decodificiarlo\r\no arrastra varias imágenes para crearlo" +
    "";
            // 
            // endecodeP
            // 
            this.endecodeP.AllowDrop = true;
            this.endecodeP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.endecodeP.BackColor = System.Drawing.SystemColors.ControlDark;
            this.endecodeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endecodeP.Location = new System.Drawing.Point(10, 59);
            this.endecodeP.Name = "endecodeP";
            this.endecodeP.Size = new System.Drawing.Size(200, 200);
            this.endecodeP.TabIndex = 16;
            this.endecodeP.DragDrop += new System.Windows.Forms.DragEventHandler(this.endecodeP_DragDrop);
            this.endecodeP.DragEnter += new System.Windows.Forms.DragEventHandler(this.endecodeP_DragEnter);
            // 
            // gifCreationGB
            // 
            this.gifCreationGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gifCreationGB.Controls.Add(this.imagesFLP);
            this.gifCreationGB.Location = new System.Drawing.Point(218, 24);
            this.gifCreationGB.Name = "gifCreationGB";
            this.gifCreationGB.Size = new System.Drawing.Size(420, 120);
            this.gifCreationGB.TabIndex = 17;
            this.gifCreationGB.TabStop = false;
            this.gifCreationGB.Text = "Gif actual";
            // 
            // imagesFLP
            // 
            this.imagesFLP.AllowDrop = true;
            this.imagesFLP.AutoScroll = true;
            this.imagesFLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesFLP.Location = new System.Drawing.Point(3, 16);
            this.imagesFLP.Name = "imagesFLP";
            this.imagesFLP.Size = new System.Drawing.Size(414, 101);
            this.imagesFLP.TabIndex = 0;
            this.imagesFLP.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.imagesFLP_ControlAdded);
            this.imagesFLP.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.imagesFLP_ControlAdded);
            this.imagesFLP.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagesFLP_DragDrop);
            this.imagesFLP.DragEnter += new System.Windows.Forms.DragEventHandler(this.endecodeP_DragEnter);
            this.imagesFLP.Enter += new System.EventHandler(this.imagesFLP_Enter);
            this.imagesFLP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.imagesFLP_PreviewKeyDown);
            // 
            // gifOptionsGB
            // 
            this.gifOptionsGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gifOptionsGB.Controls.Add(this.newCurrentGifB);
            this.gifOptionsGB.Controls.Add(this.intervalRB);
            this.gifOptionsGB.Controls.Add(this.delayNUD);
            this.gifOptionsGB.Controls.Add(this.saveCurrentGifB);
            this.gifOptionsGB.Controls.Add(this.repeatL);
            this.gifOptionsGB.Controls.Add(this.fpsRB);
            this.gifOptionsGB.Controls.Add(this.repeatNUD);
            this.gifOptionsGB.Controls.Add(this.fpsNUD);
            this.gifOptionsGB.Controls.Add(this.repeatCB);
            this.gifOptionsGB.Location = new System.Drawing.Point(221, 149);
            this.gifOptionsGB.Name = "gifOptionsGB";
            this.gifOptionsGB.Size = new System.Drawing.Size(275, 110);
            this.gifOptionsGB.TabIndex = 18;
            this.gifOptionsGB.TabStop = false;
            this.gifOptionsGB.Text = "Opciones de nuevo gif";
            // 
            // newCurrentGifB
            // 
            this.newCurrentGifB.Location = new System.Drawing.Point(189, 45);
            this.newCurrentGifB.Name = "newCurrentGifB";
            this.newCurrentGifB.Size = new System.Drawing.Size(75, 23);
            this.newCurrentGifB.TabIndex = 1;
            this.newCurrentGifB.Text = "Nuevo gif";
            this.newCurrentGifB.UseVisualStyleBackColor = true;
            this.newCurrentGifB.Click += new System.EventHandler(this.newCurrentGifB_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gifTSMI,
            this.helpTSMI});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(650, 24);
            this.menuStrip.TabIndex = 19;
            // 
            // gifTSMI
            // 
            this.gifTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encodeGifTSMI,
            this.decodeGifTSMI,
            this.tss1,
            this.addImagesTSMI,
            this.saveCurrentTSMI});
            this.gifTSMI.Name = "gifTSMI";
            this.gifTSMI.Size = new System.Drawing.Size(34, 20);
            this.gifTSMI.Text = "Gif";
            // 
            // encodeGifTSMI
            // 
            this.encodeGifTSMI.Name = "encodeGifTSMI";
            this.encodeGifTSMI.Size = new System.Drawing.Size(227, 22);
            this.encodeGifTSMI.Text = "Crear nuevo gif";
            this.encodeGifTSMI.Click += new System.EventHandler(this.encodeGifTSMI_Click);
            // 
            // decodeGifTSMI
            // 
            this.decodeGifTSMI.Name = "decodeGifTSMI";
            this.decodeGifTSMI.Size = new System.Drawing.Size(227, 22);
            this.decodeGifTSMI.Text = "Decodificar gif";
            this.decodeGifTSMI.Click += new System.EventHandler(this.decodeGifTSMI_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(224, 6);
            // 
            // addImagesTSMI
            // 
            this.addImagesTSMI.Name = "addImagesTSMI";
            this.addImagesTSMI.Size = new System.Drawing.Size(227, 22);
            this.addImagesTSMI.Text = "Añadir imágenes al gif actual";
            this.addImagesTSMI.Click += new System.EventHandler(this.addImagesTSMI_Click);
            // 
            // saveCurrentTSMI
            // 
            this.saveCurrentTSMI.Name = "saveCurrentTSMI";
            this.saveCurrentTSMI.Size = new System.Drawing.Size(227, 22);
            this.saveCurrentTSMI.Text = "Guardar gif actual";
            this.saveCurrentTSMI.Click += new System.EventHandler(this.saveCurrentTSMI_Click);
            // 
            // helpTSMI
            // 
            this.helpTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTSMI,
            this.checkUpdatesTSMI});
            this.helpTSMI.Name = "helpTSMI";
            this.helpTSMI.Size = new System.Drawing.Size(53, 20);
            this.helpTSMI.Text = "Ayuda";
            // 
            // supportTSMI
            // 
            this.supportTSMI.Name = "supportTSMI";
            this.supportTSMI.Size = new System.Drawing.Size(218, 22);
            this.supportTSMI.Text = "Soporte";
            this.supportTSMI.Click += new System.EventHandler(this.supportTSMI_Click);
            // 
            // checkUpdatesTSMI
            // 
            this.checkUpdatesTSMI.Name = "checkUpdatesTSMI";
            this.checkUpdatesTSMI.Size = new System.Drawing.Size(218, 22);
            this.checkUpdatesTSMI.Text = "Comprobar actualizaciones";
            this.checkUpdatesTSMI.Click += new System.EventHandler(this.checkUpdatesTSMI_Click);
            // 
            // gifToImgsOFD
            // 
            this.gifToImgsOFD.Filter = "Imagen animada|*.gif|Todos los archivos|*";
            this.gifToImgsOFD.Title = "Elige el gif que desees decodificar";
            // 
            // saveImagesSFD
            // 
            this.saveImagesSFD.Filter = "Imagen PNG|*.png|Imagen JPG|*.jpg;*.jpeg|Imagen GIF|*.gif|Imagen BMP|*.bmp|Imagen" +
    " TIFF|*.tif;*.tiff";
            this.saveImagesSFD.Title = "Elige donde guardar las imágenes decodificadas";
            // 
            // imageCMS
            // 
            this.imageCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeSelectedTSMI,
            this.addImagescmsTSMI});
            this.imageCMS.Name = "imageCMS";
            this.imageCMS.Size = new System.Drawing.Size(202, 70);
            // 
            // removeSelectedTSMI
            // 
            this.removeSelectedTSMI.Name = "removeSelectedTSMI";
            this.removeSelectedTSMI.Size = new System.Drawing.Size(201, 22);
            this.removeSelectedTSMI.Text = "Eliminar seleccionada(s)";
            this.removeSelectedTSMI.Click += new System.EventHandler(this.removeSelectedTSMI_Click);
            // 
            // addImagescmsTSMI
            // 
            this.addImagescmsTSMI.Name = "addImagescmsTSMI";
            this.addImagescmsTSMI.Size = new System.Drawing.Size(201, 22);
            this.addImagescmsTSMI.Text = "Añadir imágen(es)";
            this.addImagescmsTSMI.Click += new System.EventHandler(this.addImagesTSMI_Click);
            // 
            // workingL
            // 
            this.workingL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.workingL.AutoSize = true;
            this.workingL.Location = new System.Drawing.Point(502, 214);
            this.workingL.Name = "workingL";
            this.workingL.Size = new System.Drawing.Size(109, 13);
            this.workingL.TabIndex = 21;
            this.workingL.Text = "Sin tareas pendientes";
            // 
            // workingPB
            // 
            this.workingPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.workingPB.Location = new System.Drawing.Point(502, 230);
            this.workingPB.Name = "workingPB";
            this.workingPB.Size = new System.Drawing.Size(133, 23);
            this.workingPB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.workingPB.TabIndex = 22;
            // 
            // iconT
            // 
            this.iconT.Enabled = true;
            this.iconT.Interval = 200;
            this.iconT.Tick += new System.EventHandler(this.iconT_Tick);
            // 
            // currentGifInfoL
            // 
            this.currentGifInfoL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentGifInfoL.AutoSize = true;
            this.currentGifInfoL.Location = new System.Drawing.Point(503, 168);
            this.currentGifInfoL.Name = "currentGifInfoL";
            this.currentGifInfoL.Size = new System.Drawing.Size(108, 13);
            this.currentGifInfoL.TabIndex = 23;
            this.currentGifInfoL.Text = "Imágenes actuales: 0";
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 271);
            this.Controls.Add(this.currentGifInfoL);
            this.Controls.Add(this.workingPB);
            this.Controls.Add(this.workingL);
            this.Controls.Add(this.gifOptionsGB);
            this.Controls.Add(this.gifCreationGB);
            this.Controls.Add(this.endecodeP);
            this.Controls.Add(this.infoL);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(666, 310);
            this.Name = "MainF";
            this.Text = "Creador de gifs";
            ((System.ComponentModel.ISupportInitialize)(this.repeatNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).EndInit();
            this.gifCreationGB.ResumeLayout(false);
            this.gifOptionsGB.ResumeLayout(false);
            this.gifOptionsGB.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.imageCMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveCurrentGifB;
        private System.Windows.Forms.OpenFileDialog imgsToGifOFD;
        private System.Windows.Forms.SaveFileDialog saveGifSFD;
        private System.Windows.Forms.Label repeatL;
        private System.Windows.Forms.NumericUpDown repeatNUD;
        private System.Windows.Forms.CheckBox repeatCB;
        private System.Windows.Forms.NumericUpDown fpsNUD;
        private System.Windows.Forms.RadioButton fpsRB;
        private System.Windows.Forms.RadioButton intervalRB;
        private System.Windows.Forms.NumericUpDown delayNUD;
        private System.Windows.Forms.Label infoL;
        private System.Windows.Forms.Panel endecodeP;
        private System.Windows.Forms.GroupBox gifCreationGB;
        private System.Windows.Forms.FlowLayoutPanel imagesFLP;
        private System.Windows.Forms.GroupBox gifOptionsGB;
        private System.Windows.Forms.Button newCurrentGifB;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gifTSMI;
        private System.Windows.Forms.ToolStripMenuItem encodeGifTSMI;
        private System.Windows.Forms.ToolStripMenuItem decodeGifTSMI;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripMenuItem addImagesTSMI;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentTSMI;
        private System.Windows.Forms.ToolStripMenuItem helpTSMI;
        private System.Windows.Forms.ToolStripMenuItem supportTSMI;
        private System.Windows.Forms.OpenFileDialog gifToImgsOFD;
        private System.Windows.Forms.SaveFileDialog saveImagesSFD;
        private System.Windows.Forms.ContextMenuStrip imageCMS;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedTSMI;
        private System.Windows.Forms.ToolStripMenuItem addImagescmsTSMI;
        private System.Windows.Forms.Label workingL;
        private System.Windows.Forms.ProgressBar workingPB;
        private System.Windows.Forms.Timer iconT;
        private System.Windows.Forms.Label currentGifInfoL;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesTSMI;
    }
}

