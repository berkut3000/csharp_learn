using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        long offset = 0xA00000; // 10 megabytes
        long length = 0xA00000; // 10 megabytes

        // Create the memory-mapped file.
        using (var mmf = MemoryMappedFile.CreateFromFile(@"C:\Users\hydro\csharp_platzi\MemorySharedPersistent\ExtremelyLargeData.bmp", FileMode.Open,"ImgA"))
        {
            // Create a random access view, from the 256th megabyte (the offset)
            // to the 768th megabyte (the offset plus length).
            using (var accessor = mmf.CreateViewAccessor(offset, length))
            {
                int colorSize = Marshal.SizeOf(typeof(MyColor));
                MyColor color;

                // Make changes to the view.
                for (long i = 0; i < length; i += colorSize)
                {
                    accessor.Read(i, out color);
                    color.Brighten(10);
                    accessor.Write(i, ref color);
                }
            }
            Console.WriteLine("Awaiting Input");
            Console.ReadLine();
        }
    }
}

public struct MyColor
{
    public short Red;
    public short Green;
    public short Blue;
    public short Alpha;

    // Make the view brighter.
    public void Brighten(short value)
    {
        Red = (short)Math.Min(short.MaxValue, (int)Red + value);
        Green = (short)Math.Min(short.MaxValue, (int)Green + value);
        Blue = (short)Math.Min(short.MaxValue, (int)Blue + value);
        Alpha = (short)Math.Min(short.MaxValue, (int)Alpha + value);
    }
}