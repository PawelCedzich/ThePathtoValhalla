using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable]

public class GameData
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;
    public int currentLevel;
    public int currentXP;
    public int currentHunger;
    public int currentStamina;

    // JELENIE
    public bool isDear01Dead;
    public Vector3 dear01Position;
    public bool isDear02Dead;
    public Vector3 dear02Position;
    public bool isDear03Dead;
    public Vector3 dear03Position;
    public bool isDear04Dead;
    public Vector3 dear04Position;
    public bool isDear05Dead;
    public Vector3 dear05Position;
    public bool isDear06Dead;
    public Vector3 dear06Position;
    public bool isDear07Dead;
    public Vector3 dear07Position;
    public bool isDear08Dead;
    public Vector3 dear08Position;
    public bool isDear09Dead;
    public Vector3 dear09Position;
    public bool isDear10Dead;
    public Vector3 dear10Position;
    public bool isDear11Dead;
    public Vector3 dear11Position;
    public bool isDear12Dead;
    public Vector3 dear12Position;
    public bool isDear13Dead;
    public Vector3 dear13Position;
    public bool isDear14Dead;
    public Vector3 dear14Position;
    public bool isDear15Dead;
    public Vector3 dear15Position;
    public bool isDear16Dead;
    public Vector3 dear16Position;
    public bool isDear17Dead;
    public Vector3 dear17Position;
    public bool isDear18Dead;
    public Vector3 dear18Position;
    public bool isDear19Dead;
    public Vector3 dear19Position;
    public bool isDear20Dead;
    public Vector3 dear20Position;
    public bool isDear21Dead;
    public Vector3 dear21Position;
    public bool isDear22Dead;
    public Vector3 dear22Position;
    public bool isDear23Dead;
    public Vector3 dear23Position;
    public bool isDear24Dead;
    public Vector3 dear24Position;
    public bool isDear25Dead;
    public Vector3 dear25Position;
    public bool isDear26Dead;
    public Vector3 dear26Position;
    public bool isDear27Dead;
    public Vector3 dear27Position;
    public bool isDear28Dead;
    public Vector3 dear28Position;
    public bool isDear29Dead;
    public Vector3 dear29Position;
    public bool isDear30Dead;
    public Vector3 dear30Position;
    public bool isDear31Dead;
    public Vector3 dear31Position;
    public bool isDear32Dead;
    public Vector3 dear32Position;

    // BIZONY
    public bool isBison01Dead;
    public Vector3 bison01Position;
    public bool isBison02Dead;
    public Vector3 bison02Position;
    public bool isBison03Dead;
    public Vector3 bison03Position;
    public bool isBison04Dead;
    public Vector3 bison04Position;
    public bool isBison05Dead;
    public Vector3 bison05Position;
    public bool isBison06Dead;
    public Vector3 bison06Position;
    public bool isBison07Dead;
    public Vector3 bison07Position;
    public bool isBison08Dead;
    public Vector3 bison08Position;
    public bool isBison09Dead;
    public Vector3 bison09Position;
    public bool isBison10Dead;
    public Vector3 bison10Position;
    public bool isBison11Dead;
    public Vector3 bison11Position;
    public bool isBison12Dead;
    public Vector3 bison12Position;
    public bool isBison13Dead;
    public Vector3 bison13Position;
    public bool isBison14Dead;
    public Vector3 bison14Position;
    public bool isBison15Dead;
    public Vector3 bison15Position;
    public bool isBison16Dead;
    public Vector3 bison16Position;
    public bool isBison17Dead;
    public Vector3 bison17Position;
    public bool isBison18Dead;
    public Vector3 bison18Position;
    public bool isBison19Dead;
    public Vector3 bison19Position;
    public bool isBison20Dead;
    public Vector3 bison20Position;
    public bool isBison21Dead;
    public Vector3 bison21Position;



    // BOSSY
    public bool isBear01Dead;
    public Vector3 bear01Position;
    public bool isJotun01Dead;
    public Vector3 jotun01Position;

    // GOBLINY
    public bool isGoblin01Dead;
    public Vector3 goblin01Position;

    // NIXY
    public bool isNix01Dead;
    public Vector3 nix01Position;

    // KUCIAKI
    public bool isChicken01Dead;
    public Vector3 chicken01Position;




    public SerializableDictionery<int, int> ItemsInSLots;

    public GameData() {
        playerPosition = Vector3.zero;
        playerRotation = Quaternion.identity;
        maxHealth = 50;
        currentHealth = 50;
        currentLevel = 0;
        currentXP = 0;
        currentHunger = 10;
        currentStamina = 100;

        // JELENIE
        isDear01Dead = false;
        isDear02Dead = false;
        isDear03Dead = false;
        isDear04Dead = false;
        isDear05Dead = false;
        isDear06Dead = false;
        isDear07Dead = false;
        isDear08Dead = false;
        isDear09Dead = false;
        isDear10Dead = false;
        isDear11Dead = false;
        isDear12Dead = false;
        isDear13Dead = false;
        isDear14Dead = false;
        isDear15Dead = false;
        isDear16Dead = false;
        isDear17Dead = false;
        isDear18Dead = false;
        isDear19Dead = false;
        isDear20Dead = false;
        isDear21Dead = false;
        isDear22Dead = false;
        isDear23Dead = false;
        isDear24Dead = false;
        isDear25Dead = false;
        isDear26Dead = false;
        isDear27Dead = false;
        isDear28Dead = false;
        isDear29Dead = false;
        isDear30Dead = false;
        isDear31Dead = false;
        isDear32Dead = false;

        // BIZONY
        isBison01Dead = false;
        isBison02Dead = false;
        isBison03Dead = false;
        isBison04Dead = false;
        isBison05Dead = false;
        isBison06Dead = false;
        isBison07Dead = false;
        isBison08Dead = false;
        isBison09Dead = false;
        isBison10Dead = false;
        isBison11Dead = false;
        isBison12Dead = false;
        isBison13Dead = false;
        isBison14Dead = false;
        isBison15Dead = false;
        isBison16Dead = false;
        isBison17Dead = false;
        isBison18Dead = false;
        isBison19Dead = false;
        isBison20Dead = false;
        isBison21Dead = false;

        // BOSSY
        isBear01Dead = false;
        isJotun01Dead = false;

        // GOBLINY
        isGoblin01Dead = false;

        // NIXY
        isNix01Dead = false;

        // KUCIAKI
        isChicken01Dead = false;
    }
}
