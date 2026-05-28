using System.Text.Json;

var json = JsonSerializer.Serialize(new { Message = "Hello, World!" });
Console.WriteLine(json);
