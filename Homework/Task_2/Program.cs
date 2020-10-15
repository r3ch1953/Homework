using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBytes(new byte[][] { new byte[] { 1, 2, 3, 5, 7 }, new byte[] { 1, 2, 4, 9, 5 } }, "bytes.txt");
            foreach (var i in ReadBytes("bytes.txt"))
            {
                foreach (var j in i)
                {
                    Console.Write($"{j, 5}");
                }
                Console.WriteLine();
            }
        }

        static public void WriteBytes(byte[][] arr, string path)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, arr);
            }
        }

        static public byte[][] ReadBytes(string path)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var formatter = new BinaryFormatter();
                return (byte[][])formatter.Deserialize(fs);
            }
        }
    }
}
