using System.Text;
using static System.Console;

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.AppendLine("Texto na primeira linha a ser lido...");
stringBuilder.AppendLine("Texto na segunda linha a ser lido...");
stringBuilder.AppendLine("Texto na terceira linha a ser lido...");

using var stringReader = new StringReader(stringBuilder.ToString());
var buffer = new char[10];
var tamanho = 0;

LerArquivosPequenos(buffer, tamanho, stringReader);

WriteLine("\nDigite ENTER para finalizar...");
ReadLine();

static void LerArquivosPequenos(char[] bufferzinho, int tamanho, StringReader stringReader)
{
  do
  {
    WriteLine(stringReader.ReadLine());
  } while (stringReader.Peek() >= 0); //Retorna -1 quando acabar
}

static void LerArquivosGrandes(char[] bufferzinho, int tamanho, StringReader stringReader)
{
  do
  {
    bufferzinho = new char[10]; //Limpa o buffer para retirar a sujeira
    tamanho = stringReader.Read(bufferzinho);
    Write(string.Join("", bufferzinho));
  } while (tamanho >= bufferzinho.Length);
}