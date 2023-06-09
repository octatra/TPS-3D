﻿/*
 * Desc     : Membuat fungsi fade in menggunakan komponen Image
 * Author   : Rickman Roedavan
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hardcode_FadeIn : MonoBehaviour
{
    Image TargetImage;
    float FadeSpeed = 1;

    void Awake()
    {
        //Mendapatkan komponen Image secara otomatis. Catatan: Script ini harus dipasang di komponen Image
        TargetImage = GetComponent<Image>();
        
        //Membuat ukuran TargetImage sesuai dengan ukuran layar
        TargetImage.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }

    void FadeIn()
    {
        //Membuat warna TargetImage pakai transisi Lerp dari warna awal ke warna transparan
        TargetImage.color = Color.Lerp(TargetImage.color, Color.clear, FadeSpeed * Time.deltaTime);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FadeIn();
    }
}
