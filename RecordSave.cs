using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class RecordSave
    {
      

        private WaveIn wavein = null;
        private DirectSoundOut wOut = null;
        List<WaveInCapabilities> sources=null;
        WaveFileWriter writer = null;

        private string FileName_ { get; set; }
         
        public RecordSave(string filename)
        {
            sources = LoopBack.Loop();
            FileName_ = filename;
        }

        WaveInEvent e_ = null;
        public void Record()
        {
             e_ = new WaveInEvent();
            e_.WaveFormat = new WaveFormat(4100, WaveIn.GetCapabilities(0).Channels);
            e_.DataAvailable += Wave_DataAvailable;
            e_.RecordingStopped += RecordingStopped;

            //wavein = new WaveIn();
            //wavein.WaveFormat = new WaveFormat(44100, WaveIn.GetCapabilities(0).Channels);
            //wavein.DataAvailable += Wave_DataAvailable;
            //wavein.RecordingStopped+= RecordingStopped;
            writer = new WaveFileWriter(FileName_, e_.WaveFormat);
            WaveInProvider wIn = new WaveInProvider(e_);

            wOut = new DirectSoundOut();
            wOut.Init(wIn);

            e_.StartRecording();

        }
        public void Disposable()
        {
            if (wOut != null)
            {
                wOut.Stop();
                wOut.Dispose();
                wOut = null;

            }
            if(wavein != null)
            {
                e_.Dispose();
                e_ = null;
            }
        }


        public void StopRecording()
        {
           
            if (e_ != null)
            {
                e_.StopRecording();
                if (FileName_ == null)
                    return;
                var processInfo = new ProcessStartInfo
                {
                    FileName = Path.GetDirectoryName(FileName_),
                    UseShellExecute = true
                };
                Process.Start(processInfo);

            }

           

           
        }
        public void Play()
        {
            if (wOut != null)
                wOut.Play();
        }
        private void Wave_DataAvailable(object sender, WaveInEventArgs e)
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }
        private void RecordingStopped(object sender, StoppedEventArgs e)
        {
            writer.Dispose();
        }
    }
}
