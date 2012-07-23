using UnityEngine;
using System.Collections;

public class FlyForward : MonoBehaviour {
	
	public float speed = 1.0f;
		
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
	}
}
