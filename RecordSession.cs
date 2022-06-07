using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using System.Threading;
// reference: https://www.youtube.com/watch?v=q9cRZuosrOs
namespace WindowsFormsApplication1
{
    public partial class RecordSession : Form
    {
        MMDeviceEnumerator mm = null;

        public static RecordSession instatiation;

        RecordSave rs;

        public string songname = "";
        public string datepro = "";
        public bool edited = false;
        public RecordSession()
        {
            InitializeComponent();
            instatiation = this;
            
            mm = new MMDeviceEnumerator();
            btnSave.Enabled = false;

        }
       
        
        private void RecordSession_Load(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;


        }
        string filename = "";
        private void btnRecord_Click(object sender, EventArgs e)
        {
            deviceIndex = 1;

            diaSave.Filter = "Wave files | *,wav";

            if (diaSave.ShowDialog() != DialogResult.OK) return;

            filename = diaSave.FileName;

            
            
            rs = new RecordSave(filename);
            if(rs!=null)
            {
                btnRecord.Enabled = false;
                btnSave.Enabled = true;
            }
            rs.Record();
            

        }
 
        private void btnSave_Click(object sender, EventArgs e)
        {
            deviceIndex = -1;
            try
            {
                
                rs.StopRecording();
                btnRecord.Enabled = true;
                SongDBQuery.Save(new Song() { SongName = filename.Substring(filename.LastIndexOf('\\') + 1), DateProduced = DateTime.Now.ToString(), Edited = false });
            }
            catch
            {
                MessageBox.Show("Error in saving the track... Please record again!");
            }

            btnSave.Enabled = false;
            btnPlay.Enabled = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            deviceIndex = 0;
            if(rs!= null)
               rs.Play();
            btnRecord.Enabled = true; ;
            btnSave.Enabled = false;
        }
        private int deviceIndex = -1;
        private void tmrRecord_Tick(object sender, EventArgs e)
        {
            var multidevice = mm.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            if(mm != null&&deviceIndex!=-1)
            {
                prbarDectection.Value = (int)(multidevice[deviceIndex].AudioMeterInformation.MasterPeakValue * 100);
            }
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            
        }

        private void RecordSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(rs!=null)
              rs.Disposable();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
