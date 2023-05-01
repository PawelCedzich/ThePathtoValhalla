using UnityEngine;
using Interfaces;
using System;
using UnityEngine.UI;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    private Animator _animator;

    [SerializeField]
    private int currentHealth = 100;
    [SerializeField]
    private Canvas healthCanvas;
    [SerializeField]
    private Slider healthSlider;

    private Camera _cam;

    public bool isDead = false;

    private RandomMovement moving;
    private int maxHP;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        _cam = Camera.main;
        maxHP = currentHealth;
        moving = GetComponent<RandomMovement>();
        if (isDead)
        {
            healthSlider.maxValue = currentHealth;
            healthSlider.value = 0;
            healthCanvas.enabled = false;
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

    void Update()
    {
        healthCanvas.transform.rotation = Quaternion.LookRotation(healthCanvas.transform.position - _cam.transform.position);
    }

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("HP po uderzeniu: " + currentHealth + ". | Ile obra¿eñ otrzymano: " + damageAmount);
        healthSlider.maxValue = maxHP;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            healthSlider.value = 0;
            currentHealth = 0;
            isDead = true;
            healthCanvas.enabled = false;
            if (moving != null)
            {
                moving.agent.isStopped = true;
                Destroy(moving);
                _animator.SetTrigger("setDead");
            }
        }
    }
}
