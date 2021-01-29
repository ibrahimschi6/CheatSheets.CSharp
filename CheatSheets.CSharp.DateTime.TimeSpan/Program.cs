using System;
using System.Xml;

namespace CheatSheets.CSharp.DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

			var zeroDuration = TimeSpan.Zero;

			//Method  1 ------------------------------------------

			//Hour input  i.e. 90 hour
			var timeSpan = new TimeSpan(90, 0, 0);			
			Console.WriteLine(XmlConvert.ToString(timeSpan));
			
			//Minute input  i.e. 70 hour
			timeSpan = new TimeSpan(0, 70, 0);
			Console.WriteLine(XmlConvert.ToString(timeSpan));

			//Second input  i.e. 90 hour
			timeSpan = new TimeSpan(0, 0, 100);
			Console.WriteLine(XmlConvert.ToString(timeSpan));

			
			//Method  1 ------------------------------------------

			int value = 2500;

			TimeSpan timeSpan1 = TimeSpan.FromMinutes(value);
			TimeSpan timeSpan2 = TimeSpan.FromDays(value);
			TimeSpan timeSpan3 = TimeSpan.FromSeconds(value);

			TimeSpan timeSpan4 = TimeSpan.FromMilliseconds(value);
			TimeSpan timeSpan5 = TimeSpan.FromTicks(value);

			
			Console.WriteLine("----FromMinutes---------" + XmlConvert.ToString(timeSpan1));
			Console.WriteLine("----FromDays---------" + XmlConvert.ToString(timeSpan2));
			Console.WriteLine("----FromSeconds---------" + XmlConvert.ToString(timeSpan3));

			Console.WriteLine("----FromMilliseconds---------" + XmlConvert.ToString(timeSpan4));
			Console.WriteLine("----FromTicks---------" + XmlConvert.ToString(timeSpan5));


			//From Time Spant to String

			//00:07:43
			var durationTest = "PT7M43S";
			Console.WriteLine(XmlConvert.ToTimeSpan(durationTest));
			Console.WriteLine(XmlConvert.ToTimeSpan(durationTest).ToString("c"));
			Console.WriteLine(XmlConvert.ToTimeSpan(durationTest).ToString("g"));
			Console.WriteLine(XmlConvert.ToTimeSpan(durationTest).ToString("G"));
			Console.WriteLine(XmlConvert.ToTimeSpan(durationTest).ToString("dd\\:hh\\:mm\\:ss"));
		}
	}
    
}
