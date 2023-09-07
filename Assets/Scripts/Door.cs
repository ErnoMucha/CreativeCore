using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Door : MonoBehaviour
{
    private int count = 0;
    public int size;
    public Animator DoorAnimator;

    private void Start()
    {
    }

    public void BoneCollected()
    {
        //Call: from Bone prefab when pick up bone
        count++;
        if(count == size)
        {
            DoorAnimator.SetBool("Open", true);
        }
    }
}
