using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlidingSlider : MonoBehaviour
{
	public GameObject slider;
	public GameObject audioSource;
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
		if (shipComponent.health <= 30 && shipComponent.health >= 29.5f) {
						PlayAudio ();
				}
						
	
	}

	public void OnSliderChange()
	{
		Debug.Log("Slider value: " + shipComponent.health);
	}

	public void PlayAudio()
	{
		audioSource = GameObject.Find ("WarningAudio");
		audioSource.audio.Play ();
		}

}

