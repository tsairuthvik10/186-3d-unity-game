var EnemyHealth : int = 10;
//var TheEnemy : GameObject;

function DeductPoints (DamageAmount : int){
    EnemyHealth -= DamageAmount;
}

function Update () {
    if(EnemyHealth <= 0) {
        this.GetComponent("SoldierFollow").enabled = false;
       // TheEnemy.GetComponent.<Animation>().Play("die");
        Destroy(gameObject);
}
}
