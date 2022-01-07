/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.People
{
    public class PositionMeasurement : Message
    {
        public const string RosMessageName = "people_msgs/PositionMeasurement";

        public Header header { get; set; }
        //  The name of the detector that detected the person (i.e frontalface, profileface)
        public string name { get; set; }
        public string object_id { get; set; }
        public Point pos { get; set; }
        public double reliability { get; set; }
        public double[] covariance { get; set; }
        public sbyte initialization { get; set; }

        public PositionMeasurement()
        {
            this.header = new Header();
            this.name = "";
            this.object_id = "";
            this.pos = new Point();
            this.reliability = 0.0;
            this.covariance = new double[9];
            this.initialization = 0;
        }

        public PositionMeasurement(Header header, string name, string object_id, Point pos, double reliability, double[] covariance, sbyte initialization)
        {
            this.header = header;
            this.name = name;
            this.object_id = object_id;
            this.pos = pos;
            this.reliability = reliability;
            this.covariance = covariance;
            this.initialization = initialization;
        }
    }
}