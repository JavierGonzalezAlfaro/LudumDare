using UnityEngine;
using System.Collections;

public class TimeLifeDestroyer : MonoBehaviour {
	private float timer = 0;

	void Update(){
		timer += Time.deltaTime;
		if (timer > 60)
			Destroy (this.gameObject);
	}
}
