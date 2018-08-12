﻿using UnityEngine;

public class JumpAroundMovement : MonoBehaviour {

    GameObject bottom;

	// Use this for initialization
	void Start () {
        bottom = GameObject.Find("bottom");
	}

    // Update is called once per frame
    void Update()
    {
        float xPos = Random.Range(-7, 7);
        float xVel = Random.Range(-4, 4);
        float yVel = Random.Range(9, 14);

        //if (this.transform.position.y < -6)
        if (this.transform.position.y <= (bottom.transform.position.y + 1))
        {
            xPos = Random.Range(-7, 7);

            if (xPos < -3)
                xVel = Random.Range(-1, 6);
            if (xPos > 3)
                xVel = Random.Range(-6, 1);

            transform.position = new Vector2(xPos, bottom.transform.position.y + 1); // -6);

            GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
        }
    }
}
