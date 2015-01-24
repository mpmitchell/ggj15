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
	public PowerPercentage percentageButton1;
	public int percentageCounter;

	public static bool drained = false;

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
		percentageButton1 = GameObject.FindWithTag ("Percent").GetComponent<PowerPercentage> ();
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
				if (power>100)
				{
					power=100;

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
			Application.LoadLevel(Application.loadedLevel +1);
		}

		if (power <100 && power >80)
		    {
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx6;
		}

		if (power <=80 && power >60)
		{
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx5;
		}

		if (power <=60 && power >40)
		{
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx4;
		}

		if (power <=40 && power >20)
		{
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx3;
		}

		if (power <=20 && power >10)
		{
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx2;
		}

		if (power <=10 && power >0)
		{
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx1;
		}
	
		if (power <= 0) {
			percentageButton1.spriteRenderer.sprite = percentageButton1.powerPercentx0;
		
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


