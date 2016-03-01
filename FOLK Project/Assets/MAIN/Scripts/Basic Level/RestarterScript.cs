using UnityEngine;
using System.Collections;

public class RestarterScript : MonoBehaviour {

	public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
	
}
