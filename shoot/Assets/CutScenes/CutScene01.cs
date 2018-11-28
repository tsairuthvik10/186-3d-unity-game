using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene01 : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject TheUI;
    public GameObject CutSceneUI;

	void Start () {
        Cam1.SetActive(true);
        StartCoroutine(CutSceneBegin());
	}
	
    IEnumerator CutSceneBegin(){
        yield return new WaitForSeconds(10.0f);
        Cam2.SetActive(true);
        Cam1.SetActive(false);
        yield return new WaitForSeconds(3.3f);
        ThePlayer.SetActive(true);
        TheUI.SetActive(true);
        Cam2.SetActive(false);
        CutSceneUI.SetActive(false);
    }

}
