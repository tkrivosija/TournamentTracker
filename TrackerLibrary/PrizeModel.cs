namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountNumber = 0;
            decimal.TryParse(prizeAmount, out prizeAmountNumber);
            PrizeAmount = prizeAmountNumber;

            double prizePercentageNumber = 0;
            double.TryParse(prizePercentage, out prizePercentageNumber);
            PrizePercentage = prizePercentageNumber;
        }
    }
}