﻿#pragma checksum "..\..\UserManager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16EA6D11D4924A8AD7F4395C4B55DD0C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UserTasks;


namespace UserTasks {
    
    
    /// <summary>
    /// UserManager
    /// </summary>
    public partial class UserManager : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxIsikukood;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEesnimi;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPerekonnanimi;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKasutaja;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxParool;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddUser;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemoveUser;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\UserManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
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
            System.Uri resourceLocater = new System.Uri("/UserTasks;component/usermanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserManager.xaml"
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
            this.TextBoxIsikukood = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxEesnimi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxPerekonnanimi = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxKasutaja = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TextBoxParool = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ButtonAddUser = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\UserManager.xaml"
            this.ButtonAddUser.Click += new System.Windows.RoutedEventHandler(this.ButtonAddUser_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\UserManager.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonUuenda_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonRemoveUser = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\UserManager.xaml"
            this.ButtonRemoveUser.Click += new System.Windows.RoutedEventHandler(this.ButtonRemoveUser_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 48 "..\..\UserManager.xaml"
            this.listView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.listView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

