﻿#pragma checksum "..\..\..\..\Inventory\Order.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6DC0876DEA1D1926DF4D06A4B255D8B9488AA822"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SA_Three_Tiered;
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


namespace SA_Three_Tiered {
    
    
    /// <summary>
    /// Order
    /// </summary>
    public partial class Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Inventory\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Item_Ident;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Inventory\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ID_Radio;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Inventory\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Item_Name;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Inventory\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantity_text;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Inventory\Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Order_Item_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SA_Three_Tiered;component/inventory/order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Inventory\Order.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Item_Ident = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ID_Radio = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\..\..\Inventory\Order.xaml"
            this.ID_Radio.Checked += new System.Windows.RoutedEventHandler(this.ID_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Item_Name = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.Quantity_text = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Order_Item_button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Inventory\Order.xaml"
            this.Order_Item_button.Click += new System.Windows.RoutedEventHandler(this.Order_Item_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
