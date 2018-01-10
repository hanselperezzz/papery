using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // STEP 1: Saying we want the ability to load a new scene

public class MusicPlayer : MonoBehaviour {

    void Awake() // STEP 3: Add this code so the music doesn't stop when new scene loads
    {
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        Invoke("LoadFirstScene", 2f);
	}
	
    void LoadFirstScene() { // STEP 2: Deleted Update(); code that was her by default. This is the method that calls the new scene.
        SceneManager.LoadScene(1);
    }

}

