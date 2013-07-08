
namespace LightSwitchApplication
{
    public partial class Service
    {
        partial void DisplayName_Compute(ref string result)
        {
            // Set result to the desired field value
            result = string.Format("{0}: {1}", Code, Name);
        }
    }
}
