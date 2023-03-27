using System.ComponentModel;
using System.Dynamic;
using System.Windows.Input;



namespace Google_simple_scientific_calculator

{
    public class CalcViewModel : INotifyPropertyChanged
    {
        string inputString = "";
        public string inputCondition = "1";
        string displayText = "";
        string displayText1 = "";
        string ans = "";
        string acce = "CE";

        public event PropertyChangedEventHandler PropertyChanged;
        public CalcViewModel()
        {
            this.Append = new Append(this);

            this.Backspace = new Backspace(this);

            this.Calculate = new Calculate(this);

            this.Operator = new Operator(this);

        }
        public string InputString

        {

            internal set

            {

                if (inputString != value)

                {

                    inputString = value;

                    OnPropertyChanged("InputString");

                    if (value != "")

                    {
                        DisplayText = value;
                    }

                }

            }

            get { return inputString; }

        }
        public string DisplayText

        {

            internal set

            {

                if (displayText != value)

                {


                    displayText = value;

                    OnPropertyChanged("DisplayText");
                    

                }

            }

            get { return displayText; }

        }


        public string DisplayText1

        {

            internal set

            {

                if (displayText1 != value)

                {

                    displayText1 = value;

                    OnPropertyChanged("DisplayText1");

                }

            }

            get { return displayText1; }

        }

        public string Ans

        {

            internal set

            {

                if (ans != value)

                {

                    ans = value;

                    OnPropertyChanged("Ans");

                }

            }

            get { return ans; }

        }

        public string ACCE

        {

            internal set

            {

                if (acce != value)

                {

                    acce = value;

                    OnPropertyChanged("ACCE");

                }

            }

            get { return acce; }

        }


        public string Op { get; set; }       // Opertaor

        public double? Op1 { get; set; }  // Operand 1

        public ICommand Operator { protected set; get; }
        public ICommand Append { protected set; get; }

        public ICommand Backspace { protected set; get; }

        public ICommand Calculate { protected set; get; }  


        protected void OnPropertyChanged(string propertyName)

        {

            if (PropertyChanged != null)
            {
                
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
               
            }

        }
    }

}