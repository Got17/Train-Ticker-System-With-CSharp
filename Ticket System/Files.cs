using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_System
{

    internal class Files
    {
        static public void Save(string fileOfName, string inputStr)
        {
            StreamWriter writeFile = new StreamWriter(fileOfName, true, Encoding.Unicode);
            writeFile.WriteLine(inputStr);
            writeFile.Close();
        }
        static public string Open(string fileOfName)
        {
            StreamReader readFile = new StreamReader(fileOfName);
            string text = string.Empty;
            while (!readFile.EndOfStream)
            {
                text += readFile.ReadLine() + "\n";
            }
            readFile.Close();
            return text;
        }
    }
}
