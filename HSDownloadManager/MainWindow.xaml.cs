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

namespace HSDownloadManager
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Show> ShowCollection = new List<Show>();

		public MainWindow()
		{
			InitializeComponent();
			Shows_LV.Items.Clear();
			Shows_LV.ItemsSource = ShowCollection;

			ShowCollection.Add(new Show { Name = "test", Status = "Waiting", AirDate = "Mon", NextEpisode = 1 });
		}

		/// <summary>
		/// Called when the "Add Show" button is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Download_Button_Click(object sender, RoutedEventArgs e) {

		}

		/// <summary>
		/// Called when the "Settings" button is clicked.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Settings_Button_Click(object sender, RoutedEventArgs e)
		{
		}
	}

}
