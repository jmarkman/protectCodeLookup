﻿#pragma checksum "..\..\SendEdit.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E23F000B6372904919C4CBFA4DCFF40C"
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
using ppcLookupV2;


namespace ppcLookupV2 {
    
    
    /// <summary>
    /// SendEdit
    /// </summary>
    public partial class SendEdit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ppcLookupV2.SendEdit requestEdit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox requestCbox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox stateBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countyBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox townBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox codeBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendRequest;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SendEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelRequest;
        
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
            System.Uri resourceLocater = new System.Uri("/ppcLookupV2;component/sendedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SendEdit.xaml"
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
            this.requestEdit = ((ppcLookupV2.SendEdit)(target));
            return;
            case 2:
            this.requestCbox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.stateBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.countyBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.townBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.codeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sendRequest = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\SendEdit.xaml"
            this.sendRequest.Click += new System.Windows.RoutedEventHandler(this.sendRequest_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cancelRequest = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

