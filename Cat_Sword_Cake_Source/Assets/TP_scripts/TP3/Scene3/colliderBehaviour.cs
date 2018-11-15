using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Animator persoAnimator = gameObject.GetComponent<Animator>();
        persoAnimator.SetTrigger("isTrigger");
    }
}
