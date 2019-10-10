namespace XFI
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using XFI.Models;
    using XFI.Services;
    using Syncfusion.Windows.Tools.Controls;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Interaction logic for XFIMainWindowControl.
    /// </summary>
    public partial class XFIMainWindowControl : UserControl
    {
        private readonly FontSearchService _fontSearchService;
        private List<string> _fontList;
        /// <summary>
        /// Initializes a new instance of the <see cref="XFIMainWindowControl"/> class.
        /// </summary>
        public XFIMainWindowControl()
        {
            _fontSearchService = new FontSearchService();
            _fontList = new List<string>() {"boy", "girl", "child" };
            this.InitializeComponent();
            this.AutoComplete.CustomSource = _fontList;




        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "XFIMainWindow");
        }

        private async void TextBox_KeyUp(object sender, KeyEventArgs e)
       {
            //bool found = false;
            //var border = (resultStack.Parent as ScrollViewer).Parent as Border;

            //string query = (sender as TextBox).Text;
            //if (query.Length == 0)
            //{
            //    // Clear
            //    resultStack.Children.Clear();
            //    border.Visibility = System.Windows.Visibility.Collapsed;
            //}
            //else
            //{
            //    border.Visibility = System.Windows.Visibility.Visible;
            //}

            //var data = await _fontSearchService.FetchFontListAsync(query);

            

            //// Clear the list
            //resultStack.Children.Clear();

            //// Add the result
            //if(data is object)
            //{
            //    foreach (var obj in data)
            //    {
            //        addItem(obj.Name);
            //        found = true;
            //    }
            //}
          

            //if (!found)
            //{
            //    resultStack.Children.Add(new TextBlock() { Text = "No results found." });
            //}
        }

        private void addItem(string text)
        {
            //TextBlock block = new TextBlock();

            //// Add the text
            //block.Text = text;

            //// A little style...
            //block.Margin = new Thickness(2, 3, 2, 3);
            //block.Cursor = Cursors.Hand;

            //// Mouse events
            //block.MouseLeftButtonUp += (sender, e) =>
            //{
            //    textBox.Text = (sender as TextBlock).Text;
            //};

            //block.MouseEnter += (sender, e) =>
            //{
            //    TextBlock b = sender as TextBlock;
            //    b.Background = Brushes.PeachPuff;
            //};

            //block.MouseLeave += (sender, e) =>
            //{
            //    TextBlock b = sender as TextBlock;
            //    b.Background = Brushes.Transparent;
            //};

            //// Add to the panel
            //resultStack.Children.Add(block);
        }

        private void AutoComplete_KeyUp(object sender, KeyEventArgs e)
        {
            _fontList.Add("amechi");
        }
    }
}