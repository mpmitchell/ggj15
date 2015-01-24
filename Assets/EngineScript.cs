using UnityEngine;
using System.Collections;

public class EngineScript : ShipComponentScript
{
	void Start ()
	{
		health = 100;
		isActive = false;
		Timer = 3.0f;
	}

	// Update is called once per frame
	void Update ()
	{
		if (isActive == true)
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				BatteryScript.power += -5;
				Debug.Log (BatteryScript.power);
				Debug.Log (health);
				Timer = 3.0f;
			}
		}
		else
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				health--;
				Debug.Log (health);
				Timer=3.0f;
			}
		}
	}

	public void Activate()
	{
		BatteryScript.activatedEngines = true;
		BatteryScript.charging = false;
		Debug.Log ("Working");
		isActive = true;
	}

	public void Deactivate()
	{
		BatteryScript.activatedEngines = false;
		Debug.Log ("Deactivated");
		isActive = false;
	}
}