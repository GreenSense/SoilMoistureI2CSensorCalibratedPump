using System;
using NUnit.Framework;

namespace SoilMoistureI2CSensorCalibratedPump.Tests.Integration
{
	[TestFixture(Category = "Integration")]
	public class SoilMoistureI2CSensorPowerTestFixture : BaseTestFixture
	{
		[Test]
		public void Test_SoilMoistureI2CSensorPower_AlwaysOn_1SecondReadInterval()
		{
			using (var helper = new SoilMoistureI2CSensorPowerTestHelper())
			{
				helper.ReadInterval = 1;

				helper.DevicePort = GetDevicePort();
				helper.DeviceBaudRate = GetDeviceSerialBaudRate();

				helper.SimulatorPort = GetSimulatorPort();
				helper.SimulatorBaudRate = GetSimulatorSerialBaudRate();

				helper.TestSoilMoistureI2CSensorPower();
			}
		}

		[Test]
		public void Test_SoilMoistureI2CSensorPower_AlwaysOn_3SecondReadInterval()
		{
			using (var helper = new SoilMoistureI2CSensorPowerTestHelper())
			{
				helper.ReadInterval = 3;

				helper.DevicePort = GetDevicePort();
				helper.DeviceBaudRate = GetDeviceSerialBaudRate();

				helper.SimulatorPort = GetSimulatorPort();
				helper.SimulatorBaudRate = GetSimulatorSerialBaudRate();

				helper.TestSoilMoistureI2CSensorPower();
			}
		}

		[Test]
		public void Test_SoilMoistureI2CSensorPower_OnAndOff_4SecondReadInterval()
		{
			using (var helper = new SoilMoistureI2CSensorPowerTestHelper())
			{
				helper.ReadInterval = 4;

				helper.DevicePort = GetDevicePort();
				helper.DeviceBaudRate = GetDeviceSerialBaudRate();

				helper.SimulatorPort = GetSimulatorPort();
				helper.SimulatorBaudRate = GetSimulatorSerialBaudRate();

				helper.TestSoilMoistureI2CSensorPower();
			}
		}
		[Test]
		public void Test_SoilMoistureI2CSensorPower_OnAndOff_6SecondReadInterval()
		{
			using (var helper = new SoilMoistureI2CSensorPowerTestHelper())
			{
				helper.ReadInterval = 6;

				helper.DevicePort = GetDevicePort();
				helper.DeviceBaudRate = GetDeviceSerialBaudRate();

				helper.SimulatorPort = GetSimulatorPort();
				helper.SimulatorBaudRate = GetSimulatorSerialBaudRate();

				helper.TestSoilMoistureI2CSensorPower();
			}
		}
	}
}
