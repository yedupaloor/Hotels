namespace Hotels.ViewModels
{
    public class HotelCommentVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public string CreatedOn { get; set; }
        public int HotelId { get; set; }
    }
}