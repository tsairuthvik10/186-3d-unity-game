﻿var Flash : GameObject;

function Update () {
    if(GlobalAmmo.LoadedAmmo >= 1){
     if (Input.GetButtonDown("Fire1")) {
        var gunsound : AudioSource = GetComponent.<AudioSource>();
        gunsound.Play();
        Flash.SetActive(true);
        MuzzleOff();
        GetComponent.<Animation>().Play("Shoot");
        GlobalAmmo.LoadedAmmo -= 1;
    }
}
}

function MuzzleOff(){
    yield WaitForSeconds(1);
    Flash.SetActive(false);
}
