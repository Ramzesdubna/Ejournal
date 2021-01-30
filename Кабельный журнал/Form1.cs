using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кабельный_журнал
{

   
    public partial class Form1 : Form
    {

        SqlConnection sqlConnect;


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Магистратура\Дисер\Ejournal\Кабельный журнал\Database.mdf;Integrated Security=True";
            sqlConnect = new SqlConnection(connectionString);

            await sqlConnect.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command1 = new SqlCommand("SELECT * FROM [Systems], [Buildings], [Rooms] HAVING COUNT(*)>1", sqlConnect);
            
            try
            {
                sqlReader = await command1.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    systemBox.Items.Add(Convert.ToString(sqlReader["Number_of_system"]) + " " + Convert.ToString(sqlReader["Name_of_system"]));
                    subsystemBox.Items.Add(Convert.ToString(sqlReader["Number_of_subsystem"]) + " " + Convert.ToString(sqlReader["Name_of_subsystem"]));
                    buildingBox.Items.Add(Convert.ToString(sqlReader["Building"]));
                    roomBox.Items.Add(Convert.ToString(sqlReader["Number_of_room"]));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void BtnEnterElement_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Results results = new Results();


            results.ShowDialog();

        }

    }  
}
