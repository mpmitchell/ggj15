using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlidingSlider : MonoBehaviour
{
	public GameObject slider;
	public ShipComponentScript shipComponent;
	Slider slider_;

	public void Start()
	{
		slider_ = slider.GetComponent<Slider>();
	}

	public void Update()
	{
		if (slider_ && shipComponent)
			slider_.value = shipComponent.health / 100.0f;
	}

	public void OnSliderChange()
	{
		Debug.Log("Slider value: " + shipComponent.health);
	}
}
