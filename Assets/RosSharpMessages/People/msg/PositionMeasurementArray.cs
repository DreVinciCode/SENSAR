/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.People;

namespace RosSharp.RosBridgeClient.MessageTypes.People
{
    public class PositionMeasurementArray : Message
    {
        public const string RosMessageName = "people_msgs/PositionMeasurementArray";

        public Header header { get; set; }
        //  All of the people found
        public PositionMeasurement[] people { get; set; }
        //  The co-occurrence matrix between people
        public float[] cooccurrence { get; set; }

        public PositionMeasurementArray()
        {
            this.header = new Header();
            this.people = new PositionMeasurement[0];
            this.cooccurrence = new float[0];
        }

        public PositionMeasurementArray(Header header, PositionMeasurement[] people, float[] cooccurrence)
        {
            this.header = header;
            this.people = people;
            this.cooccurrence = cooccurrence;
        }
    }
}
