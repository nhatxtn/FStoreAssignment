﻿#pragma checksum "..\..\..\WindowHomepage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B5CABACF71A33D5A65B1236BF9A211A605865D34"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SalesWPFApp;
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


namespace SalesWPFApp {
    
    
    /// <summary>
    /// WindowHomepage
    /// </summary>
    public partial class WindowHomepage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView objectList;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTitle;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearchProduct;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchProduct;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchProduct;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblReportTitle;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFrom;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtStartDate;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTo;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtEndDate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\WindowHomepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExport;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SalesWPFApp;component/windowhomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowHomepage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnMemberNav_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnProductNav_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnOrderNav_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 15 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnLogout_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.objectList = ((System.Windows.Controls.ListView)(target));
            
            #line 16 "..\..\..\WindowHomepage.xaml"
            this.objectList.Loaded += new System.Windows.RoutedEventHandler(this.LoadMembers);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\WindowHomepage.xaml"
            this.objectList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GetCurrentSelection);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\WindowHomepage.xaml"
            this.objectList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.UpdateObject);
            
            #line default
            #line hidden
            return;
            case 6:
            this.labelTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            
            #line 35 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\..\WindowHomepage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lblSearchProduct = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.txtSearchProduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btnSearchProduct = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\WindowHomepage.xaml"
            this.btnSearchProduct.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.lblReportTitle = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.lblFrom = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.dtStartDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 15:
            this.lblTo = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.dtEndDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 17:
            this.btnExport = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\WindowHomepage.xaml"
            this.btnExport.Click += new System.Windows.RoutedEventHandler(this.btnExport_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

