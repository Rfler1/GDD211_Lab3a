using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
  public override void MakeSound()
    {
        Debug.Log("Uuurrrgh");
    }

    public void Collapse()
    {

    }
}