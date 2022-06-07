using Emgu.CV;
using Emgu.CV.Structure; // namespace for bgr
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCV_Hand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
             // setting default cam on parameter, index may grow on the amount of webcam
            var img = _capture.QueryFrame().ToImage<Bgr, byte>(); // query frame is a frunction used to capture image
            var bmp = img.Bitmap;
            picCam.Image = bmp;
        }
        bool _streaming;
        Capture _capture = new Capture(0);
        private void btnStream_Click(object sender, EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming;
                btnStream.Text = " Stop STreaming";

                
            }
            else
            {
                Application.Idle -= streaming;
                btnStream.Text = " Start STreaming";
            }
            _streaming = !_streaming;
        }
        private void streaming(object sender, System.EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>(); // query frame is a frunction used to capture image
            var bmp = img.Bitmap;
            picVideo.Image = bmp;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _streaming = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
