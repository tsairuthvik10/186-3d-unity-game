static var DistanceFromTarget : float;
var TheDistance : float = DistanceFromTarget;
var TextDisplay : GameObject;
var ToTarget : float;
//var FakeGun : GameObject;
var ls:UnityEngine.SceneManagement.SceneManager;

function Update () {
    var hit : RaycastHit;
    if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), hit)){
        ToTarget = hit.distance;
        DistanceFromTarget = ToTarget;
    }
    TheDistance = DistanceFromTarget;

}

function OnMouseOver(){
    if(TheDistance <= 2){
        TextDisplay.SetActive(true);
        }
       if(Input.GetButtonDown("Action")){
      if(TheDistance <= 2){
            ls.LoadScene("fatherdoc");
        }
    }
}

function OnMouseExit(){
    TextDisplay.SetActive(false);
}


