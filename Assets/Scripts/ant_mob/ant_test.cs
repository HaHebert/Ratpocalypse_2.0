using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ant_test : MonoBehaviour
{
    // Start is called before the first frame update
    public float _health = 3;
    public float Health
    {
        set
        {
            _health = value;

            if (_health <= 0)
            {
                Destroy(gameObject);
            }
        }
        get
        {
            return _health;
        }
    }
    void TakeDamage(float damage)
    {
        Debug.Log("Ant Hit " + damage);
        Health -= damage;
    }
}