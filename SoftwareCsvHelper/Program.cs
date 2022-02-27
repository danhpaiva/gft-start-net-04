using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper;
using static System.Console;

// dotnet add package CsvHelper --version 27.2.1
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

ReadLine();