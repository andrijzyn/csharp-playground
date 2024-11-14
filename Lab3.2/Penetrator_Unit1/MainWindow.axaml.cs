using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Penetrator {  
    public partial class MainWindow : Window {
        public MainWindow() { InitializeComponent(); }

        private void OnButtonClick(object sender, RoutedEventArgs e) {
            string? college = CollegeTextBox.Text;
            string? director = DirectorTextBox.Text;
            string? applicant = ApplicantTextBox.Text;

            string output = $"Dear principal's '{college}'\n{director}\n{applicant}";
            OutputTextBlock.Text = output;
        }
    }
}