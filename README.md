# Plugin.Maui.ExpansionPanel
Plugin.Maui.ExpansionPanel - is a cross-platform plugin for .NET MAUI , Used to easily show and hide (collapse and expand) content.


## How To Use 
Available on NuGet: https://www.nuget.org/packages/Plugin.Maui.ExpansionPanel/1.0.0  

Install this Plugin in your .NET MAUI Project

Now add following namespace to your content page & replace content page tag with <mauiPopup:BasePopupPage

```
   xmlns:panel="clr-namespace:MauiExpansionPanel.Views;assembly=MauiExpansionPanel"
```

MainPage.xaml
```
  <panel:ExpansionPanel IsExpanded="False">
         <panel:ExpansionPanel.HeaderContent>
                <Label Text="Header Title" />
         </panel:ExpansionPanel.HeaderContent>
         <Label Text="Description goes here" />
  </panel:ExpansionPanel>
```


