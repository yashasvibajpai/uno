﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SamplesApp.UITests.TestFramework;

namespace SamplesApp.UITests.Windows_UI_Xaml_Shapes
{
	public class Shapes_Tests : SampleControlUITestBase
	{
		[Test]
		[AutoRetry]
		public void Draw_polyline()
		{
			Run("SamplesApp.Windows_UI_Xaml_Shapes.PolylinePage");
			_app.WaitForElement("DPolyline");
			_app.Screenshot($"PolylinePage");
		}

		[Test]
		[AutoRetry]
		public void Draw_polygon()
		{
			Run("SamplesApp.Windows_UI_Xaml_Shapes.PolygonPage");
			_app.WaitForElement("DPolygon");
			_app.Screenshot($"PolygonPage");
		}
	}
}