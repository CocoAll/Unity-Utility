using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalSender : ScriptableObject
{
    public List<ISignalListener> listeners = new List<ISignalListener>();

    public void Raise()
    {
        for(int i = listeners.Count -1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(SignalListener signalListener)
    {
        listeners.Add(signalListener);
    }

    public void UnregisterListener(SignalListener signalListener)
    {
        listeners.Remove(signalListener);
    }
}
