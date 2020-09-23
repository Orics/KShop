using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.DataObjects
{
    [Table("LaptopModels")]
    public class LaptopModel : Product
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Graphics { get; set; }
        public string Screen { get; set; }
        public string Storage { get; set; }
        public string Camera { get; set; }
        public string Weight { get; set; }
        public string Battery { get; set; }
        public string Audio { get; set; }
        public string CardReader { get; set; }
        public string OS { get; set; }
    }
}