using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Telerik_SampleProject.Model
{
    public class RegistrationModel
    {
        [Key]
        [Column("Reg_Id")]
        public int RegistrationModelID { get; set; }

        #region name
        //TextBox
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "First Name should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        [Column("Reg_Name")]
        public string Name { get; set; }
        #endregion

        #region
        //NumericTextBox
        [Column("Reg_Age")]
        [Required(ErrorMessage = "{0} is required")]
        public int Age { get; set; }

        #endregion

        #region FirstName
        //MaskedTextBox
        [Column("Reg_FirstName")]
        [Required(ErrorMessage = "{0} is required")]
        public string FirstName { get; set; }
        #endregion

        #region Date
        //Calender
        [Required(ErrorMessage = "Please select date")]
        [DataType(DataType.Text)]
        [Column("Reg_Date")]
        public DateTime RegDate { get; set; }
        #endregion


    }
}
