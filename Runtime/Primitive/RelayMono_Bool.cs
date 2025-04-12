using UnityEngine.Events;

namespace Eloi.Relay
{
    public class RelayMono_Bool : AbstractGenericRelayMono<bool> {


        public UnityEvent m_onRelayIsTrue;
        public UnityEvent m_onRelayIsFalse;

        protected override void HandleDataToRelayInChildren(bool dataToHandle)
        {
            if (dataToHandle)
            {
                m_onRelayIsTrue.Invoke();
            }
            else
            {
                m_onRelayIsFalse.Invoke();
            }
        }

    }






}

