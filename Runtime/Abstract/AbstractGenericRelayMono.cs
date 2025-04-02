using UnityEngine;
using UnityEngine.Events;


namespace Eloi.Relay
{
    public class AbstractGenericRelayMono<T> : MonoBehaviour    {
        public UnityEvent<T> m_onRelayed=new UnityEvent<T>();
        public T m_lastValueRelayed= default;
        
        public void PushInInspectorLastValue()
        {
            m_onRelayed.Invoke(m_lastValueRelayed);
        }
        public void PushIn(T value)
        {
            m_lastValueRelayed = value;
            m_onRelayed.Invoke(value);
        }
        public void GetLastValue(out T value)
        {
            value = m_lastValueRelayed;
        }
        public T GetLastValue()
        {
            return m_lastValueRelayed;
        }
    }






}

