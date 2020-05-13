using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 100;
    public Collector collector;

    void Update()
    {
        health = Random.Range(0, 100);
        collector.AddValue(health);
    }
}
