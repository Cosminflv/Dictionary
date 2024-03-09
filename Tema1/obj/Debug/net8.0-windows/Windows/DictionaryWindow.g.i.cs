﻿#pragma checksum "..\..\..\..\Windows\DictionaryWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5E6BE97787483CDA29648672FAD36B5ABCAD9E45"
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
using Tema1;


namespace Tema1 {
    
    
    /// <summary>
    /// DictionaryWindow
    /// </summary>
    public partial class DictionaryWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.AutoCompleteBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameHeadline;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WordName;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CategoryHeadline;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CategoryName;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DescriptionHeadLine;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Description;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\DictionaryWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageContainer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tema1;component/windows/dictionarywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\DictionaryWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\..\Windows\DictionaryWindow.xaml"
            this.CategoryComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoryComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.AutoCompleteBox)(target));
            
            #line 20 "..\..\..\..\Windows\DictionaryWindow.xaml"
            this.SearchTextBox.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.SearchTextBox_KeyDown));
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\..\Windows\DictionaryWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameHeadline = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.WordName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.CategoryHeadline = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.CategoryName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.DescriptionHeadLine = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Description = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.ImageContainer = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

