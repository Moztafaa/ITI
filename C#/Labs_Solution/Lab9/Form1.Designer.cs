namespace Lab9;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblDisplay;
    private System.Windows.Forms.Button btnChangeFormat;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabText;
    private System.Windows.Forms.TabPage tabColor;
    private System.Windows.Forms.TabPage tabFont;
    private System.Windows.Forms.Label lblOldTextTitle;
    private System.Windows.Forms.TextBox txtOldText;
    private System.Windows.Forms.Label lblNewTextTitle;
    private System.Windows.Forms.TextBox txtNewText;
    private System.Windows.Forms.Button btnChooseColor;
    private System.Windows.Forms.Panel pnlColorPreview;
    private System.Windows.Forms.RadioButton rbArial;
    private System.Windows.Forms.RadioButton rbTimes;
    private System.Windows.Forms.RadioButton rbConsolas;
    private System.Windows.Forms.Button btnSubmit;
    private System.Windows.Forms.ColorDialog colorDialog1;

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
        this.components = new System.ComponentModel.Container();
        this.lblDisplay = new System.Windows.Forms.Label();
        this.btnChangeFormat = new System.Windows.Forms.Button();
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabText = new System.Windows.Forms.TabPage();
        this.lblOldTextTitle = new System.Windows.Forms.Label();
        this.txtOldText = new System.Windows.Forms.TextBox();
        this.lblNewTextTitle = new System.Windows.Forms.Label();
        this.txtNewText = new System.Windows.Forms.TextBox();
        this.tabColor = new System.Windows.Forms.TabPage();
        this.btnChooseColor = new System.Windows.Forms.Button();
        this.pnlColorPreview = new System.Windows.Forms.Panel();
        this.tabFont = new System.Windows.Forms.TabPage();
        this.rbArial = new System.Windows.Forms.RadioButton();
        this.rbTimes = new System.Windows.Forms.RadioButton();
        this.rbConsolas = new System.Windows.Forms.RadioButton();
        this.btnSubmit = new System.Windows.Forms.Button();
        this.colorDialog1 = new System.Windows.Forms.ColorDialog();
        this.tabControl.SuspendLayout();
        this.tabText.SuspendLayout();
        this.tabColor.SuspendLayout();
        this.tabFont.SuspendLayout();
        this.SuspendLayout();
        //
        // lblDisplay
        //
        this.lblDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDisplay.Location = new System.Drawing.Point(12, 80);
        this.lblDisplay.Name = "lblDisplay";
        this.lblDisplay.Size = new System.Drawing.Size(776, 40);
        this.lblDisplay.TabIndex = 0;
        this.lblDisplay.Text = "Your text here";
        this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        //
        // btnChangeFormat
        //
        this.btnChangeFormat.Location = new System.Drawing.Point(12, 20);
        this.btnChangeFormat.Name = "btnChangeFormat";
        this.btnChangeFormat.Size = new System.Drawing.Size(130, 35);
        this.btnChangeFormat.TabIndex = 1;
        this.btnChangeFormat.Text = "change format";
        this.btnChangeFormat.UseVisualStyleBackColor = true;
        this.btnChangeFormat.Click += new System.EventHandler(this.btnChangeFormat_Click);
        //
        // tabControl
        //
        this.tabControl.Controls.Add(this.tabText);
        this.tabControl.Controls.Add(this.tabColor);
        this.tabControl.Controls.Add(this.tabFont);
        this.tabControl.Location = new System.Drawing.Point(12, 140);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(776, 220);
        this.tabControl.TabIndex = 2;
        this.tabControl.Visible = false;
        //
        // tabText
        //
        this.tabText.Controls.Add(this.txtNewText);
        this.tabText.Controls.Add(this.lblNewTextTitle);
        this.tabText.Controls.Add(this.txtOldText);
        this.tabText.Controls.Add(this.lblOldTextTitle);
        this.tabText.Location = new System.Drawing.Point(4, 29);
        this.tabText.Name = "tabText";
        this.tabText.Padding = new System.Windows.Forms.Padding(3);
        this.tabText.Size = new System.Drawing.Size(768, 187);
        this.tabText.TabIndex = 0;
        this.tabText.Text = "change text";
        this.tabText.UseVisualStyleBackColor = true;
        //
        // lblOldTextTitle
        //
        this.lblOldTextTitle.AutoSize = true;
        this.lblOldTextTitle.Location = new System.Drawing.Point(20, 22);
        this.lblOldTextTitle.Name = "lblOldTextTitle";
        this.lblOldTextTitle.Size = new System.Drawing.Size(66, 20);
        this.lblOldTextTitle.TabIndex = 0;
        this.lblOldTextTitle.Text = "Old text:";
        //
        // txtOldText
        //
        this.txtOldText.Location = new System.Drawing.Point(110, 19);
        this.txtOldText.Name = "txtOldText";
        this.txtOldText.ReadOnly = true;
        this.txtOldText.Size = new System.Drawing.Size(630, 27);
        this.txtOldText.TabIndex = 1;
        //
        // lblNewTextTitle
        //
        this.lblNewTextTitle.AutoSize = true;
        this.lblNewTextTitle.Location = new System.Drawing.Point(20, 70);
        this.lblNewTextTitle.Name = "lblNewTextTitle";
        this.lblNewTextTitle.Size = new System.Drawing.Size(72, 20);
        this.lblNewTextTitle.TabIndex = 2;
        this.lblNewTextTitle.Text = "New text:";
        //
        // txtNewText
        //
        this.txtNewText.Location = new System.Drawing.Point(110, 67);
        this.txtNewText.Name = "txtNewText";
        this.txtNewText.Size = new System.Drawing.Size(630, 27);
        this.txtNewText.TabIndex = 3;
        //
        // tabColor
        //
        this.tabColor.Controls.Add(this.pnlColorPreview);
        this.tabColor.Controls.Add(this.btnChooseColor);
        this.tabColor.Location = new System.Drawing.Point(4, 29);
        this.tabColor.Name = "tabColor";
        this.tabColor.Padding = new System.Windows.Forms.Padding(3);
        this.tabColor.Size = new System.Drawing.Size(768, 187);
        this.tabColor.TabIndex = 1;
        this.tabColor.Text = "change color";
        this.tabColor.UseVisualStyleBackColor = true;
        //
        // btnChooseColor
        //
        this.btnChooseColor.Location = new System.Drawing.Point(20, 20);
        this.btnChooseColor.Name = "btnChooseColor";
        this.btnChooseColor.Size = new System.Drawing.Size(150, 35);
        this.btnChooseColor.TabIndex = 0;
        this.btnChooseColor.Text = "Choose Color...";
        this.btnChooseColor.UseVisualStyleBackColor = true;
        this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
        //
        // pnlColorPreview
        //
        this.pnlColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlColorPreview.Location = new System.Drawing.Point(190, 20);
        this.pnlColorPreview.Name = "pnlColorPreview";
        this.pnlColorPreview.Size = new System.Drawing.Size(100, 35);
        this.pnlColorPreview.TabIndex = 1;
        //
        // tabFont
        //
        this.tabFont.Controls.Add(this.rbConsolas);
        this.tabFont.Controls.Add(this.rbTimes);
        this.tabFont.Controls.Add(this.rbArial);
        this.tabFont.Location = new System.Drawing.Point(4, 29);
        this.tabFont.Name = "tabFont";
        this.tabFont.Padding = new System.Windows.Forms.Padding(3);
        this.tabFont.Size = new System.Drawing.Size(768, 187);
        this.tabFont.TabIndex = 2;
        this.tabFont.Text = "change font";
        this.tabFont.UseVisualStyleBackColor = true;
        //
        // rbArial
        //
        this.rbArial.AutoSize = true;
        this.rbArial.Location = new System.Drawing.Point(20, 22);
        this.rbArial.Name = "rbArial";
        this.rbArial.Size = new System.Drawing.Size(60, 24);
        this.rbArial.TabIndex = 0;
        this.rbArial.TabStop = true;
        this.rbArial.Text = "Arial";
        this.rbArial.UseVisualStyleBackColor = true;
        //
        // rbTimes
        //
        this.rbTimes.AutoSize = true;
        this.rbTimes.Location = new System.Drawing.Point(20, 62);
        this.rbTimes.Name = "rbTimes";
        this.rbTimes.Size = new System.Drawing.Size(159, 24);
        this.rbTimes.TabIndex = 1;
        this.rbTimes.TabStop = true;
        this.rbTimes.Text = "Times New Roman";
        this.rbTimes.UseVisualStyleBackColor = true;
        //
        // rbConsolas
        //
        this.rbConsolas.AutoSize = true;
        this.rbConsolas.Location = new System.Drawing.Point(20, 102);
        this.rbConsolas.Name = "rbConsolas";
        this.rbConsolas.Size = new System.Drawing.Size(91, 24);
        this.rbConsolas.TabIndex = 2;
        this.rbConsolas.TabStop = true;
        this.rbConsolas.Text = "Consolas";
        this.rbConsolas.UseVisualStyleBackColor = true;
        //
        // btnSubmit
        //
        this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSubmit.Location = new System.Drawing.Point(666, 375);
        this.btnSubmit.Name = "btnSubmit";
        this.btnSubmit.Size = new System.Drawing.Size(122, 35);
        this.btnSubmit.TabIndex = 3;
        this.btnSubmit.Text = "submit";
        this.btnSubmit.UseVisualStyleBackColor = true;
        this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 422);
        this.Controls.Add(this.btnSubmit);
        this.Controls.Add(this.tabControl);
        this.Controls.Add(this.btnChangeFormat);
        this.Controls.Add(this.lblDisplay);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Lab 9";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.tabControl.ResumeLayout(false);
        this.tabText.ResumeLayout(false);
        this.tabText.PerformLayout();
        this.tabColor.ResumeLayout(false);
        this.tabFont.ResumeLayout(false);
        this.tabFont.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion
}
