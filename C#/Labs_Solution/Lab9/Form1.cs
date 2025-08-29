using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab9;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        // Initialize display and preview fields
        if (string.IsNullOrWhiteSpace(lblDisplay.Text))
            lblDisplay.Text = "Your text here";

        txtOldText.Text = lblDisplay.Text;
        txtNewText.Text = string.Empty;
        pnlColorPreview.BackColor = lblDisplay.ForeColor;

        // Set radio according to current font family if it matches any option
        var family = lblDisplay.Font.FontFamily.Name;
        rbArial.Checked = string.Equals(family, "Arial", StringComparison.OrdinalIgnoreCase);
        rbTimes.Checked = string.Equals(family, "Times New Roman", StringComparison.OrdinalIgnoreCase);
        rbConsolas.Checked = string.Equals(family, "Consolas", StringComparison.OrdinalIgnoreCase);
    }

    private void btnChangeFormat_Click(object? sender, EventArgs e)
    {
        // Show the tab control and refresh current values
        tabControl.Visible = true;
        txtOldText.Text = lblDisplay.Text;
        txtNewText.Text = string.Empty;
        pnlColorPreview.BackColor = lblDisplay.ForeColor;

        var family = lblDisplay.Font.FontFamily.Name;
        rbArial.Checked = string.Equals(family, "Arial", StringComparison.OrdinalIgnoreCase);
        rbTimes.Checked = string.Equals(family, "Times New Roman", StringComparison.OrdinalIgnoreCase);
        rbConsolas.Checked = string.Equals(family, "Consolas", StringComparison.OrdinalIgnoreCase);
    }

    private void btnChooseColor_Click(object? sender, EventArgs e)
    {
        colorDialog1.Color = pnlColorPreview.BackColor;
        if (colorDialog1.ShowDialog(this) == DialogResult.OK)
        {
            pnlColorPreview.BackColor = colorDialog1.Color;
        }
    }

    private void btnSubmit_Click(object? sender, EventArgs e)
    {
        // Apply text
        var newText = txtNewText.Text;
        if (!string.IsNullOrWhiteSpace(newText))
        {
            lblDisplay.Text = newText;
        }

        // Apply color
        lblDisplay.ForeColor = pnlColorPreview.BackColor;

        // Apply font family (keep current size and style)
        var current = lblDisplay.Font;
        string? chosenFamily = null;
        if (rbArial.Checked) chosenFamily = "Arial";
        else if (rbTimes.Checked) chosenFamily = "Times New Roman";
        else if (rbConsolas.Checked) chosenFamily = "Consolas";

        if (!string.IsNullOrEmpty(chosenFamily))
        {
            try
            {
                lblDisplay.Font = new Font(chosenFamily, current.Size, current.Style, GraphicsUnit.Point);
            }
            catch
            {
                // If the font isn't available, keep the current font silently
            }
        }

        // Reflect updates back to the tab values
        txtOldText.Text = lblDisplay.Text;
        // Keep the tab control visible per requirement, but you can hide if desired
        // tabControl.Visible = false;
    }
}
