

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            ExibirNaListView("amigo.csv", listView1);
            ExibirNaListView("secreto.csv", listView2);

        }



        public void ExibirNaListView(string nomeArquivo, ListView listView)
        {
            listView.Items.Clear();
            listView.Columns.Clear();

            string caminhoArquivo = nomeArquivo;

            try
            {
                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    string[] cabecalho = reader.ReadLine().Split(',');
                    foreach (var coluna in cabecalho)
                    {
                        listView.Columns.Add(coluna);
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] dados = reader.ReadLine().Split(',');
                        listView.Items.Add(new ListViewItem(dados));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao ler o arquivo CSV: {ex.Message}");
            }
        }


    }
}
