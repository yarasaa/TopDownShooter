using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorChange : MonoBehaviour
{
    public float timer = 0.0f;
    public Material[] material;
    Renderer rend;
    public int x;
    void Start()
    {
        x = Random.Range(0,3);
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.material = material[x];
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1.0f)
        {
            x = Random.Range(0, 3);
            rend.material = material[x];
           
            timer = 0;
            x = 0;
        }
    }
}
