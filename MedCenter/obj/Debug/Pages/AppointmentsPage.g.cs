﻿#pragma checksum "..\..\..\Pages\AppointmentsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9DB74FEA2EE19CCA9F55738A4F8A7F979D0A1A30DD7398C2533B680D21DBD5D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MedCenter.Pages;
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


namespace MedCenter.Pages {
    
    
    /// <summary>
    /// AppointmentsPage
    /// </summary>
    public partial class AppointmentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSorting;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFilter;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtResultAmount;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAllAmount;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LViewAppointment;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu contextMenu;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnEditAppointment;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnDeleteAppointment;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\AppointmentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddAppointment;
        
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
            System.Uri resourceLocater = new System.Uri("/MedCenter;component/pages/appointmentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AppointmentsPage.xaml"
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
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\Pages\AppointmentsPage.xaml"
            this.tbSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbSorting = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\Pages\AppointmentsPage.xaml"
            this.cmbSorting.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSorting_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\Pages\AppointmentsPage.xaml"
            this.cmbFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtResultAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtAllAmount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.LViewAppointment = ((System.Windows.Controls.ListView)(target));
            return;
            case 7:
            this.contextMenu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 8:
            this.btnEditAppointment = ((System.Windows.Controls.MenuItem)(target));
            
            #line 83 "..\..\..\Pages\AppointmentsPage.xaml"
            this.btnEditAppointment.Click += new System.Windows.RoutedEventHandler(this.btnEditAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnDeleteAppointment = ((System.Windows.Controls.MenuItem)(target));
            
            #line 84 "..\..\..\Pages\AppointmentsPage.xaml"
            this.btnDeleteAppointment.Click += new System.Windows.RoutedEventHandler(this.btnDeleteAppointment_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnAddAppointment = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\..\Pages\AppointmentsPage.xaml"
            this.btnAddAppointment.Click += new System.Windows.RoutedEventHandler(this.btnAddAppointment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

