using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;

public class AttackArea : MonoBehaviour
{
    public List<IDamageable> Damageables { get; } = new();

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered collision.");
        var damageable = other.GetComponent<IDamageable>();
        if (damageable != null)
        {
            Damageables.Add(damageable);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Debug.Log("Exitted collision.");
        var damageable = other.GetComponent<IDamageable>();
        if (damageable != null && Damageables.Contains(damageable))
        {
            Damageables.Remove(damageable);
        }
    }
}
