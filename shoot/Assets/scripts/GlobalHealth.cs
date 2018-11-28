using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {

    public static int PlayerHealth = 40;
    public int InternalHealth;
    public GameObject HealthDisplay;

    void Update()
    {
        InternalHealth = PlayerHealth;
        if(PlayerHealth < 0){
            PlayerHealth = 0;
        }
        HealthDisplay.GetComponent<Text>().text = "Health: " + PlayerHealth;
        if(PlayerHealth == 0){
            SceneManager.LoadScene(21); 
        }
    }


}
