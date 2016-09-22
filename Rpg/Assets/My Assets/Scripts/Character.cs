using UnityEngine;
using System;
using System.Collections;

public class Character : MonoBehaviour {

    private int healthPoints;
    public int HealthPoints
    {
        get{ return healthPoints; }
        set { healthPoints = value; }
    }


    private int strength;
    public int Strength
    {
        get { return strength; }
        set { strength = value; }
    }

    private int intelligence;
    public int Intelligence
    {
        get { return intelligence; }
        set { intelligence = value; }
    }

    private int dexterity;
    public int Dexterity
    {
        get { return dexterity; }
        set { dexterity = value; }
    }




    //public void Move(Vector2 movement_vector, Animator anim, Rigidbody2D rbody)
    //{

    //    if (movement_vector != Vector2.zero)
    //    {
    //        anim.SetBool("isWalking", true);
    //        anim.SetFloat("input_x", movement_vector.x);
    //        anim.SetFloat("input_y", movement_vector.y);
    //    }
    //    else
    //    {
    //        anim.SetBool("isWalking", false);
    //    }

    //    rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime);

    //}

    public void Move(Vector2 movement_vector, Animator anim, Rigidbody2D rbody, float speed)
    {

        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("isWalking", true);
            anim.SetFloat("input_x", movement_vector.x);
            anim.SetFloat("input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

        rbody.MovePosition(rbody.position + movement_vector * speed * Time.deltaTime);

    }

    public void Attack(Animator anim)
    {
        anim.SetTrigger("attackTrigger");
    }


}
