

namespace MyHottel.Models
{
    public class Room :EntityBase
    {
        public string Number { get; set; }
        public Category Category { get; set; }
        public string NumberOfRoom { get; set; }

    }
}
