using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScript : MonoBehaviour
{
    public float speed;

    [SerializeField] Renderer rr;

    private void Update()
    {
        rr.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

}
