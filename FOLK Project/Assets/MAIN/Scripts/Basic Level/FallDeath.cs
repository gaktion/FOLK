using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
    {
        GameObject camera;
        camera = GameObject.Find("Main Camera");
        if (col.tag == "Player")
            camera.GetComponent<Camera2DFollow>().enabled = false;
    }
}
