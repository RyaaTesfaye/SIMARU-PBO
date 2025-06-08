using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUSUNAWAAA.Utils
{
    public interface INavHelper
    {
        void Execute();
    }
    public class NavigateToFormCommand<T> : INavHelper where T : Form, new()
    {
        private readonly Form _currentForm;

        public NavigateToFormCommand(Form currentForm)
        {
            _currentForm = currentForm;
        }

        public void Execute()
        {
            _currentForm.Hide();
            var newForm = new T();
            newForm.ShowDialog();
            _currentForm.Close();
        }
    }
}

