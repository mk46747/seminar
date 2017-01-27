using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace NannyApp.DAL
{
    public static class Logger
    {
        public static void Log(Exception e)
        {

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

            
            System.IO.StreamWriter file = File.AppendText(path);
            file.Write(e.Message +" \n" + e.Source+ "\n " + e.StackTrace);

            file.Close();

        }
         public static void Log(string text)
        {

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs.txt");

            
            System.IO.StreamWriter file = File.AppendText(path);
            file.Write("\n" + text + "\n");

            file.Close();

        }
    }
}
