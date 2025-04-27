namespace MacFilePickerBug
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenFilePicker(object sender, EventArgs e)
        {
            try 
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Please select a file",
                    FileTypes = FilePickerFileType.Images
                });
                if (result is not null)
                {
                    var file = result.FileName;
                    if (file is not null)
                    {
                        await DisplayAlert("File Selected", file, "OK");
                    }
                }
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Trace.WriteLine("Error: ", ex.StackTrace ?? ex.Message);    
            }
           
        }
    }

}
