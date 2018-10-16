using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNative.Infrastucture
{
    using ViewModels;
  public  class InstanceLocator
    {
        public MainViewModel Main { get; set; } // Binding principal

        public InstanceLocator()
        {
            this.Main = new MainViewModel(); 
        }
    }
}
