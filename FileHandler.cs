using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SecureTransferMI
{
    class FileHandler
    {
        public string final = "";
        public string final2 = "";
        public string embeddimage()
        {
            string s = Program.sep;
            //final = Program.cipher + "@#@#@#" + Program.orgimage + "@#@#@#" + Program.tarimage + "@#@#@#" + Program.omimage + "@#@#@#" + Program.tarimage + "@#@#@#" + Program.miximage;
           // final2 = final;
           


            return final;
        }

        public void revoke(string f)
        {
            string[] contents = f.Split(new string[] { "@#@#@#" }, StringSplitOptions.None);
            Program.cipher1 = contents[0];
            Program.miximage1 = contents[1];
            
        }




        //file format//
        /* 1-cip
         * 2-o
         * 3-t
         * 4-om
         * 5-tm
         * 6-mix
         * 
         
         
         */
    }
}
