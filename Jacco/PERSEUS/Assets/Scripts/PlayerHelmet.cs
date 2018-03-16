using UnityEngine;
using System.Collections;

public class PlayerHelmet : MonoBehaviour
{
    public Material normalMat;
    public Material fadeMat;
    public float duration = 1.0F;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = normalMat;
    }
    void Update()
    {
        if (Input.GetKey("0"))
        {
            StartCoroutine(ColorFadeGone());
            StopCoroutine(ColorFadeGone());
        }
    }

    public IEnumerator ColorFadeBack()
    {
        float change = 0.0f;
        while (change <= 2.0f)
        {
            change += duration * Time.deltaTime;

            rend.material.Lerp(fadeMat, normalMat, change);
            yield return null;
        }
        
    }
    public IEnumerator ColorFadeGone()
    {

        float change = 0.0f;
        print(change);

        while (change <= 2.0f)
        {
            change += duration * Time.deltaTime;
            

            rend.material.Lerp(normalMat, fadeMat, change);
            yield return null;
        }
    }
}