using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using index.Forms;
using System.IO;

namespace index
{
    
    public partial class MoviegestHomePageForm : Form 
    {
        private FavoriteMoviesManagement Business;
        public MoviegestHomePageForm()
        {
            InitializeComponent();
            this.btnExit.Click += LlExit_Click;
            this.btnBrowseForMovies.Click += btnBrowseForMovies_Click;
            
        }

        void btnBrowseForMovies_Click(object sender, EventArgs e)
        {
            var btnBrowseForMovies = new BrowseMoviesForm();
            btnBrowseForMovies.ShowDialog();
        }

        void LlExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("System warning! Do you want to exit. Confirm if you want to exit", "Exit form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it again", ex);
            }
        }

        private void btnBrowseForMovies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void MoviegestHomePageForm_Load(object sender, EventArgs e)
        {

            try
            {
                this.loadJson();                
            }
            catch(Exception ez)
            {
                Console.WriteLine(ez.Message.ToString());
            }
            
            //this.reportViewer1.RefreshReport();
        }

        public void loadJson()
        {
            try
            {
                StreamReader stringx = new StreamReader(@"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\recommendedList3.txt");
                string data = stringx.ReadToEnd();
                this.rtxtRecommend2.Text = data;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Business.callPython();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }
    }
}
