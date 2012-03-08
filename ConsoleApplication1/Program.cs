using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//programme changes directories' and files' names
//if directories' and files' names names contains "_", it replaces "_" to "-"
namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        
        {
            DirectoryInfo parent = new DirectoryInfo(@"C:\Users\dell\Desktop\abc");

            foreach (DirectoryInfo child in parent.GetDirectories())
            {
                string newName = child.FullName.Replace('_', '-');

                if (newName != child.FullName)
                {
                    child.MoveTo(newName);
                }
            }
            foreach (FileInfo child in parent.GetFiles())
            {
                string newName = child.FullName.Replace('_', '-');

                if (newName != child.FullName)
                {
                    child.MoveTo(newName);
                }
            }
                    
        }
    }
    
}
