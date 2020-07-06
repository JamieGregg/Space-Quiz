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
    public partial class frm_helpScreen : Form
    {
        //Embedding Font for the title of the help screen
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        //Titles
        private PrivateFontCollection fontsTitle = new PrivateFontCollection();
        Font myFontTitle;
        //Standard Text
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

        public frm_helpScreen()
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
            myFont = new Font(fonts.Families[0], 17.0F);
            myFontTitle = new Font(fontsTitle.Families[0], 50.0F);
        }

        private void frm_helpScreen_Load(object sender, EventArgs e)
        {
            //Try-Catch to load the help screen text file
            try
            {
                string text = System.IO.File.ReadAllText("SpaceQuizHelp.txt");
                lbl_text.Text = text;
            }
            catch
            {
                lbl_text.Text = "Sorry the instructions cannot be loaded";
            }

            lbl_title.Font = myFontTitle;
            lbl_text.Font = myFont;
            
        }


        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            //Go to main menu
            Form nextForm = new frm_LogOn();
            this.Close();
            nextForm.Show();
        }
    }
}
