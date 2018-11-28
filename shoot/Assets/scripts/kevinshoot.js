

   
    var bomb_prefab : GameObject;

    var bomb_impulse : float;

    // Use this for initialization


    // Update is called once per frame
    function Update () {
        bomb_impulse = 100;
        if(Input.GetButtonDown("Fire1")){
            //Camera cam = Camera.main;
            var cam : Camera = Camera.main;
            var theBomb : GameObject = (GameObject).Instantiate(bomb_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            theBomb.GetComponent.<Rigidbody>().AddForce(cam.transform.forward * bomb_impulse, ForceMode.Impulse);
            if (GlobalAmmo.LoadedAmmo < 1)
            {
                theBomb.SetActive(false);
        }
        }



	}

