namespace ImageGUI
{
    partial class GUI
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
            if (disposing && (components != null))
            {
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
            this.previousImage = new System.Windows.Forms.Button();
            this.loadImage = new System.Windows.Forms.Button();
            this.nextImage = new System.Windows.Forms.Button();
            this.imagePlaceholder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePlaceholder)).BeginInit();
            this.SuspendLayout();
            // 
            // previousImage
            // 
            this.previousImage.Location = new System.Drawing.Point(80, 365);
            this.previousImage.Name = "previousImage";
            this.previousImage.Size = new System.Drawing.Size(75, 23);
            this.previousImage.TabIndex = 0;
            this.previousImage.Text = "<";
            this.previousImage.UseVisualStyleBackColor = true;
            this.previousImage.Click += new System.EventHandler(this.previousImage_Click);
            // 
            // loadImage
            // 
            this.loadImage.Location = new System.Drawing.Point(337, 365);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(75, 23);
            this.loadImage.TabIndex = 1;
            this.loadImage.Text = "Load";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextImage
            // 
            this.nextImage.Location = new System.Drawing.Point(647, 365);
            this.nextImage.Name = "nextImage";
            this.nextImage.Size = new System.Drawing.Size(75, 23);
            this.nextImage.TabIndex = 2;
            this.nextImage.Text = ">";
            this.nextImage.UseVisualStyleBackColor = true;
            this.nextImage.Click += new System.EventHandler(this.nextImage_Click);
            // 
            // imagePlaceholder
            // 
            this.imagePlaceholder.Location = new System.Drawing.Point(142, 27);
            this.imagePlaceholder.Name = "imagePlaceholder";
            this.imagePlaceholder.Size = new System.Drawing.Size(537, 248);
            this.imagePlaceholder.TabIndex = 3;
            this.imagePlaceholder.TabStop = false;
            this.imagePlaceholder.Click += new System.EventHandler(this.imagePlaceholder_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagePlaceholder);
            this.Controls.Add(this.nextImage);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.previousImage);
            this.Name = "GUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePlaceholder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousImage;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.Button nextImage;
        private System.Windows.Forms.PictureBox imagePlaceholder;
    }
}

