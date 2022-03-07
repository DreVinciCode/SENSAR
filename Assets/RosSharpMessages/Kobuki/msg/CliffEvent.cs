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
    public class CliffEvent : Message
    {
        public const string RosMessageName = "kobuki_msgs-noetic/CliffEvent";

        //  Provides a cliff sensor event.
        //  This message is generated whenever a particular cliff sensor signals that the
        //  robot approaches or moves away from a cliff.
        //  Note that, despite cliff field on SensorState messages, state field is not a
        //  bitmask, but the new state of a single sensor.
        //  cliff sensor
        public const byte LEFT = 0;
        public const byte CENTER = 1;
        public const byte RIGHT = 2;
        //  cliff sensor state
        public const byte FLOOR = 0;
        public const byte CLIFF = 1;
        public byte sensor { get; set; }
        public byte state { get; set; }
        //  distance to floor when cliff was detected
        public ushort bottom { get; set; }

        public CliffEvent()
        {
            this.sensor = 0;
            this.state = 0;
            this.bottom = 0;
        }

        public CliffEvent(byte sensor, byte state, ushort bottom)
        {
            this.sensor = sensor;
            this.state = state;
            this.bottom = bottom;
        }
    }
}
