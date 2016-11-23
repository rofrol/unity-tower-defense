using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

	private static EnemyManager singleton;
	public static EnemyManager Get() {
		return singleton;
	}
	
	public List<Enemy> hostileUnits = new List<Enemy>();

	// wykonuja sie najpierw awaki a potem start
	void Awake() {
		singleton = this;
	}

	public void AddEnemy(Enemy enemy) {
		hostileUnits.Add (enemy);
	}

	public void RemoveEnemy(Enemy enemy) {
		if (hostileUnits.Contains (enemy)) {
			hostileUnits.Remove (enemy);
		}
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.R)) {
			for (int i = 0; i < hostileUnits.Count; i++) {
				Debug.LogError (".");
				// GameObject importowany przez UnityEngine wiec mozna poiminac GameObject
				GameObject.Destroy (hostileUnits [i].gameObject);
			}
		}
	}
}
