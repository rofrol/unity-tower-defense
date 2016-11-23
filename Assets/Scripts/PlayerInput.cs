using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	public GameObject spherePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			GameObject newObject = GameObject.Instantiate (spherePrefab);
			newObject.transform.position = new Vector3 (Random.Range (-10, 10), 0, Random.Range (-10, 10));
		}
	}
}
