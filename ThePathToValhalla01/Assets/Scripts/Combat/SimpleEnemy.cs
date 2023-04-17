using UnityEngine;
using Interfaces;

public class SimpleEnemy : MonoBehaviour, IDamageable
{
    public void Damage(int damageAmount)
    {
        Debug.Log(damageAmount);
    }
}
