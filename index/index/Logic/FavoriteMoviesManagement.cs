using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.ProviderBase;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using IronPython;
using System.Diagnostics;
using IronPython.Hosting;


namespace index
{
    
    public class FavoriteMoviesManagement
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        string pythonfilePath = @"C:\Users\augus\PycharmProjects\RecommendationSystem\model.py";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void DeleteMovie()
        {

        }

        public void AddToFavorite()
        {

        }


        public void callPython()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //process.StartInfo.FileName = @"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\__pycache__\model.cpython-37";
            process.StartInfo.Arguments = "/C python model.py";
            process.Start();

           

        }

        public void callPython2()
        {
            
            var engine = Python.CreateEngine();
            dynamic py = engine.ExecuteFile(@"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\model.py");
            //proc.StartInfo.FileName = @"C:\Users\augus\AppData\Local\Programs\Python\Python37\python.exe";
            //proc.StartInfo.RedirectStandardOutput = true;
            //proc.StartInfo.UseShellExecute = false;
            //var progToRun = @"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\model.py";
            //proc.StartInfo.Arguments = string.Format("{0}", progToRun);
            //proc.Start();


        }

        

    }
}
