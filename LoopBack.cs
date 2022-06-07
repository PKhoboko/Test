using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.ComponentModel;
using System.Data;


namespace WindowsFormsApplication1
{
    class LoopBack
    {

         

        public static List<WaveInCapabilities> Loop()
        {
            List<WaveInCapabilities> sources = new List<WaveInCapabilities>();
            for (int i = 0; i < WaveIn.DeviceCount; i++)
            {
                sources.Add(WaveIn.GetCapabilities(i));
            }

            return sources;
            
        }
       
    }
}
