﻿#pragma checksum "..\..\NewFigure.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B46B688B107463C9C18CE44EC8E7DBF9110A0B52"
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
using View;


namespace View {
    
    
    /// <summary>
    /// NewFigure
    /// </summary>
    public partial class NewFigure : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RectangleWidthTextBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RectangleLengthTextBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TriangleBaseTextBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CircleRadiusTextBox;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox RectangleCheck;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox TriangleCheck;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CircleCheck;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TriangleHeightTextBox;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelCreatedFigure;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\NewFigure.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridWithParameters;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/newfigure.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewFigure.xaml"
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
            this.RectangleWidthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RectangleLengthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TriangleBaseTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CircleRadiusTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 108 "..\..\NewFigure.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 115 "..\..\NewFigure.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RectangleCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 123 "..\..\NewFigure.xaml"
            this.RectangleCheck.Click += new System.Windows.RoutedEventHandler(this.RectangleCheck_Click);
            
            #line default
            #line hidden
            
            #line 123 "..\..\NewFigure.xaml"
            this.RectangleCheck.Checked += new System.Windows.RoutedEventHandler(this.RectangleCheck_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TriangleCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 124 "..\..\NewFigure.xaml"
            this.TriangleCheck.Click += new System.Windows.RoutedEventHandler(this.TriangleCheck_Click);
            
            #line default
            #line hidden
            
            #line 124 "..\..\NewFigure.xaml"
            this.TriangleCheck.Checked += new System.Windows.RoutedEventHandler(this.TriangleCheck_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CircleCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 125 "..\..\NewFigure.xaml"
            this.CircleCheck.Click += new System.Windows.RoutedEventHandler(this.CircleCheck_Click);
            
            #line default
            #line hidden
            
            #line 125 "..\..\NewFigure.xaml"
            this.CircleCheck.Checked += new System.Windows.RoutedEventHandler(this.CircleleCheck_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TriangleHeightTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.labelCreatedFigure = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.dataGridWithParameters = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

