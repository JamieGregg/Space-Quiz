using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SpaceQuiz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_SplashScreen());
        }
        public static void SaveObject(PlayerCollection thisObject)
        {
            //Saving an object
            Stream sw;
            BinaryFormatter bf = new BinaryFormatter();
            sw = File.Open("mydata.bin", FileMode.Create);
            bf.Serialize(sw, thisObject);
            sw.Close();
        }

        public static void LoadObject(ref PlayerCollection thisObject)
        {
            //loading an object
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            sr = File.OpenRead("mydata.bin");
            thisObject = (PlayerCollection)bf.Deserialize(sr);
            sr.Close();
        }


    }
}
