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
    public void OnAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastAttackTime < 1.5f || Time.timeScale == 0f) return;
        _lastAttackTime = Time.time;
        _animator.SetTrigger("SimpleAttack");
        StartCoroutine(Hit(false));
    }

    public void OnStrongAttack(InputValue value)
    {
        if (_isAttacking || Time.time - _lastStrongAttackTime < 3f || Time.timeScale == 0f) return;
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
            attackAreaDamageable.Damage(Damage * (strong ? 3 : 1));
        }

        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        _isAttacking = false;
    }
}
