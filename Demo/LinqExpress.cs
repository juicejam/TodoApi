using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.DrawingCore;
using System.IO;

namespace Demo
{
    class LinqExpress
    {
        public void CallFunction()
        {
            //FontFamilySelect();
            GetDirectories();
        }

        public void Closure()
        {
            IEnumerable<char> query = "Not what you might expect";
            string vowels = "qeiou";
            for (int i = 0; i < vowels.Length; i++)
            {
                query = query.Where(c => c != vowels[i]);
            }
            foreach (char c in query)
            {
                Console.Write(c);
            }
        }

        public void FontFamilySelect()
        {
            IEnumerable<string> query = from f in FontFamily.Families
                                        select f.Name;
            foreach (string name in query) Console.WriteLine(name);
            Console.WriteLine("----------------------");
            var query2 = from f in FontFamily.Families
                        select new { f.Name, LineSpacing = f.GetLineSpacing(FontStyle.Bold) };
            foreach (var name in query2) Console.WriteLine(name);
        }

        public void GetDirectories()
        {
            DirectoryInfo[] dirs = new DirectoryInfo(@"E:\tools\book").GetDirectories();
            var query = from d in dirs
                        where (d.Attributes & FileAttributes.System) == 0
                        select new
                        {
                            DirectoryName = d.FullName,
                            Created = d.CreationTime,
                            Files = from f in d.GetFiles()
                                    where (f.Attributes & FileAttributes.Hidden) == 0
                                    select new { FileName = f.Name, f.Length }
                        };
            foreach (var dirFiles in query)
            {
                Console.WriteLine("Directory:" + dirFiles.DirectoryName);
                foreach (var file in dirFiles.Files)
                    Console.WriteLine(" " + file.FileName + " Len: " + file.Length);
            }
        }
    }
}
