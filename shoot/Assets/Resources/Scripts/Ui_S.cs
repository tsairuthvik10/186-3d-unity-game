using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Ui_S : MonoBehaviour {
    string sprit_Path = "Sprites/cia1";
    public Sprite[] sp_S;
    public Button[] all_Btn;
    public Transform bg_T;
    private GridLayoutGroup bg_Layout;
    public GameObject btn_Gm;
    public RectTransform null_Img;
    public string all_SpritName;
    public string all_BtnSpriteName;
	void Start () {
        sp_S = Resources.LoadAll<Sprite>(sprit_Path);
        bg_Layout = bg_T.GetComponent<GridLayoutGroup>();

        List<Sprite> test_L = new List<Sprite>();
        for (int i=0;i<sp_S.Length;i++)
        {
            test_L.Add(sp_S[i]);
            all_SpritName += sp_S[i].name;
        }
        int[] a = { 7, 0, 3, 5, 6, 4, 2, 1, 8 };
        for (int i = 0; i < 9; i++)
            {
            GameObject instan_Btn = Instantiate(btn_Gm) as GameObject;
            Button btn_ = instan_Btn.GetComponent<Button>();
            btn_.onClick.AddListener(delegate() { this.Btn_OnClick(instan_Btn.GetComponent<RectTransform>()); });
            instan_Btn.name = test_L[a[i]].name;
            instan_Btn.transform.SetParent(bg_T);
            instan_Btn.GetComponent<RectTransform>().localScale = Vector3.one;
            if (i == 8)
            {
                instan_Btn.GetComponent<Image>().sprite = null;
                null_Img = instan_Btn.GetComponent<RectTransform>();
            }
            else
            {
                instan_Btn.GetComponent<Image>().sprite = test_L[a[i]];
            }            
        }
        all_Btn = transform.Find("Img_Bg").GetComponentsInChildren<Button>();
    }

    public void Btn_OnClick(RectTransform btn_Rect)
    {
        float a = Mathf.Abs(Vector2.Distance(btn_Rect.anchoredPosition, null_Img.anchoredPosition) - (bg_Layout.cellSize.x + bg_Layout.spacing.x));
        if (a < 0.1)
        {
            Sprite huanCun = btn_Rect.GetComponent<Image>().sprite;
            btn_Rect.GetComponent<Image>().sprite = null_Img.GetComponent<Image>().sprite;
            btn_Rect.gameObject.name = null_Img.gameObject.name;
            null_Img.GetComponent<Image>().sprite = huanCun;
            null_Img.gameObject.name = huanCun.name;
            null_Img = btn_Rect;
            BtnName_All();
        }
    }
    
    void BtnName_All()
    {
        all_BtnSpriteName = "";
        all_Btn =bg_T.GetComponentsInChildren<Button>();
        for (int i=0;i<all_Btn.Length;i++)
        {
            all_BtnSpriteName += all_Btn[i].gameObject.name;
        }
        if (all_BtnSpriteName == all_SpritName)
        {
            Debug.Log("Finish!");
            SceneManager.LoadScene(5);

        }
    }
}
