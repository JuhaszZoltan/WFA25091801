namespace WFA25091801;

public partial class FrmMuveletek : Form
{
    public FrmMuveletek()
    {
        InitializeComponent();
        btnOsszeadas.Click += BtnOsszeadas_Click;
        btnKivonas.Click += BtnKivonas_Click;
        btnSzorzas.Click += BtnSzorzas_Click;
        btnOsztas.Click += BtnOsztas_Click;
    }

    private void BtnOsztas_Click(object? sender, EventArgs e)
    {
        int x = int.Parse(txtElsoAdat.Text);
        int y = int.Parse(txtMasodikAdat.Text);
        lblEredmeny.Text = $"{x / y}";
    }

    private void BtnSzorzas_Click(object? sender, EventArgs e)
    {
        int x = int.Parse(txtElsoAdat.Text);
        int y = int.Parse(txtMasodikAdat.Text);
        lblEredmeny.Text = $"{x * y}";
    }

    private void BtnKivonas_Click(object? sender, EventArgs e)
    {
        int x = int.Parse(txtElsoAdat.Text);
        int y = int.Parse(txtMasodikAdat.Text);
        lblEredmeny.Text = $"{x - y}";
    }

    private void BtnOsszeadas_Click(object? sender, EventArgs e)
    {
        bool xp = int.TryParse(txtElsoAdat.Text, out int x);
        bool yp = int.TryParse(txtMasodikAdat.Text, out int y);
        
        if (xp && yp)
        {
            lblEredmeny.Text = $"{x + y}";
        }
        else
        {
            MessageBox.Show("hiba!");
        }

        
    }
}
