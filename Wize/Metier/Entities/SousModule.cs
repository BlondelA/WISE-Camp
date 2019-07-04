namespace Metier.Entities
{
    public class SousModule
    {
        public int Id { get; set; }
        public string referenceModule { get; set; } // TEXT (0 , 3000)
        public int typeModule { get; set; } // CODE (dict-type-module)
    }
}
