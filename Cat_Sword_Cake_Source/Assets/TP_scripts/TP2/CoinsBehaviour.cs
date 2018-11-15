using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsBehaviour : MonoBehaviour
{
    private Renderer[] coins_renderer;
    AudioSource aud;
    private GameObject worldObject;

    void Start()
    {
        coins_renderer = GetComponentsInChildren<Renderer>();
        worldObject = GameObject.Find("World");
        aud = gameObject.GetComponent<AudioSource> ();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            
            worldObject.SendMessage("AddCoin");

            foreach (Renderer coin_renderer in coins_renderer)
            {
                coin_renderer.enabled = false;
            }

            Collider objCollider = GetComponent<Collider>();
            
            objCollider.enabled = false;
            if (aud)
            {
                aud.Play();
            }
        }
    }
}