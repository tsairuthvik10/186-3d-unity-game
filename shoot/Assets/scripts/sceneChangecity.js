//import UnityEngine.SceneManagement;
var ls:UnityEngine.SceneManagement.SceneManager;
	function Update () {
    
        if(GlobalAmmo.LoadedAmmo == 0 && GlobalAmmo.CurrentAmmo == 0 && GlobalScore.CurrentScore != 0){
            ls.LoadScene("Demo");
            GlobalScore.CurrentScore = 0;
        }
	}

