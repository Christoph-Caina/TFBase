using Tinkerforge;

namespace TFBase
{
    class DeviceIdentifiers
    {
        public string GetDeviceNames(string DeviceID)
        {
            string DeviceName = null;

            switch (DeviceID)
            {
                //
                // Display-Namen anhand des Device-Identifiers ermitteln
                // Dieser Teil sollte zur besseren Lesbarkeit in eine eigene Funktion / Klasse ausgelagert werden
                // und nur an dieser Stelle dann aufgerufen werden.
                //
                case "11":
                    DeviceName = BrickDC.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "13":
                    DeviceName = BrickMaster.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "14":
                    DeviceName = BrickServo.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "15":
                    DeviceName = BrickStepper.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "16":
                    DeviceName = BrickIMU.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "17":
                    DeviceName = BrickRED.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "18":
                    DeviceName = BrickIMUV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "19":
                    DeviceName = BrickSilentStepper.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "21":
                    DeviceName = BrickletAmbientLight.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "23":
                    DeviceName = BrickletCurrent12.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "24":
                    DeviceName = BrickletCurrent25.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "25":
                    DeviceName = BrickletDistanceIR.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "26":
                    DeviceName = BrickletDualRelay.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "27":
                    DeviceName = BrickletHumidity.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "28":
                    DeviceName = BrickletIO16.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "29":
                    DeviceName = BrickletIO4.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "210":
                    DeviceName = BrickletJoystick.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "211":
                    DeviceName = BrickletLCD16x2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "212":
                    DeviceName = BrickletLCD20x4.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "214":
                    DeviceName = BrickletPiezoBuzzer.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "215":
                    DeviceName = BrickletRotaryEncoder.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "216":
                    DeviceName = BrickletTemperature.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "217":
                    DeviceName = BrickletTemperatureIR.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "218":
                    DeviceName = BrickletVoltage.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "219":
                    DeviceName = BrickletAnalogIn.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "220":
                    DeviceName = BrickletAnalogOut.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "221":
                    DeviceName = BrickletBarometer.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "222":
                    DeviceName = BrickletGPS.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "223":
                    DeviceName = BrickletIndustrialDigitalIn4.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "224":
                    DeviceName = BrickletIndustrialDigitalOut4.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "225":
                    DeviceName = BrickletIndustrialQuadRelay.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "226":
                    DeviceName = BrickletPTC.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "227":
                    DeviceName = BrickletVoltageCurrent.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "228":
                    DeviceName = BrickletIndustrialDual020mA.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "229":
                    DeviceName = BrickletDistanceUS.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "230":
                    DeviceName = BrickletDualButton.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "231":
                    DeviceName = BrickletLEDStrip.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "232":
                    DeviceName = BrickletMoisture.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "233":
                    DeviceName = BrickletMotionDetector.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "234":
                    DeviceName = BrickletMultiTouch.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "235":
                    DeviceName = BrickletRemoteSwitch.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "236":
                    DeviceName = BrickletRotaryEncoder.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "237":
                    DeviceName = BrickletSegmentDisplay4x7.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "238":
                    DeviceName = BrickletSoundIntensity.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "239":
                    DeviceName = BrickletTilt.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "240":
                    DeviceName = BrickletHallEffect.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "241":
                    DeviceName = BrickletLine.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "242":
                    DeviceName = BrickletPiezoSpeaker.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "243":
                    DeviceName = BrickletColor.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "244":
                    DeviceName = BrickletSolidStateRelay.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "246":
                    DeviceName = BrickletNFCRFID.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "249":
                    DeviceName = BrickletIndustrialDualAnalogIn.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "250":
                    DeviceName = BrickletAccelerometer.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "251":
                    DeviceName = BrickletAnalogInV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "253":
                    DeviceName = BrickletLoadCell.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "254":
                    DeviceName = BrickletRS232.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "255":
                    DeviceName = BrickletLaserRangeFinder.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "256":
                    DeviceName = BrickletAnalogOutV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "258":
                    DeviceName = BrickletIndustrialAnalogOut.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "259":
                    DeviceName = BrickletAmbientLightV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "260":
                    DeviceName = BrickletDustDetector.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "262":
                    DeviceName = BrickletCO2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "263":
                    DeviceName = BrickletOLED128x64.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "264":
                    DeviceName = BrickletOLED64x48.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "265":
                    DeviceName = BrickletUVLight.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "266":
                    DeviceName = BrickletThermocouple.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "267":
                    DeviceName = BrickletMotorizedLinearPoti.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "268":
                    DeviceName = BrickletRealTimeClock.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "270":
                    DeviceName = BrickletCAN.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "271":
                    DeviceName = BrickletRGBLED.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "272":
                    DeviceName = BrickletRGBLEDMatrix.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "276":
                    DeviceName = BrickletGPSV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "277":
                    DeviceName = BrickletRS485.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "278":
                    DeviceName = BrickletThermalImaging.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "282":
                    DeviceName = BrickletRGBLEDButton.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "283":
                    DeviceName = BrickletHumidityV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "285":
                    DeviceName = BrickletDMX.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "286":
                    DeviceName = BrickletNFC.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "288":
                    DeviceName = BrickletOutdoorWeather.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "289":
                    DeviceName = BrickletRemoteSwitchV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "291":
                    DeviceName = BrickletTemperatureIRV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "292":
                    DeviceName = BrickletMotionDetectorV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "294":
                    DeviceName = BrickletRotaryEncoderV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "295":
                    DeviceName = BrickletAnalogInV3.DEVICE_DISPLAY_NAME.ToString();
                    break;

                case "296":
                    DeviceName = BrickletSolidStateRelayV2.DEVICE_DISPLAY_NAME.ToString();
                    break;

                default:
                    DeviceName = "n/a: " + DeviceID;
                    break;
            }
            return DeviceName;
        }
    }
}
