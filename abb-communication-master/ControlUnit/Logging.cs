using System;

namespace ABBControlUnit
{
    public partial class ControlUnit
    {
        public event Action<string> MessageCall;

        public void OnMessageCall(string message)
        {
            MessageCall(message);
        }
    }
}
