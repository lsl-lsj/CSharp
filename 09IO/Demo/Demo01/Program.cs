using System;
using System.IO;
using System.IO.Compression;
/*
* ZipArchive创建Zip压缩文件
*/
namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string zipFile = "demo.zip";
            using(FileStream fs = File.Create(zipFile))
            {
                using(ZipArchive za = new ZipArchive(fs, ZipArchiveMode.Create))
                {
                    // 第一个文件
                    ZipArchiveEntry zae1 = za.CreateEntry(@"docs/doc1.txt");
                    using(Stream s = zae1.Open())
                    {
                        using(StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write("示例文档A");
                        }
                    }

                    // 第二个文件
                    ZipArchiveEntry zae2 = za.CreateEntry(@"docs/doc2.txt");
                    using(Stream s = zae2.Open())
                    {
                        using(StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write("示例文档B");
                        }
                    }

                    // 第三个文件
                    ZipArchiveEntry zae3 = za.CreateEntry(@"docs/doc3.txt");
                    using(Stream s = zae3.Open())
                    {
                        using(StreamWriter sw = new StreamWriter(s))
                        {
                            sw.Write("示例文档C");
                        }
                    }
                }
            }

            // 解压压缩文件
            using(FileStream fs = File.OpenRead(zipFile))
            {
                using(ZipArchive za = new ZipArchive(fs))
                {
                    foreach (ZipArchiveEntry zae in za.Entries)
                    {
                        using(Stream s = zae.Open()) 
                        {
                         using(FileStream fss = File.Create(zae.Name))
                            {
                                s.CopyTo(fss);
                            }   
                        }
                    }
                }
            }
        }
    }
}
