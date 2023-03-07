using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VeterinaryCrud.Presenter.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMessage = "";
            var results = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);

            bool isValid = Validator.TryValidateObject(model, validationContext, results, true);
            if (!isValid)
            {
                foreach (var item in results)
                {
                    errorMessage += "- " + item.ErrorMessage + "\n";
                }
                throw new Exception(errorMessage);
            }

        }
    }
}
