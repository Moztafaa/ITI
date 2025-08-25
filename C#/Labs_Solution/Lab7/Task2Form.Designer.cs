using System.ComponentModel;

namespace Lab7;

partial class Task2Form
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    private System.Windows.Forms.Label lblCoords;
    private System.Windows.Forms.Label lblDistance;

    /// <summary>
    /// Clean up any resources being used.
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
        lblCoords = new System.Windows.Forms.Label();
        lblDistance = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        SuspendLayout();
        //
        // lblCoords
        //
        lblCoords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblCoords.AutoSize = true;
        lblCoords.Location = new System.Drawing.Point(12, 21);
        lblCoords.Name = "lblCoords";
        lblCoords.Size = new System.Drawing.Size(128, 15);
        lblCoords.TabIndex = 0;
        lblCoords.Text = "Click to set first point...";
        lblCoords.MouseClick += OnFormMouseClick;
        //
        // lblDistance
        //
        lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lblDistance.AutoSize = true;
        lblDistance.Location = new System.Drawing.Point(12, 410);
        lblDistance.Name = "lblDistance";
        lblDistance.Size = new System.Drawing.Size(112, 15);
        lblDistance.TabIndex = 1;
        lblDistance.Text = "Distance: -- (click 2)";
        lblDistance.MouseClick += OnFormMouseClick;
        //
        // button1
        //
        button1.Anchor = System.Windows.Forms.AnchorStyles.None;
        button1.Location = new System.Drawing.Point(277, 200);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(100, 30);
        button1.TabIndex = 2;
        button1.Text = "Reset";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        //
        // Task2Form
        //
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(655, 434);
        Controls.Add(button1);
        Controls.Add(lblDistance);
        Controls.Add(lblCoords);
        Text = "Distance Measure";
        MouseClick += OnFormMouseClick;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button1;

    #endregion
}
