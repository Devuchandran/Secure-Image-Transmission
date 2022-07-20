using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SecureTransferMI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string OrginalFilePath = "";
      
        public static string TargetFilePath = "";
        public static string binary = "";
        public static string Targetmosaicvalue= "";

        public static string diffs = "";
        public static string enc = "";
        public static string sep = "@#@#@#";


        public static string orgimage = "";
        public static string tarimage = "";
        public static string omimage = "";
        public static string tmimage = "";
        public static string miximage = "";
        public static string cipher = "";


        public static string orgimage1 = "";
        public static string tarimage1 = "";
        public static string omimage1 = "";
        public static string tmimage1 = "";
        public static string miximage1 = "";
        public static string cipher1 = "";

        public static Bitmap om;
        public static Bitmap tm;

        public static string recvfile = "";

        public static string uname1 = "";
        public static string suspectid = "";
        public static double ww = 0;

        public static string id1="";
       
        [STAThread]

        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
