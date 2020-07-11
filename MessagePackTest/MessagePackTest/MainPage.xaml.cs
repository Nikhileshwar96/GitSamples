using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MessagePackTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private byte[] message;
        private TestData data;
        private Stream messageStream;
        public MainPage()
        {
            InitializeComponent();
            this.data = new TestData()
            {
                Test = "tesing message pack"
            };

            messageStream = new MemoryStream();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            data.Test = input.Text;
            messageStream.Position = 0;
            await MessagePack.MessagePackSerializer.SerializeAsync<TestData>(messageStream, data);
        }

        async void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            messageStream.Position = 0;
            var returnedData = await MessagePack.MessagePackSerializer.DeserializeAsync<TestData>(messageStream);
            output.Text = returnedData.Test;
        }
    }
}
