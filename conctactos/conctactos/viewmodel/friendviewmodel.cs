﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace conctactos.viewmodel
{
    class friendviewmodel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public friendviewmodel Friendviewmodel { get; set; }
    }
}
