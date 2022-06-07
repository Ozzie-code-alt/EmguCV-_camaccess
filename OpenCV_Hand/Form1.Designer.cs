namespace OpenCV_Hand
{
    partial class Form1
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
            this.picCam = new System.Windows.Forms.PictureBox();
            this.btnCap = new System.Windows.Forms.Button();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // picCam
            // 
            this.picCam.Location = new System.Drawing.Point(97, 108);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(273, 163);
            this.picCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCam.TabIndex = 0;
            this.picCam.TabStop = false;
            // 
            // btnCap
            // 
            this.btnCap.Location = new System.Drawing.Point(178, 345);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(75, 23);
            this.btnCap.TabIndex = 2;
            this.btnCap.Text = "Capture";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // picVideo
            // 
            this.picVideo.Location = new System.Drawing.Point(467, 108);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(273, 163);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideo.TabIndex = 3;
            this.picVideo.TabStop = false;
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(597, 345);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(75, 23);
            this.btnStream.TabIndex = 4;
            this.btnStream.Text = "Video";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(665, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 60);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.picVideo);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.picCam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.PictureBox picVideo;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnExit;
    }
}

