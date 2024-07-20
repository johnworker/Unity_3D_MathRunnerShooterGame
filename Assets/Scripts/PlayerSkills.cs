using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    public float skillCooldown = 5.0f;
    private float nextSkillTime = 0.0f;
    public GameObject areaAttackPrefab;
    public Transform attackPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && Time.time > nextSkillTime)
        {
            UseSkill();
            nextSkillTime = Time.time + skillCooldown;
        }
    }

    void UseSkill()
    {
        Instantiate(areaAttackPrefab, attackPoint.position, attackPoint.rotation);
        // 這裡可以添加技能音效和特效
    }
}
