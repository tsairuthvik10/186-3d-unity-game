

var bomb_life : float = 3;

var EnemyHealth : int = 10;

	// Use this for initialization
	function Start () {
		
	}
	
	// Update is called once per frame
	function Update () {
        bomb_life -= Time.deltaTime;

        if(bomb_life <= 0){
            Explode();
        }
	}

    function OnCollisionEnter (collision: Collision) {
        if(collision.gameObject.tag == "enemy"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
           // GlobalScore.CurrentScore += 10;
        }

        if (collision.gameObject.tag == "dummy")
        {
            Destroy(gameObject);
            GlobalScore.CurrentScore += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "change")
        {
            Destroy(gameObject);
            GlobalScore.CurrentScore += 10;
            Destroy(collision.gameObject);

            
        }
    }

    function Explode() {
        Destroy(gameObject);
    }

