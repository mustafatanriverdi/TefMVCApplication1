namespace TefMVCApplication1.ViewModels
{
    public class UserVM
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Province { get; set; } = null!;

        public string? FullName { get; set; } 
    }
}
