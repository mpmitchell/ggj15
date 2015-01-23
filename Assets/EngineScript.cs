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
	
	void Update ()
	{
		if (isActive ==true)
		{
			Timer-= Time.deltaTime;
			if( Timer<=0)
			{
				health--;
				Debug.Log (health);
				Timer=3.0f;
			}
		}
	}

	public void Activate()
	{
		Debug.Log ("Working");
		isActive = true;
	}

	public void Deactivate()
	{
		Debug.Log("Deactivated");
		isActive = false;
	}
}