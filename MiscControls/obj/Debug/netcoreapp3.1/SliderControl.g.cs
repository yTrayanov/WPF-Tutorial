#pragma checksum "..\..\..\SliderControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D61E87A1E00828FF429D4A537EE49D3AB4DF53D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MiscControls;
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


namespace MiscControls {
    
    
    /// <summary>
    /// SliderControl
    /// </summary>
    public partial class SliderControl : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\SliderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorR;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\SliderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorG;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\SliderControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slColorB;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MiscControls;component/slidercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SliderControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.slColorR = ((System.Windows.Controls.Slider)(target));
            
            #line 15 "..\..\..\SliderControl.xaml"
            this.slColorR.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.slColorG = ((System.Windows.Controls.Slider)(target));
            
            #line 23 "..\..\..\SliderControl.xaml"
            this.slColorG.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.slColorB = ((System.Windows.Controls.Slider)(target));
            
            #line 31 "..\..\..\SliderControl.xaml"
            this.slColorB.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ColorSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

