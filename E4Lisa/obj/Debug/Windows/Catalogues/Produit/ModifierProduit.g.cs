﻿#pragma checksum "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "630ED1F3767C528AB9A31E617F6B7E4D831DFDF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using E4Lisa.Windows.Catalogues.Produit;
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


namespace E4Lisa.Windows.Catalogues.Produit {
    
    
    /// <summary>
    /// ModifierProduit
    /// </summary>
    public partial class ModifierProduit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock recupvaleur;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Contenu;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Connexion;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Label;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Modifier;
        
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
            System.Uri resourceLocater = new System.Uri("/E4Lisa;component/windows/catalogues/produit/modifierproduit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
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
            this.recupvaleur = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Contenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Connexion = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.Label = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Modifier = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\..\..\Windows\Catalogues\Produit\ModifierProduit.xaml"
            this.Modifier.Click += new System.Windows.RoutedEventHandler(this.Modifier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
