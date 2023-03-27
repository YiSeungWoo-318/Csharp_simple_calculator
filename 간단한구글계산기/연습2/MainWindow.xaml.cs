using Google_simple_scientific_calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;



namespace Google_simple_scientific_calculator

{

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();

            this.DataContext = new CalcViewModel();

        }

    }

}

