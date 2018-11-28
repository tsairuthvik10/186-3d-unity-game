using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonstart : MonoBehaviour {
    public Button m_YourFirstButton;
	// Use this for initialization
	void Start () {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(1);
    }
}
