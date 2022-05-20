using Avalonia.Controls;
using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public void btn_OnClick(object? sender, RoutedEventArgs args)
        {
            var button = (sender as Button)!;
            switch (button.Name)
            {
                case "btn":
                    {
                        button.Content = "Ginger";
                    }
                    break;
                case "otherBtn":
                    {
                        button.Content = "Ale";
                    }
                    break;
                default:
                    {
                        button.Content = "No clue which Button you are!";
                    }
                    break;
            }
        }
    }
}
