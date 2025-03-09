using System.Windows;
using System.Windows.Controls;

namespace TodoApp.Views.Helpers
{
    public class TextBoxHelper
    {
        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.RegisterAttached(
                "Placeholder",
                typeof(string),
                typeof(TextBoxHelper),
                new PropertyMetadata(string.Empty, OnPlaceholderChanged));

        public static string GetPlaceholder(DependencyObject obj)
        {
            return (string)obj.GetValue(PlaceholderProperty);
        }

        public static void SetPlaceholder(DependencyObject obj, string value)
        {
            obj.SetValue(PlaceholderProperty, value);
        }

        private static void OnPlaceholderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                var placeholderTextBlock = textBox.Template.FindName("placeHolderTextBlock", textBox) as TextBlock;
                if (placeholderTextBlock != null)
                {
                    placeholderTextBlock.Text = e.NewValue as string;
                }
            }
        }
    }
}
