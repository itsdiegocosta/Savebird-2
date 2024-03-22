using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clound : MonoBehaviour
{
    public float vel = 0.001f;
    private Renderer quad;
    // Start is called before the first frame update
    void Start()
    {
        quad = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        Move();
    }

    void Move()
    {
        quad.material.mainTextureOffset += new Vector2(vel * Time.deltaTime, 0);
    }
}
