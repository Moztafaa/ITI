namespace Lab3;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelName = new Label();
        txtName = new TextBox();
        labelEmail = new Label();
        txtEmail = new TextBox();
        labelDepartment = new Label();
        txtDepartment = new TextBox();
        btnCreate = new Button();
        btnSearch = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        labelSearch = new Label();
        txtSearchName = new TextBox();
        btnReset = new Button();
        dgvStudents = new DataGridView();
        txtId = new TextBox();
        labelId = new Label();
        btnShowAll = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
        SuspendLayout();
        //
        // labelName
        //
        labelName.AutoSize = true;
        labelName.Location = new Point(24, 24);
        labelName.Name = "labelName";
        labelName.Size = new Size(42, 15);
        labelName.TabIndex = 0;
        labelName.Text = "Name:";
        //
        // txtName
        //
        txtName.Location = new Point(140, 21);
        txtName.Name = "txtName";
        txtName.Size = new Size(280, 23);
        txtName.TabIndex = 1;
        //
        // labelEmail
        //
        labelEmail.AutoSize = true;
        labelEmail.Location = new Point(24, 63);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(39, 15);
        labelEmail.TabIndex = 2;
        labelEmail.Text = "Email:";
        //
        // txtEmail
        //
        txtEmail.Location = new Point(140, 60);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(280, 23);
        txtEmail.TabIndex = 3;
        //
        // labelDepartment
        //
        labelDepartment.AutoSize = true;
        labelDepartment.Location = new Point(24, 102);
        labelDepartment.Name = "labelDepartment";
        labelDepartment.Size = new Size(108, 15);
        labelDepartment.TabIndex = 4;
        labelDepartment.Text = "Department Name:";
        //
        // txtDepartment
        //
        txtDepartment.Location = new Point(140, 99);
        txtDepartment.Name = "txtDepartment";
        txtDepartment.Size = new Size(280, 23);
        txtDepartment.TabIndex = 5;
        //
        // btnCreate
        //
        btnCreate.Location = new Point(450, 18);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(90, 30);
        btnCreate.TabIndex = 6;
        btnCreate.Text = "Create";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        //
        // btnSearch
        //
        btnSearch.Location = new Point(546, 18);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(90, 30);
        btnSearch.TabIndex = 7;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        //
        // btnUpdate
        //
        btnUpdate.Location = new Point(642, 18);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(90, 30);
        btnUpdate.TabIndex = 8;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        //
        // btnDelete
        //
        btnDelete.Location = new Point(738, 18);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(90, 30);
        btnDelete.TabIndex = 9;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        //
        // labelSearch
        //
        labelSearch.AutoSize = true;
        labelSearch.Location = new Point(450, 63);
        labelSearch.Name = "labelSearch";
        labelSearch.Size = new Size(96, 15);
        labelSearch.TabIndex = 10;
        labelSearch.Text = "Search by Name:";
        //
        // txtSearchName
        //
        txtSearchName.Location = new Point(553, 60);
        txtSearchName.Name = "txtSearchName";
        txtSearchName.Size = new Size(275, 23);
        txtSearchName.TabIndex = 11;
        //
        // btnReset
        //
        btnReset.Location = new Point(834, 58);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(90, 27);
        btnReset.TabIndex = 12;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = true;
        btnReset.Click += btnReset_Click;
        //
        // dgvStudents
        //
        dgvStudents.AllowUserToAddRows = false;
        dgvStudents.AllowUserToDeleteRows = false;
        dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStudents.Location = new Point(24, 150);
        dgvStudents.Name = "dgvStudents";
        dgvStudents.ReadOnly = true;
        dgvStudents.RowHeadersVisible = false;
        dgvStudents.Size = new Size(1055, 580);
        dgvStudents.TabIndex = 13;
        dgvStudents.CellContentClick += dgvStudents_CellContentClick;
        //
        // txtId
        //
        txtId.Location = new Point(477, 107);
        txtId.Name = "txtId";
        txtId.Size = new Size(280, 23);
        txtId.TabIndex = 14;
        //
        // labelId
        //
        labelId.AutoSize = true;
        labelId.Location = new Point(450, 110);
        labelId.Name = "labelId";
        labelId.Size = new Size(21, 15);
        labelId.TabIndex = 0;
        labelId.Text = "ID:";
        //
        // btnShowAll
        //
        btnShowAll.Location = new Point(834, 18);
        btnShowAll.Name = "btnShowAll";
        btnShowAll.Size = new Size(90, 30);
        btnShowAll.TabIndex = 9;
        btnShowAll.Text = "Show All";
        btnShowAll.UseVisualStyleBackColor = true;
        btnShowAll.Click += btnShowAll_Click;
        //
        // Form1
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1103, 758);
        Controls.Add(txtId);
        Controls.Add(dgvStudents);
        Controls.Add(btnReset);
        Controls.Add(txtSearchName);
        Controls.Add(labelSearch);
        Controls.Add(btnShowAll);
        Controls.Add(btnDelete);
        Controls.Add(btnUpdate);
        Controls.Add(btnSearch);
        Controls.Add(btnCreate);
        Controls.Add(txtDepartment);
        Controls.Add(labelDepartment);
        Controls.Add(txtEmail);
        Controls.Add(labelEmail);
        Controls.Add(txtName);
        Controls.Add(labelId);
        Controls.Add(labelName);
        MinimumSize = new Size(800, 600);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Student Management";
        ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label labelDepartment;
    private System.Windows.Forms.TextBox txtDepartment;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.TextBox txtSearchName;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.DataGridView dgvStudents;
    private TextBox txtId;
    private Label labelId;
    private Button btnShowAll;
}


