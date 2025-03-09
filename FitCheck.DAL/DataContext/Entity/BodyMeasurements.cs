using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitCheck.DAL.DataContext.Entity
{
    [Table("BodyMeasurement")]
    public class BodyMeasurements
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Chest")]
        public double Chest {  get; set; }
        [Column("Waist")]
        public double Waist { get; set; }
        [Column("R_Bicep")]
        public double RBicep { get; set; }
        [Column("L_Bicep")]
        public double LBicep { get; set; }
        [Column("R_Forearm")]
        public double RForearm { get; set; }
        [Column("L_Forearm")]
        public double LForearm { get; set; }
        [Column("Shoulders")]
        public double Shoulders { get; set; }
        [Column("Hips")]
        public double Hips { get; set; }
        [Column("R_Thigh")]
        public double RThigh { get; set; }
        [Column("L_Thigh")]
        public double LThigh { get; set; }
        [Column("R_Calf")]
        public double RCalf { get; set; }
        [Column("L_Calf")]
        public double LCalf { get; set; }
        [Column("Weight")]
        public double Weight { get; set; }
        [Column("Last_update")]
        public DateTime LastUpdate { get; set; }
        [Column("User_Id")]
        public int UserId { get; set; }



    }
}
