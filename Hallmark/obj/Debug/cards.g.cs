﻿

#pragma checksum "C:\Users\Afzal computers\documents\visual studio 2013\Projects\Hallmark\Hallmark\cards.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "016244AF1293A701E91070DD718B4629"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hallmark
{
    partial class cards : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 42 "..\..\cards.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.backButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 45 "..\..\cards.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.birthdaycard_Tapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 46 "..\..\cards.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.weddingcard_Tapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 47 "..\..\cards.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.friendshipcard_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


