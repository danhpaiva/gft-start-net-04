using static System.Console;

var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuarios.csv");

if (File.Exists(path))
{
  using StreamReader streamReader = new StreamReader(path);

  var cabecalho = streamReader.ReadLine()?.Split(',');

  while (true)
  {
    var linha = streamReader.ReadLine()?.Split(',');
    if (linha == null) break;

    if (cabecalho.Length == linha.Length)
    {
      for (int i = 0; i < linha.Length; i++)
      {
        WriteLine($"{cabecalho?[i]}:{linha[i]}");
      }
      WriteLine();
    }
    else
    {
      WriteLine("Verifique o arquivo csv e suas delimitações.");
      break;
    }
  }
}
else
{
  WriteLine("O arquivo não existe...");
}



WriteLine("Pressione Enter para finalizar...");
ReadLine();