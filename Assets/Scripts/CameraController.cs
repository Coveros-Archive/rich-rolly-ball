using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		// record our offset vector at the start of the game
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called once per frame after all other activities
	// 
	void LateUpdate () {

		// reset our position with same offset from player position.
		transform.position = player.transform.position + offset;

	}
}
