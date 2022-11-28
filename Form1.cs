namespace bibxmlzajecia28._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Book
        {
            public int id { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public string status { get; set; }
        }
        public class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // uzytkownik
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ksiazka
        }

        private void b_dod_uz_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void b_usun_uz_Click(object sender, EventArgs e)
        {

        }

        private void b_zapis_uz_Click(object sender, EventArgs e)
        {

        }

        private void b_odczyt_uz_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg_uz = new OpenFileDialog();
            dlg_uz.ShowDialog();
        }

        private void b_dodaj_ks_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void b_usun_ks_Click(object sender, EventArgs e)
        {

        }

        private void b_zapis_ks_Click(object sender, EventArgs e)
        {

        }

        private void b_odczyt_ks_Click(object sender, EventArgs e)
        {
          OpenFileDialog dlg_ks = new OpenFileDialog();
            dlg_ks.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}