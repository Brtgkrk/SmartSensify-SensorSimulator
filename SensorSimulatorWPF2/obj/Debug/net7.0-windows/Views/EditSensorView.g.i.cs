﻿#pragma checksum "..\..\..\..\Views\EditSensorView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C3C65B6E851177D1A869C534693F9E070A7A9C13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SensorSimulatorWPF2.Views;
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


namespace SensorSimulatorWPF2.Views {
    
    
    /// <summary>
    /// EditSensorView
    /// </summary>
    public partial class EditSensorView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SensorNameText;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SensorIdText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SensorSecretKeyText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SensorChangeSpeedText;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeNameText;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeUnitText;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValueMinText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ValueMaxText;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WarningTypeText;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label WarningText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\EditSensorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxSensorTypes;
        
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
            System.Uri resourceLocater = new System.Uri("/SensorSimulatorWPF2;component/views/editsensorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\EditSensorView.xaml"
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
            this.SensorNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SensorIdText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SensorSecretKeyText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SensorChangeSpeedText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TypeNameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TypeUnitText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ValueMinText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ValueMaxText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 35 "..\..\..\..\Views\EditSensorView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewTypeClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.WarningTypeText = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.WarningText = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            
            #line 41 "..\..\..\..\Views\EditSensorView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveSensorClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.listBoxSensorTypes = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
