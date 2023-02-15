namespace DataTalksFrontendExercise.Dto
{
    public class BaseCardModel
    {
        public int Id { get; private set; } = new Random().Next(0, 100_000);
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
               

    }
}
