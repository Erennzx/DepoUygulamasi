namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        parcaİslemleri parcaİslem = new parcaİslemleri();
        public int secilen_index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            parcaDeposu parca = new parcaDeposu();
            parca.parcaİsmi = parcaİsmi.Text;
            parca.parcaTuru = parcaTuru.Text;
            parca.parcaFiyati = Convert.ToInt32(parcaFiyati.Text);
            parca.parcaSahibi = parcaSahibi.Text;

            parcaİslem.yeniParcaEkle(parca);
            var source = new BindingSource();
            source.DataSource = parcaİslem.parcalar;
            dataGridView1.DataSource = source;
        }

        private void btnParcaGuncelle_Click(object sender, EventArgs e)
        {
            parcaDeposu urungüncelleme = new parcaDeposu();
            urungüncelleme.parcaİsmi = gParcaİsmi.Text;
            urungüncelleme.parcaTuru = gParcaTuru.Text;
            urungüncelleme.parcaFiyati = Convert.ToInt32(gParcaFiyati.Text);
            urungüncelleme.parcaSahibi = gParcaSahibi.Text;

            parcaİslem.parcaGuncelle(secilen_index, urungüncelleme);
            dataGridView1.Refresh();
        }

        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            parcaİslem.parcaSil(secilen_index);
            dataGridView1.Refresh();
            var source = new BindingSource();
            source.DataSource = parcaİslem.parcalar;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            secilen_index = e.RowIndex;
            parcaDeposu secilenUrun = parcaİslem.parcalar[secilen_index];
            gParcaİsmi.Text = secilenUrun.parcaİsmi;
            gParcaTuru.Text = secilenUrun.parcaTuru;
            gParcaFiyati.Text = secilenUrun.parcaFiyati.ToString();
            gParcaSahibi.Text = secilenUrun.parcaSahibi;
        }
    }
}