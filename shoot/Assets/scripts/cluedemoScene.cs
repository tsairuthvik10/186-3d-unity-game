using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cluedemoScene : MonoBehaviour
{
    void Start()
    {

        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(18.0f);
        SceneManager.LoadScene(14);



    }

}
