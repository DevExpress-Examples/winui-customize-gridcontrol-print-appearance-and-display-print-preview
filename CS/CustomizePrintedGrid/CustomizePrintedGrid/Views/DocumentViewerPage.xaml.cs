using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace CustomizePrintedGrid {
    public sealed partial class DocumentViewerPage : Page {
        public DocumentViewerPage() {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            if (e.Parameter is not null)
                documentViewer.DocumentSource = e.Parameter;
            base.OnNavigatedTo(e);
        }

        void HyperlinkButton_Click(object sender, RoutedEventArgs e) => Frame.GoBack();
    }
}
