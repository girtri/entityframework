
namespace EntityFrameTest2.Models
{
    class Game
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
