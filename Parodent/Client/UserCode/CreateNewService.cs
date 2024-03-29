﻿using System;
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
    public partial class CreateNewService
    {
        partial void CreateNewService_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ServicesProperty = new Service();
        }

        partial void CreateNewService_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ServicesProperty);
        }
    }
}