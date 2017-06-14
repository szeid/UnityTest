using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineExample : MonoBehaviour {
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine (TestCoroutine());
		}
	}

	IEnumerator TestCoroutine() {
		while (true) {
			Debug.Log ("Repeating for 1 seconds");
			/*yield return */new WaitForSeconds(1f);
			yield break;
		}
	}
}
