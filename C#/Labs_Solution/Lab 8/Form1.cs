namespace Lab_8;

public partial class Form1 : Form
{
    private System.Drawing.Point? _lastClick = null;

    public Form1()
    {
        InitializeComponent();
        this.Load += Form1_Load;
        this.Resize += Form1_Resize;
        this.MouseClick += Form1_MouseClick;
    }

    private void Form1_Load(object? sender, EventArgs e)
    {
        // show current Windows user name
        labelName.Text = System.Environment.UserName;
        CenterLabel();

        // initialize combobox selection if populated
        if (comboBox1 != null && comboBox1.Items.Count > 0)
            comboBox1.SelectedIndex = 0;
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
                break;
        }
    }

    private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        // some designer wiring may reference this name
        comboBox1_SelectedIndexChanged(sender, e);
    }

    private void BlueToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (labelName != null)
            labelName.ForeColor = System.Drawing.Color.Blue;
    }

    private void GreenToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (labelName != null)
            labelName.ForeColor = System.Drawing.Color.Green;
    }

    private void RedToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        if (labelName != null)
            labelName.ForeColor = System.Drawing.Color.Red;
    }

    private void Form1_MouseClick(object? sender, System.Windows.Forms.MouseEventArgs e)
    {
        var posText = $"Pos: ({e.X}, {e.Y})";

        double distance = 0;
        if (_lastClick.HasValue)
        {
            var dx = e.X - _lastClick.Value.X;
            var dy = e.Y - _lastClick.Value.Y;
            distance = Math.Sqrt(dx * dx + dy * dy);
        }

        _lastClick = new System.Drawing.Point(e.X, e.Y);

        if (toolStripStatusLabelPosition != null)
            toolStripStatusLabelPosition.Text = posText;
        if (toolStripStatusLabelDistance != null)
            toolStripStatusLabelDistance.Text = $"Distance: {distance:0.##}";
    }
}

