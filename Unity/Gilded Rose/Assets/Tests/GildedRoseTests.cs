using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class GildedRoseTests
{
    [Test]
    public void GildedRoseTestsSimplePasses()
    {
		var item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
        var app = new GildedRose(new List<Item> { item });
        app.UpdateQuality();
        Assert.That(item.Name, Is.EqualTo("fixme"));
    }
}
