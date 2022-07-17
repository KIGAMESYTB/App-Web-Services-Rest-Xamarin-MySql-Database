﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppApi.ViewModels;

namespace AppApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassroomCreatePage : ContentPage
    {
        public ClassroomCreatePage()
        {
            InitializeComponent();
            BindingContext = new ClassroomCreateViewModel();
        }
    }
}