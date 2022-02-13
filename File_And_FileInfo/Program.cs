using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nameFile = ReadLine();
nameFile = SanitizarNomeArquivo(nameFile);

var path = Path.Combine(Environment.CurrentDirectory, $"{nameFile}.txt");
CriarArquivo(path);

WriteLine("Pressione ENTER para finalizar...");
ReadLine();

static string SanitizarNomeArquivo(string nameFile)
{
  foreach (var itemInvalid in Path.GetInvalidFileNameChars())
  {
    nameFile = nameFile.Replace(itemInvalid, '-');
  }
  return nameFile;
}

static void CriarArquivo(string path)
{
  try
  {
    using var sw = File.CreateText(path);
    sw.WriteLine("Esta é a linha 01 do arquivo.");
    sw.WriteLine("Esta é a linha 02 do arquivo.");
    sw.WriteLine("Esta é a linha 03 do arquivo.");
  }
  catch
  {
    WriteLine("O nome do arquivo é inválido.");
  }
}