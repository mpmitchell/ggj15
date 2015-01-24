using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DistanceSliderScript : MonoBehaviour {

	public GameObject slider;
	Slider slider_;
	public float distance = 600.0f;

	
	public void Start()
	{
		slider_ = slider.GetComponent<Slider>();
	}
	
	public void Update()
	{
		distance -= Time.deltaTime;
			slider_.value = distance / 600.0f;

		if (distance <= 0) {
						Debug.Log ("You Win! Liam and Mathew will implement the victory screen");
				}
	}
	
	public void OnSliderChange()
	{
		Debug.Log("Slider value: " + distance);
	}
}
