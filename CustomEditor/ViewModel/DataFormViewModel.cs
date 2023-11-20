#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace CustomEditor
{
    /// <summary>
    /// Represents the view model class for data form.
    /// </summary>
    public class DataFormViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFormViewModel" /> class.
        /// </summary>
        public DataFormViewModel()
        {
            this.ContactFormModel = new ContactFormModel();
        }

        /// <summary>
        /// Gets or sets the contact form model.
        /// </summary>
        public ContactFormModel ContactFormModel { get; set; }

      
    }
}
