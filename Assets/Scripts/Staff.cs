using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour, IWeapon, IProjectileWeapon
{
    private Animator animator;


    public Transform ProjectileSpawn { get; set; }
    Fireball fireball;

    void Start()
    {
        fireball = Resources.Load<Fireball>("Weapons/Projectiles/Fireball");
        animator = GetComponent<Animator>();
    }
    public List<BaseStat> Stats { get; set; }
    public void PerformAttack()
    {
        animator.SetTrigger("Base_Attack");
    }

    public void PerformSpecialAttack()
    {
        animator.SetTrigger("Special_Attack");
    }



    public void CastProjectile()
    {
        Fireball fireballInstance = Instantiate(fireball, ProjectileSpawn.position, ProjectileSpawn.rotation);
        fireballInstance.Direction = ProjectileSpawn.forward;
    }
}
