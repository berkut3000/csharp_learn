﻿using System;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        long offset = 0x500000; // 20 megabytes
        long length = 0xA00000; // 10 megabytes
        // Assumes another process has created the memory-mapped file.
        using (var mmf = MemoryMappedFile.OpenExisting("ImgA"))
        {
            using (var accessor = mmf.CreateViewAccessor(offset, length))
            {
                int colorSize = Marshal.SizeOf(typeof(MyColor));
                MyColor color;

                // Make changes to the view.
                for (long i = 0; i < 0xA00000; i += colorSize)
                {
                    accessor.Read(i, out color);
                    color.Brighten(20);
                    accessor.Write(i, ref color);
                }
            }
        }
    }
}

public struct MyColor
{
    public short Red;
    public short Green;
    public short Blue;
    public short Alpha;

    // Make the view brigher.
    public void Brighten(short value)
    {
        Red = (short)Math.Min(short.MaxValue, (int)Red + value);
        Green = (short)Math.Min(short.MaxValue, (int)Green + value);
        Blue = (short)Math.Min(short.MaxValue, (int)Blue + value);
        Alpha = (short)Math.Min(short.MaxValue, (int)Alpha + value);
    }
}