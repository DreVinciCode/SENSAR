using UnityEngine;
using UnityEngine.UI;

namespace RosSharp.RosBridgeClient
{
    public class TeleopController : UnityPublisher<MessageTypes.Geometry.Twist>
    {
        [SerializeField] private FixedJoystick _joystick;
        [SerializeField] private Button _increaseButton;
        [SerializeField] private Button _decreaseButton;
        [SerializeField] private float _linearSpeed;
        [SerializeField] private float _angularSpeed;

        private float _minSpeed = 0.1f;
        private float _maxSpeed = 0.8f;
        private MessageTypes.Geometry.Twist message;

        public bool _publishMessageCheck { get; set; }

        protected override void Start()
        {
            base.Start();
            InitializeMessage();
        }

        public void ChangeSpeed(float value)
        {
            _linearSpeed += value;

            if (_linearSpeed > _maxSpeed)
            {
                _linearSpeed = _maxSpeed;
            }
            else if(_linearSpeed < _minSpeed)
            {
                _linearSpeed = _minSpeed;
            }
        }

        private void InitializeMessage()
        {
            message = new MessageTypes.Geometry.Twist();
            message.linear = new MessageTypes.Geometry.Vector3();
            message.angular = new MessageTypes.Geometry.Vector3();
        }

        private void PublishMessage()
        {
            Vector3 linearVelocity = new Vector3(_joystick.Vertical * _linearSpeed, 0f, 0f);
            Vector3 angularVelocity = new Vector3(0f, 0f, _joystick.Horizontal * _angularSpeed);

            message.linear = GetGeometryVector3(linearVelocity);
            message.angular = GetGeometryVector3(-angularVelocity);

            Publish(message);
        }

        private void FixedUpdate()
        {
            if (_publishMessageCheck)
            {
                if(_joystick.Horizontal != 0.0f && _joystick.Vertical != 0.0f)
                    PublishMessage();
            }
        }

        private static MessageTypes.Geometry.Vector3 GetGeometryVector3(Vector3 vector3)
        {
            MessageTypes.Geometry.Vector3 geometryVector3 = new MessageTypes.Geometry.Vector3();
            geometryVector3.x = vector3.x;
            geometryVector3.y = vector3.y;
            geometryVector3.z = vector3.z;
            return geometryVector3;
        }

    }
}
