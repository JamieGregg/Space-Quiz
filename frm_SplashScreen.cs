using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace SpaceQuiz
{
    public partial class frm_SplashScreen : Form
    {
        //Embedding Font for the title 
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        //Titles
        private PrivateFontCollection fontsTitle = new PrivateFontCollection();
        Font myFontTitle;
        //Standard Text
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

        public frm_SplashScreen()
        {
            InitializeComponent();

            //Embedding Fonts
            byte[] fontData = Properties.Resources.Humblle_Rought_Caps;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Humblle_Rought_Caps.Length);
            fontsTitle.AddMemoryFont(fontPtr, Properties.Resources.Humblle_Rought_Caps.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Humblle_Rought_Caps.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            //Creating Font Object
            myFont = new Font(fonts.Families[0], 15.0F);
            myFontTitle = new Font(fontsTitle.Families[0], 50.0F);
        }


        private void frm_SplashScreen_Load(object sender, EventArgs e)
        {
            pgb_splash.Minimum = 0;
            pgb_splash.Maximum = 120;
            tim_splash.Start();

            //Setting Fonts
            lbl_loadingMsg.Font = myFont;
            lbl_title.Font = myFontTitle;
        }
            

        private void pgb_splash_Click(object sender, EventArgs e)
        {

        }

        private void tim_Splash_Tick(object sender, EventArgs e)
        {
            //Setting the progress bar
                if (pgb_splash.Value < 120)
                    pgb_splash.Value++;
                else
                {
                    tim_splash.Stop();
                    Form nextForm = new frm_helpScreen();
                    this.Hide();
                    nextForm.Show();
                }

            //Code for the loading message below the progress bar
            if (pgb_splash.Value <= 50)
            {
                lbl_loadingMsg.Text = "Loading Planets...";
            }
            else if (pgb_splash.Value <= 100)
            {
                lbl_loadingMsg.Text = "Loading stars...";
            }
            else if (pgb_splash.Value <= 120)
            {
                lbl_loadingMsg.Location = new Point(257, 323);
                lbl_loadingMsg.Text = "Preparing for take off...";
            }
        }
        
       
    }
}
