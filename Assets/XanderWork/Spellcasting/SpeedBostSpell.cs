﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBostSpell : SpellAbstract {

    public Renderer rend;

    public float shootLifetime = 1.0f;
    public float boostLength = 1.0f;
    public float boostForce = 100.0f;
    private Rigidbody target = null;

    public override void Shoot()
    {
        Invoke("Remove", shootLifetime);
    }

    public void Remove()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == allyTeamTag && target == null)
        {
            target = other.GetComponent<Rigidbody>();
            rend.enabled = false;
            CancelInvoke();
            Invoke("Remove", boostLength);
        }
    }

    private void Update()
    {
        if(target != null)
        {
            target.AddForce(target.transform.forward * boostForce);
        }
    }

}