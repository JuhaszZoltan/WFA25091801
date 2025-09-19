using System.Collections;

namespace WFA25091801;

public partial class FrmMuveletek : Form
{
    public FrmMuveletek()
    {
        InitializeComponent();
        btnKivonas.Click += MuveletButton_Click;
        btnOsszeadas.Click += MuveletButton_Click;
        btnOsztas.Click += MuveletButton_Click;
        btnSzorzas.Click += MuveletButton_Click;

        txtElsoAdat.TextChanged += InputTextBox_TextChanged;
        txtMasodikAdat.TextChanged += InputTextBox_TextChanged;
    }

    private void MuveletButton_Click(object? sender, EventArgs e)
    {
        FeherGombok();

        (sender as Button).BackColor = Color.Gray;

        try
        {
            int x = int.Parse(txtElsoAdat.Text);
            int y = int.Parse(txtMasodikAdat.Text);

            if ((sender as Button).Name == "btnOsztas" && y == 0)
                throw new DivideByZeroException();

            lblEredmeny.Text = (sender as Button)?.Name switch
            {
                "btnOsszeadas" => $"{x + y}",
                "btnOsztas" => $"{x / (float)y}",
                "btnKivonas" => $"{x - y}",
                "btnSzorzas" => $"{x * y}",
                _ => throw new Exception("nincs ilyen gomb")
            };
        }
        catch (Exception ex)
        {
            if (ex is FormatException)
            {
                MessageBox.Show("nem jó a bemeneti formátum...");
            }
            else if (ex is DivideByZeroException)
            {
                MessageBox.Show("nem lehet nullával osztani...");
            }
            else MessageBox.Show(ex.Message);
        }
    }

    private void FeherGombok()
    {
        btnOsztas.BackColor = Color.White;
        btnOsszeadas.BackColor = Color.White;
        btnKivonas.BackColor = Color.White;
        btnSzorzas.BackColor = Color.White;
    }


    private void InputTextBox_TextChanged(object? sender, EventArgs e)
    {
        FeherGombok();
        lblEredmeny.Text = string.Empty;
    }
}
