using System;
using TestMan.ViewModels;
using Xamarin.Forms;

namespace TestMan.Views
{
    public partial class ButtonPage : ContentPage
    {
        private ButtonPageViewModel _viewModel;

        public ButtonPage()
        {
            InitializeComponent();
            _viewModel = (ButtonPageViewModel)BindingContext;

        }

        private void OnWidthRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.WidthRequestProperty, "WidthRequest");
        }
        private void OnHeigtRequestToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.HeightRequestProperty, "HeightRequest");
        }
        private void OnFontSizeToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.FontSizeProperty, "FontSize");
        }
        private void OnBorderWidthToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.BorderWidthProperty, "BorderWidth");
        }
        private void OnBorderRadiusToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.BorderRadiusProperty, "BorderRadius");
        }
        private void OnBackgroundColorNameToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.BackgroundColorProperty, "SelectedBackgroundColorName");
        }
        private void OnBorderColorNameToggled(object sender, EventArgs e)
        {
            ToggleBinding(((ToggledEventArgs)e).Value, ((SwitchWithTag)sender).Tag, Button.BorderColorProperty, "SelectedBorderColorName");
        }


        private void ToggleBinding(bool value, string targetObjectName, BindableProperty bindableProperty, string propertyName)
        {
            Button targetObject = this.FindByName<Button>(targetObjectName);
            if (!propertyName.Contains("Selected"))
            {
                propertyName = "Target" + propertyName;

            }
            if (value)
            {
                targetObject.SetBinding(bindableProperty, propertyName);
            }
            else
            {
                targetObject.RemoveBinding(bindableProperty);
            }
        }
    }
}
