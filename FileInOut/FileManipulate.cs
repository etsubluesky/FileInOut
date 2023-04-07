using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInOut
{
    public class FileManipulate
    {

        public static string RootOfProject = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.ToString();

        public FileMode Mode { get; set; }

        public FileAccess Access { get; set; }

        public string FileLocation { get; set; }

        public FileStream Stream { get; set; }

        public FileManipulate(string location, FileMode mode = FileMode.Append, FileAccess access = FileAccess.Write)
        {
            this.Mode = mode;
            this.Access = access;
            this.FileLocation = RootOfProject + location;
            Stream = new FileStream(FileLocation, this.Mode, this.Access);
            
        }
        public void AddALine(string line)
        {   
            Writer.WriteLine(line); 
        }

        public void Close()
        {
            Stream.Close();
        }

        public string CreateACopyOfTheFile()
        {
           


            List<string> lines = new List<string>();
             
            while (!Writer.)
            {
                lines.Add(reader.ReadLine());

            }

            string fileName = DateTime.Now + ".csv";

            StreamWriter writer = new StreamWriter(new FileStream(RootOfProject + $"/Data/{fileName}", FileMode.Create, FileAccess.Write));

            foreach (string line in lines) 
            {
                writer.WriteLine(line);
            }

            writer.Close();

            return fileName;
        }
    }
}
