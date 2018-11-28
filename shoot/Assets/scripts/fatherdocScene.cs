using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fatherdocScene : MonoBehaviour
{
    void Start()
    {

        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(114.0f);
        SceneManager.LoadScene(16);



    }

}
