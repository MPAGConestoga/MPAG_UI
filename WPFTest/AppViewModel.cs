﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
   public class AppViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value);  }
        }

        private ViewModels.OrderViewModel _orderVM;
        public ViewModels.OrderViewModel OrderVM
        {
            get { return _orderVM; }
            set { OnPropertyChanged(ref _orderVM, value); }
        }

        public AppViewModel()
        {
            OrderVM = new ViewModels.OrderViewModel();
            CurrentView = OrderVM;
        }
    }
}
