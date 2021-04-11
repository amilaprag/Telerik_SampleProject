using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Telerik_SampleProject.Model
{
    [Table("RegistrationMaster")]
    public class RegistrationModel
    {
        [Key]
        [Column("Reg_Id")]
        public int RegistrationModelID { get; set; }

        #region Name
        [StringLength(50, MinimumLength = 3,ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        [Column("Reg_Name")]
        public string Name { get; set; }
        #endregion

        #region Age
        [Column("Reg_Age")]
        [Range(0, 100)]
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }
        #endregion

        #region FirstName
        [Column("Reg_FirstName")]
        [Required(ErrorMessage = "{0} is required")]
        public string FirstName { get; set; }
        #endregion

        #region Date
        [Required(ErrorMessage = "Please select date")]
        [DataType(DataType.Text)]
        [Column("Reg_Date")]
        public DateTime RegDate { get; set; }
        #endregion

        #region CivilStatus
        [Required(ErrorMessage = "Please select date")]
        [Column("Reg_CivilStatus")]
        public bool CivilStatus { get; set; }
        #endregion

        #region Langudage
        [DataType(DataType.Text)]
        [Column("Reg_Language")]
        public string Langudage { get; set; }
        #endregion

        #region Subscription
        [Required(ErrorMessage = "Please select date")]
        [Column("Reg_Subscription")]
        public bool Subscription { get; set; }
        #endregion

        #region City
        // [Required(ErrorMessage = "Please select a city")]
        [Column("Reg_City")]
        public String City { get; set; }
        #endregion

    }
}
