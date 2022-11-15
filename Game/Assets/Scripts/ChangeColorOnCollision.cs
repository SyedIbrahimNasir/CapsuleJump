using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Color randomlySelectedColor;
    private void OnCollisionEnter(Collision other)
    {
        randomlySelectedColor = RandomColor;
        GetComponent<Renderer>().material.color = randomlySelectedColor;


    }

    private Color RandomColor => new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f),
            a: 1);
}



