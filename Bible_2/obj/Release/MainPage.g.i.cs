﻿#pragma checksum "C:\Users\Elroy\Documents\Visual Studio 2012\Projects\Bible_2\Bible_2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E2976D772CCC0968C68008EE90286F57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using RateMyApp.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Bible_2 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal RateMyApp.Controls.FeedbackOverlay FeedbackOverlay;
        
        internal Microsoft.Phone.Controls.LongListSelector OldSelector;
        
        internal System.Windows.DataTemplate old;
        
        internal Microsoft.Phone.Controls.LongListSelector NewSelector;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Bible_2;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.FeedbackOverlay = ((RateMyApp.Controls.FeedbackOverlay)(this.FindName("FeedbackOverlay")));
            this.OldSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("OldSelector")));
            this.old = ((System.Windows.DataTemplate)(this.FindName("old")));
            this.NewSelector = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("NewSelector")));
        }
    }
}

