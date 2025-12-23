namespace Tyuiu.KozhevnikovYV.Sprint6.Task6.V25.Lib
{
    using System.Text;
    using tyuiu.cources.programming.interfaces.Sprint6;
    public class DataService : ISprint6Task6V25
    {
        public string CollectTextFromFile(string path)
        {

            StringBuilder res = new StringBuilder();

            using (StreamReader reader  = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (string w in words)
                    {
                        // слово содержит E или e
                        if (w.IndexOf('E') >= 0)
                        {
                            res.Append(w).Append(' '); // можно AppendLine(w) если нужно с новой строки
                        }
 
                    }
                }
            }
            return res.ToString().Trim();
        }
    }
}
