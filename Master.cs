using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Lame;
using NAudio.Wave;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication1
{
    public static class Master
    {
        public static void ConvertwavTomp3(string input, string output)
        {
            using (var r = new AudioFileReader(input))
            using (var w = new LameMP3FileWriter(output, r.WaveFormat, 128))
                r.CopyTo(w);

            var info = new ProcessStartInfo
            {
               
                FileName = Path.GetDirectoryName(output),
                UseShellExecute = true


            };
            Process.Start(info);
        }
    }
}
