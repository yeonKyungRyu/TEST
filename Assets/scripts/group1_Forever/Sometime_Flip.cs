﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 때때로 반전한다
public class Sometime_Flip : MonoBehaviour 
{

    public int maxCount = 50; // 빈도：Inspector에 지정

    int count = 0; // 카운터 용
    bool flipFlag = false;

    void Start ()
	{ // 처음에 시행한다
        count = 0;  // 카운터를 리셋
    }

    void FixedUpdate()// 계속 시행한다(일정 시간마다) 
	{ 
        count = count + 1; // 카운터에 1을 더해서
        if (count >= maxCount) 
		{ // 만약, maxCount가 되면
            this.transform.Rotate(0, 0, 180); // 180도 회전해서 돈다
            count = 0; // 카운터를 리셋
                       // 그 때 그림이 180도 회전하므로 위 아래를 반전시킨다
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag; 
        }
    }
}