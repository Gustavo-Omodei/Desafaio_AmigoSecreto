

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        List<Pessoa> lista = new List<Pessoa>();
        Random random = new Random();
        Form3 form3 = new Form3();

        public Form2()
        {

            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cadastrar();
            }
        }

        private void cadastrar()
        {
            string[] vetor = textBox_Nome.Text.Split();
            if (vetor.Length >= 2)
            {
                string nome = textBox_Nome.Text.ToUpper();
                string email = textBox_Email.Text.ToLower();
                Pessoa p = new Pessoa(nome, email);

                if (!lista.Contains(p))
                {
                    lista.Add(p);
                    lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
                    lista.Sort((a, b) => a.Email.CompareTo(b.Email));


                    colocarListaText(lista);
                    textBox_Nome.Text = "";
                    textBox_Email.Text = "";
                }
            }

            List<Pessoa> listaEmbaralhada = CriarCopiaInversa(lista);


            SalvarParaCSV(lista, "amigo.csv");
            SalvarParaCSV(listaEmbaralhada, "secreto.csv");
        }


        private void colocarListaText(List<Pessoa> lista)
        {
            textBox_Nome.Text = "";
            textBox_Email.Text = "";
            listView_Nomes.Items.Clear();
            foreach (var pessoa in lista)
            {
                string[] itens = { pessoa.Nome, pessoa.Email };
                listView_Nomes.Items.Add(new ListViewItem(itens));
            }
        }

        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                cadastrar();
            }
        }

        private void SalvarParaCSV(List<Pessoa> listaPessoas, string nomeArquivo)
        {
            string caminhoArquivo = nomeArquivo;

            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    writer.WriteLine("Nome; Email");

                    foreach (var pessoa in listaPessoas)
                    {
                        writer.WriteLine($"{pessoa.Nome};{pessoa.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar no arquivo CSV: {ex.Message}");
            }
        }

        private List<Pessoa> CriarCopiaInversa(List<Pessoa> listaOriginal)
        {
            List<Pessoa> listaCopia = new List<Pessoa>(listaOriginal);
            listaCopia.Reverse();
            return listaCopia;
        }

        private void button_verLista_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();

        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            listView_Nomes.Items.Clear();
            textBox_Nome.Clear();
            textBox_Email.Clear();
            lista.Clear();

        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            cadastrar();
        }
    }
}

