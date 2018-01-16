using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    void Awake() // Add this code so the music doesn't stop when new scene loads
    {
        DontDestroyOnLoad(gameObject);
    }
}

