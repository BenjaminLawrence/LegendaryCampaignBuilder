using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryCampaignBuilder
{
    [Flags]
    enum ExpansionsCollected
    {
        None = 0,
        Core = 1,
        FantasticFour = 1 << 1,
        DarkCity = 1 << 2,
        Villains = 1 << 3,
        PaintTheTownRed = 1 << 4,
        GOTG = 1 << 5,
        FearItself = 1 << 6,
        SecretWarsOne = 1 << 7,
        SecretWarsTwo = 1 << 8,
        CaptainAmerica = 1 << 9,
        Deadpool = 1 << 10,
        CivilWar = 1 << 11,
        Noir = 1 << 12,
        XMen = 1 << 13,
        Homecoming = 1 << 14,
        Champions = 1 << 15,
        WorldWarHulk = 1 << 16,
        MarvelStudios = 1 << 17,
        AntMan = 1 << 18,
        Venom = 1 << 19,
        Dimensions = 1 << 20,
        Revelations = 1 << 21,
        Shield = 1 << 22,
        HeroesOfAsgard = 1 << 23,
        TheNewMutants = 1 << 24,
        IntoTheCosmos = 1 << 25,
        RealmOfKings = 1 << 26,
        Annihilation = 1 << 27,
        MessiahComplex = 1 << 28,
        DrStrange = 1 << 29,
        MarvelStudiosGOTG = 1 << 30,
        BlackPanther = 1 << 31,
        BlackWidow = 1 << 32,
        InfinitySaga = 1 << 33,
        MidnightSons = 1 << 34,
        WhatIfOne = 1 << 35,
        MarvelStudiosAntMan = 1 << 36,
        TwentyNinetyNine = 1 << 37,
        WeaponX = 1 << 38
    }
}
