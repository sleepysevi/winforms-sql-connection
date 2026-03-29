using TestWins.Controller;
using TestWins.Model;

namespace TestWins;

public partial class Form1 : Form
{
    private readonly StudentController controller = new StudentController();

    public Form1()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        dataGridView1.DataSource = controller.GetAll();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            var student = new Student
            {
                Name   = txtName.Text,
                Age    = int.Parse(txtAge.Text),
                Course = txtCourse.Text
            };
            controller.Add(student);
            LoadData();
            ClearFields();
            MessageBox.Show("Student added successfully!");
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            var student = new Student
            {
                StudentId = int.Parse(txtId.Text), 
                Name      = txtName.Text,
                Age       = int.Parse(txtAge.Text),
                Course    = txtCourse.Text
            };
            controller.Update(student);
            LoadData();
            ClearFields();
            MessageBox.Show("Student updated successfully!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message); 
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int id = int.Parse(txtId.Text);
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this student?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );
            if (confirm == DialogResult.Yes)
            {
                controller.Delete(id);
                LoadData();
                ClearFields();
                MessageBox.Show("Student deleted successfully!");
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }

  
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtId.Text     = row.Cells["StudentId"].Value.ToString();
            txtName.Text   = row.Cells["Name"].Value.ToString();
            txtAge.Text    = row.Cells["Age"].Value.ToString();
            txtCourse.Text = row.Cells["Course"].Value.ToString();
        }
    }

    private void ClearFields()
    {
        txtId.Text     = string.Empty;
        txtName.Text   = string.Empty;
        txtAge.Text    = string.Empty;
        txtCourse.Text = string.Empty;
    }
}
