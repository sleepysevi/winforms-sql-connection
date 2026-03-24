using System.Drawing.Text;
using TestWins.Controller;

namespace TestWins;

public partial class Form1 : Form
{
    //business

    private readonly StudentController controller = new StudentController();
    public Form1()
    {
        InitializeComponent();
        loadData();
    }

    private void loadData()
    {
        dataGridView1.DataSource = controller.getAll();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {



    }

    private void dataGridView1_CellClick(object sender, EventArgs e)
    {

    }
}
