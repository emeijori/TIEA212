﻿#pragma checksum "..\..\..\koostettuKomponentti.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84C32BD896EB4EFF43C4A584D126618C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace Jakolaskuri {
    
    
    /// <summary>
    /// koostettuKomponentti
    /// </summary>
    public partial class koostettuKomponentti : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Jakolaskuri.koostettuKomponentti komponentti;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label JakoMerkkiLabel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JaettavaBox;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox JakajaBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TulosLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label JakoTulos;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\koostettuKomponentti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button JaaNappi;
        
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
            System.Uri resourceLocater = new System.Uri("/Jakolaskuri;component/koostettukomponentti.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\koostettuKomponentti.xaml"
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
            this.komponentti = ((Jakolaskuri.koostettuKomponentti)(target));
            return;
            case 2:
            this.JakoMerkkiLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.JaettavaBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.JakajaBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TulosLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.JakoTulos = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.JaaNappi = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\koostettuKomponentti.xaml"
            this.JaaNappi.Click += new System.Windows.RoutedEventHandler(this.JaaNappi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
