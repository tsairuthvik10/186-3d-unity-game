var ls:UnityEngine.SceneManagement.SceneManager;

function OnTriggerEnter (col : Collider){
    ls.LoadScene("peter");
}
