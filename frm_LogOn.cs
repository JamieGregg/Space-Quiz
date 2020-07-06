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
    public partial class frm_LogOn : Form
    {
        PlayerCollection collectPlayer;
        PlayerInformation newPlayer;

        //Embedding Font
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        //Titles
        private PrivateFontCollection fontsTitle = new PrivateFontCollection();
        Font myFontTitle;
        //Standard Text
        private PrivateFontCollection fonts = new PrivateFontCollection();

        public frm_LogOn()
        {
            InitializeComponent();

            //Trying to load the player data
            try
            {
                Program.LoadObject(ref collectPlayer);
            }
            catch 
            {
                collectPlayer = new PlayerCollection();
            }

            newPlayer = new PlayerInformation();

            //Embedding Fonting the font for the title of the log on page
            byte[] fontData = Properties.Resources.Humblle_Rought_Caps;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Humblle_Rought_Caps.Length);
            fontsTitle.AddMemoryFont(fontPtr, Properties.Resources.Humblle_Rought_Caps.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Humblle_Rought_Caps.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            //Creating Font Object
            myFontTitle = new Font(fontsTitle.Families[0], 50.0F);
        }

        private void frm_LogOn_Load(object sender, EventArgs e)
        {
            //Setting the title to the embedded font
            lbl_title.Font = myFontTitle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_LogOn_Click(object sender, EventArgs e)
        {
            PlayerInformation exsistingPlayer = collectPlayer.GetPlayer(txt_username.Text);
            lbl_passwordError.Visible = false;
            lbl_usernameError.Visible = false;

            //Validating the textboxes 
            if (string.IsNullOrWhiteSpace(this.txt_username.Text))
            {
                lbl_usernameError.Text = "This field is required";
                lbl_usernameError.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.txt_password.Text))
            {
                lbl_passwordError.Text = "This field is required";
                lbl_passwordError.Visible = true;
            }

            else if (exsistingPlayer == null)
            {
                lbl_usernameError.Text = "This username does not exist";
                lbl_usernameError.Visible = true;
            }
            else if (exsistingPlayer.Password != txt_password.Text)
            {
                lbl_passwordError.Text = ("Incorrect password... Try again");
                lbl_passwordError.Visible = true;
                txt_password.Text = "";
            }
            else
            {
                //move to the next form
                Form nextForm = new frm_MainMenu(ref exsistingPlayer);
                this.Hide();
                nextForm.Show();
            }
        }
        

        private void btn_showPassword_MouseHover(object sender, EventArgs e)
        {
            // Setting the password text so it is visable
            txt_password.PasswordChar = '\0';
        }

        private void btn_showPassword_MouseLeave(object sender, EventArgs e)
        {
            // Setting the password text so it stars out password
            txt_password.PasswordChar = '*';
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            PlayerInformation exsistingPlayer = collectPlayer.GetPlayer(txt_username.Text);
            lbl_passwordError.Visible = false;
            lbl_usernameError.Visible = false;

            //Validating a new player
            if (string.IsNullOrWhiteSpace(this.txt_username.Text))
            {
                lbl_usernameError.Text = "This field is required";
                lbl_usernameError.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.txt_password.Text))
            {
                lbl_passwordError.Text = "This field is required";
                lbl_passwordError.Visible = true;
            }
            else if (exsistingPlayer != null)
            {
                lbl_usernameError.Text = "Sorry this username has already been taken";
                lbl_usernameError.Visible = true;
            }
            else if (txt_username.TextLength < 4 || txt_username.TextLength > 12)
            {
                lbl_usernameError.Text = "Usernames must be between 4-12 characters";
                lbl_usernameError.Visible = true;
            }
            else if (txt_password.TextLength < 4)
            {
                lbl_passwordError.Text = "Password is too short... Try again";
                lbl_passwordError.Visible = true;
            }
            else
            {
                //Registering the user
                newPlayer.Username = txt_username.Text;
                newPlayer.Password = txt_password.Text;

                collectPlayer.AddPlayer(ref newPlayer);
                Program.SaveObject(collectPlayer);

                //move to the next form
                Form nextForm = new frm_MainMenu(ref newPlayer);
                this.Close();
                nextForm.Show();
            }
        }
    }
}
        

        

    

