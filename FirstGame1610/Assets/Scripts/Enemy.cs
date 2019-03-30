using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MoveCharacter
{
    public int HealthDamage;

    private Animator animator;

    private Transform target;
    // Start is called before the first frame update
    protected override void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
