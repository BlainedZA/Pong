using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Transform playerPos;

	public float LeftX = -7.4f;
	public float RightX = 7.4f;
	
	// Update is called once per frame
	void Update () {

		Vector2 playerPos = transform.position;
		playerPos.x = Mathf.Clamp(playerPos.x, LeftX, RightX);
		transform.position = playerPos;
	}
}
