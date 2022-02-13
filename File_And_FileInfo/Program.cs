var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");

using var sw = File.CreateText(path);
sw.WriteLine("Esta é a linha 01 do arquivo.");
sw.WriteLine("Esta é a linha 02 do arquivo.");
sw.WriteLine("Esta é a linha 03 do arquivo.");