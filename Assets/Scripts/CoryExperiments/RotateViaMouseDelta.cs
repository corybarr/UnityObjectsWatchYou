using UnityEngine;
using System.Collections;

public class RotateViaMouseDelta : MonoBehaviour {
    //public float horizontalSpeed = 1.0F;
    //public float verticalSpeed = 1.0F;
	
    void Update() {
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
		if (h > 0.01) {
			Debug.Log(h);
		}
        transform.Rotate(v, h, 0);
    }
}
