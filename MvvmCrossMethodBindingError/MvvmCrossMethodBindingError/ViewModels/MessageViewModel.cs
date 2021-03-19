using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Windows;

namespace MvvmCrossMethodBindingError.ViewModels
{
    public class MessageViewModel : MvxViewModel
    {
        public IMvxCommand DisplayMessageCommand => new MvxCommand(DisplayMessage);
        public void DisplayMessage()
        {
            MessageBox.Show("Message...");
        }
    }
}
