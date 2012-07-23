using UnityEngine;
using System.Collections;

public class LookAtOtherObject : MonoBehaviour {
	
	public Transform lookAtMe;
		
	// Update is called once per frame
	void Update () {
		transform.LookAt(lookAtMe);
	
	}
}
