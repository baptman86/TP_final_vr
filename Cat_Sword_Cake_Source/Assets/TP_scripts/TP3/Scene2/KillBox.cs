using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour {
    public string levelToLoad = "boxboy_scene";

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
