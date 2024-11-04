using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarManager : MonoBehaviour
{
    public Transform target;        // เป้าหมายที่จะติดตาม (เช่น ผู้เล่นหรือศัตรู)
    public Vector3 offset;          // การชดเชยตำแหน่งสำหรับ HP bar
    public Image healthFill;        // ช่องเติมของ HP bar (ให้เชื่อมโยงกับ Image สีใน Inspector)

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (target != null)
        {
            // ติดตามตำแหน่งของ target พร้อม offset
            transform.position = target.position + offset;

            // ทำให้ HP bar หันเข้าหากล้องเสมอ
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
                             mainCamera.transform.rotation * Vector3.up);
        }
    }

    // ฟังก์ชันสำหรับอัพเดต HP bar
    public void UpdateHealthBar(float health, float maxHealth)
    {
        healthFill.fillAmount = health / maxHealth;
    }
}

