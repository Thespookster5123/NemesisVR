﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpellAbstract : MonoBehaviour {

    public float cooldownTime;

    public string enemyTeamTag;
    public string allyTeamTag;



    public abstract void Shoot();

}
