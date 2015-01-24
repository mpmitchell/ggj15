using UnityEngine;
using System.Collections;

public class LifeSupportScript : ShipComponentScript {
	
	// Update is called once per frame
	void Update()
	{
			if (isActive ==true)
			{
				
				Timer-= Time.deltaTime;
				if( Timer<=0)
				{
					BatteryScript.power+=-5;
					Timer=3.0f;
				}
				
				
			}
		if (isActive == false) {
						Timer -= Time.deltaTime;
						if (Timer <= 0) {
								health--;
								Timer=3.0f;
						}
				}
	}

	public void Activate()
	{
		if (BatteryScript.drained == false) {
			
			BatteryScript.activatedLifeSupport = true;
			BatteryScript.charging = false;
			isActive = true;
			activateButton.SetActive (false);
			deactivateButton.SetActive (true);
		} else {
			Debug.Log ("Battery is Drained. Please wait until madatory charging is completed");
		}
	}

	public override void Deactivate()
	{
		BatteryScript.activatedLifeSupport = false;
		isActive = false;
		activateButton.SetActive(true);
		deactivateButton.SetActive(false);
	}
}