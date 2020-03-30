using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    private RigidBody2D rb2d;
    public ScriptIWantToAccess GMScript;


    public void GoBall()
    {
        float random = Random.range(0, 2);
        if (random < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        } else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<RigidBody2D>();
        invoke("GoBall", 2);
    }

    void ResetBall()
    {
        GM.DestroyBall();
        GM.SpawnBall();

    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

}
