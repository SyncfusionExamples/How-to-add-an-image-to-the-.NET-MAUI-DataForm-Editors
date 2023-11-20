using Syncfusion.Maui.DataForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEditor
{
    internal class CustomDataEditor : IDataFormEditor
    {
        private SfDataForm dataForm;
        private DataFormCustomItem dataFormCustomItem;

        public CustomDataEditor(SfDataForm dataForm)
        {
            this.dataForm = dataForm;
        }
        public void CommitValue(DataFormItem dataFormItem, View view)
        {
            dataFormItem.SetValue((view as Entry).Text);
        }

        public View CreateEditorView(DataFormItem dataFormItem)
        {
            dataFormCustomItem = (DataFormCustomItem)dataFormItem;
            if(dataFormItem.FieldName=="ProfileImage")
            {
                var view = new Image()
                {
                    Source=(dataFormItem.BindingContext as DataFormViewModel).ContactFormModel.ProfileImage,
                    HorizontalOptions=LayoutOptions.Start,
                    HeightRequest=80,
                    WidthRequest=80
                };

                return view;
            }
            else if(dataFormItem.FieldName=="Name")
            {
                var entry = new Entry()
                {
                    HorizontalOptions=LayoutOptions.Start,
                    VerticalOptions=LayoutOptions.Center
                };
                entry.TextChanged += Entry_TextChanged;
                return entry;
            }
            return null;
            
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is InputView entry && dataFormCustomItem!=null)
            {
                this.CommitValue(dataFormCustomItem, entry);
            }
        }

        public void UpdateReadyOnly(DataFormItem dataFormItem)
        {
            throw new NotImplementedException();
        }
    }
}
