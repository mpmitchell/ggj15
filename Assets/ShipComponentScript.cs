using UnityEngine;
using System.Collections;

public class ShipComponentScript : MonoBehaviour
{	
	public int health = 100;
	public bool isActive = false;
	public float Timer = 3.0f;

	public GameObject activateButton;
	public GameObject deactivateButton;

	public void Start()
	{
		BatteryScript.components.Add(this);
	}

	public virtual void Deactivate()
	{
		isActive = false;
		activateButton.SetActive(true);
		deactivateButton.SetActive(false);
	}
}
