using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private Animator _animator;
    private bool _isAttacking;
    private float _lastAttackTime;
    private float _lastStrongAttackTime;
    private int playerStamina;
    private float staminaRegen = 0.8f;
    private int playerLvl;
    private int playerDamageRatio = 1;

    [SerializeField]
    private PlayerStats playerStats;

    [SerializeField]
    private float DamageAfterTime;

    [SerializeField]
    private float StrongDamageAfterTime;

    [SerializeField]
    private int Damage;

    [SerializeField]
    private AttackArea _attackArea;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
    }

    private void FixedUpdate()
    {
        this.playerLvl = playerStats.currentLevel;
        if (this.playerLvl == 0)
        {
            this.playerLvl = 1;
        }

        this.playerStamina = playerStats.currentStamina;
    }

    private void IncreaseStamina()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }
        else if (playerStats.currentStamina < playerStats.maxStamina)
        {
            playerStats.currentStamina++;
        }

        if (playerLvl < 5)
        {
            CancelInvoke("IncreaseStamina");
            staminaRegen = 1.0f;
            InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
        }
        else if (playerLvl < 10)
        {
            CancelInvoke("IncreaseStamina");
            staminaRegen = 0.8f;
            InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
        }
        else if (playerLvl < 15)
        {
            CancelInvoke("IncreaseStamina");
            staminaRegen = 0.6f;
            InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
        }
        else if (playerLvl < 20)
        {
            CancelInvoke("IncreaseStamina");
            staminaRegen = 0.4f;
            InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
        }
        else
        {
            CancelInvoke("IncreaseStamina");
            staminaRegen = 0.2f;
            InvokeRepeating("IncreaseStamina", staminaRegen, staminaRegen);
        }
    }

    public void OnAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastAttackTime < 2.0f || Time.timeScale == 0f || playerStamina < 8) return;
        playerStats.currentStamina -= 8;
        _lastAttackTime = Time.time;
        _animator.SetTrigger("SimpleAttack");
        StartCoroutine(Hit(false));
    }

    public void OnStrongAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastStrongAttackTime < 4.0f || Time.timeScale == 0f || playerStamina < 16) return;
        playerStats.currentStamina -= 16;
        _lastStrongAttackTime = Time.time;
        _animator.SetTrigger("StrongAttack");
        StartCoroutine(Hit(true));
    }

    private IEnumerator Hit(bool strong)
    {
        _isAttacking = true;
        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        foreach (var attackAreaDamageable in _attackArea.Damageables)
        {
            attackAreaDamageable.Damage(playerLvl * playerDamageRatio * Damage * (strong ? 2 : 1));
        }

        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        _isAttacking = false;
    }
}
