using System.Text;

namespace LightSwitchApplication
{
    public partial class Customer
    {
        partial void FullName_Compute(ref string result)
        {
            // Set result to the desired field value

            var fullNameBuilder = new StringBuilder();

            if (!string.IsNullOrEmpty(LastName))
            {
                fullNameBuilder.Append(LastName);
                fullNameBuilder.Append(" ");
            }

            fullNameBuilder.Append(FirstName);

            if (!string.IsNullOrEmpty(MiddleName))
            {
                fullNameBuilder.Append(" ");
                fullNameBuilder.Append(MiddleName);
            }
            
            result = fullNameBuilder.ToString();
        }
    }
}
