using System;

namespace DwayneNeedDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WebBrowser.Navigate(new Uri(@"https://cn.bing.com/"));
        }
    }
}
