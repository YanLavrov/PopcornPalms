﻿#pragma checksum "..\..\..\Views\Popcorn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D895E57D07DC98D8F43F93BADAFD6A3881FF3D65563550A3EFB2015ED085C19F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project.ViewModels;
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


namespace Project {
    
    
    /// <summary>
    /// Popcorn
    /// </summary>
    public partial class Popcorn : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Time;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Butt1L;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l1;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Butt3L;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l3;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Butt5L;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l5;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Caramel;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fruit;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cheese;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bacon;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Views\Popcorn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label totalLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/views/popcorn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Popcorn.xaml"
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
            this.Time = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Butt1L = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Views\Popcorn.xaml"
            this.Butt1L.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.l1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Butt3L = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Views\Popcorn.xaml"
            this.Butt3L.Click += new System.Windows.RoutedEventHandler(this.Butt3L_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.l3 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Butt5L = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Views\Popcorn.xaml"
            this.Butt5L.Click += new System.Windows.RoutedEventHandler(this.Butt5L_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.l5 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 51 "..\..\..\Views\Popcorn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Caramel = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Views\Popcorn.xaml"
            this.Caramel.Click += new System.Windows.RoutedEventHandler(this.Caramel_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Fruit = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Views\Popcorn.xaml"
            this.Fruit.Click += new System.Windows.RoutedEventHandler(this.Fruit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Cheese = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Views\Popcorn.xaml"
            this.Cheese.Click += new System.Windows.RoutedEventHandler(this.Cheese_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Bacon = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Views\Popcorn.xaml"
            this.Bacon.Click += new System.Windows.RoutedEventHandler(this.Bacon_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.totalLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

