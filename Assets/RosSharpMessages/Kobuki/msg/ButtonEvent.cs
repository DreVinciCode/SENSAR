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
    public class ButtonEvent : Message
    {
        public const string RosMessageName = "kobuki_msgs-noetic/ButtonEvent";

        //  Provides a button event.
        //  This message is generated whenever a particular button is pressed or released.
        //  Note that, despite buttons field on SensorState messages, state field is not a
        //  bitmask, but the new state of a single button.
        public const byte Button0 = 0;
        public const byte Button1 = 1;
        public const byte Button2 = 2;
        public const byte RELEASED = 0;
        public const byte PRESSED = 1;
        public byte button { get; set; }
        public byte state { get; set; }

        public ButtonEvent()
        {
            this.button = 0;
            this.state = 0;
        }

        public ButtonEvent(byte button, byte state)
        {
            this.button = button;
            this.state = state;
        }
    }
}
