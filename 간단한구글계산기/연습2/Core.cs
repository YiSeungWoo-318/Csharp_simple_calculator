using System;

using System.Windows.Input;

using System.Data;

namespace Google_simple_scientific_calculator

{

    class Append : ICommand

    {

        private CalcViewModel c;
        public event EventHandler CanExecuteChanged;
        public Append(CalcViewModel c)
        {
            this.c = c;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)

        {
            if (c.inputCondition == "1")
            {
                c.InputString += parameter;
            }
            else
            {
                c.InputString = "";
                c.InputString += parameter;
                c.inputCondition = "1";
                c.DisplayText1 = c.Ans;
                c.ACCE = "CE";
            }
            
        }

    }
    class Operator : ICommand

    {
        private CalcViewModel c;
        public event EventHandler CanExecuteChanged;
        public Operator(CalcViewModel c)
        {
            this.c = c;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)

        {
            if (c.inputCondition == "1")
            {
                c.InputString += parameter;
            }
            else
            {
                c.InputString += parameter;
                c.inputCondition = "1";
                c.DisplayText1 = c.Ans;
                c.ACCE = "CE";
            }
        }

    }

    class Backspace : ICommand

    {

        private CalcViewModel c;



        public Backspace(CalcViewModel c)

        {

            this.c = c;

        }

        public event EventHandler CanExecuteChanged

        {

            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }

        public bool CanExecute(object parameter)

        {

            return c.DisplayText.Length > 0;

        }

        public void Execute(object parameter)

        {
            if (c.ACCE == "CE")
            {
                int length = c.InputString.Length - 1;

                if (0 < length)

                {

                    c.InputString = c.InputString.Substring(0, length);

                }

                else

                {

                    c.InputString = c.DisplayText = "";

                }
            }

            else
            {
                c.InputString = c.DisplayText = "";
            }
            

        }

    }

    class Calculate : ICommand
    {
        private CalcViewModel c;
        public Calculate(CalcViewModel c)
        {
            this.c = c;
        }
        public event EventHandler CanExecuteChanged

        {

            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }
        public bool CanExecute(object parameter)

        {

            return 0 < c.InputString.Length;

        }
        public void Execute(object parameter)
        {
          
            

            try
            {
                c.DisplayText1 = c.InputString + "=";
                string temp = c.InputString.Replace("×", "*").Replace("÷", "/");
                c.InputString = new DataTable().Compute(temp, null).ToString();
                c.Ans = "Ans = " + c.InputString;

                c.inputCondition = "0";
                c.ACCE = "AC";
            }
            catch (Exception ex)
            {
                c.InputString = c.InputString;

            }

            
      
           
        }

    }



}