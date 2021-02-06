using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace index.Forms
{
    public partial class UpdateMovieForm : Form
    {
        private int movieId;
        private FavoriteMoviesManagement Business;
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
        SqlCommand command;
        //string str = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\augus\OneDrive\Documents\moviegestDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public UpdateMovieForm(int id)
        {
            InitializeComponent();
            this.movieId = id;
            this.Business = new FavoriteMoviesManagement();
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnCancel.Click += BtnCancel_Click;
            this.Load += UpdateMovieForm_Load;
        }

        void UpdateMovieForm_Load(object sender, EventArgs e)
        {
            //this.txtId.Text = movieId.ToString();
            //this.txtBudget.Text = this.Business.movie;
            var db = new moviegestDBEntities1();

            //this.grdDB.DataSource = db.movie_dataset_fixed.SqlQuery("Select * from movie_dataset_fixed where title like (" + this.txtSearch.Text + ")");
            //this.grdDB.DataSource = db.movie_dataset_fixed.Where(p => p.title.Equals(this.txtSearch.Text)).ToList();
            //string sqlSELECT = "SELECT * FROM movie_dataset_fixed where title like ("+this.txtSearch.Text+")";
            if (this.txtId.Text.Equals(""))
            {
                return;
            }
            else
            {
                command = connection.CreateCommand();
                command.CommandText = "UPDATE movie_dataset_fixed SET  where id like ('%" + this.txtId.Text + "%')";
                adapter.SelectCommand = command;
                
            }
           //b this.txtBudget = 
            
            //throw new NotImplementedException();
        }

        void btnUpdate_Click(object sender, EventArgs e)
        {
            
            
            
            //throw new NotImplementedException();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult Cancel;
            try
            {
                Cancel = MessageBox.Show("System warning! The process is being performed, are you sure want to cancel? Confirm if you want to cancel", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Cancel == DialogResult.Yes)
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
