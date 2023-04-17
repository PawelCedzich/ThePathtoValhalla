using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private Animator _animator;

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
        _animator.SetTrigger("SimpleAttack");
        StartCoroutine(Hit(false));
    }

    public void OnStrongAttack(InputValue value)
    {
        _animator.SetTrigger("StrongAttack");
        StartCoroutine(Hit(true));
    }

    private IEnumerator Hit(bool strong)
    {
        yield return new WaitForSeconds(strong ? StrongDamageAfterTime : DamageAfterTime);
        foreach (var attackAreaDamageable in _attackArea.Damageables)
        {
            attackAreaDamageable.Damage(Damage * (strong ? 3 : 1));
        }
    }
}
