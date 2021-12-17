﻿using DevNcore.UI.Foundation.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DevNcore.WPF.Controls
{
    public class NcoreContent : ContentControl
    {
        public NcoreContent()
        {
            Loaded += NcoreLayer_Loaded;
        }

        private void NcoreLayer_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DataContext is ObservableObject vm)
            {
                vm.ForceViewLoaded(this);
            }
        }
    }
}