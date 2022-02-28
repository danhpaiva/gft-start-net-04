using static System.Console;

string textReaderText = "Em pronunciamento televisionado às 05h55 (horário de Moscou) do dia 24/2," +
"Putin anunciou uma 'operação militar' na região de Donbas, no leste da Ucrânia.\n\n" +

"Esta área abriga muitos ucranianos de língua russa, " +
"partes dela foram ocupadas e administradas por rebeldes apoiados pela Rússia desde 2014.\n\n" +

"Putin disse que a Rússia estava intervindo como um ato de legítima defesa, " +
"a Rússia não queria ocupar a Ucrânia, segundo ele, mas iria desmilitarizar e 'desnazificar' o país.\n\n";

WriteLine($"Texto Original: \n{textReaderText}");
string linha, paragrafo = null;
StringReader stringReader = new StringReader(textReaderText);

while (true)
{
  linha = stringReader.ReadLine();
  if (linha != null)
  {
    paragrafo += linha + " ";
  }
  else
  {
    paragrafo += '\n';
    break;
  }
}

WriteLine($"Texto modificado: \n{paragrafo}");
ReadLine();
int caracterLido;
char caracterConvertido;

StringWriter stringWriter = new StringWriter();
stringReader = new StringReader(paragrafo);

while (true)
{
  caracterLido = stringReader.Read();
  if (caracterLido == -1) break;

  caracterConvertido = Convert.ToChar(caracterLido);

  if (caracterConvertido == '.')
  {
    stringWriter.Write("\n\n");

    stringReader.Read();
    stringReader.Read();
  }
  else
  {
    stringWriter.Write(caracterConvertido);
  }
}
WriteLine($"Texto armazenado no stringWriter: \n{stringWriter.ToString()}");
WriteLine("Digite enter para finalizar...");
ReadLine();