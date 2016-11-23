using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame ADWS
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (0.5f, 0, 0);
		}

		if (Input.GetKey (KeyCode.A)) {
			transform.position += new Vector3 (-0.5f, 0, 0);
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3 (0, 0, 0.5f);
		}

		if (Input.GetKey (KeyCode.S)) {
			transform.position += new Vector3 (0, 0, -0.5f);
		}
	}

	void OnCollisionEnter(Collision col) {
		Enemy enemy = col.gameObject.GetComponent<Enemy> ();

		if (enemy != null) {
			EnemyManager.Get ().RemoveEnemy (enemy);
			EnemyDetector.Get ().RemoveEnemy (enemy);
		}
		GameObject.Destroy (col.gameObject);
	}
}
