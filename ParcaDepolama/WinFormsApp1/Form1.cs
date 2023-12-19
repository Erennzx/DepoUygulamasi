namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        parca›slemleri parca›slem = new parca›slemleri();
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
            parca.parca›smi = parca›smi.Text;
            parca.parcaTuru = parcaTuru.Text;
            parca.parcaFiyati = Convert.ToInt32(parcaFiyati.Text);
            parca.parcaSahibi = parcaSahibi.Text;

            parca›slem.yeniParcaEkle(parca);
            var source = new BindingSource();
            source.DataSource = parca›slem.parcalar;
            dataGridView1.DataSource = source;
        }

        private void btnParcaGuncelle_Click(object sender, EventArgs e)
        {
            parcaDeposu urung¸ncelleme = new parcaDeposu();
            urung¸ncelleme.parca›smi = gParca›smi.Text;
            urung¸ncelleme.parcaTuru = gParcaTuru.Text;
            urung¸ncelleme.parcaFiyati = Convert.ToInt32(gParcaFiyati.Text);
            urung¸ncelleme.parcaSahibi = gParcaSahibi.Text;

            parca›slem.parcaGuncelle(secilen_index, urung¸ncelleme);
            dataGridView1.Refresh();
        }

        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            parca›slem.parcaSil(secilen_index);
            dataGridView1.Refresh();
            var source = new BindingSource();
            source.DataSource = parca›slem.parcalar;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            secilen_index = e.RowIndex;
            parcaDeposu secilenUrun = parca›slem.parcalar[secilen_index];
            gParca›smi.Text = secilenUrun.parca›smi;
            gParcaTuru.Text = secilenUrun.parcaTuru;
            gParcaFiyati.Text = secilenUrun.parcaFiyati.ToString();
            gParcaSahibi.Text = secilenUrun.parcaSahibi;
        }
    }
}