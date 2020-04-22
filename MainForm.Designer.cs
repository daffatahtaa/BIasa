namespace Editor_Biasa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button grayscale;
            this.openImage = new System.Windows.Forms.Button();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.imageProperties = new System.Windows.Forms.Label();
            this.fileDirectory = new System.Windows.Forms.Label();
            this.directory = new System.Windows.Forms.TextBox();
            this.fileSize = new System.Windows.Forms.Label();
            this.sizeText = new System.Windows.Forms.TextBox();
            this.imagResolution = new System.Windows.Forms.Label();
            this.xText = new System.Windows.Forms.TextBox();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.yText = new System.Windows.Forms.TextBox();
            this.mouse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseX = new System.Windows.Forms.TextBox();
            this.mouseY = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.backColor = new System.Windows.Forms.PictureBox();
            this.rText = new System.Windows.Forms.Label();
            this.gText = new System.Windows.Forms.Label();
            this.bText = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Label();
            this.blue = new System.Windows.Forms.Label();
            this.cText = new System.Windows.Forms.Label();
            this.brighText = new System.Windows.Forms.Label();
            this.cScroll = new System.Windows.Forms.TrackBar();
            this.bScroll = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            grayscale = new System.Windows.Forms.Button();
            this.panelOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cScroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // openImage
            // 
            this.openImage.Location = new System.Drawing.Point(9, 20);
            this.openImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(44, 21);
            this.openImage.TabIndex = 1;
            this.openImage.Text = "Open";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // panelOutput
            // 
            this.panelOutput.AutoScroll = true;
            this.panelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOutput.Controls.Add(this.pbOutput);
            this.panelOutput.Location = new System.Drawing.Point(9, 413);
            this.panelOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(241, 261);
            this.panelOutput.TabIndex = 2;
            // 
            // pbOutput
            // 
            this.pbOutput.Location = new System.Drawing.Point(2, 2);
            this.pbOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 427);
            this.pbOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOutput.TabIndex = 3;
            this.pbOutput.TabStop = false;
            this.pbOutput.MouseEnter += new System.EventHandler(this.pbOutput_MouseEnter);
            // 
            // imageProperties
            // 
            this.imageProperties.AutoSize = true;
            this.imageProperties.Location = new System.Drawing.Point(263, 54);
            this.imageProperties.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imageProperties.Name = "imageProperties";
            this.imageProperties.Size = new System.Drawing.Size(86, 13);
            this.imageProperties.TabIndex = 4;
            this.imageProperties.Text = "Image Properties";
            // 
            // fileDirectory
            // 
            this.fileDirectory.AutoSize = true;
            this.fileDirectory.Location = new System.Drawing.Point(263, 89);
            this.fileDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileDirectory.Name = "fileDirectory";
            this.fileDirectory.Size = new System.Drawing.Size(68, 13);
            this.fileDirectory.TabIndex = 4;
            this.fileDirectory.Text = "File Directory";
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(366, 89);
            this.directory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directory.Name = "directory";
            this.directory.ReadOnly = true;
            this.directory.Size = new System.Drawing.Size(158, 20);
            this.directory.TabIndex = 5;
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Location = new System.Drawing.Point(263, 118);
            this.fileSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(46, 13);
            this.fileSize.TabIndex = 4;
            this.fileSize.Text = "File Size";
            // 
            // sizeText
            // 
            this.sizeText.Location = new System.Drawing.Point(366, 118);
            this.sizeText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeText.Name = "sizeText";
            this.sizeText.ReadOnly = true;
            this.sizeText.Size = new System.Drawing.Size(158, 20);
            this.sizeText.TabIndex = 5;
            // 
            // imagResolution
            // 
            this.imagResolution.AutoSize = true;
            this.imagResolution.Location = new System.Drawing.Point(263, 149);
            this.imagResolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imagResolution.Name = "imagResolution";
            this.imagResolution.Size = new System.Drawing.Size(89, 13);
            this.imagResolution.TabIndex = 4;
            this.imagResolution.Text = "Image Resolution";
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(381, 149);
            this.xText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xText.Name = "xText";
            this.xText.ReadOnly = true;
            this.xText.Size = new System.Drawing.Size(43, 20);
            this.xText.TabIndex = 5;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(364, 151);
            this.x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 13);
            this.x.TabIndex = 4;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(441, 151);
            this.y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(14, 13);
            this.y.TabIndex = 4;
            this.y.Text = "Y";
            // 
            // yText
            // 
            this.yText.Location = new System.Drawing.Point(458, 149);
            this.yText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yText.Name = "yText";
            this.yText.ReadOnly = true;
            this.yText.Size = new System.Drawing.Size(43, 20);
            this.yText.TabIndex = 5;
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Location = new System.Drawing.Point(263, 190);
            this.mouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(39, 13);
            this.mouse.TabIndex = 4;
            this.mouse.Text = "Mouse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y";
            // 
            // mouseX
            // 
            this.mouseX.Location = new System.Drawing.Point(381, 190);
            this.mouseX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mouseX.Name = "mouseX";
            this.mouseX.ReadOnly = true;
            this.mouseX.Size = new System.Drawing.Size(43, 20);
            this.mouseX.TabIndex = 5;
            // 
            // mouseY
            // 
            this.mouseY.Location = new System.Drawing.Point(458, 190);
            this.mouseY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mouseY.Name = "mouseY";
            this.mouseY.ReadOnly = true;
            this.mouseY.Size = new System.Drawing.Size(43, 20);
            this.mouseY.TabIndex = 5;
            // 
            // panelInput
            // 
            this.panelInput.AutoScroll = true;
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInput.Controls.Add(this.pbInput);
            this.panelInput.Location = new System.Drawing.Point(9, 54);
            this.panelInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(241, 261);
            this.panelInput.TabIndex = 2;
            // 
            // pbInput
            // 
            this.pbInput.Location = new System.Drawing.Point(2, 2);
            this.pbInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(243, 226);
            this.pbInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInput.TabIndex = 3;
            this.pbInput.TabStop = false;
            this.pbInput.MouseEnter += new System.EventHandler(this.pbInput_MouseEnter);
            this.pbInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbInput_MouseMove);
            // 
            // optionsBtn
            // 
            this.optionsBtn.Location = new System.Drawing.Point(346, 354);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(77, 24);
            this.optionsBtn.TabIndex = 6;
            this.optionsBtn.Text = "Options >>>";
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.options_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Location = new System.Drawing.Point(392, 7);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(49, 15);
            this.time.TabIndex = 7;
            this.time.Text = "timeText";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // backColor
            // 
            this.backColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backColor.Location = new System.Drawing.Point(263, 228);
            this.backColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(46, 50);
            this.backColor.TabIndex = 8;
            this.backColor.TabStop = false;
            // 
            // rText
            // 
            this.rText.AutoSize = true;
            this.rText.Location = new System.Drawing.Point(341, 228);
            this.rText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(21, 13);
            this.rText.TabIndex = 9;
            this.rText.Text = "R: ";
            // 
            // gText
            // 
            this.gText.AutoSize = true;
            this.gText.Location = new System.Drawing.Point(342, 254);
            this.gText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gText.Name = "gText";
            this.gText.Size = new System.Drawing.Size(21, 13);
            this.gText.TabIndex = 9;
            this.gText.Text = "G: ";
            // 
            // bText
            // 
            this.bText.AutoSize = true;
            this.bText.Location = new System.Drawing.Point(341, 283);
            this.bText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bText.Name = "bText";
            this.bText.Size = new System.Drawing.Size(20, 13);
            this.bText.TabIndex = 9;
            this.bText.Text = "B: ";
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(261, 279);
            this.hex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(24, 13);
            this.hex.TabIndex = 10;
            this.hex.Text = "hex";
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(364, 228);
            this.red.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(22, 13);
            this.red.TabIndex = 9;
            this.red.Text = "red";
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(364, 254);
            this.green.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(34, 13);
            this.green.TabIndex = 9;
            this.green.Text = "green";
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(364, 283);
            this.blue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(27, 13);
            this.blue.TabIndex = 9;
            this.blue.Text = "blue";
            // 
            // cText
            // 
            this.cText.AutoSize = true;
            this.cText.Location = new System.Drawing.Point(448, 526);
            this.cText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cText.Name = "cText";
            this.cText.Size = new System.Drawing.Size(13, 13);
            this.cText.TabIndex = 4;
            this.cText.Text = "0";
            // 
            // brighText
            // 
            this.brighText.AutoSize = true;
            this.brighText.Location = new System.Drawing.Point(448, 449);
            this.brighText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brighText.Name = "brighText";
            this.brighText.Size = new System.Drawing.Size(13, 13);
            this.brighText.TabIndex = 5;
            this.brighText.Text = "0";
            // 
            // cScroll
            // 
            this.cScroll.Location = new System.Drawing.Point(266, 526);
            this.cScroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cScroll.Maximum = 100;
            this.cScroll.Name = "cScroll";
            this.cScroll.Size = new System.Drawing.Size(178, 45);
            this.cScroll.TabIndex = 6;
            this.cScroll.TickFrequency = 5;
            this.cScroll.Value = 1;
            this.cScroll.Scroll += new System.EventHandler(this.cBar_Scroll);
            // 
            // bScroll
            // 
            this.bScroll.Location = new System.Drawing.Point(266, 449);
            this.bScroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bScroll.Maximum = 100;
            this.bScroll.Name = "bScroll";
            this.bScroll.Size = new System.Drawing.Size(178, 45);
            this.bScroll.TabIndex = 10;
            this.bScroll.TickFrequency = 5;
            this.bScroll.Value = 1;
            this.bScroll.Scroll += new System.EventHandler(this.bBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 425);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brightness";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 497);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contrast";
            // 
            // grayscale
            // 
            grayscale.Location = new System.Drawing.Point(438, 355);
            grayscale.Name = "grayscale";
            grayscale.Size = new System.Drawing.Size(75, 23);
            grayscale.TabIndex = 11;
            grayscale.Text = "Grayscale";
            grayscale.UseVisualStyleBackColor = true;
            grayscale.Click += new System.EventHandler(this.grayscale_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(532, 705);
            this.Controls.Add(grayscale);
            this.Controls.Add(this.cText);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.brighText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.cScroll);
            this.Controls.Add(this.bScroll);
            this.Controls.Add(this.green);
            this.Controls.Add(this.bText);
            this.Controls.Add(this.red);
            this.Controls.Add(this.gText);
            this.Controls.Add(this.rText);
            this.Controls.Add(this.backColor);
            this.Controls.Add(this.time);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.yText);
            this.Controls.Add(this.mouseX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xText);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeText);
            this.Controls.Add(this.mouse);
            this.Controls.Add(this.x);
            this.Controls.Add(this.imagResolution);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileDirectory);
            this.Controls.Add(this.imageProperties);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.openImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Editor Biasa";
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cScroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.Label imageProperties;
        private System.Windows.Forms.Label fileDirectory;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.TextBox sizeText;
        private System.Windows.Forms.Label imagResolution;
        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.TextBox yText;
        private System.Windows.Forms.Label mouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mouseX;
        private System.Windows.Forms.TextBox mouseY;
        public System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox backColor;
        private System.Windows.Forms.Label rText;
        private System.Windows.Forms.Label gText;
        private System.Windows.Forms.Label bText;
        private System.Windows.Forms.Label hex;
        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Label green;
        private System.Windows.Forms.Label blue;
        public System.Windows.Forms.Label cText;
        private System.Windows.Forms.TrackBar cScroll;
        private System.Windows.Forms.TrackBar bScroll;
        private System.Windows.Forms.Label brighText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

