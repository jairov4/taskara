﻿using System;
using System.Collections.Generic;
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

namespace Taskara
{
	/// <summary>
	/// Lógica de interacción para CreateRecipe.xaml
	/// </summary>
	public partial class PrescriptionEditPage : Page
	{
		public PrescriptionEditPage()
		{
			InitializeComponent();
		}

		private void btnFinish_Click(object sender, RoutedEventArgs e)
		{
			Navigate(typeof(IndexPage));
		}
	}
}
