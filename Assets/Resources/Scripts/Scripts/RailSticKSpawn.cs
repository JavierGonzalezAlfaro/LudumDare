using UnityEngine;
using System.Collections;

public class RailSticKSpawn : MonoBehaviour {
	public GameObject railStick;

	void Start(){
		StartCoroutine ("spawnRailSticks");
	}

	IEnumerator spawnRailSticks(){
		while (true) {
			yield return new WaitForSeconds(4);
			Instantiate (railStick, this.transform.position, railStick.transform.rotation);

		}
	}
}
