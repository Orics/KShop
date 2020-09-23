using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.DataObjects
{
    [Table("PhoneModels")]
    public class PhoneModel : Product
    {
        public Phone Phone { get; set; }
        public string Network { get; set; }
        public string Body { get; set; }
        public string Platfrom { get; set; }
        public string Memory { get; set; }
        public string MainCamera { get; set; }
        public string SelfieCamera { get; set; }
        public string Sound { get; set; }
        public string Communications { get; set; }
        public string Features { get; set; }
        public string Battery { get; set; }
    }
}