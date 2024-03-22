using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart;
    private int random;
    private float IntervalOfCriation = 10;
    private float[] y = { 3.23f, 0, -3.23f };

    private float HeartSpeed = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Create();
        
    }

    void Move()
    {
        
        transform.Translate(new Vector2(HeartSpeed * Time.deltaTime, 0));
    }

    void Create()
    {
        IntervalOfCriation -= Time.deltaTime;
        if (IntervalOfCriation < 0)
        {
            random = Random.Range(0, 3);
            Instantiate(heart, new Vector2(13, y[random]), Quaternion.identity);
            IntervalOfCriation = Random.Range(10, 16);
        }

    }
}
