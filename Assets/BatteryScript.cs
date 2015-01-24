using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class BatteryScript : MonoBehaviour {
	public static int power = 100;
	public static bool charging = false;
	private float timer = 2.0f;
	private float drainedTimer = 15.0f;

	public static bool activatedEngines = false;
	public static bool activatedNavCore = false;
	public static bool activatedLifeSupport = false;
	public static bool activatedCommunications = false;

	public static bool drained = false;

	public Text batteryText;

	public static List<ShipComponentScript> components;

	void Awake()
	{
		components = new List<ShipComponentScript>();
	}

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
			if (timer <= 0)
			{
				if (power < 100)
				{
					power += 10;
				}
				timer = 2.0f;
			}
		}
		else if (power < 0)
		{
			foreach (ShipComponentScript component in components)
				component.Deactivate();

			power = 0;

			drained = true;
		}

		if (batteryText)
			batteryText.text = "Battery Level: " + power + (charging ? "  (charging)" : "");

		if (drained == true) {
						drainedTimer -= Time.deltaTime;
						if (drainedTimer <= 0) {
								drained = false;
						}
				}
	}
}
