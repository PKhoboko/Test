using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProToolsDashBoard : Form
    {
        public ProToolsDashBoard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit_Session es = new Edit_Session();
            es.Show();
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            RecordSession c = new RecordSession();
            c.Show();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            Mastering m = new Mastering();
            m.Show();
        }
    }
}
