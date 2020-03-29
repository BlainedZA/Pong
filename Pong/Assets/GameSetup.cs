using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

	public GameObject ballPrefab;
	public GameObject clone;

	void Awake ()
    {
		clone = Instantiate(ballPrefab, new Vector2(0, 0), Quaternion.identity) as GameObject;
		
	}



	// Update is called once per frame
	void Update () {
		Vector2 BallPos = clone.transform.position;
		if (BallPos.y < -5.5)
		{
			if (clone)
            {
				return;
            }
			else
            {
				DestroyBall();
			}
			
		}
	}

	void DestroyBall ()
    {
		UnityEngine.Object.Destroy(clone);
	}
}
