using UnityEngine;
using System.Collections;

public class LookAtTaggedObject : MonoBehaviour {

	public float attractionFactor = 1.0f;

	private Transform objectToLookAt;
	
	// Update is called once per frame
	void Update () {
		
		//try to get an object tagged "lookAtMe" if the object isn't tracking anything
		if (objectToLookAt == null) {
			
			GameObject go = GameObject.FindGameObjectWithTag("lookAtMe");
			if (go != null) objectToLookAt = go.transform;
			
			//objectToLookAt = GameObject.FindGameObjectWithTag("lookAtMe").transform;
		}
		
		if (objectToLookAt != null) {
			Vector3 vecToTarget = objectToLookAt.transform.position - transform.position;
			//Debug.Log (vecToTarget);	
			Quaternion rotation = Quaternion.LookRotation(vecToTarget);
			//smoothed rotation towards the target
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * attractionFactor);
			//move forward along new rotation
			//transform.Translate (Vector3.forward * Time.deltaTime * speed);
		}
	}
}
