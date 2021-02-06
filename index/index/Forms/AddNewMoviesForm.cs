using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index.Forms
{
    public partial class AddNewMoviesForm : Form
    {
        public AddNewMoviesForm()
        {
            InitializeComponent();
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Cancel;
            try
            {
                Cancel = MessageBox.Show("System warning! The process is being performed, are you sure want to cancel. Confirm if you want to cancel", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(Cancel == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }
    }
}
