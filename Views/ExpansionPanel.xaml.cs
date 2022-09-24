namespace MauiExpansionPanel.Views;

public partial class ExpansionPanel : ContentView
{
    public ExpansionPanel()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty HeaderContentProperty = BindableProperty.Create(
       propertyName: nameof(HeaderContent),
       returnType: typeof(View),
       declaringType: typeof(ExpansionPanel),
       defaultValue: new VerticalStackLayout()
       );

    public View HeaderContent
    {
        get => (View)GetValue(HeaderContentProperty);
        set => SetValue(HeaderContentProperty, value);
    }

    public static readonly BindableProperty IsExpandedProperty = BindableProperty.Create(
     propertyName: nameof(IsExpanded),
     returnType: typeof(bool),
     declaringType: typeof(ExpansionPanel),
     defaultValue: false
     );

    public bool IsExpanded
    {
        get => (bool)GetValue(IsExpandedProperty);
        set => SetValue(IsExpandedProperty, value);
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        IsExpanded = !IsExpanded;
    }
}