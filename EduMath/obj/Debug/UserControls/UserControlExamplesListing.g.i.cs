﻿#pragma checksum "..\..\..\UserControls\UserControlExamplesListing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2C3FE01BE7814171E725E961F40993BE2C2B6D37EF76DDF7777BDC898EC992F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using EduMath.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EduMath.UserControls {
    
    
    /// <summary>
    /// UserControlExamplesListing
    /// </summary>
    public partial class UserControlExamplesListing : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\UserControls\UserControlExamplesListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxTaskListing;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\UserControls\UserControlExamplesListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxTaskListing2;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\UserControls\UserControlExamplesListing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonReturn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EduMath;component/usercontrols/usercontrolexampleslisting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\UserControlExamplesListing.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ListBoxTaskListing = ((System.Windows.Controls.ListBox)(target));
            
            #line 44 "..\..\..\UserControls\UserControlExamplesListing.xaml"
            this.ListBoxTaskListing.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListBoxTaskListing_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListBoxTaskListing2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.ButtonReturn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\UserControls\UserControlExamplesListing.xaml"
            this.ButtonReturn.Click += new System.Windows.RoutedEventHandler(this.ButtonReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

