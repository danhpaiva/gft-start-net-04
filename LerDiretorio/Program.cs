using static System.Console;

var path = @"D:\work\gft-start-net-04\Directory_And_DirectoryInfo\globo";
LerDiretorios(path);
ReadKey();
Clear();
LerArquivos(path);
ReadLine();

static void LerDiretorios(string path)
{
  if (Directory.Exists(path))
  {
    var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

    foreach (var dir in diretorios)
    {
      var dirInfo = new DirectoryInfo(dir);
      WriteLine($"Nome: {dirInfo.Name}");
      WriteLine($"Raiz: {dirInfo.Root}");
      if (dirInfo.Parent != null)
        WriteLine($"Pai: {dirInfo.Parent.Name}");
      WriteLine();
    }
  }
  else
  {
    WriteLine($"Diretório {path} não existe");
  }
}

static void LerArquivos(string path)
{
  var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
  foreach (var f in files)
  {
    var fileInfo = new FileInfo(f);
    WriteLine($"Nome: {fileInfo.Name}");
    WriteLine($"Tamanho: {fileInfo.Length}");
    WriteLine($"Último Acesso: {fileInfo.LastAccessTime}");
    WriteLine($"Pasta: {fileInfo.DirectoryName}");

    WriteLine();
  }
}