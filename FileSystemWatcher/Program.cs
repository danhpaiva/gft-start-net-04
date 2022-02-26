using static System.Console;

var path = @"D:\work\gft-start-net-04\Directory_And_DirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;
fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

WriteLine($"Monitorando eventos na pasta: {path} \nPressione ENTER para finalizar...");
ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
  WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
  WriteLine($"Foi deletado o arquivo {e.Name}");
}

void OnRenamed(object sender, FileSystemEventArgs e)
{
  WriteLine($"Foi renomeado o arquivo {e.Name}");
}