using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace wfaArquivoSequencial
{
    public partial class Form1 : Form
    {

        // number of TextBoxes no Form
        private int textBoxCount = 4;

        private List<Registro> listRegistro = new List<Registro>();

        // constantes de enumeração para especificar indices do TextBox 
        public enum TextBoxIndices
        {
            CONTA,
            PRIMEIRO,
            ULTIMO,
            SALDO

        } // end enum

        // para serializar Registro em formato binário
        private BinaryFormatter formatter = new BinaryFormatter();
        private BinaryFormatter reader = new BinaryFormatter();

        // arquivo onde os dados serão gravados
        private FileStream arquivo_saida;
        private FileStream arquivo_entrada; 

        public Form1()
        {
            InitializeComponent();
        }

        // limpa TextBoxes
        public void ClearTextBoxes()
        {
            // iterage através de cada Control no Form
            for (int i = 0; i < Controls.Count; i++)
            {
                Control myControl = Controls[i]; // pega o Control

                // determina se Control é TextBox
                if (myControl is TextBox)
                {
                    // limpa a propriedade Text (seta para string vazia)
                    myControl.Text = "";
                }
            }

        } // fim do método ClearTextBoxes

        // seta os valores dos TextBox para valores num array de string
        public void SetTextBoxValues(string[] values)
        {
            // determina se array de string tem comprimento correto
            if (values.Length != textBoxCount)
            {
                // lança exceção se o comprimento não for correto
                throw (new ArgumentException("Deve existir " +
                   (textBoxCount + 1) + " strings no array"));
            }

            // seta o array de valores se o array tiver comprimento correto
            else
            {
                // set array values to text box values
                tbConta.Text =
                   values[(int)TextBoxIndices.CONTA];
                tbPrimeiroNome.Text =
                   values[(int)TextBoxIndices.PRIMEIRO];
                tbUltimoNome.Text =
                   values[(int)TextBoxIndices.ULTIMO];
                tbSaldo.Text =
                   values[(int)TextBoxIndices.SALDO];
            }

        } // fim do método SetTextBoxValues

        // retorna os valores dos TextBox num array de string
        public string[] GetTextBoxValues()
        {
            string[] values = new string[textBoxCount];

            // copia os campos dos TextBox para array de string
            values[(int)TextBoxIndices.CONTA] =
               tbConta.Text;
            values[(int)TextBoxIndices.PRIMEIRO] =
               tbPrimeiroNome.Text;
            values[(int)TextBoxIndices.ULTIMO] =
               tbUltimoNome.Text;
            values[(int)TextBoxIndices.SALDO] =
               tbSaldo.Text;

            return values;

        } // fim do método GetTextBoxValues

        private void btCriarArquivo_MouseClick(object sender, MouseEventArgs e)
        {
            // cria uma caixa de diálogo para salvar arquivo
            SaveFileDialog fileChooser = new SaveFileDialog();
            DialogResult resultado = fileChooser.ShowDialog();
            string nomeArquivo; // name of file to save data

            // allow user to create file
            fileChooser.CheckFileExists = false;

            // exit event handler if user clicked "Cancel"
            if (resultado == DialogResult.Cancel)
                return;

            // get specified file name
            nomeArquivo = fileChooser.FileName;

            // show error if user specified invalid file
            if (nomeArquivo == "" || nomeArquivo == null)
                MessageBox.Show("Nome de Arquivo Inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // save file via FileStream if user specified valid file
                try
                {
                    // open file with write access
                    arquivo_saida = new FileStream(nomeArquivo,
                       FileMode.OpenOrCreate, FileAccess.Write);

                    // disable Save button and enable Enter button
                    btCriarArquivo.Enabled = false;
                    btGravarRegistro.Enabled = true;
                }

                // handle exception if file does not exist
                catch (FileNotFoundException)
                {
                    // notify user if file does not exist
                    MessageBox.Show("Arquivo não existe", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        } // fim do método btCriarArquivo_MouseClick

        private void btGravarRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            // armazena valores dos TextBox  num array de string
            string[] values = GetTextBoxValues();

            // Registro contendo os valores dos TextBox para serializar
            Registro registro = new Registro();

            // determina se TextBox campo CONTA não está vazio
            if (values[(int)TextBoxIndices.CONTA] != "")
            {
                // armazena valores dos TextBox no Registro e serializa o Registro
                try
                {
                    // pega o valor da CONTA
                    int numeroConta = Int32.Parse(
                       values[(int)TextBoxIndices.CONTA]);

                    // determina se o valor da conta é válido
                    if (numeroConta > 0)
                    {
                        // store TextBox fields in Record
                        registro.setConta(numeroConta);
                        registro.setPrimeiroNome(values[(int)TextBoxIndices.PRIMEIRO]);
                        registro.setUltimoNome(values[(int)TextBoxIndices.ULTIMO]);
                        registro.setSaldo(Double.Parse(values[(int)TextBoxIndices.SALDO]));
                       

                        // grava o Registro no Arquivo Sequencial (serializa o objeto Registro no Arquivo)
                        formatter.Serialize(arquivo_saida, registro);
                    }
                    else
                    {
                        // notifica o usuário de número de conta errado
                        MessageBox.Show("Número de Conta Inválido", "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // notifica o usuário se ocorre erro na serialização
                catch (SerializationException)
                {
                    MessageBox.Show("Erro ao escrever no arquivo", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // notifica o usuário sobre erro de formato
                catch (FormatException)
                {
                    MessageBox.Show("Formato Inválido", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tbConta.Clear();
                tbPrimeiroNome.Clear();
                tbSaldo.Clear();
                tbUltimoNome.Clear();
            }

            ClearTextBoxes(); // clear TextBox values
        } // fim do método btGravarRegistro_MouseClick

        private void btSair_MouseClick(object sender, MouseEventArgs e)
        {
            // determina se arquivo existe
            if (arquivo_saida != null)
            {
                // fecha o arquivo --> tem que fazer toda vez que sair da 
                // aplicação!!
                try
                {
                    arquivo_saida.Close();
                }

                // notifica o usuário se teve erro ao fechar o arquivo
                catch (IOException)
                {
                    MessageBox.Show("Não consigo fechar o arquivo", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Application.Exit();
        } // fim do método btSair_MouseClick

        private void btAbrirArquivo_MouseClick(object sender, MouseEventArgs e)
        {
            // cria caixa de diálogo para usuário abrir arquivo
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName; // nome do arquivo contendo os dados

            // sai do evento se o usuário clicar Cancel
            if (result == DialogResult.Cancel)
                return;

            // obtém o nome do arquivo para leitura
            fileName = fileChooser.FileName;
            ClearTextBoxes();

            // mostra erro se o usuário digitou arquivo inválido
            if (fileName == "" || fileName == null)
                MessageBox.Show("Nome de arquivo inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // cria FileStream para obter acesso de leitura ao arquivo 
                arquivo_entrada = new FileStream(fileName, FileMode.Open,
                   FileAccess.Read);

                // enable next record button
                btProximoRegistro.Enabled = true;
            }
        } // fim do método btAbrirArquivo_MouseClick

        private void btProximoRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            // deserialia objetos da classe Registro e armazena os dados nas TextBoxes
            try
            {
                // get next Record available in file
                Registro registro =
                   (Registro)reader.Deserialize(arquivo_entrada);

                // armazena valores de Registro num array de string 
                string[] values = new string[] {
                                              registro.getConta().ToString(), 
                                              registro.getPrimeiroNome().ToString(),
                                              registro.getUltimoNome().ToString(),
                                              registro.getSaldo().ToString()
                                               };

                // copia os valores do array de string nos valores dos TextBox 
                SetTextBoxValues(values);
            }

            // trata excecção, quando não existe Registro no arquivo
            catch (SerializationException)
            {
                // fecha FileStream se não houver Registro no arquivo
                arquivo_entrada.Close();

                // abilita o botão para abrir arquivo 
                btAbrirArquivo.Enabled = true;

                // disabilita botão de próximo Registro
                btProximoRegistro.Enabled = false;

                ClearTextBoxes();

                // notifica o usuário se não existe Registro em arquivo
                MessageBox.Show("Não existem mais registros no arquivo", "",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } // fim do método btProximoRegistro_MouseClick

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Cria caixa de diálogo para usuário abrir arquivo
            OpenFileDialog fileChooser = new OpenFileDialog();
            DialogResult result = fileChooser.ShowDialog();
            string fileName; // nome do arquivo contendo os dados

            // Sai do evento se o usuário clicar Cancel
            if (result == DialogResult.Cancel)
                return;

            // Obtém o nome do arquivo para leitura
            fileName = fileChooser.FileName;
            ClearTextBoxes();

            // Mostra erro se o usuário digitou arquivo inválido
            if (fileName == "" || fileName == null)
                MessageBox.Show("Nome de arquivo inválido", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Cria FileStream para obter acesso de leitura ao arquivo 
                arquivo_entrada = new FileStream(fileName, FileMode.Open,
                   FileAccess.Read);

                listRegistro.Clear();

                while (true)
                {
                    try
                    {
                        // Get next Record available in file
                        Registro registro =
                           (Registro)reader.Deserialize(arquivo_entrada);

                        // Copia os valores do array de string nos valores dos TextBox 
                        listRegistro.Add(registro);
                    }

                    // Trata excecção, quando não existe Registro no arquivo
                    catch (SerializationException)
                    {
                        // Fecha FileStream se não houver Registro no arquivo
                        arquivo_entrada.Close();
                        break;
                    }
                }
                for (int i = 0; i < listRegistro.Count; i++)
                {
                    txtRelatorio.AppendText("Conta: " + listRegistro[i].getConta().ToString() + "\n");
                    txtRelatorio.AppendText("Nome: " + listRegistro[i].getPrimeiroNome().ToString() + " "
                        + listRegistro[i].getUltimoNome().ToString() + "\n");
                    txtRelatorio.AppendText("Saldo: " + listRegistro[i].getSaldo().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }

            }

        }

        private void btnSaldosPositivos_Click(object sender, EventArgs e)
        {
            txtRelatorio.Clear();

            for (int i = 0; i < listRegistro.Count; i++)
            {
                if (listRegistro[i].getSaldo() > 0)
                {
                    txtRelatorio.AppendText("Conta: " + listRegistro[i].getConta().ToString() + "\n");
                    txtRelatorio.AppendText("Nome: " + listRegistro[i].getPrimeiroNome().ToString() + " "
                        + listRegistro[i].getUltimoNome().ToString() + "\n");
                    txtRelatorio.AppendText("Saldo: " + listRegistro[i].getSaldo().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }
            }
        }

        private void btnSaldosNegativo_Click(object sender, EventArgs e)
        {
            txtRelatorio.Clear();

            for (int i = 0; i < listRegistro.Count; i++)
            {
                if (listRegistro[i].getSaldo() < 0)
                {
                    txtRelatorio.AppendText("Conta: " + listRegistro[i].getConta().ToString() + "\n");
                    txtRelatorio.AppendText("Nome: " + listRegistro[i].getPrimeiroNome().ToString() + " "
                        + listRegistro[i].getUltimoNome().ToString() + "\n");
                    txtRelatorio.AppendText("Saldo: " + listRegistro[i].getSaldo().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }
            }

        }

        private void btnSaldosNulo_Click(object sender, EventArgs e)
        {
            txtRelatorio.Clear();

            for (int i = 0; i < listRegistro.Count; i++)
            {
                if (listRegistro[i].getSaldo() == 0)
                {
                    txtRelatorio.AppendText("Conta: " + listRegistro[i].getConta().ToString() + "\n");
                    txtRelatorio.AppendText("Nome: " + listRegistro[i].getPrimeiroNome().ToString() + " "
                        + listRegistro[i].getUltimoNome().ToString() + "\n");
                    txtRelatorio.AppendText("Saldo: " + listRegistro[i].getSaldo().ToString() + "\n");
                    txtRelatorio.AppendText("\n");
                }

            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (arquivo_entrada != null)
            {
                // fecha o arquivo --> tem que fazer toda vez que sair da 
                // aplicação!!
                try
                {
                    arquivo_entrada.Close();
                }

                // notifica o usuário se teve erro ao fechar o arquivo
                catch (IOException)
                {
                    MessageBox.Show("Não consigo fechar o arquivo", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtRelatorio.Clear();

        }

        private void txtRelatorio_TextChanged(object sender, EventArgs e)
        {
            txtRelatorio.ScrollBars = ScrollBars.Vertical;
        }
    }
}
