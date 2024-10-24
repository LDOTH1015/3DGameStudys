using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UICondition condition;

    Condition health { get { return condition.health; } }
    Condition hunger { get { return condition.hunger; } }
    Condition stamina { get { return condition.stamina; } }

    public float noHungerHealth;

    // Update is called once per frame
    void Update()
    {
        hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        stamina.Add(stamina.passiveValue * Time.deltaTime);
        if (hunger.curValue== 0)
        {
            health.Subtract(noHungerHealth * Time.deltaTime);
        }

        if (health.curValue == 0)
        {
            Die();
        }

    }

    public void Heal(float amout)
    {
        health.Add(amout);
    }

    public void Eat(float amout)
    {
        hunger.Add(amout);
    }

    public void Die()
    {
        Debug.Log("Die");
    }
}
