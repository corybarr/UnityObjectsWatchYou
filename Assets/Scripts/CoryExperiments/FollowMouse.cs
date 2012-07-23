using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	private Camera camera;
	
	void Start() {
		camera = Camera.mainCamera;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 temp = Input.mousePosition;
		Vector3 p = camera.ScreenToWorldPoint(new Vector3(temp.x, temp.y, 2));
		transform.position = p;
		//mySphere.transform.Translate (p);				
	}
}
