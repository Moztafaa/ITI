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
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
    private System.Windows.Forms.Label labelName;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        labelName = new System.Windows.Forms.Label();
        toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip2 = new System.Windows.Forms.MenuStrip();
        toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
        comboBox1 = new System.Windows.Forms.ComboBox();
        toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
        toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        //
        // menuStrip1
        //
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { colorToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 24);
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
        // toolStripMenuItem1
        //
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
        //
        // toolStripMenuItem2
        //
        toolStripMenuItem2.Name = "toolStripMenuItem2";
        toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
        //
        // menuStrip2
        //
        menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
        menuStrip2.Location = new System.Drawing.Point(0, 0);
        menuStrip2.Name = "menuStrip2";
        menuStrip2.Size = new System.Drawing.Size(800, 24);
        menuStrip2.TabIndex = 2;
        menuStrip2.Text = "menuStrip2";
        //
        // toolStripMenuItem3
        //
        toolStripMenuItem3.Name = "toolStripMenuItem3";
        toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
        //
        // toolStripMenuItem4
        //
        toolStripMenuItem4.Name = "toolStripMenuItem4";
        toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
        //
        // comboBox1
        //
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Red", "Green", "Blue" });
        comboBox1.Location = new System.Drawing.Point(187, 103);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(75, 23);
        comboBox1.TabIndex = 3;
        comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
        //
        // toolStripMenuItem5
        //
        toolStripMenuItem5.Name = "toolStripMenuItem5";
        toolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
        //
        // toolStripMenuItem6
        //
        toolStripMenuItem6.Name = "toolStripMenuItem6";
        toolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
        //
        // toolStripMenuItem7
        //
        toolStripMenuItem7.Name = "toolStripMenuItem7";
        toolStripMenuItem7.Size = new System.Drawing.Size(32, 19);
        //
        // Form1
        //
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(comboBox1);
        Controls.Add(labelName);
        Controls.Add(menuStrip1);
        Controls.Add(menuStrip2);
        MainMenuStrip = menuStrip1;
        Text = "Form1";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;

    private System.Windows.Forms.MenuStrip menuStrip2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

    #endregion
}
