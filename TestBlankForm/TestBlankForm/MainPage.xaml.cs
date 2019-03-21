using System;
using System.IO;
using Xamarin.Forms;

namespace TestBlankForm
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TestBlankForm.txt");

        public MainPage()
        {
            InitializeComponent();

            //this function would dynamically adjust new labels to read "hello world" with these text options.
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "hello world"
            //};

            //this sets the value of the slider to 0
            Slider.Value = 0;

            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor.Text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = string.Empty;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello, Team!", "How you doin?", "Fine, i hope?");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //change text of the SliderLable based on value found in Slider
            SliderLabel.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
