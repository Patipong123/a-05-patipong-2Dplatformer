using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarManager : MonoBehaviour
{
    public Transform target;        // ������·��еԴ��� (�� �����������ѵ��)
    public Vector3 offset;          // ��ê��µ��˹�����Ѻ HP bar
    public Image healthFill;        // ��ͧ����ͧ HP bar (���������§�Ѻ Image ��� Inspector)

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (target != null)
        {
            // �Դ������˹觢ͧ target ����� offset
            transform.position = target.position + offset;

            // ����� HP bar �ѹ����ҡ��ͧ����
            transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
                             mainCamera.transform.rotation * Vector3.up);
        }
    }

    // �ѧ��ѹ����Ѻ�Ѿവ HP bar
    public void UpdateHealthBar(float health, float maxHealth)
    {
        healthFill.fillAmount = health / maxHealth;
    }
}

