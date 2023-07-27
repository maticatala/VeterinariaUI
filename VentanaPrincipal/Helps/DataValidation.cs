using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel.Channels;
using System.Windows.Forms;

namespace VentanaPrincipal.Helps
{
    public class DataValidation
    {
        private ValidationContext context;
        private List<ValidationResult> results;
        private bool valid;
        private string message;

        public DataValidation(object instance)
        {
            context = new ValidationContext(instance);
            results = new List<ValidationResult>();
            valid = Validator.TryValidateObject(instance, context, results, true);
        }

        public bool Validate()
        {
            if (!valid)
            {
                foreach(ValidationResult result in results)
                {
                    message += result.ErrorMessage + "\n";
                }
                MessageBox.Show(message);
            }
            return valid;
        }
    }
}
