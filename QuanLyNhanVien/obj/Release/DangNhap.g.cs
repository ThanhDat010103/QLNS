﻿#pragma checksum "..\..\DangNhap.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1BF76EE0D5CBCADE976D886C767198772746EF6F416F42FC773F9A638FF19EB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyNhanVien;
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


namespace QuanLyNhanVien {
    
    
    /// <summary>
    /// DangNhap
    /// </summary>
    public partial class DangNhap : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\DangNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MainBorder;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\DangNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run tblUserName;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\DangNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox taiKhoanTbx;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\DangNhap.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox matKhauPwb;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/dangnhap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DangNhap.xaml"
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
            this.MainBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            
            #line 43 "..\..\DangNhap.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimizedButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\DangNhap.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tblUserName = ((System.Windows.Documents.Run)(target));
            return;
            case 5:
            this.taiKhoanTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\DangNhap.xaml"
            this.taiKhoanTbx.KeyDown += new System.Windows.Input.KeyEventHandler(this.Login_KeyDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.matKhauPwb = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 106 "..\..\DangNhap.xaml"
            this.matKhauPwb.KeyDown += new System.Windows.Input.KeyEventHandler(this.Login_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 121 "..\..\DangNhap.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnQuenMK_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 144 "..\..\DangNhap.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnDangNhap_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

