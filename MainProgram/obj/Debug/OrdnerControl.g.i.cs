﻿#pragma checksum "..\..\OrdnerControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AFF81492094146826B646AF2DE4318CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using MainProgram;
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


namespace MainProgram {
    
    
    /// <summary>
    /// OrdnerControl
    /// </summary>
    public partial class OrdnerControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\OrdnerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx_path;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\OrdnerControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbx_uo;
        
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
            System.Uri resourceLocater = new System.Uri("/MainProgram;component/ordnercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OrdnerControl.xaml"
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
            
            #line 8 "..\..\OrdnerControl.xaml"
            ((MainProgram.OrdnerControl)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbx_path = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\OrdnerControl.xaml"
            this.tbx_path.LostFocus += new System.Windows.RoutedEventHandler(this.tbx_path_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbx_uo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\OrdnerControl.xaml"
            this.cbx_uo.Checked += new System.Windows.RoutedEventHandler(this.cbx_uo_Checked);
            
            #line default
            #line hidden
            
            #line 18 "..\..\OrdnerControl.xaml"
            this.cbx_uo.Unchecked += new System.Windows.RoutedEventHandler(this.cbx_uo_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\OrdnerControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Change_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\OrdnerControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Open_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

