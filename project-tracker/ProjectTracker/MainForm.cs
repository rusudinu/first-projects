using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace ProjectTracker
{
    public partial class MainForm : Form
    {
        #region smth smth
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void hideControls()
        {
            loginPanel.Hide();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            hideControls();

        }

        private void swapPicturesLoginButton_Tick(object sender, EventArgs e)
        {
            pictureLoginButtonCounter++;
            if (pictureLoginButtonCounter == 1) loginButtonPictureBox.Image = Properties.Resources.LBF1;
            else if (pictureLoginButtonCounter == 2) loginButtonPictureBox.Image = Properties.Resources.LBF2;
            else if (pictureLoginButtonCounter == 3) loginButtonPictureBox.Image = Properties.Resources.LBF3;
            else if (pictureLoginButtonCounter == 4) loginButtonPictureBox.Image = Properties.Resources.LBF4;
            else if (pictureLoginButtonCounter == 5) loginButtonPictureBox.Image = Properties.Resources.LBF5;
            else if (pictureLoginButtonCounter == 6) loginButtonPictureBox.Image = Properties.Resources.LBF6;
            else if (pictureLoginButtonCounter == 7)
            {
                swapPicturesLoginButtonTimer.Stop();
                loginButtonPictureBox.Image = Properties.Resources.LBF7;
                pictureLoginButtonCounter = 1;
            }
        }

        public int pictureLoginButtonCounter = 1;
        public bool animating = false;

        private void loginButtonPictureBox_Click(object sender, EventArgs e)
        {
            if (loginPanel.Visible == false) loginPanel.Show();
            else loginPanel.Hide();
        }

        private void loginButtonPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (animating == false)
            {
                animating = true;
                swapPicturesLoginButtonTimer.Start();
            }

        }


        private void loginButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureLoginButtonCounter = 1;
            animating = false;
            loginButtonPictureBox.Image = Properties.Resources.LoginButtonSimple;
        }

#endregion

        public int pictureAboutButtonCounter = 1;

        private void aboutButtonPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (animating == false)
            {
                animating = true;
                swapPicturesAboutButton.Start();
            }
            else
            {

            }
        }

        private void swapPicturesAboutButton_Tick(object sender, EventArgs e)
        {
            pictureAboutButtonCounter++;
            if (pictureAboutButtonCounter > 11) swapPicturesAboutButton.Stop();
            
                if (pictureAboutButtonCounter == 1) { aboutButtonPictureBox.Image = Properties.Resources.ABF1; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 2) { aboutButtonPictureBox.Image = Properties.Resources.ABF2; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 3) { aboutButtonPictureBox.Image = Properties.Resources.ABF3; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 4) { aboutButtonPictureBox.Image = Properties.Resources.ABF4; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 5) { aboutButtonPictureBox.Image = Properties.Resources.ABF5; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 6) { aboutButtonPictureBox.Image = Properties.Resources.ABF6; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 7) { aboutButtonPictureBox.Image = Properties.Resources.ABF7; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 8) { aboutButtonPictureBox.Image = Properties.Resources.ABF8; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 9) { aboutButtonPictureBox.Image = Properties.Resources.ABF9; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureAboutButtonCounter == 10) { aboutButtonPictureBox.Image = Properties.Resources.ABF10; Console.WriteLine(pictureAboutButtonCounter); }
                else if (pictureLoginButtonCounter == 11)
                {
                    
                }
            if (pictureAboutButtonCounter == 11)
            {
                Console.WriteLine(pictureAboutButtonCounter);
                swapPicturesAboutButton.Stop();
                aboutButtonPictureBox.Image = Properties.Resources.ABF11;
                pictureAboutButtonCounter = 1;
            }
        }

        private void aboutButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureAboutButtonCounter = 1;
            swapPicturesAboutButton.Stop();
            animating = false;
            aboutButtonPictureBox.Image = Properties.Resources.ABF1;
        }
    }
}