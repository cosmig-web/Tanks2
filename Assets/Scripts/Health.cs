using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;

    public Image bar;

    public UnityEvent onDeath;

    float currentHelth;

    private void Start()
    {
        currentHelth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHelth -= damage;
        currentHelth = MathF.Max(0, currentHelth);
        bar.transform.localScale = new Vector3((float)currentHelth / maxHealth, 1, 1);
    }
}
