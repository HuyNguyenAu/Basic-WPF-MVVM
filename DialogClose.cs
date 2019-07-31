using System.Windows;

// Close the dialog window.
// https://adammills.wordpress.com/2009/07/01/window-close-from-xaml/

namespace SimpleNote.Core
{
    public static class DialogClose
    {
        public static readonly DependencyProperty CloseProperty =
        DependencyProperty.RegisterAttached(
        "Close",
        typeof(bool),
        typeof(DialogClose),
        new UIPropertyMetadata(false, OnClose));

        public static void SetClose(DependencyObject target, bool value)
        {
            target.SetValue(CloseProperty, value); 
        }

        private static void OnClose(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is bool && ((bool)e.NewValue))
            {               
                Window window = GetWindow(sender);

                if (window != null)
                {                
                    window.Close();
                }
            }
        }

        private static Window GetWindow(DependencyObject sender)
        {
            Window window = null;

            if (sender is Window)
            {
                window = sender as Window;
            }

            if (window == null)
            {
                window = Window.GetWindow(sender);
            }

            return window;
        }
    }
}
