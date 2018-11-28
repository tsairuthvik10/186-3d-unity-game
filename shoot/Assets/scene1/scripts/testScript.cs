using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testScript : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider col) {

        StartCoroutine(OnCollisionEnter());
    }

    IEnumerator OnCollisionEnter()
    {
        yield return new WaitForSeconds(0);
        SceneManager.LoadScene(3);
    }

}
	
	

