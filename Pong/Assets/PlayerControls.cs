using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public float speed = 10f;

	private Rigidbody2D rigBody;

	void Awake ()
    {
		rigBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
			rigBody.velocity = new Vector2(-speed, 0);
        }
		else if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
		{
			rigBody.velocity = new Vector2(speed, 0);
		}
		else
        {
			rigBody.velocity = new Vector2(0, 0);
		}
	}
}
