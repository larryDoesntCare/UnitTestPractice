﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestRunner {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

	
		public MainWindow() {
			InitializeComponent();
			this.DataContext = TestingLib.Assert.TestResults;
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			var testClass = new TestingLib.TestThePaymentDate();
			testClass.DateIs30DaysInFuture();
			testClass.ReturnsMondayIfProposedDateIsSaturday();
			testClass.ReturnsMondayIfProposedDateIsSunday();
		



		}
	}
}