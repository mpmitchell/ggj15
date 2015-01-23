using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlidingSlider : MonoBehaviour
{
	public GameObject slider;
	Slider slider_;
	EngineScript engine;

	public void Start()
	{
		slider_ = slider.GetComponent<Slider>();
		engine = GetComponent<EngineScript>();
	}

	public void Update()
	{
		if (slider_)
			slider_.value = engine.health / 100.0f;
	}

	public void OnSliderChange()
	{
		Debug.Log("Slider value: " + engine.health);
	}
}
