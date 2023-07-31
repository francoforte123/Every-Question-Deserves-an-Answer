namespace Every_Question_Deserves_an_Answer.Models
{
    public class Response
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string IsAccepted { get; set; }
        public Request Request { get; set; }
    }
}
