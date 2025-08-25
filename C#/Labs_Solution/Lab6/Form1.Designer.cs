namespace Lab6;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    // create text box
    private TextBox inputTextBox = new TextBox();
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
        inputTextBox = new System.Windows.Forms.TextBox();
        btnOpen = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // inputTextBox
        // 
        inputTextBox.Location = new System.Drawing.Point(0, 0);
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new System.Drawing.Size(100, 23);
        inputTextBox.TabIndex = 0;
        // 
        // btnOpen
        // 
        btnOpen.Location = new System.Drawing.Point(62, 309);
        btnOpen.Name = "btnOpen";
        btnOpen.Size = new System.Drawing.Size(110, 56);
        btnOpen.TabIndex = 0;
        btnOpen.Text = "Open";
        btnOpen.UseVisualStyleBackColor = true;
        btnOpen.Click += DemoOpenBtn;
        // 
        // Form1
        //
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(607, 456);
        Controls.Add(btnOpen);
        Text = "Hello GUI";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnOpen;

    #endregion
}
