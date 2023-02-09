using System.Data;
using System.Data.SqlClient;

namespace DisconnectedForms
{
    public partial class Form1 : Form
    {
        static string ConnectionString { get; set; } = "Data Source=DESKTOP-KNH15NM;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static string query = "select * from Teachers";

        static public SqlDataAdapter Adapter { get; set; } = new(query, ConnectionString);
        public DataSet Ds { get; set; } = new();
        public SqlCommandBuilder CommandBuilder { get; set; } = new(Adapter);

        public Form1()
        {
            InitializeComponent();
            Adapter.AcceptChangesDuringUpdate = true;
        }

        private void getData_Click(object sender, EventArgs e)
        {

            Adapter.Fill(Ds);

            dataGridView1.DataSource = Ds.Tables[0];
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            Adapter.UpdateCommand = CommandBuilder.GetUpdateCommand(); 
            Adapter.Update(Ds);
        }
    }
}