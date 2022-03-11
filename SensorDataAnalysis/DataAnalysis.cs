using System;
using System.Collections.Generic;
using System.Text;

namespace SensorDataAnalysis
{
    public class DataAnalysis
    {
        /// <summary>
        /// 获取九轴传感器的数据，加速度、角速度、角度 数据 
        /// </summary>
        /// <param name="bit"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static NineAxisSensorModel NineAxis(byte[] bit, DeviceType d)
        {
            if (d == DeviceType.WT901BLECL)
            {
                if (bit[0] == 0x55 && bit[1] == 0x61)
                {
                    NineAxisSensorModel m = new NineAxisSensorModel();
                    double a1 = BitConverter.ToInt16(bit, 2);
                    double a2 = BitConverter.ToInt16(bit, 4);
                    double a3 = BitConverter.ToInt16(bit, 6);
                    double aa1 = BitConverter.ToInt16(bit, 8);
                    double aa2 = BitConverter.ToInt16(bit, 10);
                    double aa3 = BitConverter.ToInt16(bit, 12);
                    double aaa1 = BitConverter.ToInt16(bit, 14);
                    double aaa2 = BitConverter.ToInt16(bit, 16);
                    double aaa3 = BitConverter.ToInt16(bit, 18);
                    m.AccelerationX = a1 / 32768 * 16;
                    m.AccelerationY = a2 / 32768 * 16;
                    m.AccelerationZ = a3 / 32768 * 16;
                    m.AngularVelocityX = aa1 / 32768 * 2000;
                    m.AngularVelocityY = aa2 / 32768 * 2000;
                    m.AngularVelocityZ = aa3 / 32768 * 2000;
                    m.AngleX = aaa1 / 32768 * 180;
                    m.AngleY = aaa2 / 32768 * 180;
                    m.AngleZ = aaa3 / 32768 * 180;
                    return m;
                }

            }


            return null;
        }
    }
}
