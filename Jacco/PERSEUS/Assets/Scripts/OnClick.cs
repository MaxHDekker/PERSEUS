﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }

}
