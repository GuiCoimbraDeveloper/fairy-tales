namespace FairyTales.Models
{
    public class FairyTale
    {
        public string Name { get; set; }
        public TimeSpan ReadTime { get; set; }
        public bool IsSaved { get; set; }
        public string Image { get; set; }
    }
}
