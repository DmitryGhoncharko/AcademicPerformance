﻿#pragma checksum "..\..\..\Views\WinStudentJournal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFC056BA5D3BBD7C6A4D332C3554973E62A3606205D59CFDE3723AF29087A301"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using System.Windows.Forms.Integration;
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


namespace AcademicPerformance.Views {
    
    
    /// <summary>
    /// WinStudent
    /// </summary>
    public partial class WinStudent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 48 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miPersonalProfile;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miExit;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSearch;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbSearch;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgJournal;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\Views\WinStudentJournal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
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
            System.Uri resourceLocater = new System.Uri("/AcademicPerformance;component/views/winstudentjournal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\WinStudentJournal.xaml"
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
            
            #line 9 "..\..\..\Views\WinStudentJournal.xaml"
            ((AcademicPerformance.Views.WinStudent)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miPersonalProfile = ((System.Windows.Controls.MenuItem)(target));
            
            #line 48 "..\..\..\Views\WinStudentJournal.xaml"
            this.miPersonalProfile.Click += new System.Windows.RoutedEventHandler(this.MiPersonalProfile_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.miExit = ((System.Windows.Controls.MenuItem)(target));
            
            #line 50 "..\..\..\Views\WinStudentJournal.xaml"
            this.miExit.Click += new System.Windows.RoutedEventHandler(this.MiExit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblSearch = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.tbSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dgJournal = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\..\Views\WinStudentJournal.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

