using static System.Console;

var path = @"D:\work\gft-start-net-04\Directory_And_DirectoryInfo\globos";
LerDiretorios(path);
ReadKey();

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