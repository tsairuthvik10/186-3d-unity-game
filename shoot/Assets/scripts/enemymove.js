var ThePlayer : GameObject;
var TheEnemy : GameObject;
var EnemySpeed : float;
var MoveTrigger : int;

function Update () {

if(MoveTrigger == 1){
EnemySpeed = 0.04;
transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
}
}
