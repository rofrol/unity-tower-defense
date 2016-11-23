using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	void Start() {
		EnemyManager.Get ().AddEnemy (this);
	}

	void OnTriggerEnter(Collider col) {
		EnemyDetector enemyDetector = col.gameObject.GetComponent<EnemyDetector> ();

		if (enemyDetector != null)
			enemyDetector.AddEnemy (this);
	}

	void OnTriggerExit(Collider col) {
		EnemyDetector enemyDetector = col.gameObject.GetComponent<EnemyDetector> ();

		if (enemyDetector != null)
			enemyDetector.RemoveEnemy (this);
	}

}
