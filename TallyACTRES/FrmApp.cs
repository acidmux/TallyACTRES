using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace TallyACTRES
{
    public partial class FrmApp : Form
    {
        Dictionary<string, string> _data = new Dictionary<string, string>() {
            { "mirror.tallysolutions.com", "127.0.0.1"},
            { "bssdev2.tallysolutions.com", "127.0.0.1"},
            { "experts.tallysolutions.com", "127.0.0.1"},
            { "message.tallysolutions.com", "127.0.0.1"},
            { "licensing.tallysolutions.com", "127.0.0.1"},
            { "tallynet.tallyenterprise.com", "127.0.0.1"},
            { "tipl.tallysolutions.com", "127.0.0.1"},
        };
        public FrmApp()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                foreach (string each in ReadHosts())
                {
                    if (!_data.Keys.Contains(each.Replace("\t", " ").Split(' ').Last().Trim()))
                    {
                        list.Add(each);
                    }
                }
                foreach (var each in _data)
                {
                    list.Add($"{each.Value}  {each.Key}");
                }
                WriteHosts(list.ToArray());
                MessageBox.Show("Successfully applied", "Woo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to apply", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnreserve_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                foreach (string each in ReadHosts())
                {
                    if (!_data.Keys.Contains(each.Replace("\t", " ").Split(' ').Last().Trim()))
                    {
                        list.Add(each);
                    }
                }
                WriteHosts(list.ToArray());
                MessageBox.Show("Successfully applied", "Woo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to apply", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string[] ReadHosts()
        {
            return System.IO.File.ReadAllLines(@"C:\Windows\System32\drivers\etc\hosts");
        }
        private void WriteHosts(string[] lines)
        {
            System.IO.File.WriteAllLines(@"C:\Windows\System32\drivers\etc\hosts", lines);
        }
    }
}
