using UnityEngine;
using System.Collections;

public class RotateViaMouseXPosition : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		//Debug.Log(Input.mousePosition.x);
		float screenMidpoint = Screen.width / 2.0f;
		//Debug.Log(screenMidpoint);
		float pixelsFromCenter = Input.mousePosition.x - screenMidpoint;
		//Debug.Log(pixelsFromCenter);
		float degreesFromCenter = pixelsFromCenter / Screen.width * 360.0f;
		Debug.Log(degreesFromCenter);
		
		Quaternion target = Quaternion.Euler(0, 0, degreesFromCenter);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
	}
}
