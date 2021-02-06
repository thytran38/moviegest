using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Linq;
using System.Data.ProviderBase;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;


namespace index.Forms
{
    public partial class BrowseMoviesForm : Form
    {
        private FavoriteMoviesManagement Business;
        private string MovieTitle;
        public int movieID;
        //private bool isEmpty = true;
        //SqlConnection connection = new;

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public List<string> favoriteCollection = new List<string>();
        public BrowseMoviesForm()
        {
            InitializeComponent();
            this.Business = new FavoriteMoviesManagement();
            this.MovieTitle = this.txtSearch.Text;
            this.Load +=BrowseMoviesForm_Load;
            this.btnSearch.Click += btnSearch_Click;
            this.grdDB.DoubleClick += grdDB_DoubleClick;
            this.grdDB.CellClick += grdDB_CellClick;
            this.btnCancel.Click += btnCancel_Click;
            
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Cancel;
            try
            {
                Cancel = MessageBox.Show("Are you sure want to Cancel? Confirm if you want to Cancel", "Cancel Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Cancel == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                throw new ApplicationException("System error! Please check it agian", ex);
            }
        }

        void btnAddToFavorite_Click(object sender, EventArgs e)
        {
            if (grdDB.SelectedCells.Count > 0)
            {
                MovieTitle = grdDB.SelectedRows[0].Cells[13].Value + string.Empty;
                favoriteCollection.Add(MovieTitle + "\n");
            }
            //throw new NotImplementedException();
        }

        void btnRec_Click(object sender, EventArgs e)
        {

            //this.Business.callPython();
            //var recommendForm = new recommendedMoviesForm();
            //recommendForm.ShowDialog();
            //throw new NotImplementedException();
        }

        void grdDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdDB.SelectedCells.Count > 0)
            {
                MovieTitle = grdDB.SelectedRows[0].Cells[13].Value + string.Empty;
                this.txtTest.Text = MovieTitle;
            }

            System.IO.File.WriteAllText(@"C:\Users\augus\source\repos\moviegest01\moviegest\index\index\Logic\Python\argv.txt", MovieTitle);
            
            
            //throw new NotImplementedException();
        }

        void grdDB_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdDB.SelectedRows.Count == 1)
            {
                int a = 0;
                a = Int32.Parse(this.grdDB.SelectedRows[0].Cells[3].Value + string.Empty);
                var updateform = new UpdateMovieForm(a);
                updateform.ShowDialog();
                this.ViewAnyMovies();

            }
            //throw new NotImplementedException();
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            this.ViewAnyMovies();            
            //throw new NotImplementedException();
        }

        private void ViewAnyMovies()
        {
            var db = new moviegestDBEntities1();

            //this.grdDB.DataSource = db.movie_dataset_fixed.SqlQuery("Select * from movie_dataset_fixed where title like (" + this.txtSearch.Text + ")");
            //this.grdDB.DataSource = db.movie_dataset_fixed.Where(p => p.title.Equals(this.txtSearch.Text)).ToList();
            //string sqlSELECT = "SELECT * FROM movie_dataset_fixed where title like ("+this.txtSearch.Text+")";
            if(this.txtSearch.Text.Equals(""))
            {
                return;
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM movie_dataset_fixed where title like ('%" + this.txtSearch.Text + "%')";
                adapter.SelectCommand = command;
                //command.ExecuteNonQuery();
                //table.Clear();
                adapter.Fill(table);
                grdDB.DataSource = table;
            }
            
            
        }
       
        

        private void BtnSave_Click(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

       
        private void BtnAddToFavorite_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            
            
            //throw new NotImplementedException();
        }

        private void BrowseMoviesForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                this.ViewAnyMovies();
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void BrowseMoviesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void clearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(grdDB.Rows.Count==0)
            {
                return;
            }
            StringBuilder stringbuild = new StringBuilder();
            string columnsHeader = "";
           for (int i = 0; i < grdDB.Columns.Count; i++)
           {
               columnsHeader += grdDB.Columns[i].Name + ",";
           }
           stringbuild.Append(columnsHeader + Environment.NewLine);
             foreach (DataGridViewRow grd in grdDB.Rows)
           {
               if (!grd.IsNewRow)
               {
                   for (int c = 0; c < grd.Cells.Count; c++)
                   {
                       stringbuild.Append(grd.Cells[c].Value + ",");
                   }
                   stringbuild.Append(Environment.NewLine);
               }
           }
            
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 3;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using(System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName,false))
                {
                    sw.WriteLine(stringbuild.ToString());
                }
            }
            MessageBox.Show("CSV file saved.");
        }

        private void deleteARecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (DataGridViewRow item in this.grdDB.SelectedRows)
            {
                grdDB.Rows.RemoveAt(item.Index);
            }
        }
    }
}
