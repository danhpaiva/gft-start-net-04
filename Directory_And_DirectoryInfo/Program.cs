var path = Path.Combine(Environment.CurrentDirectory, "globo");

var diretorioGlobo = Directory.CreateDirectory(path);

var americaNorte = diretorioGlobo.CreateSubdirectory("America do Norte");
var americaCEntral = diretorioGlobo.CreateSubdirectory("America Central");
var americaSul = diretorioGlobo.CreateSubdirectory("America do Sul");

americaNorte.CreateSubdirectory("USA");
americaNorte.CreateSubdirectory("Mexico");

americaCEntral.CreateSubdirectory("Panama");

americaSul.CreateSubdirectory("Brasil");