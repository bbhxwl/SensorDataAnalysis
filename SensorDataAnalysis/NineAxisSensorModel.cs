using System;
using System.Collections.Generic;
using System.Text;

namespace SensorDataAnalysis
{
    /// <summary>
    /// 九轴
    /// </summary>
   public  class NineAxisSensorModel
    {
        /// <summary>
        /// 加速度X
        /// </summary>
        public double AccelerationX { get; set; }
        /// <summary>
        /// 加速度Y
        /// </summary>
        public double AccelerationY { get; set; }
        /// <summary>
        /// 加速度Z
        /// </summary>
        public double AccelerationZ { get; set; }
        /// <summary>
        /// 角速度X
        /// </summary>
        public double AngularVelocityX { get; set; }
        /// <summary>
        /// 角速度Y
        /// </summary>
        public double AngularVelocityY { get; set; }
        /// <summary>
        /// 角速度Z
        /// </summary>
        public double AngularVelocityZ { get; set; }
        /// <summary>
        /// 角度X
        /// </summary>
        public double AngleX { get; set; }
        /// <summary>
        /// 角度Y
        /// </summary>
        public double AngleY { get; set; }
        /// <summary>
        /// 角度Z
        /// </summary>
        public double AngleZ { get; set; }

    }
}
