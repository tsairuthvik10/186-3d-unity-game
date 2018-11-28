var Enemy : GameObject;
var gun : GameObject;
var count: int = 1;


function Update () {
    if(Enemy == null && count == 1 ){
          gun.SetActive(true); 
           count++;
    }
}
