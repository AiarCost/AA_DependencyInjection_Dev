using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDriver : IDriver
{

    private Bike m_bike;

    public void Control(Bike bike)
    {
        m_bike = bike;
        Debug.Log("A human (player) will control the bike");
    }
}
