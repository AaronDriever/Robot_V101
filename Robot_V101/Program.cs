using System;
using Microsoft.SPOT;
using System.Threading;
using Microsoft.SPOT.Hardware;
using GHIElectronics.NETMF.FEZ;
using GHIElectronics.NETMF.Hardware;

namespace Robot_V101
{
    using HC_SR04;
    using HMC_6343;

    public class Robot // All Robot parts go here
    {
        public class Compass // Compass module stuff
        {
            HMC_6343 _compass;
            public double gotHeading
            {

                get
                {
                    return _compass.Heading;
                }
            }
            public void UpdateCompass()
            {
                _compass.Update();
            }
        }
        public class Sonar // Sonar module stuff
        {
            public static void gotDistance()
            {
                HC_SR04.getDistance();
            }
        }
        public class Servo // Servo stuff
        {

            static PWM servoL = new PWM((PWM.Pin)FEZ_Pin.PWM.Di5);
            static PWM servoR = new PWM((PWM.Pin)FEZ_Pin.PWM.Di6);
            public class Move
            {

                public static void Stop() // Servo Stop
                {
                    servoL.SetPulse(20 * 1000 * 1000, 1500 * 1000);
                    servoR.SetPulse(20 * 1000 * 1000, 1500 * 1000);
                }
                public static void Forward()
                {

                }
                public static void Reverse()
                {

                }
                public static void RotateCW()
                {

                }
                public static void RotateCCW()
                {

                }
            }

        }
    }
    public class Program
    {
        public void Main()
        {
            Debug.Print(Resources.GetString(Resources.StringResources.String1));
            Robot.Servo.Move.Stop();
            Robot.Sonar.gotDistance();
            
        }

    }
}
