using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb ;
	public float speed; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame. Good for input?
	//void Update () {
	
	//}

	// Called before physics computations
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {

		// If this is a pickup object, deactivate it.
		if (other.gameObject.CompareTag ("Pick Uppable")) {
			other.gameObject.SetActive (false);
		}
	}
}
