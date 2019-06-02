using System;

namespace String_Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             <summary>
                 <para>Using this for calling your characters to full length strings makes it harder for reader to know what strings are being called.</para>
                 <para>You can also add additional junk strings to further concealing your strings.</para>
                 <para>as well as encode each string character with a unique encoder</para>
             </summary>
            */
            #region ByteArray
            string cd = "Eo ipso";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(cd);
            string s = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);
            #endregion
            
            #region UniCharArray
            char[] q = new char[10];
            int c = 0;
            q[c++] = '\u00D0';
            q[c++] = '\u00B5';
            q[c++] = '\u00D0';
            q[c++] = '\u00D9';
            q[c++] = '\u008A';
            q[c++] = '\u00D9';
            q[c++] = '\u00D9';
            q[c++] = '\u00D2';
            q[c++] = '\u00D8';
            #endregion

            #region CharacterLiterals

            char[] chars = new char[4];

            chars[0] = 'X';        // Character literal
            chars[1] = '\x1101';   // Hexadecimal
            chars[2] = (char)8;    // Cast from integral type
            chars[3] = '\u0058';   // Unicode
            #endregion

            #region StringArray
            String[] weekDays = { "Mon", "Tues", "Wed", "Thurs" };
            #endregion

            #region SubtractStringLength
            string cmd = "meilleurs sentiments";
            cmd = cmd.Remove(0, 10);
            #endregion

            #region StringRemove
            string qq = "Lorem Ipsum";
            //Console.WriteLine(MyString.Remove(0, 2));
            #endregion

            //TODO Get string characters from a file and use them as strings.
            //Use many  files and streamreader and calling each character to string.
            //Call a string by spaces and line number like (#ofspaces,line#)
            Console.ReadLine();
        }
    }
}
