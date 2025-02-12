﻿using DemoCenter.Maui.DemoModules.Drawer.Data;
using DemoCenter.Maui.ViewModels;
using Microsoft.Maui.Controls;

namespace DemoCenter.Maui.DemoModules.CollectionView.Views {
    public partial class CollectionViewLoadMoreView : Demo.DemoPage {
        public CollectionViewLoadMoreView() {
            InitializeComponent();
            BindingContext = new LoadMoreViewModel(new MailMessagesRepository());
        }
    }
}
