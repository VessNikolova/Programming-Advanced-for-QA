namespace Song_01
{
    public class Song
    {
        public string typeList { get; set; }
        public string name { get; set; }
        public string time { get; set; }

        public Song() { }

        public Song(string typeList, string name, string time)
        {
            this.typeList = typeList;
            this.name = name;
            this.time = time;
        }
    }
}
