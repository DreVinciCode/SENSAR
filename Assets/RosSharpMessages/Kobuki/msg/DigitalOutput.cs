/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Kobuki
{
    public class DigitalOutput : Message
    {
        public const string RosMessageName = "kobuki_msgs-noetic/DigitalOutput";

        //  Digital output - only four pins. 
        //  Array of values indices represent pins 0-3 respectively.
        public bool[] values { get; set; }
        //  Set indices to true to set a pin, false to ignore.
        public bool[] mask { get; set; }

        public DigitalOutput()
        {
            this.values = new bool[4];
            this.mask = new bool[4];
        }

        public DigitalOutput(bool[] values, bool[] mask)
        {
            this.values = values;
            this.mask = mask;
        }
    }
}
