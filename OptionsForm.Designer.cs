namespace Editor_Biasa
{
    partial class OptionsForm
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
            if (disposing && ( components != null )) {
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
            this.hist1 = new System.Windows.Forms.Button();
            this.hist2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hist1
            // 
            this.hist1.Location = new System.Drawing.Point(9, 10);
            this.hist1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hist1.Name = "hist1";
            this.hist1.Size = new System.Drawing.Size(72, 23);
            this.hist1.TabIndex = 0;
            this.hist1.Text = "Histogram 1";
            this.hist1.UseVisualStyleBackColor = true;
            this.hist1.Click += new System.EventHandler(this.hist1_Click);
            // 
            // hist2
            // 
            this.hist2.Location = new System.Drawing.Point(113, 10);
            this.hist2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hist2.Name = "hist2";
            this.hist2.Size = new System.Drawing.Size(72, 23);
            this.hist2.TabIndex = 0;
            this.hist2.Text = "Histogram 2";
            this.hist2.UseVisualStyleBackColor = true;
            this.hist2.Click += new System.EventHandler(this.hist2_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 51);
            this.Controls.Add(this.hist2);
            this.Controls.Add(this.hist1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hist1;
        private System.Windows.Forms.Button hist2;
    }
}