/*

 * transform position refers to the current position of the 
 * gameObject that this script is attached to
 * 
 * set:
 * To change the transform.position you need to give it
 * a Vector2/3 object
 * 
 * get:
 * transform.position returns a Vector3 object of the current
 * position of the gameObject
 * You can also get singly the x, y or z value 
 * For example to get the x position we would write
 * transform.position.x
 * 
 * 

*/

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
