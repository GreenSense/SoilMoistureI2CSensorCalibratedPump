using System;
using System.Threading;
using NUnit.Framework;
namespace SoilMoistureI2CSensorCalibratedPump.Tests.Integration
{
	public class SoilMoistureI2CSensorPowerTestHelper : GreenSenseHardwareTestHelper
	{
		public int ReadInterval = 1;

		public void TestSoilMoistureI2CSensorPower()
		{
			WriteTitleText("Starting soil moisture sensor power test");

			EnableDevices();

			SetDeviceReadInterval(ReadInterval);

			var data = WaitForDataEntry();

			AssertDataValueEquals(data, "V", ReadInterval);

			var sensorDoesTurnOff = ReadInterval > DelayAfterTurningSoilMoistureI2CSensorOn;

			if (sensorDoesTurnOff)
			{
				Console.WriteLine("The soil moisture sensor should turn off when not in use.");

				TestSoilMoistureI2CSensorPowerTurnsOnAndOff();
			}
			else
			{
				Console.WriteLine("The soil moisture sensor should stay on permanently.");

				TestSoilMoistureI2CSensorPowerStaysOn();
			}
		}

		public void TestSoilMoistureI2CSensorPowerStaysOn()
		{
			WriteParagraphTitleText("Waiting until the soil moisture sensor is on before starting the test...");

			WaitUntilSoilMoistureI2CSensorPowerPinIs(On);

			var durationInSeconds = ReadInterval * 5;

			WriteParagraphTitleText("Checking that soil moisture sensor power pin stays on...");

			AssertSoilMoistureI2CSensorPowerPinForDuration(On, durationInSeconds);
		}

		public void TestSoilMoistureI2CSensorPowerTurnsOnAndOff()
		{
			WriteParagraphTitleText("Waiting until the soil moisture sensor has turned on then off before starting the test...");

			WaitUntilSoilMoistureI2CSensorPowerPinIs(On);
			WaitUntilSoilMoistureI2CSensorPowerPinIs(Off);
			WaitUntilSoilMoistureI2CSensorPowerPinIs(On);

			CheckSoilMoistureI2CSensorOnDuration();
			CheckSoilMoistureI2CSensorOffDuration();
		}

		public void CheckSoilMoistureI2CSensorOnDuration()
		{
			WriteParagraphTitleText("Getting the total on time...");

			var totalOnTime = WaitWhileSoilMoistureI2CSensorPowerPinIs(On);

			WriteParagraphTitleText("Checking the total on time is correct...");

			var expectedOnTime = DelayAfterTurningSoilMoistureI2CSensorOn;

			AssertIsWithinRange("total on time", expectedOnTime, totalOnTime, TimeErrorMargin);
		}

		public void CheckSoilMoistureI2CSensorOffDuration()
		{
			WriteParagraphTitleText("Getting the total off time...");

			var totalOffTime = WaitWhileSoilMoistureI2CSensorPowerPinIs(Off);

			WriteParagraphTitleText("Checking the total off time is correct...");

			var expectedOffTime = ReadInterval - DelayAfterTurningSoilMoistureI2CSensorOn;

			AssertIsWithinRange("total off time", expectedOffTime, totalOffTime, TimeErrorMargin);
		}
	}
}
