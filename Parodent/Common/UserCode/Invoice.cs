using System.Linq;

namespace LightSwitchApplication
{
    public partial class Invoice
    {
        partial void DisplayName_Compute(ref string result)
        {
            // Set result to the desired field value
            result = string.Format("{0} - {1}", GenerateDate.ToLongDateString(), Customer == null ? string.Empty : Customer.FullName);
        }

        partial void TotalPrice_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = ProvidedServices.Sum(c => c.Price);
        }

        partial void GenerateDateDisplay_Compute(ref string result)
        {
            // Set result to the desired field value
            result = GenerateDate.ToShortDateString();
        }
    }
}
