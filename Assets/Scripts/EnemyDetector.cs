using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyDetector : MonoBehaviour {

    private static EnemyDetector singleton;
    public static EnemyDetector Get()
    {
        return singleton;
    }
    // wykonuja sie najpierw awaki a potem start
    void Awake()
    {
        singleton = this;
    }

    public List<Enemy> hostileInRange = new List<Enemy> ();

	public void AddEnemy(Enemy enemy) {
		hostileInRange.Add (enemy);
	}

	public void RemoveEnemy(Enemy enemy) {
		if (hostileInRange.Contains (enemy)) {
			hostileInRange.Remove (enemy);
		}
	}
}
