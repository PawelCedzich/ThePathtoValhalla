using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    public PlayerStats playerStats;

    // JELENIE
    public SimpleEnemy dear01;
    public SimpleEnemy dear02;
    public SimpleEnemy dear03;
    public SimpleEnemy dear04;
    public SimpleEnemy dear05;
    public SimpleEnemy dear06;
    public SimpleEnemy dear07;
    public SimpleEnemy dear08;
    public SimpleEnemy dear09;
    public SimpleEnemy dear10;
    public SimpleEnemy dear11;
    public SimpleEnemy dear12;
    public SimpleEnemy dear13;
    public SimpleEnemy dear14;
    public SimpleEnemy dear15;
    public SimpleEnemy dear16;
    public SimpleEnemy dear17;
    public SimpleEnemy dear18;
    public SimpleEnemy dear19;
    public SimpleEnemy dear20;
    public SimpleEnemy dear21;
    public SimpleEnemy dear22;
    public SimpleEnemy dear23;
    public SimpleEnemy dear24;
    public SimpleEnemy dear25;
    public SimpleEnemy dear26;
    public SimpleEnemy dear27;
    public SimpleEnemy dear28;
    public SimpleEnemy dear29;
    public SimpleEnemy dear30;
    public SimpleEnemy dear31;
    public SimpleEnemy dear32;

    // BIZONY
    public SimpleEnemy bison01;
    public SimpleEnemy bison02;
    public SimpleEnemy bison03;
    public SimpleEnemy bison04;
    public SimpleEnemy bison05;
    public SimpleEnemy bison06;
    public SimpleEnemy bison07;
    public SimpleEnemy bison08;
    public SimpleEnemy bison09;
    public SimpleEnemy bison10;
    public SimpleEnemy bison11;
    public SimpleEnemy bison12;
    public SimpleEnemy bison13;
    public SimpleEnemy bison14;
    public SimpleEnemy bison15;
    public SimpleEnemy bison16;
    public SimpleEnemy bison17;
    public SimpleEnemy bison18;
    public SimpleEnemy bison19;
    public SimpleEnemy bison20;
    public SimpleEnemy bison21;

    // BOSSY
    public SimpleEnemy bear01;
    public SimpleEnemy jotun01;

    // GOBLINY
    public SimpleEnemy goblin01;

    // NIXY
    public SimpleEnemy nix01;

    // KUCIAKI
    public SimpleEnemy chicken01;

    public void LoadData(GameData data)
    {

        Debug.Log("loading player position");
        this.transform.position = data.playerPosition;
        Debug.Log("loading player rotation");
        this.transform.rotation = data.playerRotation;

        Debug.Log("loading player stats");
        this.playerStats.maxHealth = data.maxHealth;
        this.playerStats.currentHealth = data.currentHealth;
        this.playerStats.SetHealthBar();

        this.playerStats.currentHunger = data.currentHunger;
        this.playerStats.SetHungerBar();

        this.playerStats.currentStamina = data.currentStamina;
        this.playerStats.SetStaminaBar();

        this.playerStats.currentLevel = data.currentLevel;
        this.playerStats.currentXP = data.currentXP;

        // JELENIE
        this.dear01.isDead = data.isDear01Dead;
        this.dear01.transform.position = data.dear01Position;
        this.dear02.isDead = data.isDear02Dead;
        this.dear02.transform.position = data.dear02Position;
        this.dear03.isDead = data.isDear03Dead;
        this.dear03.transform.position = data.dear03Position;
        this.dear04.isDead = data.isDear04Dead;
        this.dear04.transform.position = data.dear04Position;
        this.dear05.isDead = data.isDear05Dead;
        this.dear05.transform.position = data.dear05Position;
        this.dear06.isDead = data.isDear06Dead;
        this.dear06.transform.position = data.dear06Position;
        this.dear07.isDead = data.isDear07Dead;
        this.dear07.transform.position = data.dear07Position;
        this.dear08.isDead = data.isDear08Dead;
        this.dear08.transform.position = data.dear08Position;
        this.dear09.isDead = data.isDear09Dead;
        this.dear09.transform.position = data.dear09Position;
        this.dear10.isDead = data.isDear10Dead;
        this.dear10.transform.position = data.dear10Position;
        this.dear11.isDead = data.isDear11Dead;
        this.dear11.transform.position = data.dear11Position;
        this.dear12.isDead = data.isDear12Dead;
        this.dear12.transform.position = data.dear12Position;
        this.dear13.isDead = data.isDear13Dead;
        this.dear13.transform.position = data.dear13Position;
        this.dear14.isDead = data.isDear14Dead;
        this.dear14.transform.position = data.dear14Position;
        this.dear15.isDead = data.isDear15Dead;
        this.dear15.transform.position = data.dear15Position;
        this.dear16.isDead = data.isDear16Dead;
        this.dear16.transform.position = data.dear16Position;
        this.dear17.isDead = data.isDear17Dead;
        this.dear17.transform.position = data.dear17Position;
        this.dear18.isDead = data.isDear18Dead;
        this.dear18.transform.position = data.dear18Position;
        this.dear19.isDead = data.isDear19Dead;
        this.dear19.transform.position = data.dear19Position;
        this.dear20.isDead = data.isDear20Dead;
        this.dear20.transform.position = data.dear20Position;
        this.dear21.isDead = data.isDear21Dead;
        this.dear21.transform.position = data.dear21Position;
        this.dear22.isDead = data.isDear22Dead;
        this.dear22.transform.position = data.dear22Position;
        this.dear23.isDead = data.isDear23Dead;
        this.dear23.transform.position = data.dear23Position;
        this.dear24.isDead = data.isDear24Dead;
        this.dear24.transform.position = data.dear24Position;
        this.dear25.isDead = data.isDear25Dead;
        this.dear25.transform.position = data.dear25Position;
        this.dear26.isDead = data.isDear26Dead;
        this.dear26.transform.position = data.dear26Position;
        this.dear27.isDead = data.isDear27Dead;
        this.dear27.transform.position = data.dear27Position;
        this.dear28.isDead = data.isDear28Dead;
        this.dear28.transform.position = data.dear28Position;
        this.dear29.isDead = data.isDear29Dead;
        this.dear29.transform.position = data.dear29Position;
        this.dear30.isDead = data.isDear30Dead;
        this.dear30.transform.position = data.dear30Position;
        this.dear31.isDead = data.isDear31Dead;
        this.dear31.transform.position = data.dear31Position;
        this.dear32.isDead = data.isDear32Dead;
        this.dear32.transform.position = data.dear32Position;



        this.bison01.isDead = data.isBison01Dead;
        this.bison01.transform.position = data.bison01Position;
        this.bison02.isDead = data.isBison02Dead;
        this.bison02.transform.position = data.bison02Position;
        this.bison03.isDead = data.isBison03Dead;
        this.bison03.transform.position = data.bison03Position;
        this.bison04.isDead = data.isBison04Dead;
        this.bison04.transform.position = data.bison04Position;
        this.bison05.isDead = data.isBison05Dead;
        this.bison05.transform.position = data.bison05Position;
        this.bison06.isDead = data.isBison06Dead;
        this.bison06.transform.position = data.bison06Position;
        this.bison07.isDead = data.isBison07Dead;
        this.bison07.transform.position = data.bison07Position;
        this.bison08.isDead = data.isBison08Dead;
        this.bison08.transform.position = data.bison08Position;
        this.bison09.isDead = data.isBison09Dead;
        this.bison09.transform.position = data.bison09Position;
        this.bison10.isDead = data.isBison10Dead;
        this.bison10.transform.position = data.bison10Position;
        this.bison11.isDead = data.isBison11Dead;
        this.bison11.transform.position = data.bison11Position;
        this.bison12.isDead = data.isBison12Dead;
        this.bison12.transform.position = data.bison12Position;
        this.bison13.isDead = data.isBison13Dead;
        this.bison13.transform.position = data.bison13Position;
        this.bison14.isDead = data.isBison14Dead;
        this.bison14.transform.position = data.bison14Position;
        this.bison15.isDead = data.isBison15Dead;
        this.bison15.transform.position = data.bison15Position;
        this.bison16.isDead = data.isBison16Dead;
        this.bison16.transform.position = data.bison16Position;
        this.bison17.isDead = data.isBison17Dead;
        this.bison17.transform.position = data.bison17Position;
        this.bison18.isDead = data.isBison18Dead;
        this.bison18.transform.position = data.bison18Position;
        this.bison19.isDead = data.isBison19Dead;
        this.bison19.transform.position = data.bison19Position;
        this.bison20.isDead = data.isBison20Dead;
        this.bison20.transform.position = data.bison20Position;
        this.bison21.isDead = data.isBison21Dead;
        this.bison21.transform.position = data.bison21Position;



        this.bear01.isDead = data.isBear01Dead;
        this.bear01.transform.position = data.bear01Position;

        this.goblin01.isDead = data.isGoblin01Dead;
        this.goblin01.transform.position = data.goblin01Position;

        this.jotun01.isDead = data.isJotun01Dead;
        this.jotun01.transform.position = data.jotun01Position;

        this.nix01.isDead = data.isNix01Dead;
        this.nix01.transform.position = data.nix01Position;

        this.chicken01.isDead = data.isChicken01Dead;
        this.chicken01.transform.position = data.chicken01Position;
    }

    public void SaveData(GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        data.playerRotation = this.transform.rotation;

        data.maxHealth = this.playerStats.maxHealth;
        data.currentHealth = this.playerStats.currentHealth;

        data.currentStamina = this.playerStats.currentStamina;

        data.currentHunger = this.playerStats.currentHunger;

        data.currentLevel = this.playerStats.currentLevel;
        data.currentXP = this.playerStats.currentXP;

        // JELENIE
        data.isDear01Dead = this.dear01.isDead;
        data.dear01Position = this.dear01.transform.position;
        data.isDear02Dead = this.dear02.isDead;
        data.dear02Position = this.dear02.transform.position;
        data.isDear03Dead = this.dear03.isDead;
        data.dear03Position = this.dear03.transform.position;
        data.isDear04Dead = this.dear04.isDead;
        data.dear04Position = this.dear04.transform.position;
        data.isDear05Dead = this.dear05.isDead;
        data.dear05Position = this.dear05.transform.position;
        data.isDear06Dead = this.dear06.isDead;
        data.dear06Position = this.dear06.transform.position;
        data.isDear07Dead = this.dear07.isDead;
        data.dear07Position = this.dear07.transform.position;
        data.isDear08Dead = this.dear08.isDead;
        data.dear08Position = this.dear08.transform.position;
        data.isDear09Dead = this.dear09.isDead;
        data.dear09Position = this.dear09.transform.position;
        data.isDear10Dead = this.dear10.isDead;
        data.dear10Position = this.dear10.transform.position;
        data.isDear11Dead = this.dear11.isDead;
        data.dear11Position = this.dear11.transform.position;
        data.isDear12Dead = this.dear12.isDead;
        data.dear12Position = this.dear12.transform.position;
        data.isDear13Dead = this.dear13.isDead;
        data.dear13Position = this.dear13.transform.position;
        data.isDear14Dead = this.dear14.isDead;
        data.dear14Position = this.dear14.transform.position;
        data.isDear15Dead = this.dear15.isDead;
        data.dear15Position = this.dear15.transform.position;
        data.isDear16Dead = this.dear16.isDead;
        data.dear16Position = this.dear16.transform.position;
        data.isDear17Dead = this.dear17.isDead;
        data.dear17Position = this.dear17.transform.position;
        data.isDear18Dead = this.dear18.isDead;
        data.dear18Position = this.dear18.transform.position;
        data.isDear19Dead = this.dear19.isDead;
        data.dear19Position = this.dear19.transform.position;
        data.isDear20Dead = this.dear20.isDead;
        data.dear20Position = this.dear20.transform.position;
        data.isDear21Dead = this.dear21.isDead;
        data.dear21Position = this.dear21.transform.position;
        data.isDear22Dead = this.dear22.isDead;
        data.dear22Position = this.dear22.transform.position;
        data.isDear23Dead = this.dear23.isDead;
        data.dear23Position = this.dear23.transform.position;
        data.isDear24Dead = this.dear24.isDead;
        data.dear24Position = this.dear24.transform.position;
        data.isDear25Dead = this.dear25.isDead;
        data.dear25Position = this.dear25.transform.position;
        data.isDear26Dead = this.dear26.isDead;
        data.dear26Position = this.dear26.transform.position;
        data.isDear27Dead = this.dear27.isDead;
        data.dear27Position = this.dear27.transform.position;
        data.isDear28Dead = this.dear28.isDead;
        data.dear28Position = this.dear28.transform.position;
        data.isDear29Dead = this.dear29.isDead;
        data.dear29Position = this.dear29.transform.position;
        data.isDear30Dead = this.dear30.isDead;
        data.dear30Position = this.dear30.transform.position;
        data.isDear31Dead = this.dear31.isDead;
        data.dear31Position = this.dear31.transform.position;
        data.isDear32Dead = this.dear32.isDead;
        data.dear32Position = this.dear32.transform.position;



        data.isBison01Dead = this.bison01.isDead;
        data.bison01Position = this.bison01.transform.position;
        data.isBison02Dead = this.bison02.isDead;
        data.bison02Position = this.bison02.transform.position;
        data.isBison03Dead = this.bison03.isDead;
        data.bison03Position = this.bison03.transform.position;
        data.isBison04Dead = this.bison04.isDead;
        data.bison04Position = this.bison04.transform.position;
        data.isBison05Dead = this.bison05.isDead;
        data.bison05Position = this.bison05.transform.position;
        data.isBison06Dead = this.bison06.isDead;
        data.bison06Position = this.bison06.transform.position;
        data.isBison07Dead = this.bison07.isDead;
        data.bison07Position = this.bison07.transform.position;
        data.isBison08Dead = this.bison08.isDead;
        data.bison08Position = this.bison08.transform.position;
        data.isBison09Dead = this.bison09.isDead;
        data.bison09Position = this.bison09.transform.position;
        data.isBison10Dead = this.bison10.isDead;
        data.bison10Position = this.bison10.transform.position;
        data.isBison11Dead = this.bison11.isDead;
        data.bison11Position = this.bison11.transform.position;
        data.isBison12Dead = this.bison12.isDead;
        data.bison12Position = this.bison12.transform.position;
        data.isBison13Dead = this.bison13.isDead;
        data.bison13Position = this.bison13.transform.position;
        data.isBison14Dead = this.bison14.isDead;
        data.bison14Position = this.bison14.transform.position;
        data.isBison15Dead = this.bison15.isDead;
        data.bison15Position = this.bison15.transform.position;
        data.isBison16Dead = this.bison16.isDead;
        data.bison16Position = this.bison16.transform.position;
        data.isBison17Dead = this.bison17.isDead;
        data.bison17Position = this.bison17.transform.position;
        data.isBison18Dead = this.bison18.isDead;
        data.bison18Position = this.bison18.transform.position;
        data.isBison19Dead = this.bison19.isDead;
        data.bison19Position = this.bison19.transform.position;
        data.isBison20Dead = this.bison20.isDead;
        data.bison20Position = this.bison20.transform.position;
        data.isBison21Dead = this.bison21.isDead;
        data.bison21Position = this.bison21.transform.position;



        data.isBear01Dead = this.bear01.isDead;
        data.bear01Position = this.bear01.transform.position;
        
        data.isGoblin01Dead = this.goblin01.isDead;
        data.goblin01Position = this.goblin01.transform.position;

        data.isJotun01Dead = this.jotun01.isDead;
        data.jotun01Position = this.jotun01.transform.position;

        data.isNix01Dead = this.nix01.isDead;
        data.nix01Position = this.nix01.transform.position;

        data.isChicken01Dead = this.chicken01.isDead;
        data.chicken01Position = this.chicken01.transform.position;
    }

}
