using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BatteryScript : MonoBehaviour {
	public static int power = 100;
	public static bool charging = false;
	private float timer=2.0f;
	public static bool activatedEngines = false;
	public static bool activatedNavCore = false;
	public static bool activatedLifeSupport = false;
	public static bool activatedCommunications = false;

	public Text batteryText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(activatedEngines==false && activatedNavCore==false && activatedLifeSupport==false && activatedCommunications==false)
		{
			charging =true;
		}
			if (charging == true) {

				timer-=Time.deltaTime;
				if(timer<=0)
				{
					Debug.Log (power);
					if(power<100)
					{
						power++;
						Debug.Log (power);
					}
					timer=2.0f;
			}
		}

		if (batteryText)
			batteryText.text = "Battery Level: " + power;
	}
}
