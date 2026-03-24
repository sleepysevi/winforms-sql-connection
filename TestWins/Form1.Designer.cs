namespace TestWins;

partial class Form1
{
    // View
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.TextBox txtStudentId;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.TextBox txtCourse;


    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.Label lblTitle;




    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {

        this.txtName = new System.Windows.Forms.TextBox();
        this.txtAge = new System.Windows.Forms.TextBox();
        this.txtCourse = new System.Windows.Forms.TextBox();

        this.btnAdd = new System.Windows.Forms.Button();
        this.btnUpdate = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();

        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.lblTitle = new System.Windows.Forms.Label();

        //================
        // FORM
        //===============

        this.BackColor = System.Drawing.Color.WhiteSmoke;
        this.ClientSize = new System.Drawing.Size(900, 600);
        this.Text = "Student Management System";

        //================
        // TITLE
        //===============

        this.lblTitle.Text = "Student Management System";
        //this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FOndStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(200, 10);
        this.lblTitle.AutoSize = true;

        // ===============
        // TEXTBOX
        // ==============

        this.txtName.Location = new System.Drawing.Point(20, 110);
        this.txtName.Size = new System.Drawing.Size(200, 23);
        this.txtName.PlaceholderText = "Name";

        this.txtAge.Location = new System.Drawing.Point(20, 150);
        this.txtAge.Size = new System.Drawing.Size(200, 23);
        this.txtAge.PlaceholderText = "Age";

        this.txtCourse.Location = new System.Drawing.Point(20, 190);
        this.txtCourse.Size = new System.Drawing.Size(200, 23);
        this.txtCourse.PlaceholderText = "Course";


        // ===============
        // BUTTONS
        // ==============

        this.btnAdd.Text = "Add";
        this.btnAdd.Location = new System.Drawing.Point(20, 240);
        this.btnAdd.Size = new System.Drawing.Size(60, 70);
        this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
        this.btnAdd.ForeColor = System.Drawing.Color.White;
        this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

        this.btnUpdate.Text = "Update";
        this.btnUpdate.Location = new System.Drawing.Point(90, 240);
        this.btnUpdate.Size = new System.Drawing.Size(60, 30);
        this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

        this.btnDelete.Text = "Delete";
        this.btnDelete.Location = new System.Drawing.Point(160, 240);
        this.btnDelete.Size = new System.Drawing.Size(60, 30);
        this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

        // =======================
        // DATAGRIDVIEW
        // =======================
        this.dataGridView1.Location = new System.Drawing.Point(250, 70);
        this.dataGridView1.Size = new System.Drawing.Size(520, 350);
        this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
        this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);


        //===================
        // ADD CONTROLS
        //==================

        this.Controls.Add(this.lblTitle);

        this.Controls.Add(this.txtStudentId);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.txtAge);
        this.Controls.Add(this.txtCourse);

        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);

        this.Controls.Add(this.dataGridView1);
    }

    #endregion
}
