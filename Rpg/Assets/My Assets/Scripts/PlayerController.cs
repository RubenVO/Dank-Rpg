using UnityEngine;
using System.Collections;

public class PlayerController: Character {

    Rigidbody2D rbody;
    Animator anim;

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

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        Move(movement_vector, anim, rbody, 1f);


        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            Attack(anim);
        }

    }
}
