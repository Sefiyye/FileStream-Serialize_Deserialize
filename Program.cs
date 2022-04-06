using System;
using System.IO;

namespace Serialize_and_Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(@"C:\Users\User\Desktop\AP204Directory", "text.txt");
            string path = @"C:\Users\User\Desktop\AP204Directory";
            string anotherPath=Path.Combine(@"C:\Users\User\Desktop\AP204Directory", "AP-204");
            string datasFilePath = Path.Combine(@"C:\Users\User\Desktop\AP204Directory", "AP-204", "datas.txt");
            string ShexsiFilePath1 = Path.Combine(@"C:\Users\User\Desktop\AP204Directory", "AP-204", "shexsi");
            //StreamWriter streamWriter = new StreamWriter(datasFilePath, true);
            //for (int i = 0; i < 5; i++)
            //{
            //    streamWriter.WriteLine("Product" + i);
            //}
            //streamWriter.Write("Hello world");

            //StreamReader streamReader = new StreamReader(datasFilePath);
            //string data = streamReader.ReadToEnd();
            //Console.WriteLine(data);
            //streamWriter.Close();
            using (StreamWriter streamWriter = new StreamWriter(datasFilePath, true)) 
                {
                for (int i = 0; i < 5; i++)
                {
                    streamWriter.WriteLine("Product" + i);
                }
                } 

            using (StreamReader streamReader = new StreamReader(datasFilePath))
            {
                string data = streamReader.ReadToEnd();
                Console.WriteLine(data);
            }
            //streamWriter.Flush();
            //Directory.CreateDirectory(anotherPath);
            //File.Create(filePath);
            //File.Create(datasFilePath);
            //File.Create(ShexsiFilePath1);

            //foreach (var item in Directory.GetDirectories(@"C:\Users\User\Desktop\AP204Directory"))
            //{
            //    Console.WriteLine(item);
            //}

            //Directory.Delete(path, true);
            //if (File.Exists(filePath))
            //{
            //    File.Delete(filePath);
            //}
            //else
            //{
            //    Console.WriteLine("Bele bir fayl yoxdur");
            //}

        }
    }
}
