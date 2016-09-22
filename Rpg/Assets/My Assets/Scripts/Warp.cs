using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

	IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        ScreenFader sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFader>();

        if (other.gameObject.tag == "Player")
        {
            yield return StartCoroutine(sf.FadeToBlack());
            Debug.Log("player collided");
            other.gameObject.transform.position = warpTarget.position;
            Camera.main.transform.position = warpTarget.position;
            yield return StartCoroutine(sf.FadeToClear());
        }
        else if(other.gameObject.tag == "Follower")
        {
            Debug.Log("player collided");
            other.gameObject.transform.position = warpTarget.position;
        }
        
    }

}
