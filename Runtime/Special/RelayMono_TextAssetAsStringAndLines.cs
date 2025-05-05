using UnityEngine;
using UnityEngine.Events;

namespace Eloi.Relay
{
    public class RelayMono_TextAssetAsStringAndLines : AbstractGenericRelayMono<TextAsset>
    {

        public UnityEvent<string> m_onRelayedAsString = new UnityEvent<string>();
        public UnityEvent<string[]> m_onRelayedAsLines = new UnityEvent<string[]>();

        protected override void HandleDataToRelayInChildren(TextAsset dataToHandle)
        {

            // Example: Convert TextAsset to string and log it
            string text = "";

            if ( dataToHandle && dataToHandle.text!= null)
            {
                text = dataToHandle.text;
            }
            
            string[] lines = text.Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
            m_onRelayedAsString.Invoke(text);
        }
    }




}

