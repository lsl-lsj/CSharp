using System;
using System.IO;
using System.Text;

/*
 * IDosposable接口的应用
 */

namespace Demo07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using TextWriter tw = new TextWriter();
            tw.WriteText(".NET Core 3.1");
        }
    }

    internal class TextWriter : IDisposable
    {
        // 文件名
        private const string FILE_NAME = "demo07.txt";

        // 文件流
        private FileStream fs = null;

        public TextWriter()
        {
            //打开或者创建文件
            fs = File.OpenWrite(FILE_NAME);
        }

        public void WriteText(string str)
        {
            // 获取文本字节数
            byte[] date = Encoding.UTF8.GetBytes(str);
            // 将字节数组写入文件流
            fs.Write(date, 0, date.Length);
            // 将缓冲写入文件
            fs.Flush();
        }

        public void Dispose()
        {
            // 关闭文件流
            fs?.Close();
            // 释放资源
            fs?.Dispose();
        }
    }
}