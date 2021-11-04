using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndriodDriver : IDriver
{

    private Bike m_bike;

    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("This bike will be controlled by an AI");
    }
}
