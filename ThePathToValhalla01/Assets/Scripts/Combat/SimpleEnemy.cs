using UnityEngine;
using Interfaces;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int currentHealth = 100;

    public bool isDead = false;

    private RandomMovement moving;

    void Start()
    {
        moving = GetComponent<RandomMovement>();
        if (isDead)
        {
            Debug.Log("Martwy po wczytaniu.");
            if (moving != null)
            {
                Destroy(moving);
            }
        }
    }

    // private Animator _animator;

    /*
     private void Awake(){
        _animator = GetComponent<Animator>();
    }
     */
    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("HP po uderzeniu: " + currentHealth + ". | Ile obra¿eñ otrzymano: " + damageAmount);
        if (currentHealth <= 0)
        {
            isDead = true;
            Debug.Log("NPC UMIERA");
            if (moving != null)
            {
                Destroy(moving);
            }
        }
        //_animator.SetTrigger("Damaged");
    }
}
