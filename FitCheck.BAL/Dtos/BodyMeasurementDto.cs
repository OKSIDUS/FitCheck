using System.ComponentModel.DataAnnotations.Schema;

namespace FitCheck.BAL.Dtos
{
    public class BodyMeasurementDto
    {
        public int Id { get; set; }
        public double Chest { get; set; }
        public double Waist { get; set; }
        public double RBicep { get; set; }
        public double LBicep { get; set; }
        public double RForearm { get; set; }
        public double LForearm { get; set; }
        public double Shoulders { get; set; }
        public double Hips { get; set; }
        public double RThigh { get; set; }
        public double LThigh { get; set; }
        public double RCalf { get; set; }
        public double LCalf { get; set; }
        public double Weight { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserId { get; set; }
    }
}
