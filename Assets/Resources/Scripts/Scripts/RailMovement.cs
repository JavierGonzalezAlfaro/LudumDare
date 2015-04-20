using UnityEngine;
using System.Collections;

public class RailMovement : MonoBehaviour {
	void Update () {
		transform.Translate (0.01f, 0, 0);
	}
}
