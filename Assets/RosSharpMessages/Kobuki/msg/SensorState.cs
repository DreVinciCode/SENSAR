/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Kobuki
{
    public class SensorState : Message
    {
        public const string RosMessageName = "kobuki_msgs-noetic/SensorState";

        //  Kobuki Sensor Data Messages
        // 
        //  For more direct simple interactions (buttons, leds, gyro, motor velocity
        //  etc) use the other topics. This provides detailed information about the
        //  entire state package that is transmitted at 50Hz from the robot.
        // 
        // ##### CONSTANTS ######
        //  Bumper states (states are combined, when multiple bumpers are pressed)
        public const byte BUMPER_RIGHT = 1;
        public const byte BUMPER_CENTRE = 2;
        public const byte BUMPER_LEFT = 4;
        //  Wheel drop sensor states (states are combined, when both wheel drop sensors are triggered)
        public const byte WHEEL_DROP_RIGHT = 1;
        public const byte WHEEL_DROP_LEFT = 2;
        //  Cliff sensor states (states are combined, when multiple cliff sensors are triggered)
        public const byte CLIFF_RIGHT = 1;
        public const byte CLIFF_CENTRE = 2;
        public const byte CLIFF_LEFT = 4;
        //  Button states (only one button can be triggered at a time)
        public const byte BUTTON0 = 1;
        public const byte BUTTON1 = 2;
        public const byte BUTTON2 = 4;
        //  Charger state is a combination of charging device (adapter, docking station)
        //  and state (charging, charged, discharging):
        public const byte DISCHARGING = 0;
        public const byte DOCKING_CHARGED = 2;
        public const byte DOCKING_CHARGING = 6;
        public const byte ADAPTER_CHARGED = 18;
        public const byte ADAPTER_CHARGING = 22;
        //  Over current states
        public const byte OVER_CURRENT_LEFT_WHEEL = 1;
        public const byte OVER_CURRENT_RIGHT_WHEEL = 2;
        public const byte OVER_CURRENT_BOTH_WHEELS = 3;
        //  Digital input states (states are combined, when multiple inputs are set at the same time)
        //  When connecting Yujin's test board, it acts as pull-up what inverts the behaviour:
        //  No input: 79, all inputs set (e.g. buttons pressed): 64
        public const byte DIGITAL_INPUT0 = 1;
        public const byte DIGITAL_INPUT1 = 2;
        public const byte DIGITAL_INPUT2 = 4;
        public const byte DIGITAL_INPUT3 = 8;
        public const byte DB25_TEST_BOARD_CONNECTED = 64;
        // ##### MESSAGE ######
        public Header header { get; set; }
        // ##################
        //  Core Packet
        // ##################
        public ushort time_stamp { get; set; }
        //  milliseconds starting when turning on Kobuki (max. 65536, then starts from 0 again)
        public byte bumper { get; set; }
        //  see bumper states
        public byte wheel_drop { get; set; }
        //  see wheel drop sensor states
        public byte cliff { get; set; }
        //  see cliff sensor states
        public ushort left_encoder { get; set; }
        //  accumulated ticks left wheel starting with turning on Kobuki (max. 65535)
        public ushort right_encoder { get; set; }
        //  accumulated ticks right wheel starting with turning on Kobuki (max. 65535)
        public sbyte left_pwm { get; set; }
        //  % of applied maximum voltage left wheel: -100 (max. voltage backward) to +100 (max. voltage forward)
        public sbyte right_pwm { get; set; }
        //  % of applied maximum voltage right wheel: -100 (max. voltage backward) to +100 (max. voltage forward)
        public byte buttons { get; set; }
        //  see button states
        public byte charger { get; set; }
        //  see charger states
        public byte battery { get; set; }
        //  battery voltage in 0.1V (ex. 16.1V -> 161)
        // ##################
        //  Cliff Packet
        // ##################
        public ushort[] bottom { get; set; }
        //  ADC output of the right, centre, left cliff PSD sensor (0 - 4095, distance measure is non-linear)
        // ##################
        //  Current Packet
        // ##################
        public byte[] current { get; set; }
        //  motor current for the left and right motor in 10mA (ex. 12 -> 120mA)
        public byte over_current { get; set; }
        //  see over current states
        // ##################
        //  Input Packet
        // ##################
        public ushort digital_input { get; set; }
        //  see digital input states; will show garbage when nothing is connected
        public ushort[] analog_input { get; set; }
        //  ADC values for the 4 analog inputs; 0 - 4095: 0.0 - 3.3V; will show garbage when nothing is connected

        public SensorState()
        {
            this.header = new Header();
            this.time_stamp = 0;
            this.bumper = 0;
            this.wheel_drop = 0;
            this.cliff = 0;
            this.left_encoder = 0;
            this.right_encoder = 0;
            this.left_pwm = 0;
            this.right_pwm = 0;
            this.buttons = 0;
            this.charger = 0;
            this.battery = 0;
            this.bottom = new ushort[0];
            this.current = new byte[0];
            this.over_current = 0;
            this.digital_input = 0;
            this.analog_input = new ushort[0];
        }

        public SensorState(Header header, ushort time_stamp, byte bumper, byte wheel_drop, byte cliff, ushort left_encoder, ushort right_encoder, sbyte left_pwm, sbyte right_pwm, byte buttons, byte charger, byte battery, ushort[] bottom, byte[] current, byte over_current, ushort digital_input, ushort[] analog_input)
        {
            this.header = header;
            this.time_stamp = time_stamp;
            this.bumper = bumper;
            this.wheel_drop = wheel_drop;
            this.cliff = cliff;
            this.left_encoder = left_encoder;
            this.right_encoder = right_encoder;
            this.left_pwm = left_pwm;
            this.right_pwm = right_pwm;
            this.buttons = buttons;
            this.charger = charger;
            this.battery = battery;
            this.bottom = bottom;
            this.current = current;
            this.over_current = over_current;
            this.digital_input = digital_input;
            this.analog_input = analog_input;
        }
    }
}
