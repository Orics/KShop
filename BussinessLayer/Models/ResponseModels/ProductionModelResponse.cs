namespace BussinessLayer.Models
{
    public class ProductionModelResponse : BaseModel
    {
        public string ProductionName { get; set; }
        public override bool IsValidate()
        {
            throw new System.NotImplementedException();
        }
    }
}