
namespace Articles
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                string command = commands[0];

                if(command == "Edit")
                {
                    string newContent = commands[1];
                    article.Edit(newContent);
                }else if(command == "ChangeAuthor")
                {
                    string newAuthor = commands[1];
                    article.ChangeAuthor(newAuthor);
                }else if(command == "Rename")
                {
                    string newTitle = commands[1];
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
