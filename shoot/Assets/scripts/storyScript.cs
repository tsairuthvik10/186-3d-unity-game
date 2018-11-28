using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storyScript : MonoBehaviour
{

    [TextArea(4, 30)]
    public string[] page;
    int pageNumber = -1;
    Text view;
    // Use this for initialization
    void Start()
    {
        view = GetComponent<Text>();
        Invoke("PageTurn", 2);
    }

    // Update is called once per frame
    void PageTurn()
    {
        pageNumber++;
        if (pageNumber < page.Length)
        {
            view.text = page[pageNumber];
        }
        Invoke("PageTurn", 8);
    }
}