using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_ : MonoBehaviour
{
    MeshRenderer meshRenderer;
    // 代表被发现时的帧数（这里用帧数代表时间）
    public int spottedFrame = -100;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        // 通过设置 spottedFrame，就可以实现隐藏或显现
        
    }
}
