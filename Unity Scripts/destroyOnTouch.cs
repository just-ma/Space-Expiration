using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnTouch : MonoBehaviour {

	private GameObject ship;
	private Vector3 offset;

	void Start(){
		offset = transform.position;
	}

	void Update(){
		if (ship == null)
			ship = GameObject.FindWithTag("Ship");
		transform.position = ship.transform.position + offset;
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag != "Enemy") {
			Destroy (collision.gameObject);
		}
	}
}
