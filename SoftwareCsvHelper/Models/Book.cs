using CsvHelper.Configuration.Attributes;
public class Book
{
  [Name("titulo")]
  public string Titulo { get; set; }
  [Name("autor")]
  public string Autor { get; set; }
  [Name("preço")]
  [CultureInfo("pt-br")]
  public decimal Preco { get; set; }
  [Name("lançamento")]
  [Format("dd/MM/yyyy")]
  public DateOnly Lancamento { get; set; }
}