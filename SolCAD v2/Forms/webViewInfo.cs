
using Microsoft.Web.WebView2.Core;
using System.Net.Http;

namespace SolCAD_v2.Forms
{
    public partial class webViewInfo : Form
    {
        private static Inicio inicio;
        private static int option;
        public webViewInfo(Inicio ini, int op)
        {
            inicio = ini;
            option = op;
            InitializeComponent();

            wvInfo.CoreWebView2InitializationCompleted += wvInfo_CoreWebView2InitializationCompleted;

        }

        private void webViewInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio.Show();
        }

        private async void webViewInfo_Load(object sender, EventArgs e)
        {
            await wvInfo.EnsureCoreWebView2Async(null);
        }

        private void wvInfo_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                switch (option)
                {
                    case 1:
                        string htmData = Path.Combine(Environment.CurrentDirectory+"/webSource/Documento de ayuda.htm");
                        wvInfo.CoreWebView2.Navigate("file://" + htmData);
                        break;
                    case 2:
                        wvInfo.Source = new Uri("https://matias.ma/nsfw/");
                        break;
                }
            }
            else
            {
                // Manejar cualquier error de inicialización aquí
            }
        }
    }
}
