﻿#pragma checksum "..\..\InsuranceCompany.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BEA53B0E8F99253CFA5D6441323FB7FD03D8BBBFBE64E651A340DDE1A8F78EFF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PohoronnoeBuro;
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


namespace PohoronnoeBuro {
    
    
    /// <summary>
    /// InsuranceCompany
    /// </summary>
    public partial class InsuranceCompany : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RoleDgr;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBut;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UpdBut;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBut;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextTBx;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmpBut;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\InsuranceCompany.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EmpBut_Копировать;
        
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
            System.Uri resourceLocater = new System.Uri("/PohoronnoeBuro;component/insurancecompany.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsuranceCompany.xaml"
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
            this.RoleDgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\InsuranceCompany.xaml"
            this.RoleDgr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RoleDgr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddBut = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\InsuranceCompany.xaml"
            this.AddBut.Click += new System.Windows.RoutedEventHandler(this.AddBut_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.UpdBut = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\InsuranceCompany.xaml"
            this.UpdBut.Click += new System.Windows.RoutedEventHandler(this.UpdBut_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DeleteBut = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\InsuranceCompany.xaml"
            this.DeleteBut.Click += new System.Windows.RoutedEventHandler(this.DeleteBut_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextTBx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EmpBut = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\InsuranceCompany.xaml"
            this.EmpBut.Click += new System.Windows.RoutedEventHandler(this.EmpBut_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EmpBut_Копировать = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\InsuranceCompany.xaml"
            this.EmpBut_Копировать.Click += new System.Windows.RoutedEventHandler(this.EmpBut_Копировать_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

