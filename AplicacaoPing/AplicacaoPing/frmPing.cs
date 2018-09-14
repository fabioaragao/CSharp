using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace AplicacaoPing
{
    public partial class frmPing : Form
    {
        public frmPing()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping1 = new Ping();
                PingReply resp = ping1.Send(txtHost.Text);
                txtIpHost.Text = Convert.ToString(resp.Address);
                if (Convert.ToString(resp.Status) == "Success")
                {
                    txtStatus.Text = "Ativo";
                }
                else
                {
                    txtStatus.Text = "Inativo";
                }
            }
            catch ( Exception ex)
            {
                txtStatus.Text = "Host não encontrado";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtHost.Clear();
            txtIpHost.Clear();
            txtStatus.Clear();
        }
    }
}
