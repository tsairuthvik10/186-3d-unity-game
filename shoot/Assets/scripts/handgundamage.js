var DamageAmount : int = 5;
var TargetDistance : float;
var AllowedRange : float = 15;

function Update () {
if(GlobalAmmo.LoadedAmmo >= 1){
    if (Input.GetButtonDown("Fire1")){
        var shot : RaycastHit;
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), shot)){
            TargetDistance = shot.distance;
                if (TargetDistance < AllowedRange) {
                    shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
        }
    }
}
}
