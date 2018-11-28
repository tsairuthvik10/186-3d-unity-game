using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class friendframeScene : MonoBehaviour
{
    void Start()
    {

        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(98.0f);
        SceneManager.LoadScene(9);



    }

}
