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
    public bool isJotun02Dead;
    public Vector3 jotun02Position;
    public bool isJotun03Dead;
    public Vector3 jotun03Position;

    // GOBLINY
    public bool isGoblin01Dead;
    public Vector3 goblin01Position;
    public bool isGoblin02Dead;
    public Vector3 goblin02Position;
    public bool isGoblin03Dead;
    public Vector3 goblin03Position;
    public bool isGoblin04Dead;
    public Vector3 goblin04Position;
    public bool isGoblin05Dead;
    public Vector3 goblin05Position;
    public bool isGoblin06Dead;
    public Vector3 goblin06Position;
    public bool isGoblin07Dead;
    public Vector3 goblin07Position;
    public bool isGoblin08Dead;
    public Vector3 goblin08Position;
    public bool isGoblin09Dead;
    public Vector3 goblin09Position;
    public bool isGoblin10Dead;
    public Vector3 goblin10Position;
    public bool isGoblin11Dead;
    public Vector3 goblin11Position;
    public bool isGoblin12Dead;
    public Vector3 goblin12Position;
    public bool isGoblin13Dead;
    public Vector3 goblin13Position;
    public bool isGoblin14Dead;
    public Vector3 goblin14Position;
    public bool isGoblin15Dead;
    public Vector3 goblin15Position;
    public bool isGoblin16Dead;
    public Vector3 goblin16Position;
    public bool isGoblin17Dead;
    public Vector3 goblin17Position;
    public bool isGoblin18Dead;
    public Vector3 goblin18Position;
    public bool isGoblin19Dead;
    public Vector3 goblin19Position;
    public bool isGoblin20Dead;
    public Vector3 goblin20Position;


    // NIXY
    public bool isNix01Dead;
    public Vector3 nix01Position;
    public bool isNix02Dead;
    public Vector3 nix02Position;
    public bool isNix03Dead;
    public Vector3 nix03Position;
    public bool isNix04Dead;
    public Vector3 nix04Position;
    public bool isNix05Dead;
    public Vector3 nix05Position;
    public bool isNix06Dead;
    public Vector3 nix06Position;
    public bool isNix07Dead;
    public Vector3 nix07Position;
    public bool isNix08Dead;
    public Vector3 nix08Position;
    public bool isNix09Dead;
    public Vector3 nix09Position;
    public bool isNix10Dead;
    public Vector3 nix10Position;
    public bool isNix11Dead;
    public Vector3 nix11Position;
    public bool isNix12Dead;
    public Vector3 nix12Position;
    public bool isNix13Dead;
    public Vector3 nix13Position;
    public bool isNix14Dead;
    public Vector3 nix14Position;


    // KUCIAKI
    public bool isChicken01Dead;
    public Vector3 chicken01Position;
    public bool isChicken02Dead;
    public Vector3 chicken02Position;
    public bool isChicken03Dead;
    public Vector3 chicken03Position;
    public bool isChicken04Dead;
    public Vector3 chicken04Position;
    public bool isChicken05Dead;
    public Vector3 chicken05Position;
    public bool isChicken06Dead;
    public Vector3 chicken06Position;
    public bool isChicken07Dead;
    public Vector3 chicken07Position;
    public bool isChicken08Dead;
    public Vector3 chicken08Position;
    public bool isChicken09Dead;
    public Vector3 chicken09Position;
    public bool isChicken10Dead;
    public Vector3 chicken10Position;
    public bool isChicken11Dead;
    public Vector3 chicken11Position;
    public bool isChicken12Dead;
    public Vector3 chicken12Position;
    public bool isChicken13Dead;
    public Vector3 chicken13Position;
    public bool isChicken14Dead;
    public Vector3 chicken14Position;
    public bool isChicken15Dead;
    public Vector3 chicken15Position;

    // WILKI
    public bool isWolf01Dead;
    public Vector3 wolf01Position;
    public bool isWolf02Dead;
    public Vector3 wolf02Position;
    public bool isWolf03Dead;
    public Vector3 wolf03Position;
    public bool isWolf04Dead;
    public Vector3 wolf04Position;
    public bool isWolf05Dead;
    public Vector3 wolf05Position;
    public bool isWolf06Dead;
    public Vector3 wolf06Position;
    public bool isWolf07Dead;
    public Vector3 wolf07Position;
    public bool isWolf08Dead;
    public Vector3 wolf08Position;
    public bool isWolf09Dead;
    public Vector3 wolf09Position;
    public bool isWolf10Dead;
    public Vector3 wolf10Position;
    public bool isWolf11Dead;
    public Vector3 wolf11Position;
    public bool isWolf12Dead;
    public Vector3 wolf12Position;
    public bool isWolf13Dead;
    public Vector3 wolf13Position;
    public bool isWolf14Dead;
    public Vector3 wolf14Position;
    public bool isWolf15Dead;
    public Vector3 wolf15Position;
    public bool isWolf16Dead;
    public Vector3 wolf16Position;
    public bool isWolf17Dead;
    public Vector3 wolf17Position;
    public bool isWolf18Dead;
    public Vector3 wolf18Position;
    public bool isWolf19Dead;
    public Vector3 wolf19Position;
    public bool isWolf20Dead;
    public Vector3 wolf20Position;
    public bool isWolf21Dead;
    public Vector3 wolf21Position;
    public bool isWolf22Dead;
    public Vector3 wolf22Position;
    public bool isWolf23Dead;
    public Vector3 wolf23Position;
    public bool isWolf24Dead;
    public Vector3 wolf24Position;
    public bool isWolf25Dead;
    public Vector3 wolf25Position;
    public bool isWolf26Dead;
    public Vector3 wolf26Position;
    public bool isWolf27Dead;
    public Vector3 wolf27Position;
    public bool isWolf28Dead;
    public Vector3 wolf28Position;
    public bool isWolf29Dead;
    public Vector3 wolf29Position;
    public bool isWolf30Dead;
    public Vector3 wolf30Position;
    public bool isWolf31Dead;
    public Vector3 wolf31Position;
    public bool isWolf32Dead;
    public Vector3 wolf32Position;
    public bool isWolf33Dead;
    public Vector3 wolf33Position;
    public bool isWolf34Dead;
    public Vector3 wolf34Position;
    public bool isWolf35Dead;
    public Vector3 wolf35Position;
    public bool isWolf36Dead;
    public Vector3 wolf36Position;

    // bandyci A

    public bool isBanditA01Dead;
    public Vector3 banditA01Position;
    public bool isBanditA02Dead;
    public Vector3 banditA02Position;
    public bool isBanditA03Dead;
    public Vector3 banditA03Position;

    // bandyci B

    public bool isBanditB01Dead;
    public Vector3 banditB01Position;
    public bool isBanditB02Dead;
    public Vector3 banditB02Position;
    public bool isBanditB03Dead;
    public Vector3 banditB03Position;

    // bandyci C

    public bool isBanditC01Dead;
    public Vector3 banditC01Position;
    public bool isBanditC02Dead;
    public Vector3 banditC02Position;
    public bool isBanditC03Dead;
    public Vector3 banditC03Position;
    public bool isBanditC04Dead;
    public Vector3 banditC04Position;

    // bandyci D

    public bool isBanditD01Dead;
    public Vector3 banditD01Position;
    public bool isBanditD02Dead;
    public Vector3 banditD02Position;
    public bool isBanditD03Dead;
    public Vector3 banditD03Position;
    public bool isBanditD04Dead;
    public Vector3 banditD04Position;
    public bool isBanditD05Dead;
    public Vector3 banditD05Position;



    public SerializableDictionery<int, int> ItemsInSLots;
    public SerializableDictionery<int, int> DamageinSlots;

    public SerializableDictionery<int, bool> NpcQuestActive;
    public SerializableDictionery<int, bool> NpcQuestCompleted;
    public SerializableDictionery<int, bool> NpcQuestPlayerCollected;
    public SerializableDictionery<int, int> NpcQuestTriggerID;

    public float musicVolume;

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
        isJotun02Dead = false;
        isJotun03Dead = false;

        // GOBLINY
        isGoblin01Dead = false;
        isGoblin02Dead = false;
        isGoblin03Dead = false;
        isGoblin04Dead = false;
        isGoblin05Dead = false;
        isGoblin06Dead = false;
        isGoblin07Dead = false;
        isGoblin08Dead = false;
        isGoblin09Dead = false;
        isGoblin10Dead = false;
        isGoblin11Dead = false;
        isGoblin12Dead = false;
        isGoblin13Dead = false;
        isGoblin14Dead = false;
        isGoblin15Dead = false;
        isGoblin16Dead = false;
        isGoblin17Dead = false;
        isGoblin18Dead = false;
        isGoblin19Dead = false;
        isGoblin20Dead = false;

        // NIXY
        isNix01Dead = false;
        isNix02Dead = false;
        isNix03Dead = false;
        isNix04Dead = false;
        isNix05Dead = false;
        isNix06Dead = false;
        isNix07Dead = false;
        isNix08Dead = false;
        isNix09Dead = false;
        isNix10Dead = false;
        isNix11Dead = false;
        isNix12Dead = false;
        isNix13Dead = false;
        isNix14Dead = false;

        // KUCIAKI
        isChicken01Dead = false;
        isChicken02Dead = false;
        isChicken03Dead = false;
        isChicken04Dead = false;
        isChicken05Dead = false;
        isChicken06Dead = false;
        isChicken07Dead = false;
        isChicken08Dead = false;
        isChicken09Dead = false;
        isChicken10Dead = false;
        isChicken11Dead = false;
        isChicken12Dead = false;
        isChicken13Dead = false;
        isChicken14Dead = false;
        isChicken15Dead = false;

        //WILKI
        isWolf01Dead = false;
        isWolf02Dead = false;
        isWolf03Dead = false;
        isWolf04Dead = false;
        isWolf05Dead = false;
        isWolf06Dead = false;
        isWolf07Dead = false;
        isWolf08Dead = false;
        isWolf09Dead = false;
        isWolf10Dead = false;
        isWolf11Dead = false;
        isWolf12Dead = false;
        isWolf13Dead = false;
        isWolf14Dead = false;
        isWolf15Dead = false;
        isWolf16Dead = false;
        isWolf17Dead = false;
        isWolf18Dead = false;
        isWolf19Dead = false;
        isWolf20Dead = false;
        isWolf21Dead = false;
        isWolf22Dead = false;
        isWolf23Dead = false;
        isWolf24Dead = false;
        isWolf25Dead = false;
        isWolf26Dead = false;
        isWolf27Dead = false;
        isWolf28Dead = false;
        isWolf29Dead = false;
        isWolf30Dead = false;
        isWolf31Dead = false;
        isWolf32Dead = false;
        isWolf33Dead = false;
        isWolf34Dead = false;
        isWolf35Dead = false;
        isWolf36Dead = false;

        //BANDYCI A
        isBanditA01Dead = false;
        isBanditA02Dead = false;
        isBanditA03Dead = false;
        //BANDYCI B
        isBanditB01Dead = false;
        isBanditB02Dead = false;
        isBanditB03Dead = false;
        //BANDYCI C
        isBanditC01Dead = false;
        isBanditC02Dead = false;
        isBanditC03Dead = false;
        isBanditC04Dead = false;
        //BANDYCI D
        isBanditD01Dead = false;
        isBanditD02Dead = false;
        isBanditD03Dead = false;
        isBanditD04Dead = false;
        isBanditD05Dead = false;

        musicVolume = 0.5f;
    }
}
