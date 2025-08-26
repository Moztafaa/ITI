namespace Lab_8;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPosition;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDistance;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        labelName = new System.Windows.Forms.Label();
        comboBox1 = new System.Windows.Forms.ComboBox();
        statusStrip1 = new System.Windows.Forms.StatusStrip();
        toolStripStatusLabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
        toolStripStatusLabelDistance = new System.Windows.Forms.ToolStripStatusLabel();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        SuspendLayout();
        //
        // menuStrip1
        //
        // (no menu strip) initialize label and combobox below
        //
        // labelName
        //
        labelName.AutoSize = true;
        labelName.Font = new System.Drawing.Font("Segoe UI", 20F);
        labelName.Location = new System.Drawing.Point(343, 198);
        labelName.Name = "labelName";
        labelName.Size = new System.Drawing.Size(88, 37);
        labelName.TabIndex = 1;
        labelName.Text = "Name";
        //
        //
        // menuStrip1
        //
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        //
        // colorToolStripMenuItem
        //
        colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { blueToolStripMenuItem, greenToolStripMenuItem, redToolStripMenuItem });
        colorToolStripMenuItem.Name = "colorToolStripMenuItem";
        colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        colorToolStripMenuItem.Text = "Color";
        //
        // blueToolStripMenuItem
        //
        blueToolStripMenuItem.Name = "blueToolStripMenuItem";
        blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        blueToolStripMenuItem.Text = "Blue";
        blueToolStripMenuItem.Click += BlueToolStripMenuItem_Click;
        //
        // greenToolStripMenuItem
        //
        greenToolStripMenuItem.Name = "greenToolStripMenuItem";
        greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        greenToolStripMenuItem.Text = "Green";
        greenToolStripMenuItem.Click += GreenToolStripMenuItem_Click;
        //
        // redToolStripMenuItem
        //
        redToolStripMenuItem.Name = "redToolStripMenuItem";
        redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        redToolStripMenuItem.Text = "Red";
        redToolStripMenuItem.Click += RedToolStripMenuItem_Click;

        // statusStrip1
        //
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelPosition, toolStripStatusLabelDistance });
        statusStrip1.Location = new System.Drawing.Point(0, 428);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(800, 22);
        statusStrip1.TabIndex = 4;
        statusStrip1.Text = "statusStrip1";
        //
        // comboBox1
        //
        comboBox1.FormattingEnabled = true;
        comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        comboBox1.Items.AddRange(new object[] { "Red", "Green", "Blue" });
        comboBox1.Location = new System.Drawing.Point(187, 103);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(75, 23);
        comboBox1.TabIndex = 3;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
        //
        // status labels default text
        //
        toolStripStatusLabelPosition.Name = "toolStripStatusLabelPosition";
        toolStripStatusLabelPosition.Size = new System.Drawing.Size(100, 17);
        toolStripStatusLabelPosition.Text = "Pos: -";
        toolStripStatusLabelDistance.Name = "toolStripStatusLabelDistance";
        toolStripStatusLabelDistance.Size = new System.Drawing.Size(100, 17);
        toolStripStatusLabelDistance.Text = "Distance: -";
        //
        // Form1
        //
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(menuStrip1);
        Controls.Add(statusStrip1);
        Controls.Add(comboBox1);
        Controls.Add(labelName);
        MainMenuStrip = menuStrip1;
        Text = "Form1";
        Load += Form1_Load;

        ResumeLayout(false);
        PerformLayout();
    }



    #endregion
}
