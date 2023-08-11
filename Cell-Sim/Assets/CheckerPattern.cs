using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CheckerPattern : MonoBehaviour
{
    // Start is called before the first frame update

    MeshRenderer meshRenderer;
    Material material;
    Texture2D texture;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
        texture = new Texture2D(256, 256, TextureFormat.RGBA32, true, true);
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.filterMode = FilterMode.Point;
        
        material.SetTexture("_MainTex", texture);
        GenerateTexture();
    }

    void GenerateTexture()
    {
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                if (x % 2 == 0)
                {
                    texture.SetPixel(x, y, Color.black);
                }
                else 
                {
                    texture.SetPixel(x,y, Color.white);
                }
            }
        }
        texture.Apply();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
