﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] objekSampah;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, objekSampah.Length);
            Instantiate(objekSampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
