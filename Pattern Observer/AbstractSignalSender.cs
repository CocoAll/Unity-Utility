using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractSignalSender
{
    public List<ISignalListener> listeners = new List<ISignalListener>();

    public void Raise()
    {
        for(int i = listeners.Count -1; i >= 0; i--)
        {
            listeners[i].OnSignalRaised();
        }
    }

    public void RegisterListener(ISignalListener signalListener)
    {
        listeners.Add(signalListener);
    }

    public void UnregisterListener(ISignalListener signalListener)
    {
        listeners.Remove(signalListener);
    }
}
