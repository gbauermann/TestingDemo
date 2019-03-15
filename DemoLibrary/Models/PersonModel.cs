

namespace DemoLibrary.Models
{
    public class PersonModel
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        public string FullName { get => $"{FisrtName} {LastName}"; }
    }
}
