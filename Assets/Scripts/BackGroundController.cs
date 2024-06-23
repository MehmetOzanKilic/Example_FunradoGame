using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    [SerializeField]Material material;
    private float hue=50;
    private float s=50;
    private float v=50;
    private bool redFlag=false;

    void Update()
    {
        if(!redFlag)
        {
            //changes the color of the background overtime
            hue +=Time.deltaTime*20;
            if(hue>=360)hue=0;

            Color newColor = Color.HSVToRGB(hue/360, s/100, v/100);

            material.color = newColor;
        }
        
    }

    public void wrongMove()
    {
        StartCoroutine(MakeRed());
    }

    private IEnumerator MakeRed()
    {
        yield return new WaitForSeconds(0.1f);
        redFlag=true;

        float temp =hue;

        material.color = Color.red;

        Vector3 originalPos = transform.position;

        for(int i = 0;i<10;i++)
        {
            transform.position = originalPos + Random.insideUnitSphere*2;
            yield return new WaitForSeconds(0.05f);
        }

        transform.position = originalPos;


        redFlag=false;
    }
}
