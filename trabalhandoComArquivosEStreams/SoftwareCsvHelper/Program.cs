using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

// dotnet add package CsvHelper --version 27.2.1
//LerArquivoCsvComDynamic();
//LerCsvComClasse();
//LerArquivoCsvComOutroDelimitador();

EscreverEmCsv();

static void EscreverEmCsv()
{
  var path = Path.Combine(Environment.CurrentDirectory, "Saida");

  var diretorioInfo = new DirectoryInfo(path);
  if (!diretorioInfo.Exists) diretorioInfo.Create();

  path = Path.Combine(path, "usuarios.csv");

  var pessoas = new List<Pessoa>()
    {
        new Pessoa()
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = 123456,
        },
        new Pessoa()
        {
            Nome = "Pedro Paiva",
            Email = "pp@gmail.com",
            Telefone = 456789,
        },
        new Pessoa()
        {
            Nome = "Maria Antonia",
            Email = "ma@gmail.com",
            Telefone = 123456,
        },
        new Pessoa()
        {
            Nome = "Carla Moraes",
            Email = "cms@gmail.com",
            Telefone = 9987411,

        },
    };
  using var sr = new StreamWriter(path);
  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
  {
    Delimiter = "|"
  };
  using var csvWriter = new CsvWriter(sr, csvConfig);
  csvWriter.WriteRecords(pessoas);
}

static void LerArquivoCsvComOutroDelimitador()
{
  var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "livros.csv");

  var fileInfo = new FileInfo(path);

  if (!fileInfo.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe.");

  using var streamReader = new StreamReader(fileInfo.FullName);
  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
  {
    Delimiter = ";"
  };

  using var csvReader = new CsvReader(streamReader, csvConfig);
  csvReader.Context.RegisterClassMap<LivroMap>();
  var registros = csvReader.GetRecords<Book>();

  foreach (var registro in registros)
  {
    WriteLine($"Titulo:{registro.Titulo}");
    WriteLine($"Preço:{registro.Preco}");
    WriteLine($"Autor:{registro.Autor}");
    WriteLine($"Lançamento:{registro.Lancamento}");
    WriteLine();
  }
}

static void LerCsvComClasse()
{
  var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "users.csv");

  var fileInfo = new FileInfo(path);

  if (!fileInfo.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe.");

  using var streamReader = new StreamReader(fileInfo.FullName);
  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
  using var csvReader = new CsvReader(streamReader, csvConfig);

  var registros = csvReader.GetRecords<User>();

  foreach (var registro in registros)
  {
    WriteLine($"Nome:{registro.Nome}");
    WriteLine($"Email:{registro.Email}");
    WriteLine($"Telefone:{registro.Telefone}");
    WriteLine();
  }
}

static void LerArquivoCsvComDynamic()
{
  var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "produtos.csv");

  var fileInfo = new FileInfo(path);

  if (!fileInfo.Exists)
    throw new FileNotFoundException($"O arquivo {path} não existe.");

  using var streamReader = new StreamReader(fileInfo.FullName);
  var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
  using var csvReader = new CsvReader(streamReader, csvConfig);

  var registros = csvReader.GetRecords<dynamic>();

  foreach (var registro in registros)
  {
    WriteLine($"Nome:{registro.Produto}");
    WriteLine($"Marca:{registro.Marca}");
    WriteLine($"Preço:{registro.Preco}");
    WriteLine();
  }
}

WriteLine("Digite Enter para finalizar...");
ReadLine();