using UnityEngine;
using System.Collections;

public class Curve : MonoBehaviour {
	
	public float speed = 2.0f;
	public bool curveYaw = true;
	public bool curvePitch = true;
	public bool curveRoll = true;
	
	
	// Update is called once per frame
	void Update () {
		
		//NOTE: Vector3.left won't actually rotate left. To rotate left, you want to rotate about the Y axis, 
		//which is Vector3.up
		if (curveYaw) {
			transform.Rotate(Vector3.up * speed * Time.deltaTime);
		}
		if(curvePitch) {
			transform.Rotate(Vector3.right * -1.0f * speed * Time.deltaTime);
		}
		if (curveRoll) {
			transform.Rotate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}
