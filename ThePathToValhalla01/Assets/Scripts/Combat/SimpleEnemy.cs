using UnityEngine;
using Interfaces;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    // private Animator _animator;

    /*
     private void Awake(){
        _animator = GetComponent<Animator>();
    }
     */
    public void Damage(int damageAmount)
    {
        Debug.Log(damageAmount);
        //_animator.SetTrigger("Damaged");
    }
}
