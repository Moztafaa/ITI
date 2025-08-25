using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7;

public partial class Task2Form : Form
{
    // Simple state
    private Point startPoint;
    private bool isMeasuring;

    public Task2Form()
    {
        InitializeComponent();
    }

    private Point ToFormPoint(object sender, Point controlPoint)
    {
        if (sender is Control c)
        {
            Point screen = c.PointToScreen(controlPoint);
            return this.PointToClient(screen);
        }
        return controlPoint;
    }

    // Handle mouse click to set points and compute distance
    private void OnFormMouseClick(object sender, MouseEventArgs e)
    {
        var p = ToFormPoint(sender, e.Location);

        if (!isMeasuring)
        {
            // First click: store start point
            startPoint = p;
            isMeasuring = true;
            lblCoords.Text = $"First point: X={p.X}, Y={p.Y}";
            lblDistance.Text = "Distance: -- (click 2)";
        }
        else
        {
            // Second click: compute and show distance, then reset state
            int dx = p.X - startPoint.X;
            int dy = p.Y - startPoint.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            lblCoords.Text = $"Second point: X={p.X}, Y={p.Y}";
            lblDistance.Text = $"Distance: {distance:F2} px";
            isMeasuring = false;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Reset the measurement state
        isMeasuring = false;
        lblCoords.Text = "Click to set first point...";
        lblDistance.Text = "Distance: -- (click 2)";
    }
}
