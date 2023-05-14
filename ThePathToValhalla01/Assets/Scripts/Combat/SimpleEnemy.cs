using UnityEngine;
using Interfaces;
using System;
using UnityEngine.UI;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    private Animator _animator;

    [SerializeField]
    private int currentHealth;
    [SerializeField]
    private Canvas healthCanvas;
    [SerializeField]
    private Slider healthSlider;
    [SerializeField]
    private int valueXP;

    private Camera _cam;

    public bool isDead = false;

    private RandomMovement moving;
    private EnemyMovement moving2;
    private int maxHP;
    private GameObject player;
    private PlayerStats playerStats;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponentInChildren<PlayerStats>();
        _cam = Camera.main;
        maxHP = currentHealth;
        moving = GetComponent<RandomMovement>();
        moving2 = GetComponent<EnemyMovement>();
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
            if (moving2 != null)
            {
                moving2.agent.isStopped = true;
                Destroy(moving2);
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
                playerStats.IncreaseXP(valueXP);
            }
            if (moving2 != null)
            {
                moving2.agent.isStopped = true;
                Destroy(moving2);
                _animator.SetTrigger("setDead");
                playerStats.IncreaseXP(valueXP);
            }
        }
    }
}
