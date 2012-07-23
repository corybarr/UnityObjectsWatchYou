using UnityEngine;
using System.Collections;

public class YBobber : MonoBehaviour {
	
	public float maxYVal = 2f;
	public float minYVal = -2f;
	private int direction = 1;
	private float smooth = 1.0f;
		
	// Update is called once per frame
	void Update () {
		
		float newYPos = transform.position.y + Time.deltaTime * smooth * direction;
		if (newYPos > maxYVal || newYPos < minYVal) {
			direction *= -1;
			newYPos = transform.position.y + Time.deltaTime * smooth * direction;
		}
		
		transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);
	}
}
