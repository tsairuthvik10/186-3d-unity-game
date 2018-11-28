using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class finalScene : MonoBehaviour
{
    void Start()
    {

        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(10.0f);
        //SceneManager.LoadScene(19);



    }

}
