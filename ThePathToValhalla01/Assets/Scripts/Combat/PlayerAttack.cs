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
    private float range = 100f;
    public Transform InteractionSource;
    public GameObject objectToThrow;
    public Transform dist_attakPoint;

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

    public int ItemDamage;

    public SoundPlayer soundPlayer;
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
        soundPlayer.PlaySound("weapon_swing", 1.0f, 0.3f);
        playerStats.currentStamina -= 8;
        _lastAttackTime = Time.time;
        _animator.SetTrigger("SimpleAttack");
        StartCoroutine(Hit(false));
    }

    public void OnStrongAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastStrongAttackTime < 4.0f || Time.timeScale == 0f || playerStamina < 16) return;
        soundPlayer.PlaySound("weapon_hardSwing", 0.8f, 0.3f);
        playerStats.currentStamina -= 16;
        _lastStrongAttackTime = Time.time;
        _animator.SetTrigger("StrongAttack");
        StartCoroutine(Hit(true));
    }

    public void OnDistanceAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastAttackTime < 2.0f || Time.timeScale == 0f || playerStamina < 4) return;
        playerStats.currentStamina -= 4;
        _lastAttackTime = Time.time;

        _animator.SetTrigger("DistanceAttack");
        Invoke("DistanceAttack_action", 1);
        //GameObject projectile = Instantiate(objectToThrow, dist_attakPoint.position, InteractionSource.rotation);
        //Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        //Vector3 forceToAdd = InteractionSource.transform.forward * 50 + transform.up * 0;
        //projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        //_animator.SetTrigger("DistanceAttack");
        //RaycastHit hit;
        //if (Physics.Raycast(InteractionSource.position, InteractionSource.forward, out hit, range))
        //{
        //    Debug.Log(hit.transform.name);

        //    SimpleEnemy target = hit.transform.GetComponent<SimpleEnemy>();
        //    if (target != null)
        //    {
        //        target.Damage(10);
        //    }
        //}
    }

    public void DistanceAttack_action()
    {
        GameObject projectile = Instantiate(objectToThrow, dist_attakPoint.position, InteractionSource.rotation);
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        Vector3 forceToAdd = InteractionSource.transform.forward * 50 + transform.up * 0;
        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        RaycastHit hit;
        if (Physics.Raycast(InteractionSource.position, InteractionSource.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            SimpleEnemy target = hit.transform.GetComponent<SimpleEnemy>();
            if (target != null)
            {
                target.Damage(10);
            }
        }
    }

    private IEnumerator Hit(bool strong)
    {
        _isAttacking = true;
        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        foreach (var attackAreaDamageable in _attackArea.Damageables)
        {
            soundPlayer.PlaySound("hit", 1.0f, 0.2f);
            attackAreaDamageable.Damage((playerLvl * playerDamageRatio * (Damage) * (strong ? 2 : 1)) + ItemDamage);
        }

        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        _isAttacking = false;
    }
}

