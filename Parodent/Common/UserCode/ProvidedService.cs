
namespace LightSwitchApplication
{
    public partial class ProvidedService
    {
        partial void Price_Compute(ref decimal result)
        {
            // Set result to the desired field value
            result = Service == null ? 0 : Service.Price*Count;
        }
    }
}
