#pragma checksum "..\..\..\..\AddNewTemplate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20B40D7E2721D0F4D3560A710984733A0BE09AD1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Design_4;
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


namespace Design_4 {
    
    
    /// <summary>
    /// AddNewTemplate
    /// </summary>
    public partial class AddNewTemplate : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\AddNewTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox templatePathTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\AddNewTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button findNugetFileBtnn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\AddNewTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button installTemplateBtnss;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\AddNewTemplate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox powerShellOutputListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Design 4;component/addnewtemplate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AddNewTemplate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.templatePathTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.findNugetFileBtnn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\AddNewTemplate.xaml"
            this.findNugetFileBtnn.Click += new System.Windows.RoutedEventHandler(this.findNugetFileBtn);
            
            #line default
            #line hidden
            return;
            case 3:
            this.installTemplateBtnss = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\AddNewTemplate.xaml"
            this.installTemplateBtnss.Click += new System.Windows.RoutedEventHandler(this.installTemplateBtn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 57 "..\..\..\..\AddNewTemplate.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.nextBtnAddNewTemplate);
            
            #line default
            #line hidden
            return;
            case 5:
            this.powerShellOutputListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

