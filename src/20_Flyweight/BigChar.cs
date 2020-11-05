using System;
using System.IO;

namespace Flyweight
{
    public class BigChar
    {
        private char charname;
        private String fontdata;

        public BigChar(char charname)
        {
            this.charname = charname;

            String pass = String.Format("..\\..\\..\\Fryweightpt\\Fryweightpt\\Fryweightpt\\inputTxt\\big{0}.txt", this.charname);

            try
            {
                System.IO.StreamReader reader = (new System.IO.StreamReader(pass, System.Text.Encoding.Default));

                String line;

                while ((line = reader.ReadLine()) != null)
                {
                    fontdata += line + "\n";

                }
            }
            catch (IOException e)
            {
                this.fontdata = charname + "?";
            }
        }

        public void print()
        {
            Console.Write(fontdata);
        }
    }
}
