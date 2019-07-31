using System;
using System.Windows.Input;

namespace SimpleNote.Core
{
    // Allow button bindings. 

    public class ICommandBase : ViewModels.ViewModelBase
    {
        private ICommand icommand_base;

        private ICommand ICommand_Base
        {
            get
            {
                return icommand_base;
            }
            set
            {
                icommand_base = value;
                OnPropertyChanged("ICommand_Base");
            }
        }

        public ICommand ICommand_Button_Base(Action<object> param)
        {
            ICommand_Base = null;

            if (param != null)
            {
                ICommand_Base = new RelayCommand(param);
            }

            return ICommand_Base;
        }
    }
}
