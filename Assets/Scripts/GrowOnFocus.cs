using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnFocus : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 originalScale;
    private Vector3 selectedScale;

    void Start()
    {
        originalScale = transform.localScale;
        selectedScale = originalScale * 1.1f;   
    }

    void Scale(){
        transform.localScale = selectedScale;
    }

    void Unscale(){
        transform.localScale = originalScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
