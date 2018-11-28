public var yourButton: Button;
var ls:UnityEngine.SceneManagement.SceneManager;

    function Start() {
        var btn: Button = yourButton.GetComponent.<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    function TaskOnClick() {
        Debug.Log("You have clicked the button!");
        ls.LoadScene("Agent");
    }

