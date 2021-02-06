using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace index.Forms
{
    public partial class recommendedMoviesForm : Form
    {
        public recommendedMoviesForm()
        {
            InitializeComponent();
            this.Load += recommendedMoviesForm_Load;
        }

        

        public void loadJson()
        {
            try
            {
                StreamReader stringx = new StreamReader(@"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\recommendedList3.txt");
                string data = stringx.ReadToEnd();
                this.rtxtRecommend.Text = data;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        void recommendedMoviesForm_Load(object sender, EventArgs e)
        {

            this.loadJson();
            //this.rtxtBox.DataBindings
            //throw new NotImplementedException();
        }
    }
}
