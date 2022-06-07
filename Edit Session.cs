using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace WindowsFormsApplication1
{
    public partial class Edit_Session : Form
    {
        private List<Song> lstSongs;
        int h, m, s;
        
        public Edit_Session()
        {
            InitializeComponent();
        }
      
        private WaveFileReader wreader = null;
        private DirectSoundOut output = null;
        bool isActive;
        private void Edit_Session_Load(object sender, EventArgs e)
        {
            s = 0;
            m = 0;
            h = 0;

            isActive = false;
            lstSongs = SongDBQuery.GetSongs();
            if (lstSongs.Count > 0)
            {
                foreach (Song s in lstSongs)
                {
                    if (Convert.ToBoolean(s.Edited) == false)
                    {
                       lstNotEdited  .Items.Add(s);
                    }
                    if (Convert.ToBoolean(s.Edited) == true)
                    {
                        lstbxEdited.Items.Add(s);
                    }

                }
            }




        }

        private void btnTrimEnd_Click(object sender, EventArgs e)
        {
            txtTrimEnd.Text = txtTimer.Text;
            DisplayTime(txtTrimStart.Text);
        }

        private void Edit_Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(output!=null)
            {
                if (output.PlaybackState == PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if(wreader != null)
            {
                wreader.Dispose();
                wreader = null;
            }
         
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if(isActive)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                {
                    s++;
                    if (s >= 60)
                    {
                        m++;
                        s = 0;
                    }
                    if (m >= 60)
                    {
                        h++;
                        m = 0;
                    }
                    trckbProgress.Value = s + (m * 60) + (h * 60);
                }
               
                  
               
            }
            if (isActive)
            {
                if (s>=wreader.TotalTime.Seconds&&m>=wreader.TotalTime.Minutes&&h>=wreader.TotalTime.Hours)
                {
                    tmrProgress.Enabled = false;
                    output.Stop();
                    isActive = false;
                }
            }
               
            DisplayTime(txtTimer.Text);
           
            
        }

        private void DisplayTime(string textbox)
        {
          textbox = txtTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            

           
            if(lstNotEdited.SelectedItem!=null)
            {
                isActive = true;
                string s = ((Song)lstNotEdited.SelectedItem).SongName;
                wreader = new WaveFileReader(s);

                trckbProgress.Maximum = (wreader.TotalTime.Minutes * 60) + wreader.TotalTime.Seconds;
                trckbProgress.Minimum = 0;

                output = new DirectSoundOut();
                output.Init(new WaveChannel32(wreader));

                output.Play();
            }
            else
            {
                MessageBox.Show("Please select a song in unedited list!");
            }
           
        }

        private void trckbProgress_Scroll(object sender, EventArgs e)
        {
            if(isActive != true)
            {
                h = trckbProgress.Value / 3600;
                s = trckbProgress.Value % 3600;
                m = trckbProgress.Value / 60;
                s += trckbProgress.Value % 60;
                DisplayTime(txtTimer.Text);

            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (output.PlaybackState == PlaybackState.Playing)
            {
                
                isActive = false;
                output.Pause();
            }
                
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string pathin = txtTrimStart.Text;
            string pathout = txtTrimEnd.Text;
            Song s = null;
            if (lstSongs.Count>0)
            {
                string sSong = ((Song)lstNotEdited.SelectedItem).SongName.Replace(" ","");
                int i = lstNotEdited.SelectedIndex;
                string newSong = sSong.Remove(sSong.IndexOf('.')) + "Edited.wav";


                try
                {

                    EditWave.TrimWavFile(sSong, "C:\\Users\\u21824772\\Documents\\COS730\\u21824772_Assignment3- COS730\\WindowsFormsApplication1\\WindowsFormsApplication1\\bin\\Debug" + newSong,
                        new TimeSpan(int.Parse(pathin.Substring(0, 2)), int.Parse(pathin.Substring(3, 2)), int.Parse(pathin.Substring(6, 2))),
                       new TimeSpan(int.Parse(pathin.Substring(0, 2)), int.Parse(pathin.Substring(3, 2)), int.Parse(pathin.Substring(6, 2))));
                           s = new Song() { SongName = newSong, DateProduced = lstSongs.ToArray()[i].DateProduced, Edited = true };
                        if (SongDBQuery.Save(s))
                        {
                            lstSongs.Add(s);
                            MessageBox.Show("Have Successfull trimmed a song!");
                        }


                }
                catch
                {
                    if (s != null)
                        lstSongs.Remove(s);
                    MessageBox.Show("The song choosen could not be trimmed, please select another one!");

                }

                foreach(Song song in lstSongs)
                {
                    lstbxEdited.Items.Add(song);
                }



            }
            else
            {
                MessageBox.Show("There are no songs in the databse, go to the recording page to record a sound audio");
            }
            
            
        }

       
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtTrimStart.Text = txtTimer.Text;
            DisplayTime(txtTrimStart.Text);
     
        }
    }
}
