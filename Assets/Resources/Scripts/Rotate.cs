using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	private bool rotateStronger = false;

	void Start(){
		
	}

	void Update () {
		float rotationSpeed = -4f;
		if (rotateStronger) {
			rotationSpeed = -20f;
		}
		this.transform.Rotate(0, rotationSpeed, 0);
		if(Input.GetKeyDown(KeyCode.E)){
			rotateStronger = !rotateStronger;
		}
	}
}
