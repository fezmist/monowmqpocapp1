using System;
using poclib45;

namespace pocmonoconsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Hello World!");

				MQTest mqtest = new MQTest();
				mqtest.ConnectMQ("QM1", "test", "QM1.SRVRCHNL");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}


			Console.ReadLine();
		}
	}
}
