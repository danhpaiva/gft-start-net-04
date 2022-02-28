using CsvHelper.Configuration.Attributes;
public class Book
{
  public string Titulo { get; set; }
  public string Autor { get; set; }
  public decimal Preco { get; set; }
  public DateOnly Lancamento { get; set; }
}