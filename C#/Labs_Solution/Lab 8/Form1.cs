namespace Lab_8;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load;
        this.Resize += Form1_Resize;
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        labelName.Text = "Mostafa Ibrahim";
        CenterLabel();
    }

    private void Form1_Resize(object? sender, EventArgs e)
    {
        CenterLabel();
    }

    private void CenterLabel()
    {
        if (labelName == null) return;
        labelName.AutoSize = true;
        labelName.Left = (this.ClientSize.Width - labelName.Width) / 2;
        labelName.Top = (this.ClientSize.Height - labelName.Height) / 2;
    }

    private void BlueToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        labelName.ForeColor = System.Drawing.Color.Blue;
    }

    private void GreenToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        labelName.ForeColor = System.Drawing.Color.Green;
    }

    private void RedToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        labelName.ForeColor = System.Drawing.Color.Red;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBox1 == null || labelName == null) return;

        var sel = comboBox1.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(sel)) return;

        switch (sel)
        {
            case "Red":
                labelName.ForeColor = System.Drawing.Color.Red;
                break;
            case "Green":
                labelName.ForeColor = System.Drawing.Color.Green;
                break;
            case "Blue":
                labelName.ForeColor = System.Drawing.Color.Blue;
                break;
            default:
                // unknown selection - keep current color
                break;
        }
    }



    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        // Some designers generate duplicate event names; forward to the primary handler.
        comboBox1_SelectedIndexChanged(sender, e);
    }
}

