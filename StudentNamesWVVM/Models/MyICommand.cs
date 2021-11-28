using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentNamesWVVM.Models
{
    internal class MyICommand : ICommand
    {
        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;

        public MyICommand(Action excecuteMethod)
        {
            _TargetExecuteMethod = excecuteMethod;
        }

        public MyICommand(Action excecuteMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = excecuteMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }



        public bool CanExecute(object? parameter)
        {
            if(_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if(_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;

        }


        public event EventHandler CanExecuteChanged = delegate { };

        public void Execute(object? parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }
    }
}
