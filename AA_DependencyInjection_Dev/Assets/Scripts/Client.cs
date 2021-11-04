using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {

        //bike controlled by the player
        public Bike m_playerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndriodBike;

        private void Awake()
        {
            //Set up a bike with a huma driver and jet engine
            IEngine JetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();

            m_playerBike.SetEngine(JetEngine);
            m_playerBike.SetDriver(humanDriver);
            m_playerBike.StartEngine();

            // Set up a bike with a AI driver and nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndriodDriver();

            m_AndriodBike.SetEngine(JetEngine);
            m_AndriodBike.SetDriver(androidDriver);
            m_AndriodBike.StartEngine();

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_playerBike.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_playerBike.TurnRight();
            }
        }
    }
}

