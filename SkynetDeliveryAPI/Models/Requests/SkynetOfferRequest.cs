namespace SkynetDeliveryAPI.Models.Requests
{
   
    public class SkynetOfferRequest
    {
        public string Consignee { get; set; }
        public string Consignor { get; set; }
        public Package[] Cartons { get; set; }

    }
}
