﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C1B72C0077D4AA9E12D57C4098CE25ECD2B646D"
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
using System.Windows.Controls.Ribbon;
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DebugText;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_MouseAccel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cb_DarkMode;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Install;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label txt_background;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_background;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DebugText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.cb_MouseAccel = ((System.Windows.Controls.CheckBox)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.cb_MouseAccel.Checked += new System.Windows.RoutedEventHandler(this.cb_MouseAccelButton_Checked);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.cb_MouseAccel.Unchecked += new System.Windows.RoutedEventHandler(this.cb_MouseAccelButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cb_DarkMode = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.cb_DarkMode.Checked += new System.Windows.RoutedEventHandler(this.cb_DarkMode_Checked);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.cb_DarkMode.Unchecked += new System.Windows.RoutedEventHandler(this.cb_DarkMode_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Install = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\MainWindow.xaml"
            this.btn_Install.Click += new System.Windows.RoutedEventHandler(this.btn_InstallVSC_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txt_background = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btn_background = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\MainWindow.xaml"
            this.btn_background.Click += new System.Windows.RoutedEventHandler(this.btn_changeBg_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

