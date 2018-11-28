var AmmoSound : AudioSource;

function OnTriggerEnter (col : Collider){
    AmmoSound.Play();
    if(GlobalAmmo.LoadedAmmo == 0){
        GlobalAmmo.LoadedAmmo += 20;
    this.gameObject.SetActive(false);
}
else{
    GlobalAmmo.CurrentAmmo += 20;
    this.gameObject.SetActive(false);
}
}
