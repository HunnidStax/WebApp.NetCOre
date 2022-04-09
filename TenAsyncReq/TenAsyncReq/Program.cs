using System.Text.Json;


class Program
{
    static readonly HttpClient client = new HttpClient();
    static readonly string url = "https://jsonplaceholder.typicode.com/posts/";
    static readonly string fileName = "result.txt";
    static readonly int tasksCount = 10;
    static readonly int startId = 4;

    static async Task Main(string[] args)
    {
        var tasks = new Task<Post>[tasksCount];
        for (int i = 0; i < tasksCount; i++)
        {
            tasks[i] = GetPostAsync(startId + i);
        }

        Task.WaitAll(tasks);

        using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.Default))
        {
            foreach (var task in tasks)
            {
                if (task.Result != null)
                {
                    string text = task.Result.ToString();
                    await sw.WriteLineAsync(text);
                    Console.WriteLine(text);
                }
            }
        }

        Console.WriteLine("Done. Press any key!");
        Console.ReadKey();
    }

    static async Task<Post> GetPostAsync(int id)
    {
        try
        {
            string path = $"{url}{id}";
            var jsonText = await client.GetStringAsync(path);

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var post = JsonSerializer.Deserialize<Post>(jsonText, serializeOptions);
            return post;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in task with id={id}: {ex.Message}");
            return null;
        }
    }
}
