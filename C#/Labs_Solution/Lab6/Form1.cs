namespace Lab6;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();


        this.BackColor = Color.Bisque;

        this.ResizeEnd += (sender, e) => this.Opacity = 1;


    }

    protected override void OnResizeBegin(EventArgs e)
    {
        base.OnResizeBegin(e);

        this.Opacity = 0.75;



    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void DemoOpenBtn(object sender, EventArgs e)
    {
        this.Text = "Button Clicked!";
    }
}
