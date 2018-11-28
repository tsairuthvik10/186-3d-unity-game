using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SoldierFollow : MonoBehaviour {

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange = 20.0f;
    public GameObject TheEnemy;
    public float EnemySpeed;
    public int AttackTrigger;
    public int IsAttacking;
    public GameObject ScreenFlash;
    public RaycastHit shot;
    Animator anim;
    [Range(0.0f, 1.0f)]
    public float HitAccuracy = 0.5f;

    public float DamagePoints = 2.0f;

    public AudioClip GunSound = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float dist = Vector3.Distance(ThePlayer.transform.position, this.transform.position);
        bool shoot = false;
        bool follow = (dist < AllowedRange);
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            TargetDistance = shot.distance;
            if (follow)
            {
                EnemySpeed = 0.1f;

                if (AttackTrigger == 0)
                {
                    // TheEnemy.GetComponent<Animation>().Play("assault_combat_run");
                    shoot = false;
                    transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                    if (IsAttacking == 0)
                    {
                        StartCoroutine(EnemyDamage());
                    }
                }
            }
            else
            {
                EnemySpeed = 0;
                shoot = false;
                follow = false;

            }
        }
                if (AttackTrigger == 1)
                {

                    //TheEnemy.GetComponent<Animation>().Play("assault_combat_shoot");
                    shoot = true;
                    follow = false;
            if (IsAttacking == 0)
            {
                StartCoroutine(EnemyDamage());
            }

        }


        anim.SetBool("Shoot", shoot);
        anim.SetBool("Run", follow);
    }

    void OnTriggerEnter(){
        AttackTrigger = 1;

    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

    IEnumerator EnemyDamage()
    {
        IsAttacking = 1;

         AudioSource gunsound = GetComponent<AudioSource>();
        gunsound.Play();
        float random = Random.Range(0.0f, 1.0f);

        // The higher the accuracy is, the more likely the player will be hit
        bool isHit = random > 1.0f - HitAccuracy;

        if (isHit)
        {
            GlobalHealth.PlayerHealth -= 2;
            //yield return new WaitForSeconds(0.9f);
            ScreenFlash.SetActive(true);
        }
        yield return new WaitForSeconds(0.5f);
        ScreenFlash.SetActive(false);
        yield return new WaitForSeconds(1);
        IsAttacking = 0;
    }


}
