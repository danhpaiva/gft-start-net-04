using CsvStream;
using static System.Console;

CriarArquivoCSV();

WriteLine("Pressione Enter para finalizar...");
ReadLine();

static void CriarArquivoCSV()
{
  var path = Path.Combine(Environment.CurrentDirectory, "Saida");

  var pessoas = new List<Pessoa>()
  {
    new Pessoa(){
      Nome = "Daniel Paiva",
      Email = "danpaiva@live.com",
      Telefone = 31313131,
      Nascimento = new DateOnly(year: 1990, month: 10, day: 18)
    },
    new Pessoa(){
      Nome = "Fernanda Paiva",
      Email = "fernanda@live.com",
      Telefone = 31313131,
      Nascimento = new DateOnly(year: 1990, month: 10, day: 18)
    },
     new Pessoa(){
      Nome = "Daniel Paiva",
      Email = "danpaiva@live.com",
      Telefone = 31313131,
      Nascimento = new DateOnly(year: 1990, month: 10, day: 18)
    },
    new Pessoa(){
      Nome = "Fernanda Paiva",
      Email = "fernanda@live.com",
      Telefone = 31313131,
      Nascimento = new DateOnly(year: 1990, month: 10, day: 18)
    }
  };

  var diretorio = new DirectoryInfo(path);
  if (!diretorio.Exists)
  {
    diretorio.Create();
    path = Path.Combine(path, "usuarios-criados.csv");
    WriteLine($"Diretório e arquivo criado: {path}");
  }

  using var streamWriter = new StreamWriter(path);
  streamWriter.WriteLine("nome,email,telefone,nascimento");

  foreach (var pessoa in pessoas)
  {
    var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
    streamWriter.WriteLine(linha);
  }
}

static void LerArquivoCsv()
{
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

}