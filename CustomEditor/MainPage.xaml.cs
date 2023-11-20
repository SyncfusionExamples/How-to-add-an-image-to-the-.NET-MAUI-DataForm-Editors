using Syncfusion.Maui.Core;
using Syncfusion.Maui.DataForm;

namespace CustomEditor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            contactForm.RegisterEditor(nameof(ContactFormModel.ProfileImage), new CustomDataEditor(this.contactForm));
            contactForm.RegisterEditor(nameof(ContactFormModel.Name),new CustomDataEditor(this.contactForm));   
        }

        private void contactForm_GenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
        {
            if(e.DataFormItem != null)
            {
                e.DataFormItem.LeadingView = CreateLeadingView(e.DataFormItem);
            }

            if(e.DataFormGroupItem != null)
            {
                if(e.DataFormGroupItem.Name=="Address")
                {
                    e.DataFormGroupItem.ColumnCount = 2;
                }
            }
        }
        private View CreateLeadingView(DataFormItem dataFormItem)
        {
            var view = new Label()
            {
                FontSize = 26,
                TextColor = Colors.Gray,
                FontFamily = "InputLayoutIcons",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Start,
                WidthRequest = 30,
                HeightRequest = 30
            };
            switch (dataFormItem.FieldName)
            {
                case "Name":
                    view.Text = "F";
                    break;
                case "Mobile":
                    view.Text = "E";
                    break;
                case "Address":
                    view.Text = "C";
                    break;
                case "ZipCode":
                    dataFormItem.ShowLeadingView = false;
                    break;
                case "Email":
                    view.Text = "G";
                    break;
                default:
                    view.Text = string.Empty;
                    break;
            }
            return view;
        }
    }
}