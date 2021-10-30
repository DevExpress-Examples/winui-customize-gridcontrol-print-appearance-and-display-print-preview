using DevExpress.WinUI.Grid.Printing;
using DevExpress.WinUI.Printing;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Windows.UI.Text;

namespace CustomizePrintedGrid {

    public sealed partial class GridPage : Page {

        public GridPage() {
            InitializeComponent();
        }

        public ViewModel ViewModel { get; } = new ViewModel();

        void HyperlinkButton_Click(object sender, RoutedEventArgs e) {
            var documentSource = new PrintableLink(new GridControlPrinter(gridcontrol));

            // Customize a Document's Print Appearance
            documentSource.PageHeaderText = "Invoices";

            documentSource.PageHeaderStyle = new PrintBrickStyle {
                FontSize = 20.0d,
                Background = Colors.LightGreen,
                Padding = new Thickness(10,0,0,0),
                BorderColor = Colors.LightGray,
                BorderThickness = 1.0d
            };

            documentSource.ReportFooterText = "Invoice revision date: 1st of October";
            documentSource.ReportFooterStyle = new PrintBrickStyle {
                FontSize = 14.0d,
                FontStyle = FontStyle.Oblique,
                Foreground = Colors.DarkGray
            };
           

            // Pass the created documentSource to the DocumentViewer as a parameter
            Frame.Navigate(typeof(DocumentViewerPage), documentSource, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
        }
    }
}
