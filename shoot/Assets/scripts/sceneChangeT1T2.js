//import UnityEngine.SceneManagement;
var ls:UnityEngine.SceneManagement.SceneManager;
	function Update () {
        if(GlobalScore.CurrentScore == 60){
            ls.LoadScene("Scenetraining2");
            GlobalScore.CurrentScore = 0;
        }
	}

