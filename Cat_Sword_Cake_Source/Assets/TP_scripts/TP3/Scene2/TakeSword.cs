using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeSword : MonoBehaviour
{
    public string scene;
    bool notfound = true;
    float distance = 10;
    GameObject player;
    //	Use	this	for	initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");      //	pour	trouver	le	personnage
    }
    //	Update	is	called	once	per	frame
    void Update()
    {

        distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance < 4 && notfound)
        {
            this.transform.parent = GameObject.FindWithTag("hand").transform;
            this.transform.localPosition = new Vector3(0.05f, -0.16f, -0.46f);
            this.transform.localRotation = Quaternion.identity;
            this.transform.localRotation = Quaternion.Euler(-118, -10, -90);
            notfound = false;
            StartCoroutine(Victory());
        }

    }

    IEnumerator Victory()
    {
        GameVariables.currentTime = GameVariables.allowedTime;
        while (GameVariables.currentTime > 0)
        {
            //attendre	1	seconde
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(1.0f);
            SceneManager.LoadScene(scene);
        }
    }
}