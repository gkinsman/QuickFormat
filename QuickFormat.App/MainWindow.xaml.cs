using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using Newtonsoft.Json;

namespace QuickFormat.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            _bound = false;
        }

        private bool _bound;

        protected override void OnActivated(EventArgs e)
        {
            if (_bound) return;
            
            var clipboardContents = Clipboard.GetData(DataFormats.Text)?.ToString();
            if (clipboardContents == null) return;

            try
            {
                var parsed = JsonConvert.DeserializeObject(clipboardContents);
                FormattedJson = JsonConvert.SerializeObject(parsed, Formatting.Indented);
                _bound = true;
            }
            catch(Exception)
            {
            }
        }

        public static readonly DependencyProperty PropertyTypeProperty = DependencyProperty.Register(
            "FormattedJson", typeof(string), typeof(MainWindow), new PropertyMetadata(default(string)));

        public string FormattedJson
        {
            get { return (string) GetValue(PropertyTypeProperty); }
            set { SetValue(PropertyTypeProperty, value); }
        }
    }
}