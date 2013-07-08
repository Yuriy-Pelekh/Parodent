using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class InvoiceDetail
    {
        partial void Invoice_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Invoice);
        }

        partial void Invoice_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Invoice);
        }

        partial void InvoiceDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Invoice);
        }
    }
}