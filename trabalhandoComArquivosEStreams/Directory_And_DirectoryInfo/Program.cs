using static System.Console;

CriarDiretoriosGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "Brasil", "brasil.txt");

MoverArquivo(origem, destino);
WriteLine();
CopiarArquivo(origem, destino);
ReadLine();

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
  if (!File.Exists(pathOrigem))
  {
    WriteLine("Arquivo de origem não existe...");
    return;
  }
  if (File.Exists(pathDestino))
  {
    WriteLine("Arquivo de origem não existe...");
    return;
  }
  File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
  if (!File.Exists(pathOrigem))
  {
    WriteLine("Arquivo de origem não existe...");
    return;
  }
  if (File.Exists(pathDestino))
  {
    WriteLine("Arquivo de origem não existe...");
    return;
  }
  File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
  if (!File.Exists(path))
  {
    using var sw = File.CreateText(path);
    sw.WriteLine("Pupulação: 230 milhões");
    sw.WriteLine("Dados Atualizados em 24 de Fevereiro");
  }
}

static void CriarDiretoriosGlobo()
{
  var path = Path.Combine(Environment.CurrentDirectory, "globo");

  if (!Directory.Exists(path))
  {
    var diretorioGlobo = Directory.CreateDirectory(path);

    var americaNorte = diretorioGlobo.CreateSubdirectory("America do Norte");
    var americaCEntral = diretorioGlobo.CreateSubdirectory("America Central");
    var americaSul = diretorioGlobo.CreateSubdirectory("America do Sul");

    americaNorte.CreateSubdirectory("USA");
    americaNorte.CreateSubdirectory("Mexico");

    americaCEntral.CreateSubdirectory("Panama");

    americaSul.CreateSubdirectory("Brasil");
  }
}
