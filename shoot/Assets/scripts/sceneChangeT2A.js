//import UnityEngine.SceneManagement;
var ls:UnityEngine.SceneManagement.SceneManager;
	function Update () {
        if(GlobalScore.CurrentScore == 130){
            ls.LoadScene("friendframe");
            GlobalScore.CurrentScore = 0;
        }
	}

