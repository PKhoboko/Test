using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Mastering : Form
    {
        List<Song> lstSongs = new List<Song>();
        public Mastering()
        {
            
            InitializeComponent();
            lstSongs = SongDBQuery.GetSongs();
            if(lstSongs.Count>0)
            {
                foreach (Song s in lstSongs)
                {

                    if (s.SongName.Substring(s.SongName.IndexOf('.'), 4) == ".mp3" && Convert.ToBoolean(s.Edited) == true)
                    {
                        lstbxMaster.Items.Add(s);
                    }
                    else
                        if(s.SongName.Substring(s.SongName.IndexOf('.'), 4) == ".wav" && Convert.ToBoolean(s.Edited) == true)
                    {
                        lstbxUnMaster.Items.Add(s);
                    }

                }
            }
            

        }
        string sSong = "";
        string Mp3 = "";
        private void btnMp3_Click(object sender, EventArgs e)
        {
            int i = lstbxUnMaster.SelectedIndex;
            if ((sSong = lstSongs.ToArray()[i].SongName).Length>0)
            {
                Mp3 = sSong.Remove(lstSongs.ToArray()[1].SongName.IndexOf('.')) + "MP3Converted.mp3";
                Master.ConvertwavTomp3(sSong, "C:\\Users\\u21824772\\Documents\\COS730\\u21824772_Assignment3- COS730\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug\\" + Mp3);

                Song s = new Song() { SongName = Mp3, DateProduced = lstSongs.ToArray()[i].DateProduced, Edited = lstSongs.ToArray()[i].Edited };

                if (SongDBQuery.Save(s))
                    lstbxMaster.Items.Add(s);
                else
                    MessageBox.Show("Error could not convert save the converted mp3 to the database, contact your IT administrator");
                lstbxMaster.ClearSelected();
                lstbxUnMaster.ClearSelected();
            }
            else
            {
                MessageBox.Show("Please select a song to convert... in the unmastered list");
            }
            

        }
        private BlockAlignReductionStream stream = null;
        private void PlayMp3(string songname)
        {
            WaveStream ws = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(songname));
            stream = new BlockAlignReductionStream(ws);
            output = new DirectSoundOut();
            output.Init(stream);

            output.Play();
        }
        private void PlayWav(string songname)
        {
            wreader = new WaveFileReader(songname);

            output = new DirectSoundOut();
            output.Init(new WaveChannel32(wreader));

            output.Play();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private WaveFileReader wreader = null;
        private DirectSoundOut output = null;
        private void btnPlay_Click(object sender, EventArgs e)
        {
           

            if (lstbxMaster.SelectedItem != null)
            {
                lstbxUnMaster.ClearSelected();
                PlayMp3(((Song)lstbxMaster.SelectedItem).SongName);
            }
                                 
               
            if (lstbxUnMaster.SelectedItem != null)
            {
                lstbxMaster.ClearSelected();
                PlayWav(((Song)lstbxUnMaster.SelectedItem).SongName);
            }
                
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(output.PlaybackState==PlaybackState.Playing)
            {
                output.Pause();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(output.PlaybackState==PlaybackState.Playing)
            {
                output.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clean();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Clean()
        {
            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                 output.Dispose();
                output = null;
            }
               
            if (wreader != null)
            {
                wreader.Dispose();
                wreader = null;
            }
                
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
                

        }

        private void Mastering_FormClosed(object sender, FormClosedEventArgs e)
        {
            Clean();
        }
    }
}
