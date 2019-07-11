namespace Metier.Entities
{
    public class SousModule
    {
        public int Id { get; set; }
        // TEXT (0, 3000)
        public string referenceModule { get; set; }
        // CODE (dict-type-module)
        public Code typeModule { get; set; }
    }
}
