namespace Song_01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Song> list = new List<Song>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string typeList = input[0];
                string name = input[1];
                string time = input[2];

                Song newSong = new Song(typeList, name, time);

                list.Add(newSong);
            }

            string request = Console.ReadLine();


            foreach (Song song in list)
            {
                if (request == "all")
                {
                    Console.WriteLine(song.name);
                }
                else
                {
                    if (request == song.typeList)
                    {
                        Console.WriteLine(song.name);
                    }
                }
            }
        }
    }
}


