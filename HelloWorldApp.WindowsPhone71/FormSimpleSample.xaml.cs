﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;


using HelloWorldApp.BusinessObjects;

namespace HelloWorldApp
{
	public partial class FormSimpleSample : PhoneApplicationPage
	{
		public FormSimpleSample()
		{
			InitializeComponent();
		}

		# region    Platform dependant code (port needed)
		//-------------------------------------------------------------------------
		Person person = null;
		//-------------------------------------------------------------------------
		private void buttonLoad_Click(object sender, RoutedEventArgs e)
		{

		}
		//-------------------------------------------------------------------------
		# endregion Platform dependant code (port needed)
	}
}