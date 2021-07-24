using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mesh_Network
{
    public partial class MessageText : Form
    {
        string msgText = "";
        public MessageText()
        {
            InitializeComponent();
        }

        private void btnAbbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSenden_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!String.IsNullOrWhiteSpace(this.tbText.Text))
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sie haben keinen Text eingegeben!\n"+ ex, "Fehler!", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                
            }
            finally 
            {
                msgText = this.tbText.Text;
                this.Close();
            }

        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
