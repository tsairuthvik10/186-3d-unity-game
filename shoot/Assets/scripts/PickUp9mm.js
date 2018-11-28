static var DistanceFromTarget : float;
var TheDistance : float = DistanceFromTarget;
var TextDisplay : GameObject;
var ToTarget : float;
var FakeGun : GameObject;
var RealGun : GameObject;
var AmmoDisplay : GameObject;
var Bullets : GameObject;
var PickUpAudio : AudioSource;
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
        TextDisplay.GetComponent.<Text>().text = "Take 9mm Pistol";
        }
       if(Input.GetButtonDown("Action")){
      if(TheDistance <= 2){
            TakeNineMil();
        }
    }
}

function OnMouseExit(){
    TextDisplay.GetComponent.<Text>().text = "";
}

function TakeNineMil(){
    PickUpAudio.Play();
    transform.position = Vector3(0, -1000, 0);
    FakeGun.SetActive(false);
    RealGun.SetActive(true);
    Bullets.SetActive(true);
    AmmoDisplay.SetActive(true);
    TextDisplay.SetActive(false);
}
