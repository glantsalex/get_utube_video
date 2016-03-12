using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ytDdownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void btnGetVideoInfo_Click(object sender, EventArgs e)
        {
            cmbFormats.Items.Clear();
            
            var videoFormats = m_utProvider.getVideoFormats(txtVideoId.Text.Trim());
            m_selectedVideoId  = videoFormats.Item1;
            videoFormats.Item2.ForEach( format => cmbFormats.Items.Add( format ) );
            
            cmbFormats.SelectedIndex = 0;
        }

        private readonly ytProvider m_utProvider = new ytProvider();
        private string m_selectedVideoId;

        private void button1_Click(object sender, EventArgs e)
        {
            Action cb = completionCallback;

            m_utProvider.downloadVideo(m_selectedVideoId, cmbFormats.SelectedItem.ToString(), cb);
        }

        private void completionCallback()
        {
            Action cb = () => 
            {
                MessageBox.Show("download completed.");
            };
            this.BeginInvoke(cb);
        }
    }
}
