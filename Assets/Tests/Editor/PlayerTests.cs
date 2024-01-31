using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
    private PlayerMotor p;
    private LoadSaveScript l;

    [SetUp]
    public void Setup()
    {
        GameObject playerObject = new GameObject("Player");
        p = playerObject.AddComponent<PlayerMotor>();
        GameObject loadObject = new GameObject("SaveLoader");
        l = loadObject.AddComponent<LoadSaveScript>();
    }

    // A Test behaves as an ordinary method
    [Test]
    public void PlayerGravity()
    {
        Assert.AreEqual(p.gravity, -9.8f);
    }
    [Test]
    public void SaveScriptKills()
    {
        Assert.AreEqual(l.kills, 0);
    }
}
