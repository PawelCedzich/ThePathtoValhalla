using UnityEngine;
using Interfaces;
using System;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    private Animator _animator;

    [SerializeField]
    private int currentHealth = 100;

    public bool isDead = false;

    private RandomMovement moving;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        moving = GetComponent<RandomMovement>();
        if (isDead)
        {
            _animator.SetTrigger("setDead");
            currentHealth = 0;
            Debug.Log("Martwy po wczytaniu.");
            if (moving != null)
            {
                moving.agent.isStopped = true;
                Destroy(moving);
            }
        }
    }

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("HP po uderzeniu: " + currentHealth + ". | Ile obra¿eñ otrzymano: " + damageAmount);
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            if (moving != null)
            {
                moving.agent.isStopped = true;
                Destroy(moving);
                _animator.SetTrigger("setDead");
            }
        }
    }
}
