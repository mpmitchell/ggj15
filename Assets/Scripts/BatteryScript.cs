using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class BatteryScript : MonoBehaviour {
	public static int power = 100;
	public static bool charging = false;
	private float timer = 2.0f;

	public static bool activatedEngines = false;
	public static bool activatedNavCore = false;
	public static bool activatedLifeSupport = false;
	public static bool activatedCommunications = false;
	public PowerPercentage percentageButton1;
	public int percentageCounter;

	public Text batteryText;

	public static List<ShipComponentScript> components;

	public SpriteRenderer spriteRenderer;

	void Awake()
	{
		components = new List<ShipComponentScript>();
	}

	// Use this for initialization
	void Start () {

		spriteRenderer = renderer as SpriteRenderer;
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
		}

		if (batteryText)
			batteryText.text = "Battery Level: " + power + (charging ? "  (charging)" : "");
	}


}
