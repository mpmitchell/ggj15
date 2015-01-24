using UnityEngine;
using System.Collections;

public class EngineScript : ShipComponentScript
{
	// Update is called once per frame
	void Update()
	{
		if (isActive == true)
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				BatteryScript.power += -5;
				Timer = 0.5f;
			}
		}
		else
		{
			Timer -= Time.deltaTime;
			if (Timer <= 0)
			{
				health--;
				Timer=0.5f;
			}
		}
	}

	public void Activate()
	{
		BatteryScript.activatedEngines = true;
		BatteryScript.charging = false;
		isActive = true;
		activateButton.SetActive(false);
		deactivateButton.SetActive(true);
	}

	public override void Deactivate()
	{
		BatteryScript.activatedEngines = false;
		isActive = false;
		activateButton.SetActive(true);
		deactivateButton.SetActive(false);
	}
}