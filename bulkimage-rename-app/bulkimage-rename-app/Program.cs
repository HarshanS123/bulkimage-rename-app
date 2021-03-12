using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkimage_rename_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source Folder Path");
            string spath = Console.ReadLine();

            Console.WriteLine("Destination Folder Path");
            string savepath = Console.ReadLine();

            Console.WriteLine("Please Enter New Name");
            string text = Console.ReadLine();
            try
            {
                if (!spath.Equals("") && spath != null)
                {
                    if (!savepath.Equals("") && savepath != null)
                    {
                        if (!text.Equals("") && text != null)
                        {
                            DirectoryInfo d = new DirectoryInfo(spath);
                            FileInfo[] Files = d.GetFiles("*.jpg");

                            foreach (FileInfo file in Files)
                            {
                                var a = file.FullName.ToString().Split('\\').Last();
                                var newname = text.Trim() + a;
                                var path = savepath + '\\' + newname;
                                File.Move(file.FullName, path);
                            }


                        }

                    }

                }

                Console.WriteLine("........");
                Console.ReadLine();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
