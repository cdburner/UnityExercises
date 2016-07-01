using UnityEngine;
using System.Collections;

public class MoveBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (transform.position);
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(transform.position.x + 0.05f, 0);
	}
}
