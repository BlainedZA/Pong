using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

	public GameObject ballPrefab;
	public GameObject clone;

	public void SpawnBall ()
    {
		clone = Instantiate(ballPrefab, new Vector2(0, 0), Quaternion.identity) as GameObject;
	}


	// Update is called once per frame
	void Update () {
		
		if(clone)
        {
			Vector2 BallPos = clone.transform.position;
			if (BallPos.y < -5.5)
			{
				DestroyBall();
			}
		}
		else
        {
			return;
        }
	}

	public void DestroyBall ()
    {
		Object.Destroy(clone);
	}
}
