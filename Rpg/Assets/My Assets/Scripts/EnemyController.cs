using UnityEngine;
using System;
using System.Collections;

public class EnemyController : Character {
    

    Rigidbody2D rbody;
    Animator anim;

    int x;
    int y;

    // Use this for initialization
    void Start () {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        HealthPoints = 100;
        Strength = 0;
        Intelligence = 0;
        Dexterity = 0;

    }
	
	// Update is called once per frame
	void Update () {

        Vector2 movement_vector = new Vector2(x, y);

        Move(movement_vector, anim, rbody, 0.8f);


        

    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("first");
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("second");
            if (Math.Abs((Math.Abs(Math.Round(this.transform.position.x, 2)) - Math.Abs(Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.x, 2)))) < 0.5)
            {
                x = 0;
            }
            else if (Math.Round(this.transform.position.x, 2) < Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.x, 2))
            {
                x = 1;
            }
            else if (Math.Round(this.transform.position.x, 2) > Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.x, 2))
            {
                x = -1;
            }

            if (Math.Round(this.transform.position.y, 2) == Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.y, 2))
            {
                y = 0;
            }
            else if (Math.Round(this.transform.position.y, 2) < Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.y, 2))
            {
                y = 1;
            }
            else if (Math.Round(this.transform.position.y, 2) > Math.Round(GameObject.FindGameObjectWithTag("Player").transform.position.y))
            {
                y = -1;
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            x = 0;
            y = 0;
        }
    }
}
